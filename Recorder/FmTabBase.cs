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

        private void FmTabBase_Load(object sender, EventArgs e)
        {
            ucTabContainer1.OnLastTabClosed += () => { Hide(); };
        }
     
        public void AddTab(string url)
        {
            var tabInfo = new TabInfo(ucTabContainer1);
            var browser = new BrowserHelper(new BrowserHelperParam(url, tabInfo.TabPage, new RecordAdapter(), true)).Browser;
            browser.DocumentCompleted += (o, e) =>
                {
                    tabInfo.TabButton.UCText = browser.DocumentTitle;
                };
            tabInfo.TabPage.BackColor = Color.GreenYellow;
            ucTabContainer1.AddTab(tabInfo);
        }

        public void AddTab(WebKitBrowser browser)
        {
            var tabInfo = new TabInfo(ucTabContainer1);
            browser.Dock = DockStyle.Fill;
            browser.Load += (o, e) =>
            {
                browser.GetScriptManager.ScriptObject = new RecordAdapter();
            };
            browser.DocumentCompleted += (o, e) =>
            {
                tabInfo.TabButton.UCText = browser.DocumentTitle;
            };
            tabInfo.TabPage.Controls.Add(browser);
            ucTabContainer1.AddTab(tabInfo);
        }

        protected override void CloseClickedHandler()
        {
            ucTabContainer1.RemoveAndDisposeAll();
            Hide();
        }
    }
}
