using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U8Model.TM;
using U8Services.TM;

namespace U8Manager.TM
{
    public class LeaveManager
    {
        LeaveService service;
        public LeaveManager(string conn)
        {
            service = new LeaveService(conn);
        }
        public string ccode { get; set; }

        public int addLeave(LeaveVoucher leave,ref string errMsg)
        {
            LeaveVoucherHead head = leave.head;
            string voucherCode = service.getNewCode();
            ccode = voucherCode;
            int row = 0;
            string barcode = "||TM110|" + voucherCode;
            head.cVoucherCode = voucherCode;
            List<LeaveVoucherBody> lstBody = leave.body;
            HRPersonInfo info = service.getPersonInfo(lstBody[0].cPersonCode,ref errMsg);
            if (lstBody.Count == 1)
            {
                head.cDepCode = info.depCode;
                head.cDepName = info.depName;
                head.vLeaveReason = lstBody[0].vLeaveReason;
                head.vRemark = lstBody[0].vRemark;
            }
            head.pk_hr_tm_LeaveMain= Guid.NewGuid().ToString();
            head.dBeginDate = Convert.ToDateTime(lstBody[0].dBeginDate).ToString("yyyy-MM-dd HH:mm:dd");
            head.dEndDate = Convert.ToDateTime(lstBody[0].dEndDate).ToString("yyyy-MM-dd HH:mm:dd");
            int headdata = service.InsertHead(head, barcode, ref errMsg);
            if (headdata > 0)
            {
                row = row + headdata;
                int q = service.updateMaxCode();
                row = row + q;
                for (int i = 0; i < lstBody.Count; i++)
                {
                    TimeSpan ts1 = new TimeSpan(Convert.ToDateTime(lstBody[i].dBeginDate).Ticks);
                    TimeSpan ts2 = new TimeSpan(Convert.ToDateTime(lstBody[i].dEndDate).Ticks);
                    TimeSpan ts = ts1.Subtract(ts2).Duration();
                    int day = ts.Days;
                    int hours = ts.Hours;
                    if (day >=0 ) 
                    {
                        if (hours >= 8) { hours = 8; }
                        lstBody[i].LeaveHours = day*8 + hours;
                        lstBody[i].vLeaveUnit = 1;
                        lstBody[i].nActualLeaveTime= day * 8 + hours;
                    }                   
                    //decimal hours = service.getLeaveHours(lstBody[i].dBeginDate, lstBody[i].dEndDate,
                    //    lstBody[i].cPersonCode);
                    decimal hoursForLeave = lstBody[i].LeaveHours;
                    lstBody[i].pk_hr_tm_Leave= Guid.NewGuid().ToString();
                    int bodydata = service.InsertBody(head, lstBody[i], info, barcode, i, hoursForLeave, ref errMsg);
                    if (bodydata > 0)
                    {
                        row = bodydata + row;
                    }

                }

            }

            return row;
        }
        public int auditLeave(string ccode, LeaveVoucherHead head, ref string errMsg)
        {
            int i = service.auditHead(ccode, head, ref errMsg);
            if (i == 1)
            {
                int q = service.auditBody(ccode, head,  ref errMsg);
                i = i + q;
            }

            return i;
        }
        public int auditLeave(string ccode,string username, string userid,ref string errMsg)
        {
            int i = service.auditHead(ccode,username,ref errMsg);
            if (i == 1) 
            {
                int q = service.auditBody(ccode, username, userid, ref errMsg);
                i = i + q;
            }

            return i;
        }
        private decimal getLeaveTime(string beginTime, string endTime,string cleaveType) 
        {
            decimal leaveTime = decimal.Zero;
            return leaveTime;
        }

    }
    }
