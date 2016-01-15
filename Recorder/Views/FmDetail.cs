using Recorder.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recorder.Views
{
    public partial class FmDetail : Form
    {

        public FmDetail()
        {
            InitializeComponent();
        }
        public FmDetail(string json)
        {
            InitializeComponent();
            _json = json;
        }

        string _json = "{}";
        BrowserHelper _editBrowserHelper = new BrowserHelper(BrowserHelper.LocalToUrl(AppDomain.CurrentDomain.BaseDirectory + "html/detail.html"));
        private void FmDetail_Load(object sender, EventArgs e)
        {
            _editBrowserHelper.InitWebBrowser(this);
            _editBrowserHelper.Browser.DocumentCompleted+= (o, be) =>
            {
                _editBrowserHelper.Browser.GetScriptManager.EvaluateScript(string.Format("detailPage.bind({0});",_json));
            };
        }

    }
}
