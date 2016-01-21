using DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Entities
{
    /// <summary>
    /// 问题记录实体
    /// </summary>
    public class Record
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 所属项目
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// 问题描述
        /// </summary>
         public string Description{get;set;}

        /// <summary>
        /// 标签
        /// </summary>
         public string Tag { get; set; }
        
        /// <summary>
        /// 状态
        /// </summary>
         public RecordStatus Status { get; set; }

        /// <summary>
        /// 解决方法
        /// </summary>
        public string DealWith { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 最后编辑时间
        /// </summary>
        public DateTime LastEditDate { get; set; }


    }
}
