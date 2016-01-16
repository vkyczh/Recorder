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
    public partial class FmBase : Form
    {

        public FmBase()
        {
            InitializeComponent();
            InitTitle();
        }

        /// <summary>
        /// 开启页面
        /// </summary>
        /// <param name="browserHelperParam"></param>
        public virtual void Init(BrowserHelperParam browserHelperParam)
        {
            if (browserHelperParam.Container == null)
                browserHelperParam.Container = pContainer;
            _browserHelperParam = browserHelperParam;
            InitTimer();
        }

        /// <summary>
        /// 开启页面
        /// </summary>
        /// <param name="path"></param>
        public virtual void Init(string path)
        {
            Init(new BrowserHelperParam(path));
        }

        public string Title
        {
            get
            {
                return lbTitle.Text;
            }

            set
            {
                lbTitle.Text = value;
            }
        }

        public bool IsTopMost
        {
            get
            {
                return TopMost;
            }
            set
            {
                TopMost = value;
                ucBtnNail.InnerBackgroundImage = TopMost?Properties.Resources.nailed:Properties.Resources.nail;
            }
        }

        protected bool IsBrowserCreated;
        protected WebKitBrowser _browser;

        protected WebKitBrowser Browser
        {
            get
            {
                if (_browser == null)
                {
                    throw new Exception("请在BrowserCreated之后访问Browser对象");
                }
                return _browser;
            }
            private set
            {
                _browser = value;
            }
        }

        /// <summary>
        /// 用于延迟Browser的UI渲染，使得界面显示更平滑
        /// </summary>
        Timer _timer;
        BrowserHelperParam _browserHelperParam;

        #region >>> protected

        /// <summary>
        /// Browser创建完成
        /// </summary>
        protected virtual void BrowserCreated()
        {

        }
        #endregion <<< protected

        #region >>> control event

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion <<< control event


        #region >>> private
        private void InitTitle()
        {
            lbTitle.MouseDown += (o, e) =>
            {
                WinTool.ReleaseCapture();
                WinTool.Capture(Handle);
            };

            lbTitle.MouseUp += (o, e) =>
            {
                WinTool.ReleaseCapture();
            };
        }

        private void InitTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1;
            _timer.Tick += (o, e) =>
            {
                CreateBrowser();
                _timer.Stop();
                _timer.Dispose();
            };
            _timer.Start();
        }

        private void CreateBrowser()
        {
            Browser = new BrowserHelper(_browserHelperParam).Browser;

            Browser.DocumentCompleted += TitleHandler;
            Browser.DocumentTitleChanged += TitleHandler;
            IsBrowserCreated = true;
            BrowserCreated();
        }

        protected virtual void TitleHandler(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Browser.DocumentTitle))
                lbTitle.Text = Browser.DocumentTitle;
        }

        #endregion <<< private

        private void ucBtnSize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void FmBase_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                return;

            ucBtnSize.InnerBackgroundImage =
                WindowState == FormWindowState.Maximized ?
                Properties.Resources.downResize : Properties.Resources.maxResize;

            ucBtnSize.Tip = WindowState == FormWindowState.Maximized ? "向下还原" : "最大化";
        }

        private void ucBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucBtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ucBtnNail_Click(object sender, EventArgs e)
        {
            IsTopMost = !IsTopMost;
        }

        

    }
}
