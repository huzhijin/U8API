using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.TM
{
    /// <summary>
    /// 人员排班计划
    /// </summary>
    public class PersonDayResult
    {
        public string cPsn_Num { set; get; }
        public string dDutyDate { set; get; }
        public string cDutyCode { set; get; }
        public decimal nWorkHours { set; get; }
    }
}
