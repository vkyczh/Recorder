using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public void DisSelect()
        {

        }
    }
}
