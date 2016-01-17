using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recorder
{
    public partial class UCButton : UserControl
    {
        public UCButton()
        {
            InitializeComponent();
        }

        public Color MouseEnterBackgroundColor = Color.FromArgb(54, 87, 200);
        public Color MouseDownBackgroundColor = Color.FromArgb(54, 87, 255);
        public Color MouseLeaveBackgroundColor = Color.Transparent;

        public string Tip { get; set; }
        public Image InnerBackgroundImage
        {
            get
            {
                return pContainer.BackgroundImage;
            }

            set
            {
                pContainer.BackgroundImage = value;

            }
        }
        public ContentAlignment TextAlign
        {
            get
            {
                return lbText.TextAlign;
            }
            set
            {
                lbText.TextAlign = value;
            }
        }

        public string UCText
        {
            get
            {
                return lbText.Text;
            }
            set
            {
                lbText.Text = value;
            }
        }

        private void UCButton_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterHandler();
        }

        protected virtual void MouseEnterHandler()
        {
            BackColor = MouseEnterBackgroundColor;
        }

        private void UCButton_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveHandler();
        }

        protected virtual void MouseLeaveHandler()
        {
            BackColor = MouseLeaveBackgroundColor;
        }

        private void UCButton_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownHandler();
        }

        protected virtual void MouseDownHandler()
        {
            BackColor = MouseDownBackgroundColor;
        }

        protected virtual void UCButton_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUpHandler();
        }

        protected virtual void MouseUpHandler()
        {
            BackColor = MouseEnterBackgroundColor;
        }

        private void lbText_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void lbText_MouseHover(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tip))
                return;

            toolTip1.Show(Tip, this,2,Height+2,1000);
        }

        private void UCButton_Click(object sender, EventArgs e)
        {
            ClickHandler();
        }

        protected virtual void ClickHandler()
        {

        }

        private void lbText_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        private void UCButton_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveHandler();
        }

        protected virtual void MouseMoveHandler()
        {

        }
    }
}
