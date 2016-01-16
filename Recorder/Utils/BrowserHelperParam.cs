using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Recorder.Utils
{
    public class BrowserHelperParam
    {
        public BrowserHelperParam(string path, Control container = null, object scriptObject = null, bool isUrl = false)
        {
            Path = path;
            Container = container;
            ScriptObject = scriptObject;
            IsUrl = isUrl;
        }

        /// <summary>
        /// 本地应用程序文件相对路径，或者当IsUrl为true时为绝对url
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 承载Browser的容器
        /// </summary>
        public Control Container { get; set; }

        /// <summary>
        /// Path属性是否为绝对url
        /// </summary>
        public bool IsUrl { get; set; }

        /// <summary>
        /// Browser.GetScriptManager的ScriptObject属性。 在页面javascript中以window.external 访问此对象。
        /// </summary>
        public object ScriptObject { get; set; }

        /// <summary>
        /// 获取可浏览的url路径
        /// </summary>
        /// <returns></returns>
        public string GetUrl()
        {
            return IsUrl ? Path : LocalToUrl(AppDomain.CurrentDomain.BaseDirectory + Path);
        }

        private static string LocalToUrl(string path)
        {
            return HttpUtility.UrlPathEncode(string.Format("file:///{0}", path)).Replace("\\", "//");
        }
    }
}
