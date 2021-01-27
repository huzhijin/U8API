using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helper.DB;
using U8Model.TM;

namespace U8Services.Common
{
    /// <summary>
    /// 单据通用Service类
    /// </summary>
    public class VoucherService
    {
        private SqlHelper db = null;
        public VoucherService(string conn)
        {
            db = new SqlHelper(conn);
        }
        /// <summary>
        /// 获取最大流水号
        /// </summary>
        /// <param name="cardNumber">单据类型编码</param>
        /// <param name="voucherPrefix">单据类型前缀</param>
        /// <returns></returns>
        public string GetNewCode(string cardNumber,string voucherPrefix)
        {
            String sql = "select  cNumber+1  from  VoucherHistory  where CardNumber='"+cardNumber+ "' and cContent is NULL";
            string num = db.GetSingle(sql).ToString();
            num = num.PadLeft(5, '0');
            string sj = DateTime.Today.ToString("yyyyMMdd");
            num = voucherPrefix + sj + num;
            return num;
        }
        /// <summary>
        /// 更新最大流水号
        /// </summary>
        /// <param name="cardNumber">单据类型编码</param>
        /// <returns></returns>
        public int UpdateMaxCode(string cardNumber)
        {
            string sql = " update VoucherHistory set cNumber=cNumber+1  Where  CardNumber='" + cardNumber + "'and cContent is NULL";
            return db.ExecuteSql(sql);
        }

        public int excuteSql(string sql)
        {
            int i = db.ExecuteSql(sql);
            return i;
        }

        public HRPersonInfo getPersonInfo(string personCode, ref string errMsg)
        {
            try
            {
                string today = DateTime.Today.ToString("yyyy-MM-dd");
                String sql = "select a.cpsn_num,a.cpsn_name,a.dEnterUnitDate,a.JobNumber,a.cJobCode,a.dLeaveDate,a.rPersonType,IsNull(a1.cDepCode,a.cdept_num) as cDept_num,b.cdepname,c.vdescription as rSex,d.vdescription as rPersonTypeName,e.reducation,HR_CT002.vdescription as EducationName,f.cDutycode,f.vdutyname,j.cJobCode,j.vjobname,a.cJobGradeCode,g.cJobGradeName,a.cJobRankCode,r.cJobRankName,p.dBeginDate, a.cDutyclass,k.vName AS  cDutyclassName from hr_hi_person as a  left join hr_tm_dayresult as a1 on a.cpsn_num=a1.cpsn_num and ddutyDate='" + today + "' left join department as b on IsNull(a1.cDepCode,a.cdept_num)=b.cdepcode  left join HR_CT001 c on c.ccodeID=a.rSex  left join HR_CT000 d on d.ccodeID=a.rPersonType  left join  hr_hi_edu e on  a.cPsn_Num = e.cPsn_Num  and isnull(e.irecordid,0) =  ( select max(isnull(lshy.irecordid,0)) from dbo.hr_hi_edu as lshy where isnull(lshy.blastflag,0)=1 and lshy.cPsn_Num= e.cPsn_Num )  left join  HR_CT002  on  HR_CT002.ccodeID = e.reducation  left join  HR_HI_JOBINFO on  a.cPsn_Num = HR_HI_JOBINFO.cPsn_Num  and isnull(HR_HI_JOBINFO.irecordid,0) =  ( select max(isnull(lshy.irecordid,0)) from dbo.HR_HI_JOBINFO as lshy where isnull(lshy.blastflag,0)=1 and lshy.cPsn_Num= HR_HI_JOBINFO.cPsn_Num )  left join  HR_OM_DUTY f on HR_HI_JOBINFO.cDutycode = f.cDutycode  left join  HR_HI_Probation p on a.cPsn_Num = p.cPsn_Num and p.blastflag = 1  left join  HR_HM_JobGrade g on a.cJobGradeCode = g.cJobGradeCode  left join  HR_HM_JobRank r on a.cJobRankCode = r.cJobRankCode  left join hr_om_job j on j.cJobCode=a.cJobCode  LEFT JOIN hr_tm_DutyClass k ON k.cCode=a.cDutyclass  where a.cpsn_num='" + personCode + "'";
                DataSet ds = db.Query(sql);
                HRPersonInfo info = new HRPersonInfo();
                if (ds != null)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    info.personCode = dr["cpsn_num"].ToString();
                    info.personName = dr["cpsn_name"].ToString();
                    info.depCode = dr["cDept_num"].ToString();
                    info.depName = dr["cdepname"].ToString();
                    info.jobNum = dr["cJobCode"].ToString();
                    if (dr["cDutyclass"].ToString() != "")
                    {
                        info.dutyClass = dr["cDutyclass"].ToString();
                    }
                    if (dr["cDutyclassName"].ToString() != "")
                    {
                        info.dutyClassName = dr["cDutyclassName"].ToString();
                    }

                }
                return info;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }


    }
}
