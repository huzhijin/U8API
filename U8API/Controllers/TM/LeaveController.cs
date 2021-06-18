using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.WebSockets;
using Newtonsoft.Json;
using Swashbuckle.Swagger.Annotations;
using U8Manager.Common;
using U8Manager.TM;
using U8Model.Common;
using U8Model.TM;

namespace U8API.Controllers.TM
{
   
    /// <summary>
    /// 请假单
    /// </summary>
    public class LeaveController : ApiController
    {
        public VoucherManager vouMag { get; set; }
        /// <summary>
        /// 新增请假单
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="json">请假单json</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddLeave")]
        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(LeaveVoucher))]
        public HttpResponseMessage AddLeave(string token, string json)
        {
          
                string errMsg = "";
                ReturnMessage msg = new ReturnMessage();
            try
            {
                ReceiveLog receive = new ReceiveLog();
                receive.uuid = Guid.NewGuid();
                receive.receiveData = json;
                receive.interfaceCode = "Leave";
                receive.interfaceDesc = "请假单新增";
                receive.op = "add";
               
                vouMag = (VoucherManager)HttpContext.Current.Application.Get(token);
                if (vouMag == null)
                {
                    msg.Success = false;
                    msg.Msg = "参数token无效或已过期";
                    msg.Code = 500;
                }
                else
                {
                    ReceiveLogManager logManager = new ReceiveLogManager(vouMag.UFDataConnstringForNet);
                    logManager.AddReceiveLog(receive, ref errMsg);
                    LeaveManager leaveMag = new LeaveManager(vouMag.UFDataConnstringForNet);
                    LeaveVoucher leave = (LeaveVoucher)JsonConvert.DeserializeObject(json, typeof(LeaveVoucher));
                    int i = leaveMag.addLeave(leave, ref errMsg);
                    if (i >= 2)
                    {

                        //msg.Success = true;
                        //msg.Code = 200;
                        //dynamic c = new { code = leaveMag.ccode };
                        //msg.Data = JsonConvert.SerializeObject(c);
                        //msg.Msg = "新增成功";
                        int q = leaveMag.auditLeave(leaveMag.ccode, leave.head, ref errMsg);
                        if (q >= 2)
                        {
                            msg.Success = true;
                            msg.Code = 200;
                            dynamic c = new { code = leaveMag.ccode };
                            msg.Data = JsonConvert.SerializeObject(c);
                            msg.Msg = "审核成功";
                        }
                        else
                        {
                            msg.Success = false;
                            msg.Code = 500;
                            msg.Msg = "审核失败:" + errMsg;
                        }
                    }
                    else
                    {
                        msg.Success = false;
                        msg.Code = 500;
                        msg.Msg = "新增失败:" + errMsg;
                    }
                    receive = logManager.getReturnDesc(receive, msg);
                    logManager.UpdateReceiveLog(receive, ref errMsg);
                }
               
                HttpContext.Current.Application.Remove(vouMag.GetGUID);
                string str = msg.ToJson();
                return new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            }
            catch(Exception ex) 
            {
                msg.Success = false;
                msg.Code = 500;
                msg.Msg = ex.Message.ToString();
                string str = msg.ToJson();
                return new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            }
           


        }
        /// <summary>
        /// 审核请假单
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="ccode">请假单号</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AuditLeave")]
        public HttpResponseMessage AuditLeave(string token, string ccode)
        {
            string errMsg = "";
            ReturnMessage msg = new ReturnMessage();
            vouMag = (VoucherManager)HttpContext.Current.Application.Get(token);
            if (vouMag == null)
            {
                msg.Success = false;
                msg.Msg = "参数token无效或已过期";
                msg.Code = 500;
            }
            else
            {
                LeaveManager leaveMag = new LeaveManager(vouMag.UFDataConnstringForNet);
                int i=leaveMag.auditLeave(ccode,vouMag.cUserName, vouMag.cUserID, ref errMsg);
                if(i>=2)
                {
                    msg.Success = true;
                    msg.Code = 200;
                    dynamic c = new { code = ccode };
                    msg.Data = JsonConvert.SerializeObject(c);
                    msg.Msg = "审核成功";
                }
                else
                {
                    msg.Success = false;
                    msg.Code = 500;
                    msg.Msg = "审核失败:" + errMsg;
                }
            }
       
            HttpContext.Current.Application.Remove(vouMag.GetGUID);
            string str = msg.ToJson();
            return new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };


        }
    }
}
