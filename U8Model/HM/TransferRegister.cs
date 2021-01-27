using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.HM
{
    /// <summary>
    /// 人事调动登记
    /// </summary>
    [Serializable]
    public class TransferRegister
    {
        
        public string PK_HR_HI_TransferRegister{set;get;}
        public string cVoucherId{set;get;}
        public string cPsn_Num{set;get;}
        public string dTransferDate{set;get;}
        public string rTransferType{set;get;}
        public string cTransferReason{set;get;}
        public string rFormerDepCode{set;get;}
        public string rLaterDepCode{set;get;}
        public string rFormerClassCode{set;get;}
        public string rLaterClassCode{set;get;}
        public string rFormerDutyCode{set;get;}
        public string rLaterDutyCode{set;get;}
        public string rFormerDutyLev{set;get;}
        public string rLaterDutyLev{set;get;}
        public string rFormerJobRankCode{set;get;}
        public string rLaterJobRankCode{set;get;}
        public string rFormerJobGradeCode{set;get;}
        public string rLaterJobGradeCode{set;get;}
        public string rFormerPositionCode{set;get;}
        public string rLaterPositionCode{set;get;}
        public string cTransferVoucherType{set;get;}
        public string cTransferVoucherNum{set;get;}
        public string cTransferVoucherLineNum{set;get;}
        public string cCreateBy{set;get;}
        public DateTime? dCreateOn{set;get;}
        public string cSubmitBy{set;get;}
        public DateTime? dSubmitOn{set;get;}
        public string cAuditBy{set;get;}
        public DateTime? dAuditOn{set;get;}
        public int? bAuditFlag{set;get;}
        public string cstate { set; get; }
        public string csysbarcode{set;get;}
       
        public string cPsn_Name{set;get;}
       
        public string rPersonType{set;get;}
        public string rChgPersonType{set;get;}
        public string rFormerBusDepCode{set;get;}
        public string rLaterBusDepCode{set;get;}
        public string dPValidDate{set;get;}
    }
}
