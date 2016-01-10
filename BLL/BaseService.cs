using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BaseService
    {
        public static  void InitDataBase(string dbName)
        {
            DbContext.Init(dbName);
        }

    }
}
