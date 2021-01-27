using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.TM
{
    /// <summary>
    /// 请假单
    /// </summary>
    [Serializable]
    public class LeaveVoucher
    {
        /// <summary>
        /// 表头
        /// </summary>
        public LeaveVoucherHead head  { set; get; }
        /// <summary>
        /// 表体
        /// </summary>
        public List<LeaveVoucherBody> body { set; get; }
    }
    [Serializable]
    public class LeaveVoucherHead
    {
        /// <summary>
        /// 主键uuid
        /// </summary>
        public string pk_hr_tm_LeaveMain { set; get; }
        /// <summary>
        /// 单据号
        /// </summary>
        public string cVoucherCode { set; get; }
        /// <summary>
        /// 假别
        /// </summary>
        public string cLeaveType { set; get; }
        /// <summary>
        /// 请假时间类型
        /// </summary>
        public string rLeaveTimeType { set; get; }
        /// <summary>
        /// 部门编码
        /// </summary>
        public string cDepCode { set; get; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string cDepName { set; get; }
        /// <summary>
        /// 请假原因
        /// </summary>
        public string vLeaveReason { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        public string vRemark { set; get; }
        /// <summary>
        /// 制单人
        /// </summary>
        public string cMaker { set; get; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime dBeginDate { set; get; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime dEndDate { set; get; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string cAuditBy { set; get; }
        

    }
    [Serializable]
    public class LeaveVoucherBody
    {
        /// <summary>
        /// 子表uuid
        /// </summary>
        public string pk_hr_tm_Leave { set; get; }

        /// <summary>
        /// 人员编码
        /// </summary>
        public string cPersonCode { set; get; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime dBeginDate { set; get; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime dEndDate { set; get; }
        /// <summary>
        /// 请假原因
        /// </summary>
        public string vLeaveReason { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        public string vRemark { set; get; }
        /// <summary>
        /// 请假小时
        /// </summary>
        public decimal LeaveHours { set; get; }
        /// <summary>
        /// 请假单位
        /// </summary>
        public  int vLeaveUnit { set; get; }
        /// <summary>
        /// 请假时间
        /// </summary>
        public decimal nActualLeaveTime { set; get; }


    }
}

