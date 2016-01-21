using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data;
using Common.Utils;

namespace Common.Util
{
    public class SqliteHelper
    {
        static string _dbFileName;
        static SqliteInitInfo initInfo;
        public static void Init(string dbFileName,SqliteInitInfo initInfo)
        {
            _dbFileName = dbFileName;
            Connect((c) => {
                CreateTableIfNotExist(initInfo, c);
            });
        }

        public static int ExecuteNoQuery(string cmdText,SQLiteParameter[] parameters)
        {
            int result = 0;
            Connect((c)=>{
                var cmd = new SQLiteCommand(cmdText, c);
                cmd.Parameters.AddRange(parameters);
                result=  cmd.ExecuteNonQuery();
            });
            return result;
        }

        public static object ExecuteQuery(string cmdText, SQLiteParameter[] parameters)
        {
            object result = null;
            Connect((c) =>
            {
                var cmd = new SQLiteCommand(cmdText, c);
                cmd.Parameters.AddRange(parameters);
                var adapter = new SQLiteDataAdapter(cmd);
                var ds = new DataSet();
                adapter.Fill(ds);
                result = ds.Tables[0];
            });
            return result;
        }

        private static void CreateTableIfNotExist(SqliteInitInfo initInfo, SQLiteConnection c)
        {
            var existCommandText = string.Format("SELECT COUNT(*) FROM sqlite_master where type='table' and name='{0}'", initInfo.TableName);
            SQLiteCommand cmd = new SQLiteCommand(existCommandText, c);
            var dataAdapter = new SQLiteDataAdapter(cmd);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            if (ds.Tables[0].Rows[0][0].ToString() != "1")
            {
                cmd.CommandText = initInfo.CreateSql;
                var r = cmd.ExecuteNonQuery();
            }
        }

        private static void Connect(Action<SQLiteConnection> action)
        {
            var dbPath = AppDomain.CurrentDomain.BaseDirectory + _dbFileName;
            using (var c = new SQLiteConnection(string.Format("Data Source={0};Version=3;", dbPath)))
            {
                try
                {
                    c.Open();
                    action(c);
                }
                catch
                {

                }
                finally
                {
                    c.Close();
                }
            }
        }


    }
}
