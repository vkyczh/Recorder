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
        }
        
        private void FmTabBase_Load(object sender, EventArgs e)
        {
            //var tabInfo = new TabInfo(ucTabContainer1);
            //tabInfo.TabPage.BackColor = Color.GreenYellow;
            //ucTabContainer1.AddTab(tabInfo);

            //var tabInfo2 = new TabInfo(ucTabContainer1);
            //tabInfo2.TabPage.BackColor = Color.Gold;
            //ucTabContainer1.AddTab(tabInfo2);
           // ucTabContainer1.SelectedTabInfo = tabInfo2;
           // SelectedTabInfo = tabInfo;
        }
        private void ucButton1_Click(object sender, EventArgs e)
        {
            var tabInfo = new TabInfo(ucTabContainer1);
            new BrowserHelper(new BrowserHelperParam("html/list.html", tabInfo.TabPage,new RecordAdapter()));
            tabInfo.TabPage.BackColor = Color.GreenYellow;
            ucTabContainer1.AddTab(tabInfo);
        }
    }
}
