using BLL.Services;
using DataModel.Entities;
using DataModel.Enums;
using Recorder.Business;
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
            pList.MouseWheel += (obj, e) =>
            {
                int step = 50*(e.Delta>0? -1:1);
                
                _listBrowserHelper.Browser.GetScriptManager.EvaluateScript("document.body.scrollTop+="+step+";");
            };
            _editBrowserHelper = InitWebBrowser(pEdit, BrowserHelper.LocalToUrl(AppDomain.CurrentDomain.BaseDirectory + "html/edit.html"));
            _listBrowserHelper = InitWebBrowser(pList, BrowserHelper.LocalToUrl(AppDomain.CurrentDomain.BaseDirectory + "html/list.html"));
        }

        BrowserHelper _editBrowserHelper;
        BrowserHelper _listBrowserHelper;
        RecordAdapter _recordAdapter = new RecordAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {
            pList.Dock = DockStyle.Fill;
            pEdit.Dock = DockStyle.Fill;
            pEdit.BringToFront();

            _editBrowserHelper.Browser.GetScriptManager.ScriptObject = _recordAdapter;
            _listBrowserHelper.Browser.GetScriptManager.ScriptObject = _recordAdapter;
        }

        private BrowserHelper InitWebBrowser(Control container, string url)
        {
            var browserHelper = new BrowserHelper(container, url);
            browserHelper.InitWebBrowser();
            return browserHelper;
        }

        private static void TestDbOperates()
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
            record.Status = RecordStatus.InHand;
            record.DealWith = "trying to solve this problem ";
            service.Update(record);
            var updatedRecord = service.Get(record.Id);
            var list = service.Query(null);
        }

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            WinTool.ReleaseCapture();
            WinTool.SendMessage(Handle, WinTool.WM_SYSCOMMAND, WinTool.HTCAPTION + WinTool.SC_MOVE, 0);
        }

        private void lbTitle_MouseUp(object sender, MouseEventArgs e)
        {
            WinTool.ReleaseCapture();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.BackColor = Color.FromArgb(54, 87, 200);
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.BackColor = Color.Transparent;
        }

        private void lbEdit_Click(object sender, EventArgs e)
        {
            pEdit.BringToFront();

        }

        private void lbList_Click(object sender, EventArgs e)
        {
            pList.BringToFront();
            pList.Focus();
            _listBrowserHelper.Browser.Reload();
        }
    }
}
