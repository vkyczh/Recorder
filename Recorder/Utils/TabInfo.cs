using Recorder.UserControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebKit;

namespace Recorder.Utils
{
    public class TabInfo
    {
        public Action OnDisposed;
        public TabInfo()
        {
            TabPage = new UCTabPage();
            TabButton = new UCTabButton(this);
        }

        public UCTabPage TabPage { get; set; }

        public UCTabButton TabButton { get; set; }

        UCTabContainer _ucTabContainer;
        public UCTabContainer UCTabContainer
        {
            get
            {
                return _ucTabContainer;
            }
            set
            {
                _ucTabContainer = value;
            }
        }

        /// <summary>
        /// 选中Tab页
        /// 注意：此动作只应该改由UCTabContainer通过给SelectedTabInfo赋值调用。
        /// 以此保证之前选中页状态被设置为未选中。
        /// </summary>
        public void Select()
        {
            TabButton.SelectTab();
            TabPage.SelectTabPage();
        }

        /// <summary>
        /// 反选中Tab页
        /// 注意：此动作只应该改由UCTabContainer通过给SelectedTabInfo赋值调用。
        /// 以此保证被选中页状态被设置为选中状态。
        /// </summary>
        public void DisSelect()
        {
            TabButton.DisSelectTab();
            TabPage.DisSelect();
        }

        public void Remove()
        {
            _ucTabContainer.Remove(this);
        }

        public void RemoveAndDispose()
        {
            Remove();
            DisposeWebKitBrowser();
            if (OnDisposed != null)
                OnDisposed();
        }

        public void DisposeWebKitBrowser()
        {
            foreach (var c in TabPage.Controls)
            {
                if (c is WebKitBrowser)
                {
                    (c as WebKitBrowser).Dispose();
                }
            }
        }
    }
}
