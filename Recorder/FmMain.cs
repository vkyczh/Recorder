using Recorder.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebKit;

namespace Recorder
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
            
            InitWebBrowser();
        }

        BrowserHelper _browserHelper;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitWebBrowser()
        {
            _browserHelper = new BrowserHelper(this, "http://www.baidu.com");
            _browserHelper.InitWebBrowser();
        }
    }
}
