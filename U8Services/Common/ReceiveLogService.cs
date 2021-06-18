using Helper.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U8Model.Common;

namespace U8Services.Common
{
    public class ReceiveLogService
    {
        private SqlHelper db = null;
        public ReceiveLogService(string conn)
        {
            db = new SqlHelper(conn);
        }
        public int AddLog(ReceiveLog receive,ref string errMsg)
        {
            try
            {
                
                string sql = db.InsertSql<ReceiveLog>(receive, "receiveLog");
                int i = db.ExecuteSql(sql);
                return i;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }
        }
        public int UpdateLog(ReceiveLog receive, ref string errMsg) 
        {
            try
            {
                
                string sql = "update  receiveLog set returnFlag="+ receive.returnFlag+ ",returnDesc='"+receive.returnDesc+"',returnData='"+receive.returnData+"',returnTime='"+ receive.returnTime+ "'  where uuid='"+receive.uuid+"'";
                int i = db.ExecuteSql(sql);
                return i;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }
        }
    }
}
