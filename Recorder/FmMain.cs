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
            Top = 70;
            Left = Screen.GetWorkingArea(this).Width - Width - 10;
        }

        BrowserHelper _editBrowserHelper;
        BrowserHelper _listBrowserHelper;
        RecordAdapter _recordAdapter = new RecordAdapter();
        Timer _timer;

        public bool IsTopMost
        {
            get
            {
                return TopMost;
            }
            set
            {
                TopMost = value;
                ucBtnNail.InnerBackgroundImage = TopMost ? Properties.Resources.nailed : Properties.Resources.nail;
            }
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            pList.Dock = DockStyle.Fill;
            pEdit.Dock = DockStyle.Fill;
            _timer.Start();
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
            _listBrowserHelper.Browser.NewWindowCreated += Browser_NewWindowCreated;
        }

        private void Browser_NewWindowCreated(object sender, NewWindowCreatedEventArgs e)
        {
            FmTabBase.Default.AddTab(e.WebKitBrowser);
            if (!FmTabBase.Default.Visible)
                FmTabBase.Default.Show();
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
        
        private void ucBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucBtnNail_Click(object sender, EventArgs e)
        {
            IsTopMost = !IsTopMost;
        }


    }
}
