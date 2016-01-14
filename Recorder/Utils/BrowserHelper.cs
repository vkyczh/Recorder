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
        public BrowserHelper(string url)
        {
            Browser = new WebKitBrowser();
            Url = url;
            Browser.Navigate(Url);
        }
        public WebKitBrowser Browser { get; private set; }
        public Control BrowserContainer{get;private set;}
        public string Url { get; private set; }

        public void InitWebBrowser(Control browserContainer)
        {
            Browser.Dock = DockStyle.Fill;
            browserContainer.Controls.Add(Browser);
        }

        public static string LocalToUrl(string path)
        {
            return HttpUtility.UrlPathEncode(string.Format("file:///{0}", path)).Replace("\\", "//");
        }
    }
}
