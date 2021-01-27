using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.DB;
using U8Model.GL;

namespace U8Services.GL
{
    public class AccVouchService
    {
        private SqlHelper db = null;
        public AccVouchService(string conn)
        {
            db = new SqlHelper(conn);
        }

        public int Delete(Voucher v)
        {
            string sql = "update gl_accvouch set iflag = 1 where iyperiod = " + v.Coutno_id.Substring(0, 6) + " and ino_id = " + Convert.ToInt32(v.Coutno_id.Substring(6));
            return db.ExecuteSql(sql);
        }

        public bool VouchIsExists(Voucher v)
        {
            string sql = "select count(*) from gl_accvouch where iyperiod = " + v.Coutno_id.Substring(0, 6) + " and ino_id = " + Convert.ToInt32(v.Coutno_id.Substring(6));
            int a = Convert.ToInt32(db.GetSingle(sql));
            if (a > 0) { return true; } else { return false; }
        }

        /// <summary>
        /// 是否已记账
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool CheckIsBook(Voucher v)
        {
            string sql = "select min(ibook) from gl_accvouch where iyperiod = " + v.Coutno_id.Substring(0, 6) + " and ino_id = " + Convert.ToInt32(v.Coutno_id.Substring(6));
            int a = Convert.ToInt32(db.GetSingle(sql));
            if (a == 1) { return true; } else { return false; }
        }
        /// <summary>
        /// 是否已审核
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool CheckIsCheck(Voucher v)
        {
            string sql = "select isnull(ccheck,'') from gl_accvouch where iyperiod = " + v.Coutno_id.Substring(0, 6) + " and ino_id = " + Convert.ToInt32(v.Coutno_id.Substring(6));
            string a = db.GetSingle(sql).ToString();
            if (a == "" || a == null) { return false; } else { return true; }
        }

        public string GetCoutNO(string csign, string vouno)
        {
            string sql = "select top 1 coutno_id from GL_accvouch where convert(varchar,iYPeriod) + right(cast(POWER(10,4) as varchar) + ino_id,4) = '" + vouno + "' and csign = '" + csign + "'";
            object o = db.GetSingle(sql);
            if (o != null)
                return o.ToString();
            return "";
        }

        public void auditPZ(string coutnoid, string userName, string aduitDate)
        {
            string sql = " update GL_accvouch set ccheck='" + userName + "',daudit_date='" + aduitDate + "'  where coutno_id = '" + coutnoid + "'";
            db.ExecuteSql(sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accid">账套号</param>
        /// <param name="coutid">应收付单号</param>
        /// <param name="csign">记账类型</param>
        /// <param name="vouno">凭证号格式YYYYMM0000</param>
        /// <param name="coutno_id">凭证唯一号</param>
        /// <param name="coutsign">AR 或 AP</param>
        /// <param name="coutbillsign">R0 或 P0</param>
        public void BindVoucher(string accid, string coutid, string csign, string vouno, string coutno_id, string coutsign, string coutbillsign)
        {
            string ino_id = vouno.Substring(vouno.Length - 4);
            string cPZNum = csign + "-" + ino_id;
            string month = vouno.Substring(4, 2);
            string year = vouno.Substring(0, 4);
            string iYperiod = vouno.Substring(0, 6);
            string sql = "update GL_accvouch set coutaccset = '" + accid + "',ioutyear = " + year + ",coutsysname = '" + coutsign + "',coutsign = '" + coutsign + "',doutdate = doutbilldate,coutbillsign = '" + coutbillsign + "',coutid='" + coutid + "' where coutno_id = '" + coutno_id + "'";
            db.ExecuteSql(sql);
            sql = "update Ap_Vouch set cPZid = '" + coutno_id + "',cPZNum = '" + cPZNum + "',doutbilldate=dverifydate where cVouchID='" + coutid + "' and cflag = '" + coutsign + "'";
            db.ExecuteSql(sql);
            if (coutsign == "AR")
                sql = "Update AR_Detail set cPZID=N'" + coutno_id + "',iSignSeq=(select top 1 iSignSeq * 10 from GL_accvouch where coutno_id = '" + coutno_id + "' and ccode = AR_Detail.ccode),cGLSign=N'" + csign + "',iGLno_id=" + Convert.ToInt32(ino_id) + ",ino_id=" + Convert.ToInt32(ino_id) + ",dPZDate=dRegDate where cProcStyle=N'" + coutbillsign + "' and cVouchID=N'" + coutid + "' and cFlag=N'" + coutsign + "'";
            else
                sql = "Update AP_Detail set cPZID=N'" + coutno_id + "',iSignSeq=(select top 1 iSignSeq * 10 from GL_accvouch where coutno_id = '" + coutno_id + "' and ccode = AP_Detail.ccode),cGLSign=N'" + csign + "',iGLno_id=" + Convert.ToInt32(ino_id) + ",ino_id=" + Convert.ToInt32(ino_id) + ",dPZDate=dRegDate where cProcStyle=N'" + coutbillsign + "' and cVouchID=N'" + coutid + "' and cFlag=N'" + coutsign + "'";
            db.ExecuteSql(sql);
            sql = "DELETE FROM Gl_coderemark WHERE iperiod = " + month + " AND csign = N'" + csign + "' AND ino_id = " + Convert.ToInt32(ino_id) + " and iyear=" + year;
            db.ExecuteSql(sql);
            sql = "insert into Gl_coderemark (iYperiod,iyear,iperiod,csign,ino_id,inid) select iYperiod,iyear,iperiod,csign,ino_id,inid from GL_accvouch where coutno_id = '" + coutno_id + "'";
            db.ExecuteSql(sql);
        }

        public bool bPerson(string ccode, string year)
        {
            string sql = "select bperson from code where ccode = '" + ccode + "'  and  iyear ='" + year + "'";
            return Convert.ToBoolean(db.GetSingle(sql));
        }
        public bool bCus(string ccode, string year)
        {
            string sql = "select bcus from code where ccode = '" + ccode + "'  and  iyear ='" + year + "'";
            return Convert.ToBoolean(db.GetSingle(sql));
        }
        public bool bBank(string ccode, string year)
        {
            string sql = "select bbank from code where ccode = '" + ccode + "' and  iyear ='" + year + "'";
            return Convert.ToBoolean(db.GetSingle(sql));
        }
        public bool bCash(string ccode, string year)
        {
            string sql = "select bcash from code where ccode = '" + ccode + "' and  iyear ='" + year + "'";
            return Convert.ToBoolean(db.GetSingle(sql));
        }
        public bool bCashItem(string ccode, string year)
        {
            string sql = "select bcashItem from code where ccode = '" + ccode + "' and  iyear ='" + year + "'";
            return Convert.ToBoolean(db.GetSingle(sql));
        }
       


    }
}
