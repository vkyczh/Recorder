using DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Filters
{
    /// <summary>
    /// 问题记录的过滤条件
    /// </summary>
    public class RecordFilter
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public RecordStatus? Status { get; set; }

        /// <summary>
        /// 处理办法
        /// </summary>
        public string DealWith { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? BeginEditDate { get; set; }

        /// <summary>
        /// 最后编辑时间
        /// </summary>
        public DateTime? EndEditDate { get; set; }



    }
}
