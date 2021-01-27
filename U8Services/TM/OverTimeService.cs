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
    /// 加班单Service类
    /// </summary>
    public class OverTimeService
    {
        private SqlHelper db = null;
        public OverTimeService(string conn)
        {
            db = new SqlHelper(conn);
        }
        public string GetNewRecord()
        {
            String sql = "select  max(iRecordId)  from  HR_TM_OverTimeVoucher";
            string num = db.GetSingle(sql).ToString();            
            return num;
        }
        public string getHeadSql(OverTimeVoucherHead head)
        {
            string sql = db.InsertSql<OverTimeVoucherHead>(head, " HR_TM_OverTimeVoucher ");
            return sql;
        }
        public string getBodySql(List<OverTimeVoucherBody> boyList)
        {
            string sql = db.BulkInsertSql<OverTimeVoucherBody>(boyList, "hr_tm_OverTimeresult");
            return sql;
        }
        public int auditHead(string ccode, OverTimeVoucherHead head, ref string errMsg)
        {
            try
            {
                string sql = "update HR_TM_OverTimeVoucher set cStatus='2',bAuditFlag='1',cAuditor ='" + head.cAuditor  + "',dAuditTime=convert(nvarchar(19),GETDATE(),120),cAuditorNum='" + head.cAuditorNum + "' where VoucherID ='" + ccode + "' and (bAuditFlag<>1 or bAuditFlag is null)";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }
        public int auditBody(string ccode, OverTimeVoucherHead head, ref string errMsg)
        {
            try
            {
                string sql = "update hr_tm_OverTimeresult set bAuditFlag=1,cStatus='2',cAuditor = '" + head.cAuditor + "', cAuditorNum = '" + head.cAuditorNum + "', dAuditTime = convert(nvarchar(19), GETDATE(), 120)  where VoucherID = '" + ccode + "' and (bAuditFlag<>1 or bAuditFlag is null)";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }
        }
        public int auditHead(string ccode, string username,string userid, ref string errMsg)
        {
            try
            {
                string sql = "update HR_TM_OverTimeVoucher set cStatus='2',cAuditor = '" + username + "',dAuditTime=convert(nvarchar(19),GETDATE(),120),cAuditorNum='" + userid + "' where VoucherID ='" + ccode + "' and (bAuditFlag<>1 or bAuditFlag is null)";
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
                string sql = "update hr_tm_OverTimeresult set bAuditFlag=1,cStatus='2',cAuditor = '" + username + "', cAuditorNum = '" + userId + "', dAuditTime = convert(nvarchar(19), GETDATE(), 120)  where VoucherID = '" + ccode + "' and (bAuditFlag<>1 or bAuditFlag is null)";
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
