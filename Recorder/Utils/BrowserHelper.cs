using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;
using WebKit;

namespace Recorder.Utils
{
    public class BrowserHelper
    {
        public BrowserHelper(string path, Control browserContainer, object scriptObject,bool isUrl = false)
        {
            Browser = new WebKitBrowser();
            Browser.Dock = DockStyle.Fill;
            browserContainer.Controls.Add(Browser);
            Browser.GetScriptManager.ScriptObject = scriptObject;//必须在Add到父控件后GetScriptManager才不为空
            Browser.Navigate(isUrl ? path : LocalToUrl(AppDomain.CurrentDomain.BaseDirectory + path));
        }

        public BrowserHelper(BrowserHelperParam p)
        {
            Browser = new WebKitBrowser();
            Browser.Dock = DockStyle.Fill;
            Browser.Load += (o, e) =>
            {
                Browser.GetScriptManager.ScriptObject = p.ScriptObject;//必须在Add到父控件后GetScriptManager才不为空
            };
            p.Container.Controls.Add(Browser);
            Browser.Navigate(p.GetUrl());
        }

        public WebKitBrowser Browser { get; private set; }

        private static string LocalToUrl(string path)
        {
            return HttpUtility.UrlPathEncode(string.Format("file:///{0}", path)).Replace("\\", "//");
        }

    }
}
