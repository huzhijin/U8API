using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.TM
{
    /// <summary>
    /// hr人员信息
    /// </summary>
    [Serializable]
    public class HRPersonInfo
    {
        /// <summary>
        /// 人员编码
        /// </summary>
        public string personCode { set; get; }
        /// <summary>
        /// 人员名称
        /// </summary>
        public string personName { set; get; }
        /// <summary>
        /// 部门编码
        /// </summary>
        public string depCode { set; get; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string depName { set; get; }
        /// <summary>
        /// 工号
        /// </summary>
        public string jobNum { set; get; }
        /// <summary>
        /// 班组编码
        /// </summary>
        public string dutyClass { set; get; }
        /// <summary>
        /// 班组名称
        /// </summary>
        public string dutyClassName { set; get; }
    }
}
