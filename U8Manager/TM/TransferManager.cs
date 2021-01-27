using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U8Model.HM;
using U8Services.Common;
using U8Services.HM;

namespace U8Manager.TM
{
    public class TransferManager
    {
        TransferRegisterService transferService;
        VoucherService voucherService;
        public TransferManager(string conn)
        {
            transferService = new TransferRegisterService(conn);
            voucherService = new VoucherService(conn);
        }
        public string ccode { get; set; }
        public int AddTransfer(TransferRegister transfer, ref string errMsg)
        {
            ccode = voucherService.GetNewCode("HM701", "DD");
            transfer.cVoucherId= ccode;
            transfer.bAuditFlag = 0;
            transfer.cstate = "0";
            transfer.PK_HR_HI_TransferRegister= Guid.NewGuid().ToString();
            transfer.csysbarcode= "||HM701|" + ccode;
            transfer.dCreateOn = DateTime.Now;
            string headSql = transferService.getSql(transfer);
            int a = voucherService.excuteSql(headSql);
            if (a >= 1)
            {
                voucherService.UpdateMaxCode("HM701");
            }

            return a;
        }
        public int auditTransfer(string ccode, TransferRegister transfer, ref string errMsg) 
        {
            int i = transferService.auditVoucher(ccode,transfer, ref errMsg);
            return i;
        }
        public int auditTransfer(string ccode, string username, string userid, ref string errMsg)
        {
            int i = transferService.auditVoucher(ccode, username, ref errMsg);
            return i;
        }
    }
}
