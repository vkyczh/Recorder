using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebKit;

namespace Recorder.Utils
{
    public class BrowserHelper
    {
        public BrowserHelper(Control browserContainer, string url)
        {
            Browser = new WebKitBrowser();
            BrowserContainer = browserContainer;
            Url = url;
        }
        public WebKitBrowser Browser { get; private set; }
        public Control BrowserContainer{get;private set;}
        public string Url { get; private set; }

        public void InitWebBrowser()
        {
            Browser.Dock = DockStyle.Fill;
            BrowserContainer.Controls.Add(Browser);
            Browser.Navigate(Url);
        }
    }
}
