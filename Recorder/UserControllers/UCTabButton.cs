using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Recorder.Utils;

namespace Recorder.UserControllers
{
    public partial class UCTabButton : UCButton
    {
        public Action<TabInfo> OnDragOut;
        public UCTabButton()
        {
            InitializeComponent();
        }

        public UCTabButton(TabInfo tabInfo)
        {
            _ucTabPage = tabInfo.TabPage;
            _tabInfo = tabInfo;
            InitializeComponent();
        }

        bool _clicked;
        private bool _isSelcted;

        public bool IsSelcted {
            get 
            {
                return _isSelcted;
            }
            private set
            {
                _isSelcted = value;
                RefreshBackColor();
            }
        }

        private void RefreshBackColor()
        {
            BackColor = _isSelcted ? MouseDownBackgroundColor : MouseLeaveBackgroundColor;
        }

        UCTabPage _ucTabPage;
        TabInfo _tabInfo;
       
        protected override void MouseEnterHandler()
        {
            if (_isSelcted)
                return;
            BackColor = MouseEnterBackgroundColor;
        }

        protected override void MouseLeaveHandler()
        {
            RefreshBackColor();
        }

        protected override void MouseUpHandler()
        {
            _clicked = false;
        }

        protected override void MouseDownHandler()
        {
            _clicked = true;
        }

        protected override void ClickHandler()
        {
            base.ClickHandler();
        }

        protected override void MouseMoveHandler()
        {
            base.MouseMoveHandler();
            var p = PointToClient(MousePosition);
            if (_clicked& p.Y > Height || p.Y < 0)
            {
                _clicked = false;
                if (OnDragOut != null)
                {
                    OnDragOut(_tabInfo);
                }
            }
        }
        public  void SelectTab()
        {
            IsSelcted = true;
        }

        public void DisSelectTab()
        {
            IsSelcted = false;
        }

        private void ucBtnClose_Click(object sender, EventArgs e)
        {
            _tabInfo.RemoveAndDispose();
        }
    }
}
