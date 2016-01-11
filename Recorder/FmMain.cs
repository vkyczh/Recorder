using BLL.Services;
using DataModel.Entities;
using DataModel.Enums;
using Recorder.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebKit;

namespace Recorder
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();

            //InitWebBrowser();
        }

        BrowserHelper _browserHelper;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitWebBrowser()
        {
            _browserHelper = new BrowserHelper(this, "http://www.baidu.com");
            _browserHelper.InitWebBrowser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new RecordService();
            var record = service.Add(new Record
            {
                Title = "title",
                Tag = "tag",
                Project = "prject",
                DealWith = "dealwith",
                Description = "des",
                Status = RecordStatus.Pending
            });
            record.Status =  RecordStatus.InHand;
            record.DealWith = "trying to solve this problem ";
            service.Update(record);
            var updatedRecord = service.Get(record.Id);
            var list = service.Query(null);
        }
    }
}
