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
    public class ErrandManager
    {
        ErrandService errandService;
        VoucherService voucherService;
        public ErrandManager(string conn)
        {
            errandService = new ErrandService(conn);
            voucherService = new VoucherService(conn);
        }
        public string ccode { get; set; }
        public int AddErrand(ErrandVoucher errand, ref string errMsg)
        {
             ccode = voucherService.GetNewCode("TM02", "CC");
            List<ErrandVoucherBody> bodyList = errand.body;
            errand.head.cVoucherId = ccode;
            errand.head.cVoucherCode = ccode;
            errand.head.cCode = "TM140";
            errand.head.cExamineApproveType = 2;
            errand.head.cStatus = "0";
            errand.head.pk_hr_tm_ErrandMain = Guid.NewGuid().ToString();
            errand.head.dCreateOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd");
            errand.head.vReason = bodyList[0].vReason;
            errand.head.dBeginDate = bodyList[0].dBeginDate;
            errand.head.dEndDate= bodyList[0].dEndDate;
            for (int q = 0; q < bodyList.Count; q++)
            {
                string person = bodyList[q].cPsn_Num;
                HRPersonInfo info = voucherService.getPersonInfo(person, ref errMsg);
                bodyList[q].cDepCode = info.depCode;
                bodyList[q].cDepName = info.depName;
                errand.head.cDepName= info.depName;
                errand.head.cDepCode = info.depCode;                
                //bodyList[q].pk_hr_tm_Errand = Guid.NewGuid().ToString();
                bodyList[q].cVoucherId = ccode;
                bodyList[q].cExamineApproveType = "2";
                bodyList[q].cSysBarCode = "|" + q.ToString();
                bodyList[q].bAuditFlag = false;
                bodyList[q].cStatus = "0";
                bodyList[q].cErrandType = errand.head.cErrandType;
            }
            string headSql = errandService.getHeadSql(errand.head);
            int a = voucherService.excuteSql(headSql);
            string bodySql = errandService.getBodySql(errand.body);
            int b = 0;
            if (a == 1)
            {

                b = voucherService.excuteSql(bodySql);
            }
            if (b >= 1)
            {
                voucherService.UpdateMaxCode("TM02");
            }

            int i = a + b;
            return i;
        }
        public int auditErrand(string ccode, ErrandVoucherHead head, ref string errMsg)
        {
            int i = errandService.auditHead(ccode, head, ref errMsg);
            if (i == 1)
            {
                int q = errandService.auditBody(ccode, head, ref errMsg);
                i = i + q;
            }

            return i;
        }

        public int auditErrand(string ccode, string username, string userid, ref string errMsg)
        {
            int i = errandService.auditHead(ccode, username, ref errMsg);
            if (i == 1)
            {
                int q = errandService.auditBody(ccode, username, userid, ref errMsg);
                i = i + q;
            }

            return i;
        }

    }
}
