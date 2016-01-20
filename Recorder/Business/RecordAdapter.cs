using BLL.Services;
using DataModel.Entities;
using DataModel.Enums;
using Newtonsoft.Json;
using Recorder.Views;
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
        public bool Save(string recordJson)
        {
            var r = JsonConvert.DeserializeObject<Record>(recordJson);
            if (r.Id == Guid.Empty)
                return _recordService.Add(r) != null;
            else
                return _recordService.Update(r) !=null;
        }

        public string Read()
        {
            var list = _recordService.Query(null).OrderByDescending(p => p.CreateDate);
            var result = JsonConvert.SerializeObject(list);
            return result;
        }

        public string GetRecordById(string id)
        {
            Record record;
            if (string.IsNullOrEmpty(id))
                record = new Record();
            else
                record = _recordService.Get(new Guid(id));
            return JsonConvert.SerializeObject(record);
        }

        public void Alert(string msg)
        {
            MessageBox.Show(msg);
        }

        public void ShowDetail(string json)
        {
            var fmDetail = new FmDetail(json);
            fmDetail.Show();
        }
    }
}
