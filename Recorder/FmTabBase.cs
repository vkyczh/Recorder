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
    public partial class FmTabBase : FmBase
    {
        public FmTabBase()
            : base()
        {
            InitializeComponent();
            Title = "";
            pToolBar.Visible = false;
        }

        public static FmTabBase Default = new FmTabBase();
        public static List<FmTabBase> FmTabBaseList = new List<FmTabBase>();

        static FmTabBase()
        {
            Default.Title = "主工作区";
        }

        public void CaptureForm()
        {
            WinTool.ReleaseCapture();
            WinTool.Capture(this.Handle);

        }
        private void FmTabBase_Load(object sender, EventArgs e)
        {
            ucTabContainer1.OnTabsEmpty += () => { Hide(); };
        }

        public void MoveInTab(TabInfo tabInfo)
        {
            ucTabContainer1.AddTab(tabInfo);
        }
        public void AddTab(WebKitBrowser browser)
        {
            var tabInfo = new TabInfo();
            browser.Dock = DockStyle.Fill;
            browser.Load += (o, e) =>
            {
                browser.GetScriptManager.ScriptObject = new RecordAdapter();
            };
            RegisterEvent(tabInfo, browser);

            tabInfo.TabPage.Controls.Add(browser);
            ucTabContainer1.AddTab(tabInfo);
        }

        private static void RegisterEvent(TabInfo tabInfo, WebKitBrowser browser)
        {
            tabInfo.TabButton.OnDragOut += (t) =>
            {
                t.MoveToNewForm(MousePosition);
            };
            browser.DocumentCompleted += (o, e) =>
            {
                tabInfo.TabButton.UCText = browser.DocumentTitle;
                tabInfo.TabButton.Tip = browser.DocumentTitle;
            };
            browser.NewWindowCreated += (o, e) =>
            {
                FmTabBase.Default.AddTab(e.WebKitBrowser);
                if (!FmTabBase.Default.Visible)
                    FmTabBase.Default.Show();
            };
        }

        public bool PointInTabContainer(Point mousePoint)
        {
            var p =  pToolBar.PointToClient(mousePoint);
            if (p.X > 0 && p.X < pToolBar.Width
                && p.Y > 0 && p.Y < pToolBar.Height)
                return true;
            return false;
        }

        protected override void CloseClickedHandler()
        {
            ucTabContainer1.RemoveAndDisposeAll();
            if (this == Default)
            {
                Hide();
            }
            else
            {
                base.CloseClickedHandler();
            }
        }
    }
}
