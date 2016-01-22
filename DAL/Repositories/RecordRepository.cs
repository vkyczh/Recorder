using DataModel.Entities;
using DataModel.Enums;
using DataModel.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class RecordRepository
    {
        public Record Add(Record entity)
        {
            var cmdText = "insert into Record (Id,Title,Project,Description,Tag,Status,DealWith,CreateDate,LastEditDate)" +
                      " values           (@Id,@Title,@Project,@Description,@Tag,@Status,@DealWith,@CreateDate,@LastEditDate)";
            var parameters = new[]{
                new SQLiteParameter("@Id",entity.Id.ToString()),
                new SQLiteParameter("@Title",entity.Title),
                new SQLiteParameter("@Project",entity.Project),
                new SQLiteParameter("@Description",entity.Description),
                new SQLiteParameter("@Tag",entity.Tag),
                new SQLiteParameter("@Status",entity.Status),
                new SQLiteParameter("@DealWith",entity.DealWith),
                new SQLiteParameter("@CreateDate",entity.CreateDate),
                new SQLiteParameter("@LastEditDate",entity.LastEditDate)
            };
            if (DbContext.ExecuteNoQuery(cmdText, parameters) != 1)
                throw new Exception("新增记录失败");

            return entity;
        }

        public bool Delete(Guid id)
        {
            var cmdText = "delete from record where id = @id";
            var parameters = new[] { new SQLiteParameter("@id", id.ToString()) };
            return DbContext.ExecuteNoQuery(cmdText, parameters) == 1;
        }

        public Record Update(Record entity)
        {
            var cmdText = "update Record set " +
                     " title = @Title,project = @Project,description = @Description,tag = @Tag,status = @Status,dealwith = @DealWith,CreateDate = @CreateDate,LastEditDate = @LastEditDate" +
                     " where id = @Id";
            var parameters = new[]{
                new SQLiteParameter("@Id",entity.Id.ToString()),
                new SQLiteParameter("@Title",entity.Title),
                new SQLiteParameter("@Project",entity.Project),
                new SQLiteParameter("@Description",entity.Description),
                new SQLiteParameter("@Tag",entity.Tag),
                new SQLiteParameter("@Status",entity.Status),
                new SQLiteParameter("@DealWith",entity.DealWith),
                new SQLiteParameter("@CreateDate",entity.CreateDate),
                new SQLiteParameter("@LastEditDate",entity.LastEditDate)
            };
            if (DbContext.ExecuteNoQuery(cmdText, parameters) != 1)
                throw new Exception("修改记录失败");

            return entity;
        }

        public IEnumerable<Record> Query(RecordFilter filter)
        {
            var cmdText = "select * from record where 1= 1 ";
            var parameters = new Stack<SQLiteParameter>();
            if (filter != null)
            {
                if (filter.BeginEditDate != null)
                {
                    cmdText += "and LastUpdateDate >=  @BeginEditDate ";
                    parameters.Push(new SQLiteParameter("@BeginEditDate", filter.BeginEditDate.Value));
                }
                if (!string.IsNullOrWhiteSpace(filter.DealWith))
                {
                    cmdText += "and DealWith like @DealWith ";
                    parameters.Push(new SQLiteParameter("@DealWith",string.Format("%{0}%",filter.DealWith)));
                }
                if (filter.EndEditDate != null)
                {
                    cmdText += "and LastUpdateDate <  @EndEditDate ";
                    parameters.Push(new SQLiteParameter("@EndEditDate", filter.EndEditDate.Value));
                }
                if (!string.IsNullOrWhiteSpace(filter.Project))
                {
                    cmdText += "and project like @Project ";
                    parameters.Push(new SQLiteParameter("@Project", string.Format("%{0}%", filter.Project)));
                }
                if (filter.Status != null)
                {
                    cmdText += "and Status = @Status ";
                    parameters.Push(new SQLiteParameter("@Status", filter.Status.Value));
                }
                if (!string.IsNullOrWhiteSpace(filter.Tag))
                {
                    cmdText += "and tag like @Tag ";
                    parameters.Push(new SQLiteParameter("@Tag", string.Format("%{0}%", filter.Tag)));
                }
                if (!string.IsNullOrWhiteSpace(filter.Title))
                {
                    cmdText += "and title like @Title ";
                    parameters.Push(new SQLiteParameter("@Title", string.Format("%{0}%",filter.Title)));
                }
            }
            var dt = DbContext.ExecuteQuery(cmdText, parameters.ToArray());
            var result = new List<Record>();
            foreach (DataRow row in dt.Rows)
            {
                result.Add(new Record
                {
                    Id = new Guid(row["Id"].ToString()),
                    CreateDate = (DateTime)row["CreateDate"],
                    DealWith = row["DealWith"].ToString(),
                    LastEditDate = (DateTime)row["LastEditDate"],
                    Description = row["Description"].ToString(),
                    Status = (RecordStatus)row["Status"],
                    Project = row["Project"].ToString(),
                    Tag = row["Tag"].ToString(),
                    Title = row["Title"].ToString()
                });
            }
            return result;
        }

        public Record Get(Guid id)
        {
            var cmdText = "select * from record where id= @id ";
            var dt = DbContext.ExecuteQuery(cmdText, new[] { new SQLiteParameter("@id", id.ToString()) });
            if (dt.Rows.Count == 0)
                throw new Exception("数据不存在或者已被删除");
            var row = dt.Rows[0];
            return new Record
                {
                    Id = new Guid(row["Id"].ToString()),
                    CreateDate = (DateTime)row["CreateDate"],
                    DealWith = row["DealWith"].ToString(),
                    LastEditDate = (DateTime)row["LastEditDate"],
                    Description = row["Description"].ToString(),
                    Status = (RecordStatus)row["Status"],
                    Project = row["Project"].ToString(),
                    Tag = row["Tag"].ToString(),
                    Title = row["Title"].ToString()
                };
        }

    }
}
