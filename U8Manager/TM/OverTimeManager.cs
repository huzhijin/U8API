using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U8Model.TM;
using U8Services.Common;
using U8Services.TM;

namespace U8Manager.TM
{
    public class OverTimeManager
    {
        OverTimeService overTimeService;
        VoucherService voucherService;
        public OverTimeManager(string conn)
        {
            overTimeService = new OverTimeService(conn);
            voucherService = new VoucherService(conn);
        }
        public string ccode { get; set; }
        public int AddOverTime(OverTimeVoucher overtime, ref string errMsg)
        {
             ccode = voucherService.GetNewCode("TM03", "JB");
            int record =Convert.ToInt32(overTimeService.GetNewRecord());
            List<OverTimeVoucherBody> bodyList = overtime.body;
            overtime.head.VoucherID = ccode;
            overtime.head.VoucherCode = ccode;
            overtime.head.cExamineApproveType = 2;
            overtime.head.bAuditFlag = 0;
            overtime.head.cStatus = 0;
            overtime.head.iRecordId = record + 1;
            overtime.head.dJbDate = Convert.ToDateTime(bodyList[0].dBeginTime).ToString("yyyy-MM-dd");
            overtime.head.dBeginTime = Convert.ToDateTime(bodyList[0].dBeginTime).TimeOfDay.ToString(); ;
            overtime.head.dEndTime = Convert.ToDateTime(bodyList[0].dEndTime).TimeOfDay.ToString(); ;
            overtime.head.dDutyTime = Convert.ToDateTime(bodyList[0].dBeginTime).TimeOfDay.ToString();
            overtime.head.dOffTime = Convert.ToDateTime(bodyList[0].dEndTime).TimeOfDay.ToString();
            overtime.head.dCreatTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd");
            overtime.head.vReason = bodyList[0].vReason;
            overtime.head.vRemark = bodyList[0].vRemark;
            overtime.head.iBeginCardAhead = 60;
            overtime.head.iEndCardForward = 60;
            overtime.head.nManHours = (Convert.ToDateTime(bodyList[0].dEndTime) - Convert.ToDateTime(bodyList[0].dBeginTime)).Hours.ToString();
            for (int q = 0; q < bodyList.Count; q++)
            {
                string person = bodyList[q].cPsn_Num;
                HRPersonInfo info = voucherService.getPersonInfo(person, ref errMsg);
                overtime.head.cDept_num = info.depCode;
                bodyList[q].JobNumber = info.jobNum;
                bodyList[q].VoucherID = ccode;
                bodyList[q].uRecordId= Guid.NewGuid().ToString();
                bodyList[q].dDutyTime = Convert.ToDateTime(bodyList[q].dBeginTime).TimeOfDay.ToString();
                bodyList[q].dOffTime = Convert.ToDateTime(bodyList[q].dEndTime).TimeOfDay.ToString();
                bodyList[q].dJbDate = Convert.ToDateTime(bodyList[q].dBeginTime).ToString("yyy-MM-dd");
                bodyList[q].nOvertimeHours = (Convert.ToDateTime(bodyList[q].dEndTime) - Convert.ToDateTime(bodyList[q].dBeginTime)).Hours.ToString();
                bodyList[q].nManHours = (Convert.ToDateTime(bodyList[q].dEndTime) - Convert.ToDateTime(bodyList[q].dBeginTime)).Hours.ToString();
                bodyList[q].nSubOVTime = "0";
                bodyList[q].dBeginTime = Convert.ToDateTime(bodyList[q].dBeginTime).AddMinutes(-60).TimeOfDay.ToString(); 
                bodyList[q].dEndTime = Convert.ToDateTime(bodyList[q].dEndTime).AddMinutes(60).TimeOfDay.ToString();              
                bodyList[q].dCreatTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd");               
                bodyList[q].uOverTimeCode= Guid.NewGuid().ToString();
                bodyList[q].cExamineApproveType = 2;
                bodyList[q].bAuditFlag = 0;
                bodyList[q].cStatus = 0;
                bodyList[q].iRowNo = q;
                bodyList[q].iComputeType = overtime.head.iComputeType;
                bodyList[q].vJbCode = overtime.head.vJbCode;
                bodyList[q].cTimeUseless1 = overtime.head.cTimeUseless1;
                bodyList[q].cTimeUseless2 = overtime.head.cTimeUseless2;
                bodyList[q].rFreeCardMode = overtime.head.rFreeCardMode;
                bodyList[q].rDealType = overtime.head.rDealType;
            }

            string headSql = overTimeService.getHeadSql(overtime.head);
            string bodySql = overTimeService.getBodySql(overtime.body);
            int a = voucherService.excuteSql(headSql);
            int b = 0;
            int c = 0;
            if (a == 1)
            {
                b = voucherService.excuteSql(bodySql);
            }
            if (b >= 1)
            {
               c= voucherService.UpdateMaxCode("TM03");
            }

            int i = a + b+c;
            return i;
        }
        public int auditOverTime(string ccode, OverTimeVoucherHead head, ref string errMsg)
        {
            int i = overTimeService.auditHead(ccode, head, ref errMsg);
            if (i == 1)
            {
                int q = overTimeService.auditBody(ccode, head, ref errMsg);
                i = i + q;
            }

            return i;
        }
        public int auditOverTime(string ccode, string username, string userid, ref string errMsg)
        {
            int i = overTimeService.auditHead(ccode, username, userid, ref errMsg);
            if (i == 1)
            {
                int q = overTimeService.auditBody(ccode, username, userid, ref errMsg);
                i = i + q;
            }

            return i;
        }
    }
}
