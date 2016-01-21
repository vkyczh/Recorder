using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Enums
{

    /// <summary>
    /// 处理状态
    /// </summary>
    public enum RecordStatus
    {
        /// <summary>
        /// 待处理
        /// </summary>
        Pending = 0,

        /// <summary>
        /// 在处理
        /// </summary>
        InHand = 1,

       /// <summary>
       /// 已处理
       /// </summary>
        Resolved = 2
    }
}
