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
            InitTimer();
        }

        private void SetPosition()
        {
            Top = 50;
            Left = Screen.GetWorkingArea(this).Width - Width - 50;
        }


        BrowserHelper _editBrowserHelper;
        BrowserHelper _listBrowserHelper;
        RecordAdapter _recordAdapter = new RecordAdapter();
        Timer _timer;

        private void FmMain_Load(object sender, EventArgs e)
        {
            pList.Dock = DockStyle.Fill;
            pEdit.Dock = DockStyle.Fill;
            _timer.Start();
            //SetBrowser();
        }

        private void InitTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1;
            _timer.Tick += (o, e) =>
            {
                SetBrowser();
                _timer.Stop();
                _timer.Dispose();
            };
        }

        private void SetBrowser()
        {
            _editBrowserHelper = new BrowserHelper("html/edit.html", pEdit, _recordAdapter);
            _listBrowserHelper = new BrowserHelper("html/list.html", pList, _recordAdapter);
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
            WinTool.Capture(Handle);
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

    }
}
