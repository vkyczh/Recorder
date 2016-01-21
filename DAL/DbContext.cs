using Common.Util;
using Common.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DbContext
    {
        public static void Init(string dbName)
        {
            var tableName = "Record";
            SqliteInitInfo initInfo = new SqliteInitInfo
            {
                TableName = tableName,
                CreateSql = string.Format(
                @"create table {0} (
                Id varchar(36) not null,
                Title nvarchar(36) not null ,
                Project nvarchar(100) ,
                Description text,
                Tag nvarchar(300) ,
                Status int,
                DealWith text ,
                CreateDate datetime,
                LastEditDate datetime,
                PRIMARY KEY('Id'))",
                tableName)
            };
            SqliteHelper.Init(dbName, initInfo);
        }

        public static int ExecuteNoQuery(string cmdText, SQLiteParameter[] parameters)
        {
            return SqliteHelper.ExecuteNoQuery(cmdText, parameters);
        }

        public static DataTable ExecuteQuery(string cmdText, SQLiteParameter[] parameters)
        {
            return SqliteHelper.ExecuteQuery(cmdText, parameters) as DataTable;
        }
    }
}
