using BLL.Services;
using DataModel.Entities;
using DataModel.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recorder.Business
{
    public class RecordAdapter
    {
        RecordService _recordService = new RecordService();
        public bool Save(string title, string project, string tag, string description, string dealWith, string status)
        {
            return _recordService.Add(new Record
              {
                  Title = title,
                  Project = project,
                  Tag = tag,
                  Description = description,
                  DealWith = dealWith,
                  Status = (RecordStatus)int.Parse(status)
              }) != null;
        }

        public string Read()
        {
            var list = _recordService.Query(null).OrderByDescending(p=>p.CreateDate);
            var result = JsonConvert.SerializeObject(list);
            return result;
        }

        public void Alert(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
