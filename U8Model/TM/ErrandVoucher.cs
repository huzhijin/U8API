using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.TM
{
    /// <summary>
    /// 出差单
    /// </summary>
    [Serializable]
    public class ErrandVoucher
    {
        /// <summary>
        /// 表头
        /// </summary>
        public ErrandVoucherHead head {set;get;}
        /// <summary>
        /// 表体
        /// </summary>
        public List<ErrandVoucherBody> body {set;get;}
    }
    [Serializable]
    public class ErrandVoucherHead
    {
        /// <summary>
        /// 审批人
        /// </summary>
        public string cAuditBy{set;get;}
        /// <summary>
        /// 单据编号(TM140)
        /// </summary>
        public string cCode{set;get;}
        /// <summary>
        ///制单人
        /// </summary>
        public string cCreateBy{set;get;}
        /// <summary>
        /// 当前审核人
        /// </summary>
        public string cCurrentAuditor{set;get;}
        /// <summary>
        /// 部门编码
        /// </summary>
        public string cDepCode{set;get;}
        /// <summary>
        /// 部门名称
        /// </summary>
        public string cDepName{set;get;}
        /// <summary>
        /// 出差类别
        /// </summary>
        public string cErrandType{set;get;}
        /// <summary>
        /// 数据来源标识
        /// </summary>
        public int cExamineApproveType{set;get;}
        /// <summary>
        /// 修改人
        /// </summary>
        //public string cModifyBy{set;get;}
        /// <summary>
        /// 单据状态
        /// </summary>
        public string cStatus{set;get;}
        /// <summary>
        /// 提交人
        /// </summary>
        public string cSubmitBy{set;get;}
        /// <summary>
        /// 条码
        /// </summary>
        public string cSysBarCode{set;get;}
        /// <summary>
        /// 单据编码
        /// </summary>
        public string cVoucherCode{set;get;}
        /// <summary>
        /// 单据编号
        /// </summary>
        public string cVoucherId{set;get;}
        /// <summary>
        /// 审核日期
        /// </summary>
        public string dAuditOn{set;get;}
        /// <summary>
        /// 开始日期
        /// </summary>
        public string dBeginDate{set;get;}
        /// <summary>
        /// 制单日期
        /// </summary>
        public string dCreateOn{set;get;}
        /// <summary>
        /// 结束日期
        /// </summary>
        public string dEndDate{set;get;}
        /// <summary>
        /// 修改日期
        /// </summary>
        //public string dModifyOn{set;get;}
        /// <summary>
        /// 
        /// </summary>
        //public string dSubmitOn{set;get;}
        /// <summary>
        /// 主键
        /// </summary>
        public string pk_hr_tm_ErrandMain { set;get;}
        /// <summary>
        /// 单据类型
        /// </summary>
        public string VoucherType{set;get;}
        /// <summary>
        /// 出差原因
        /// </summary>
        public string vReason{set;get;}
        /// <summary>
        /// 备注
        /// </summary>
        public string vRemark{set;get;}
    }
    [Serializable]
    public class ErrandVoucherBody
    {
        /// <summary>
        /// 部门编码
        /// </summary>
        public string cDepCode { set; get; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string cDepName { set; get; }
        /// <summary>
        /// 是否审核 
        /// </summary>
        public bool bAuditFlag{set;get;}
        /// <summary>
        /// 当前记录标识
        /// </summary>
        public bool bLastFlag{set;get;}
        /// <summary>
        /// 审核人
        /// </summary>
        public string cAuditor{set;get;}
        /// <summary>
        /// cAuditorNum
        /// </summary>
        public string cAuditorNum{set;get;}
        /// <summary>
        /// 制单人
        /// </summary>
        public string cCreator{set;get;}
        /// <summary>
        /// 制单人编码
        /// </summary>
        public string cCreatorNum{set;get;}
        /// <summary>
        /// 当前审核人
        /// </summary>
        public string cCurrentAuditor{set;get;}
        /// <summary>
        /// 班组
        /// </summary>
        public string cDutyClass{set;get;}
        /// <summary>
        /// 出差类别
        /// </summary>
        public string cErrandType{set;get;}
        /// <summary>
        /// 来源类型
        /// </summary>
        public string cExamineApproveType{set;get;}
        /// <summary>
        /// 修改人
        /// </summary>
        //public string cOperator{set;get;}
        /// <summary>
        /// 修改人编码
        /// </summary>
        //public string cOperatorNum{set;get;}
        /// <summary>
        /// 
        /// </summary>
        public string cPsn_Num{set;get;}
        /// <summary>
        /// 状态
        /// </summary>
        public string cStatus{set;get;}
        /// <summary>
        /// 条码
        /// </summary>
        public string cSysBarCode{set;get;}
        /// <summary>
        /// 单据编号
        /// </summary>
        public string cVoucherId{set;get;}
        /// <summary>
        /// 审核时间
        /// </summary>
        public string dAuditTime{set;get;}
        /// <summary>
        /// 开始日期
        /// </summary>
        public string dBeginDate{set;get;}
        /// <summary>
        /// 制单时间
        /// </summary>
        public string dCreatTime{set;get;}
        /// <summary>
        /// 结束日期
        /// </summary>
        public string dEndDate{set;get;}
        /// <summary>
        /// 修改时间
        /// </summary>
        //public string dOperatTime{set;get;}
        /// <summary>
        /// 记录序号
        /// </summary>
        //public int iRecordId{set;get;}
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNumber{set;get;}
        /// <summary>
        /// 状态2
        /// </summary>
        public Decimal nStatus2{set;get;}
        /// <summary>
        /// 主键
        /// </summary>
        //public string pk_hr_tm_Errand{set;get;}
        /// <summary>
        /// 审批人
        /// </summary>
        public string vApprover{set;get;}
        /// <summary>
        /// 出差原因
        /// </summary>
        public string vReason{set;get;}
        /// <summary>
        /// 备注
        /// </summary>
        public string vRemark{set;get;}
        /// <summary>
        /// 状态1
        /// </summary>
        public string vStatus1{set;get;}

    }
}
