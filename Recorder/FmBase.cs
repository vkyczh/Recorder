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

        public string Title{
            get
            {
                return lbTitle.Text;
            }

            set 
            {
                lbTitle.Text = value;
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

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.BackColor = Color.FromArgb(54, 87, 200);
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.BackColor = Color.Transparent;
        }

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
            IsBrowserCreated = true;
            BrowserCreated();
        }

        #endregion <<< private
    }
}
