using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helper.DB;
using U8Model.TM;

namespace U8Services.TM
{
    /// <summary>
    /// 请假单Service类
    /// </summary>
    public class LeaveService
    {
        private SqlHelper db = null;
        public LeaveService(string conn)
        {
            db = new SqlHelper(conn);
        }
        public string getNewCode()
        {
            String sql = "select  cNumber+1  from  VoucherHistory  where CardNumber='TM01'";
            string num = db.GetSingle(sql).ToString();
            string sj = DateTime.Today.ToString("yyyyMMdd");
            num = "QJ" + sj + num;
            return num;
        }
        public int updateMaxCode()
        {
            string sql = " update VoucherHistory set cNumber=cNumber+1  Where  CardNumber='TM01'";
            return db.ExecuteSql(sql);
        }
        public HRPersonInfo getPersonInfo(string personCode,ref string errMsg)
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
        public int InsertHead(LeaveVoucherHead head, string barcode,ref string  errMsg)
        {
            try
            {
                string sql = " insert into hr_tm_LeaveMain (cExamineApproveType,cAuditBy,cCode,cCreateBy,cCurrentAuditor,cDepCode,cDepName,cLeaveType,cModifyBy,cStatus,cSubmitBy,cSysBarCode,cVoucherCode,cVoucherId,dAuditOn,dBeginDate, dCreateOn,dEndDate,dModifyOn,dSubmitOn,PK_hr_tm_LeaveMain,rLeaveTimeType,vLeaveReason,vRemark)";
                sql += "values('2','','TM110','" + head.cMaker + "','','" + head.cDepCode + "','" + head.cDepName + "','" + head.cLeaveType + "','','0','','" + barcode + "','" + head.cVoucherCode + "','" + head.cVoucherCode + "',null,'" + head.dBeginDate + "',getdate(), '" + head.dEndDate + "',null,null,'" + head.pk_hr_tm_LeaveMain + "','" + head.rLeaveTimeType + "','" + head.vLeaveReason + "','" + head.vRemark + "')";
                return db.ExecuteSql(sql); ;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }
            
        }
        public int InsertBody(LeaveVoucherHead head, LeaveVoucherBody body, HRPersonInfo info, string barcode, int row, decimal leaveHours,ref string errMsg)
        {
            try
            {
                string cSysBarCode = barcode+ "|" + (row + 1).ToString();
                string year = DateTime.Today.ToString("yyyy");
                string sql = " insert into hr_tm_Leave (cExamineApproveType,cDepCode,cDepName,cDutyClass,cLeaveType,cPsn_Num,cSysBarCode,cVoucherId,dBeginDate,dEndDate,nDeductedTime,dPlanEndDate,irowno, IsDeducted,nActualLeaveHours,nActualLeaveTime,PK_hr_tm_Leave,rLeaveStatus,rLeaveTimeType,vLeaveReason,vLeaveUnit,vRemark,vRestPeriod,vTerminateReason) ";
                sql += "values ('2','" + info.depCode + "','" + info.depName + "','" + info.dutyClass + "','" + head.cLeaveType + "','" + body.cPersonCode + "','" + cSysBarCode + "','" + head.cVoucherCode + "','" + body.dBeginDate + "','" + body.dEndDate + "','0','" + body.dEndDate + "', " + row + ",0," + leaveHours + "," + body.nActualLeaveTime + ",'" + body.pk_hr_tm_Leave + "','0','" + head.rLeaveTimeType + "','" + body.vLeaveReason + "', " + body.vLeaveUnit + ",'" + body.vRemark + "','" + year + "','')";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }
        
        }
        public int auditHead(string ccode, LeaveVoucherHead head, ref string errMsg)
        {
            try
            {
                string sql = "update hr_tm_LeaveMain set cStatus='2',dAuditOn=convert(nvarchar(19),GETDATE(),120),cAuditBy='" + head.cAuditBy + "' where cVoucherId ='" + ccode + "'";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }
        public int auditBody(string ccode, LeaveVoucherHead head, ref string errMsg)
        {
            try
            {
                string sql = "update hr_tm_Leave set  bAuditFlag='1',cAuditor = '" + head.cAuditBy + "',dAuditTime = convert(nvarchar(19), GETDATE(), 120)  where cVoucherId = '" + ccode + "' ";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }

        }
        public int auditHead(string ccode,string username,ref string errMsg) 
        {
            try
            {
                string sql = "update hr_tm_LeaveMain set cStatus='2',dAuditOn=convert(nvarchar(19),GETDATE(),120),cAuditBy='" + username + "' where cVoucherId ='" + ccode + "'";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg=ex.Message.ToString();
                throw;
            }
           
        }
        public int auditBody(string ccode,string username,string userId, ref string errMsg)
        {
            try
            {
                string sql = "update hr_tm_Leave set bAuditFlag='1',cAuditor = '" + username + "', cAuditorNum = '" + userId + "', dAuditTime = convert(nvarchar(19), GETDATE(), 120)  where cVoucherId = '" + ccode + "' ";
                return db.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message.ToString();
                throw;
            }
           
        }
        public List<LeaveType> getLeaveType(string cleaveType) 
        {
            List<LeaveType> leaveTypeList = new List<LeaveType>();
            string sql = "SELECT * FROM hr_tm_LeaveType WHERE cCode='"+ cleaveType + "'";
            DataSet ds = db.Query(sql);
            if (ds != null)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    LeaveType leaveType = new LeaveType();
                    PropertyInfo[] propertys = leaveType.GetType().GetProperties();
                    int i = 0;
                    foreach (PropertyInfo prop in propertys)
                    {
                        string filename = ds.Tables[0].Columns[i].ColumnName;
                        if (prop.Name.ToLower().Equals(filename.ToLower()))
                        {
                            var x = dr[filename] == null ? "" : dr[filename].ToString();
                            prop.SetValue(leaveType, x, null);
                        }
                        i++;
                    }
                    leaveTypeList.Add(leaveType);
                }
            }
                    return leaveTypeList;
        }
    }
}
