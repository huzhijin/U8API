using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.DB;
using U8Model.TM;

namespace U8Services.TM
{
    /// <summary>
    /// 出差单Service类
    /// </summary>
    public class ErrandService
    {
        private SqlHelper db = null;
        public ErrandService(string conn)
        {
            db = new SqlHelper(conn);
        }

        public string getHeadSql(ErrandVoucherHead head)
        {
            string sql = db.InsertSql<ErrandVoucherHead>(head, "hr_tm_ErrandMain");
            return sql;
        }
        public string getBodySql(List<ErrandVoucherBody> boyList)
        {
            string sql = db.BulkInsertSql<ErrandVoucherBody>(boyList, "hr_tm_Errand");
            return sql;
        }
        public int auditHead(string ccode, ErrandVoucherHead head, ref string errMsg)
        {
            try
            {
                string sql = "update hr_tm_ErrandMain set cStatus='2',dAuditOn=convert(nvarchar(19),GETDATE(),120),cAuditBy='" + head.cAuditBy + "' where cVoucherId ='" + ccode + "'";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }
        public int auditBody(string ccode, ErrandVoucherHead head, ref string errMsg)
        {
            try
            {
                string sql = "update hr_tm_Errand set bAuditFlag=1,cStatus='2',cAuditor = '" + head.cAuditBy + "', dAuditTime = convert(nvarchar(19), GETDATE(), 120)  where cVoucherId = '" + ccode + "' ";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }
        public int auditHead(string ccode, string username, ref string errMsg)
        {
            try
            {
                string sql = "update hr_tm_ErrandMain set cStatus='2',dAuditOn=convert(nvarchar(19),GETDATE(),120),cAuditBy='" + username + "' where cVoucherId ='" + ccode + "'";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }
        public int auditBody(string ccode, string username, string userId, ref string errMsg)
        {
            try
            {
                string sql = "update hr_tm_Errand set bAuditFlag=1,cStatus='2',cAuditor = '" + username + "', cAuditorNum = '" + userId + "', dAuditTime = convert(nvarchar(19), GETDATE(), 120)  where cVoucherId = '" + ccode + "' ";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }
    }
}
