using BLL.Services;
using DataModel.Entities;
using DataModel.Enums;
using DataModel.Filters;
using Newtonsoft.Json;
using Recorder.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebKit;

namespace Recorder.Business
{
    public class RecordAdapter
    {
        RecordService _recordService = new RecordService();
        public WebKitBrowser ListBrowser { get; set; }
        public WebKitBrowser EditBrowser { get; set; }
        public bool Save(string recordJson)
        {
            var r = JsonConvert.DeserializeObject<Record>(recordJson);
            bool result = false;
            if (r.Id == Guid.Empty)
            {
                result = _recordService.Add(r) != null;
            }
            else
                result = _recordService.Update(r) != null;

            if (result)
                ListBrowser.GetScriptManager.EvaluateScript(string.Format("listPage.vm.dataRefreshed({0})", JsonConvert.SerializeObject(r)));
            return result;
        }

        public string Read()
        {
            var list = _recordService.Query(null).OrderByDescending(p => p.CreateDate);
            var result = JsonConvert.SerializeObject(list);
            return result;
        }

        public string Search(string title,string tag)
        {
            var list = _recordService.Query(new RecordFilter() {  Tag = tag, Title = title }).OrderByDescending(p => p.CreateDate);
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

        public bool Delete(string id)
        {
            var r = _recordService.Delete(new Guid(id));
            return r;
        }
    }
}
