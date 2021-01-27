using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.TM
{
    /// <summary>
    /// 加班单
    /// </summary>
    [Serializable]
    public class OverTimeVoucher
    {
        /// <summary>
        /// 表头
        /// </summary>
        public OverTimeVoucherHead head { set; get; }
        /// <summary>
        /// 表体
        /// </summary>
        public List<OverTimeVoucherBody> body { set; get; }
    }
    [Serializable]
    public class OverTimeVoucherHead
    {
        /// <summary>
        /// 单据编号
        /// </summary>
        public string  VoucherID { set; get; }
        /// <summary>
        /// 单据编码
        /// </summary>

        public string VoucherCode  {set; get; }
        /// <summary>
        /// 部门编码
        /// </summary>

        public string cDept_num { set; get; }
        /// <summary>
        /// 批准人
        /// </summary>

        public string vApprover { set; get; }
        /// <summary>
        ///加班类别
        /// </summary>
        public string vJbCode { set; get; }
        /// <summary>
        /// 加班计算方式
        /// </summary>
        public string iComputeType { set; get; }
        /// <summary>
        /// 加班原因
        /// </summary>
        public string vReason { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        public string vRemark { set; get; }
        /// <summary>
        /// 加班日期
        /// </summary>
        public string dJbDate { set; get; }
        /// <summary>
        /// 加班时间
        /// </summary>
        public string nManHours { set; get; }
        /// <summary>
        /// 扣除时间1
        /// </summary>
        public string  cTimeUseless1 { set; get; }
        /// <summary>
        /// 扣除时间2
        /// </summary>
        public string  cTimeUseless2 { set; get; }
        /// <summary>
        /// 加班开始时间
        /// </summary>
        public string dDutyTime { set; get; }
        /// <summary>
        /// 加班结束时间
        /// </summary>
        public string dOffTime { set; get; }
        /// <summary>
        /// 开始时间跨天
        /// </summary>
        public int  bOverDate { set; get; }
        /// <summary>
        /// 结束时间跨天
        /// </summary>
        public int bOverDate2 { set; get; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string dBeginTime { set; get; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string dEndTime { set; get; }
        /// <summary>
        /// 提前打卡时间
        /// </summary>
        public int iBeginCardAhead { set; get; }
        /// <summary>
        /// 推迟打卡时间
        /// </summary>
        public int iEndCardForward { set; get; }
        /// <summary>
        /// 免卡方式
        /// </summary>
        public string rFreeCardMode { set; get; }
        /// <summary>
        /// 最大迟到时间
        /// </summary>
        public int nMaxDelay { set; get; }
        /// <summary>
        /// 最大早退时间
        /// </summary>
        public int nMaxLeave { set; get; }
        /// <summary>
        /// 当前记录标识
        /// </summary>
        public string bLastFlag { set; get; }
        /// <summary>
        /// 记录序号
        /// </summary>
        public int iRecordId { set; get; }
        /// <summary>
        /// 是否审核
        /// </summary>
        public int bAuditFlag { set; get; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string cAuditor { set; get; }
        /// <summary>
        /// 审核人编码
        /// </summary>
        public string cAuditorNum { set; get; }
        /// <summary>
        /// 制单人
        /// </summary>
        public string cCreator { set; get; }
        /// <summary>
        /// 制单人编码
        /// </summary>
        public string cCreatorNum { set; get; }
        /// <summary>
        /// 修改人
        /// </summary>
        //public string cOperator { set; get; }
        /// <summary>
        /// 修改人编码
        /// </summary>
        //public string cOperatorNum { set; get; }
        /// <summary>
        /// 修改时间
        /// </summary>
        //public string dOperatTime { set; get; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public string dAuditTime { set; get; }
        /// <summary>
        /// 制单时间
        /// </summary>
        public string dCreatTime { set; get; }
        /// <summary>
        /// 加班单处置方式 
        /// </summary>
        public string rDealType { set; get; }
        /// <summary>
        ///来源类型
        /// </summary>
        public int cExamineApproveType { set; get; }
        /// <summary>
        ///状态
        /// </summary>
        public int cStatus { set; get; }
    }
    [Serializable]
    public class OverTimeVoucherBody

    {    /// <summary>
        /// 主键(guid)
        /// </summary>
        public string uRecordId { set; get; }
        /// <summary>
        /// 免卡方式
        /// </summary>
        public string rFreeCardMode { set; get; }
        /// <summary>
        /// 已经作废的主键(guid)
        /// </summary>
        public string uOverTimeCode { set; get; }
        /// <summary>
        ///人员编码
        /// </summary>
        public string cPsn_Num { set; get; }
        /// <summary>
        /// 实际加班时间
        /// </summary>
        public string nOvertimeHours { set; get; }
        /// <summary>
        /// 扣除时间
        /// </summary>
        public string nSubOVTime { set; get; }

        /// <summary>
        /// 有效工时  
        /// </summary>
        public string nManHours { set; get; }
        /// <summary>
        /// 加班日期
        /// </summary>
        public string dJbDate { set; get; }
        /// <summary>
        /// 加班类别
        /// </summary>
        public string vJbCode { set; get; }
        /// <summary>
        /// 加班原因
        /// </summary>
        public string vReason { set; get; }
        /// <summary>
        /// 审批人
        /// </summary>
        public string vApprover { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        public string vRemark { set; get; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string dBeginTime { set; get; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string dEndTime { set; get; }
        /// <summary>
        /// 最大迟到时间
        /// </summary>
        public decimal nMaxDelay { set; get; }
        /// <summary>
        /// 最大早退时间
        /// </summary>
        public decimal nMaxLeave { set; get; }
        /// <summary>
        /// 零刷卡旷工工时
        /// </summary>
        //public decimal nAbsent0 { set; get; }
        /// <summary>
        /// 单刷卡旷工工时 
        /// </summary>
        //public decimal nAbsent1 { set; get; }

        /// <summary>
        /// 加班开始时间  
        /// </summary>
        public string dDutyTime { set; get; }
        /// <summary>
        /// 加班结束时间
        /// </summary>
        public string dOffTime { set; get; }
        /// <summary>
        /// 开始时间跨天  
        /// </summary>
        public int bOverDate { set; get; }
        /// <summary>
        /// 结束时间跨天
        /// </summary>
        public int bOverDate2 { set; get; }

        /// <summary>
        /// 加班计算类别 
        /// </summary>
        public string iComputeType { set; get; }
        /// <summary>
        /// 上班刷卡时间
        /// </summary>
        //public string dOVStartCard { set; get; }
        /// <summary>
        /// 下班刷卡时间
        /// </summary>
        //public string dOVEndCard { set; get; }
        /// <summary>
        /// 记录号
        /// </summary>
        public int iRecordId { set; get; }
        /// <summary>
        /// 当前记录标识 
        /// </summary>
        public int bLastFlag { set; get; }
        /// <summary>
        /// 状态1
        /// </summary>
        //public string vStatus1 { set; get; }
        /// <summary>
        /// 状态2
        /// </summary>
        //public string nStatus2 { set; get; }
        /// <summary>
        /// 实际加班时间（分钟） 
        /// </summary>
        public int iActualOverMinute { set; get; }
        /// <summary>
        /// 审核人编码
        /// </summary>
        public string cAuditorNum { set; get; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string cAuditor { set; get; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public string dAuditTime { set; get; }
        /// <summary>
        /// 是否审核
        /// </summary>
        public int bAuditFlag { set; get; }
        /// <summary>
        /// 制单人编码
        /// </summary>
        public string cCreatorNum { set; get; }
        /// <summary>
        /// 制单人
        /// </summary>
        public string cCreator { set; get; }
        /// <summary>
        /// 制单时间
        /// </summary>
        public string dCreatTime { set; get; }
        /// <summary>
        /// 修改人编码
        /// </summary>
        //public string cOperatorNum { set; get; }
        /// <summary>
        /// 修改人
        /// </summary>
        //public string cOperator { set; get; }
        /// <summary>
        /// 修改时间
        /// </summary>
        //public string dOperatTime { set; get; }
        /// <summary>
        /// 迟到分钟
        /// </summary>
        public int iLAbsentMinute { set; get; }
        /// <summary>
        /// 早退分钟
        /// </summary>
        public int iEAbsentMinute { set; get; }
        /// <summary>
        /// 旷工分钟
        /// </summary>
        public int iAbsentMinute { set; get; }
        /// <summary>
        /// 旷工小时
        /// </summary>
        public decimal nAbsentOverHours { set; get; }
        /// <summary>
        /// 上班签卡原因 
        /// </summary>
        public string rSignCardReason1 { set; get; }
        /// <summary>
        /// 下班签卡原因 
        /// </summary>
        public string rSignCardReason2 { set; get; }
        /// <summary>
        /// 单据编码 
        /// </summary>
        public string VoucherID { set; get; }
        /// <summary>
        /// 扣除时间1 
        /// </summary>
        public string cTimeUseless1 { set; get; }
        /// <summary>
        /// 扣除时间2
        /// </summary>
        public string cTimeUseless2 { set; get; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNumber { set; get; }
        /// <summary>
        /// 有效截至日期
        /// </summary>
        //public string dValidityDate { set; get; }
        /// <summary>
        /// 加班处置方式
        /// </summary>
        public string rDealType { set; get; }
        /// <summary>
        /// 行号
        /// </summary>
        public int iRowNo { set; get; }
        /// <summary>
        /// 初始化发生期间 
        /// </summary>
        public string cInitPeriod { set; get; }
        /// <summary>
        /// 数据来源标示 
        /// </summary>
        public int cExamineApproveType { set; get; }
        /// <summary>
        /// 可休时间 
        /// </summary>
        public decimal nAvailableOverHours { set; get; }
        /// <summary>
        /// 单据类型  默认值0
        /// </summary>
        public int iAuVoucherType { set; get; }
        /// <summary>
        /// 期间  默认值0
        /// </summary>
        public int iPeriodOrder { set; get; }
        /// <summary>
        ///状态
        /// </summary>
        public int cStatus { set; get; }
    }
}
