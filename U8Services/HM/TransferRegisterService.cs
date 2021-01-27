using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.DB;
using U8Model.HM;
using U8Model.TM;

namespace U8Services.HM
{
    /// <summary>
    ///人员调动登记Service类
    /// </summary>
    public class TransferRegisterService
    {
        private SqlHelper db = null;
        public TransferRegisterService(string conn)
        {
            db = new SqlHelper(conn);
        }
        public string getSql (TransferRegister tr)
        {
            string sql = db.InsertSql<TransferRegister>(tr, "HR_HI_TransferRegister");
            return sql;
        }
        public int auditVoucher(string ccode, TransferRegister tr, ref string errMsg)
        {
            try
            {
                int i = 0;
                string sql1 = "update HR_HI_TransferRegister set cstate='2',dAuditOn=convert(nvarchar(19),GETDATE(),120),cAuditBy='" + tr.cAuditBy + "' where cVoucherId ='" + ccode + "'";
                int a = db.ExecuteSql(sql1);
                string sql2 = "update UPDATE hr_hi_person SET cDept_num = '" + tr.rLaterDepCode + "' where cPsn_Num='" + tr.cPsn_Num + "'";
                int b = db.ExecuteSql(sql2);
                string sql3 = " INSERT  INTO hr_hi_jobInfo( PK_hr_hi_jobInfo, cjobcode ,cDepCode ,cDeptName ,cJobName ,cJobRankCode ,cJobGradeCode ,cDutycode , cDutyName ,\n" +
                  " cSupPerson ,dbegindate ,denddate ,rDChgType ,rDutyLev ,rholdpostWay ,rhpreason ,vhpAuthUnit ,vAuthorizeDoc ,\n" +
                  " dremovDate ,rremovMode ,rremovReason ,vrmAuthUnit ,vrmAuthDoc ,vstatus1 ,nstatus2 ,bMaxJobRankCode ,iRecordID ,\n" +
                  " blastflag ,cPsn_Num , bPartJob,cVoucherId )\n" +
                  " SELECT TOP 1 NEWID(), ISNULL(hr_hi_jobInfo.cjobcode, '') ,ISNULL(hr_hi_person.cDept_num, '') ,ISNULL(hr_hi_jobInfo.cDeptName, '') ,ISNULL(hr_hi_jobInfo.cJobName, '') ,ISNULL(hr_hi_jobInfo.cJobRankCode, '') ,\n" +
                  " ISNULL(hr_hi_jobInfo.cJobGradeCode, '') ,ISNULL(hr_hi_jobInfo.cDutycode, '') ,ISNULL(hr_hi_jobInfo.cDutyName, '') ,ISNULL(hr_hi_jobInfo.cSupPerson, '') ,\n" +
                  " ISNULL(hr_hi_jobInfo.dbegindate, '') ,ISNULL(hr_hi_jobInfo.denddate, '') ,ISNULL(hr_hi_jobInfo.rDChgType, '') ,ISNULL(hr_hi_jobInfo.rDutyLev, '') ,\n" +
                  " ISNULL(hr_hi_jobInfo.rholdpostWay, '') ,ISNULL(hr_hi_jobInfo.rhpreason, '') ,ISNULL(hr_hi_jobInfo.vhpAuthUnit, '') ,ISNULL(hr_hi_jobInfo.vAuthorizeDoc, '') ,\n" +
                  " ISNULL(hr_hi_jobInfo.dremovDate, '') ,ISNULL(hr_hi_jobInfo.rremovMode, '') ,ISNULL(hr_hi_jobInfo.rremovReason, '') ,ISNULL(hr_hi_jobInfo.vrmAuthUnit, '') ,\n" +
                  " ISNULL(hr_hi_jobInfo.vrmAuthDoc, '') ,ISNULL(hr_hi_jobInfo.vstatus1, '') ,ISNULL(hr_hi_jobInfo.nstatus2, 0) ,ISNULL(hr_hi_jobInfo.bMaxJobRankCode, '') ,\n" +
                  " ( SELECT    ISNULL(MAX(iRecordID), 0) + 1 FROM  hr_hi_jobInfo WHERE cPsn_Num='"+tr.cPsn_Num+"') ,\n" +
                  "  1 , hr_hi_person.cPsn_Num , 0 , '"+ccode+"'\n" +
                  " FROM    hr_hi_person\n" +
                  " LEFT OUTER JOIN hr_hi_jobInfo ON hr_hi_jobInfo.cPsn_Num = hr_hi_person.cPsn_Num\n" +
                  " AND hr_hi_jobInfo.blastflag = 1\n" +
                  " AND hr_hi_jobInfo.bPartJob = 0\n" +
                  " WHERE   hr_hi_person.cPsn_Num = '"+tr.cPsn_Num+"' ;";
                int c = db.ExecuteSql(sql3);
                string sql4= "update hr_hi_jobinfo set denddate = '"+tr.dTransferDate+"' , cVoucherId = '"+ccode+"',blastflag = 0 WHERE   cPsn_Num = '"+tr.cPsn_Num+"' AND blastflag = 1 AND bPartJob = 0\n" +
            "   AND ISNULL(iRecordID, 0) <> ( SELECT  ISNULL(MAX(iRecordID), 0)\n" +
            "   FROM  hr_hi_jobInfo  where  cPsn_Num = '"+tr.cPsn_Num+"' ) ; ";
                int d = db.ExecuteSql(sql4);
                string sql5 = "UPDATE hr_hi_jobinfo SET cDepCode='"+tr.rLaterDepCode+ "',beginDate='"+tr.dTransferDate+ "',depName=(SELECT cdepname from Department where cdepcode='"+tr.rLaterDepCode+"') where cPsn_Num = '" + tr.cPsn_Num+"' AND blastflag = 1 AND bPartJob = 0 ";
                int e = db.ExecuteSql(sql5);
                string sql6 = "update HR_TM_PersonDutyClass set dLeaveDutyClassDate = '"+tr.dTransferDate+"' ,blastflag = 0  where PK_hr_tm_personDutyClass = (select top 1  PK_hr_tm_personDutyClass from HR_TM_PersonDutyClass where cpsn_num='"+tr.cPsn_Num+"' and blastflag = 1 order by dEnterDutyClassDate desc)";
                int f = db.ExecuteSql(sql6);
                string sql7 = "UPDATE hr_tm_DayResult SET cDepCode = '"+tr.rLaterDepCode+ "',cDepCode_Num = '" + tr.rLaterDepCode + "' WHERE cPsn_Num = '"+tr.cPsn_Num+"' AND dDutyDate >= '"+tr.dTransferDate+"'";
                int g = db.ExecuteSql(sql7);
                string sql8 = "UPDATE hr_tm_MonthResult SET vdepcode_num = '"+ tr.rLaterDepCode + "',vDepCode = '"+tr.rLaterDepCode+"' WHERE cPsn_Num = '"+tr.cPsn_Num+"' AND ((cYear = "+Convert.ToDateTime(tr.dTransferDate).Year+" AND cMonth >= "+ Convert.ToDateTime(tr.dTransferDate).Month + ") OR (cYear > "+ Convert.ToDateTime(tr.dTransferDate).Year + "))";
                int h = db.ExecuteSql(sql8);
                string sql9 = "UPDATE  UA_User   SET  cDept = (SELECT cdepname from Department where cdepcode='" + tr.rLaterDepCode + "')    WHERE   cUser_id IN  (SELECT cUser_Id FROM UserHrPersonContro WHERE UserHrPersonContro.cPsn_Num='" + tr.cPsn_Num+"')";
                int k = db.ExecuteSql(sql9);
                i = a + b + c + d + e + f + g + h + k;
                return i;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }

        public int auditVoucher(string ccode, string username, ref string errMsg)
        {
             try
            {
                int i = 0;
                string sql = "update HR_HI_TransferRegister set cstate='2',dAuditOn=convert(nvarchar(19),GETDATE(),120),cAuditBy='" + username + "' where cVoucherId ='" + ccode + "'";
                int a= db.ExecuteSql(sql);
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
