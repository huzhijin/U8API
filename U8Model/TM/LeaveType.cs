using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.TM
{
    public class LeaveType
    {
        public string cCode { get; set; }


        public string vName { get; set; }


        public bool? bSumTime { get; set; }


        public string vSumField { get; set; }


        public bool? bCountTime { get; set; }


        public string vCountField { get; set; }


        public bool? bIncludeDuty { get; set; }


        public bool? bIncludeRest { get; set; }


        public bool? bSalaryHoliday { get; set; }


        public bool? bCanDeduct { get; set; }


        public string vSumHoursField { get; set; }


        public string vSumDaysField { get; set; }


        public int? iDeductSequece { get; set; }


        public string vPreMothSumLeave { get; set; }


        public string vCurrentSumField { get; set; }


        public string vCurrentDeductField { get; set; }


        public string vCurrentTotalField { get; set; }


        public string vCurrentBalanceField { get; set; }


        public int? iBalanceFunc { get; set; }


        public int? iTimeUnit { get; set; }


        public bool? bUsed { get; set; }


        public int? iVacPeriodType { get; set; }


        public string vVacFormular { get; set; }


        public string vVacFormularDesc { get; set; }


        public string vBeginDate { get; set; }


        public decimal? nMinLeaveTime { get; set; }


        public string vMemo { get; set; }


        public string nVacFormulaBeginDateWithPara { get; set; }


        public string nVacFormulaEndDateWithPara { get; set; }


        public string nVacFormularWithPara { get; set; }


        public decimal? iRestHours { get; set; }


        public decimal? iRestDays { get; set; }


        public int? bDayCanDeduct { get; set; }


        public int? iDayDeductSequence { get; set; }


        public string vVacFormulaBeginDate { get; set; }


        public string vVacFormulaBeginDateDesc { get; set; }


        public string vVacFormulaEndDate { get; set; }


        public string vVacFormulaEndDateDesc { get; set; }


        public int? bUsedControl { get; set; }


        public int iBalanceRuleType { get; set; }


        public decimal? iProvideAmount { get; set; }


        public bool? bDelayControl { get; set; }


        public int? iDelayTimes { get; set; }


        public bool? bEnable { get; set; }


        public bool bControlPriority { get; set; }


        public string cSeniorLeaveType { get; set; }
    }
}
