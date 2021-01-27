using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.GL
{
    public class Voucher
    {
        /// <summary>
        /// 操作码
        /// </summary>
        public string OP { set; get; }
        /// <summary>
        /// 业务类型
        /// </summary>
        public string RootTag { set; get; }
        /// <summary>
        /// 账套号
        /// </summary>
        public string Accid { set; get; }

        public string Coutno_id { set; get; }
    }
 }
