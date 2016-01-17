using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Recorder.Utils;
using WebKit;

namespace Recorder.UserControllers
{
    public partial class UCTabContainer : UserControl
    {
        public UCTabContainer()
        {
            InitializeComponent();
        }

        IList<TabInfo> TabInfoList = new List<TabInfo>();

        TabInfo _preSelectedTabInfo;
        TabInfo _selectedTabInfo;
        int _leftForTabButton = 0;

        public TabInfo SelectedTabInfo
        {
            get
            {
                return _selectedTabInfo;
            }
            set
            {
                if (_selectedTabInfo == value)
                    return;
                _preSelectedTabInfo = _selectedTabInfo;
                _selectedTabInfo = value;

                if (_preSelectedTabInfo != null)
                    _preSelectedTabInfo.DisSelect();
                
                if (_selectedTabInfo != null)
                    _selectedTabInfo.Select();
            }
        }

        public void AddTab(TabInfo tabInfo)
        {
            tabInfo.TabButton.Left = _leftForTabButton;
            _leftForTabButton += tabInfo.TabButton.Width;
            tabInfo.TabButton.Click += (o, e) => { SelectedTabInfo = tabInfo; };
            pTabButtonContainer.Controls.Add(tabInfo.TabButton);
            pTabPageContainer.Controls.Add(tabInfo.TabPage);
            TabInfoList.Add(tabInfo);
            SelectedTabInfo = tabInfo;
        }

        public TabInfo Remove(TabInfo tabInfo)
        {
            TabInfoList.Remove(tabInfo);
            pTabButtonContainer.Controls.Remove(tabInfo.TabButton);
            pTabPageContainer.Controls.Remove(tabInfo.TabPage);
            if (tabInfo == SelectedTabInfo)
            {
                if (_preSelectedTabInfo != null && _preSelectedTabInfo != tabInfo && TabInfoList.Contains(_preSelectedTabInfo))
                {
                    SelectedTabInfo = _preSelectedTabInfo;
                }
                else if (TabInfoList.Count != 0)
                {
                    SelectedTabInfo = TabInfoList.First();
                }
            }
            RefreshTabButtonContainer();
            return tabInfo;
        }

        private void RefreshTabButtonContainer()
        {
            pTabButtonContainer.Controls.Clear();
            _leftForTabButton = 0;
            foreach (var t in TabInfoList)
            {
                t.TabButton.Left = _leftForTabButton;
                pTabButtonContainer.Controls.Add(t.TabButton);
                _leftForTabButton += t.TabButton.Width;
            }
        }
    }
}
