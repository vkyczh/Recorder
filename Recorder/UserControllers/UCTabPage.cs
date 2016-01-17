using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebKit;

namespace Recorder.UserControllers
{
    public partial class UCTabPage : UserControl
    {
        public UCTabPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void SelectTabPage()
        {
            BringToFront();
        }

        public WebKitBrowser GetWebBrowser()
        {
            foreach (var ctr in Controls)
            {
                if (ctr is WebKitBrowser)
                    return ctr as WebKitBrowser;
            }
            return null;
        }
        public void DisSelect()
        {

        }
    }
}
