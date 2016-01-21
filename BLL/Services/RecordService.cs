using DAL.Repositories;
using DataModel.Entities;
using DataModel.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services
{
    public class RecordService:BaseService
    {
        RecordRepository RecordRepository = new RecordRepository();
        public Record Add(Record entity)
        {
            entity.Id = Guid.NewGuid();
            entity.CreateDate = DateTime.Now;
            entity.LastEditDate = DateTime.Now;
            return RecordRepository.Add(entity);
        }

        public bool Delete(Guid id)
        {
            return RecordRepository.Delete(id);
        }

        public Record Update(Record entity)
        {
            return RecordRepository.Update(entity);
        }

        public IEnumerable<Record> Query(RecordFilter filter)
        {
            return RecordRepository.Query(filter);
        }

        public  Record Get(Guid id)
        {
            return RecordRepository.Get(id);
        }
    }
}
