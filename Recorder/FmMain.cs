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
using System.Threading;
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
            SetPosition();
        }

        private void SetPosition()
        {
            Top = 50;
            Left = Screen.GetWorkingArea(this).Width - Width - 50;
        }


        BrowserHelper _editBrowserHelper = new BrowserHelper(BrowserHelper.LocalToUrl(AppDomain.CurrentDomain.BaseDirectory + "html/edit.html"));
        BrowserHelper _listBrowserHelper = new BrowserHelper(BrowserHelper.LocalToUrl(AppDomain.CurrentDomain.BaseDirectory + "html/list.html"));
        RecordAdapter _recordAdapter = new RecordAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {
            pList.Dock = DockStyle.Fill;
            pEdit.Dock = DockStyle.Fill;
            SetBrowser();
        }

        private void SetBrowser()
        {
            _editBrowserHelper.InitWebBrowser(pEdit);
            _listBrowserHelper.InitWebBrowser(pList);
            _editBrowserHelper.Browser.GetScriptManager.ScriptObject = _recordAdapter;
            _listBrowserHelper.Browser.GetScriptManager.ScriptObject = _recordAdapter;
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
            pTool.BackgroundImage = global::Recorder.Properties.Resources.LeftSelectedTab;
        }

        private void lbList_Click(object sender, EventArgs e)
        {
            pList.BringToFront();
            _listBrowserHelper.Browser.Focus();
            _listBrowserHelper.Browser.Reload();
            pTool.BackgroundImage = global::Recorder.Properties.Resources.RightSelectedTab;
        }

        private void FmMain_Shown(object sender, EventArgs e)
        {

        }
    }
}
