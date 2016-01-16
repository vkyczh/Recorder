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
    public partial class FmDetail : FmBase
    {
        /// <summary>
        /// 请使用传递json字符串参数的构造函数
        /// </summary>
        public FmDetail()
        {
            InitializeComponent();
        }

        public FmDetail(string json)
            : base()
        {
            InitializeComponent();
            _json = json;
            Init("html/detail.html");
        }

        string _json;

        protected override void BrowserCreated()
        {
            base.BrowserCreated();
            BindJson();
        }
        private void BindJson()
        {
            Browser.DocumentCompleted += (o, be) =>
            {
                Browser.GetScriptManager.EvaluateScript(string.Format("detailPage.bind({0});", _json));
            };
        }

    }
}
