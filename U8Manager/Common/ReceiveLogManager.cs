using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U8Model.Common;
using U8Services.Common;

namespace U8Manager.Common
{
    public class ReceiveLogManager
    {
        ReceiveLogService receiveLogService;
        public ReceiveLogManager(string conn)
        {
            receiveLogService = new ReceiveLogService(conn);
        }
        public ReceiveLog getReturnDesc(ReceiveLog log,ReturnMessage message) 
        {

            if (message.Success)
            {
                log.returnFlag = 1;
                log.returnDesc = message.Msg;
                log.returnData = message.Data.ToString();
               

            }
            else 
            {
                log.returnFlag = 0;
                log.returnDesc = message.Msg;
                log.returnData = message.Data.ToString();
             
            }
            return log;

        }
        public bool AddReceiveLog(ReceiveLog receiveLog,ref string errMsg) 
        {
            receiveLog.receiveTime = DateTime.Now;
            int i =receiveLogService.AddLog(receiveLog,ref errMsg);
            if (i != 1)
            {
                return false;
            }
            else 
            {
                return true;
            }

        }
        public bool UpdateReceiveLog(ReceiveLog receiveLog, ref string errMsg)
        {
            receiveLog.receiveTime = DateTime.Now;
            int i = receiveLogService.UpdateLog(receiveLog, ref errMsg);
            if (i != 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
