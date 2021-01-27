using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using U8Manager.Common;
using U8Manager.TM;
using U8Model.Common;
using U8Model.TM;

namespace U8API.Controllers.TM
{
  
    /// <summary>
    /// 加班单
    /// </summary>
    public class OverTimeController : ApiController
    {
        public VoucherManager vouMag { get; set; }
        /// <summary>
        /// 新增加班单
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="json">加班单json</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddOverTime")]
        public HttpResponseMessage AddOverTime(string token, string json)
        {
            
            string errMsg = "";
            ReturnMessage msg = new ReturnMessage();
            try
            {
                vouMag = (VoucherManager)HttpContext.Current.Application.Get(token);
            if (vouMag == null)
            {
                msg.Success = false;
                msg.Msg = "参数token无效或已过期";
                msg.Code = 500;
            }
            else
            {
                OverTimeManager overTimeMag = new OverTimeManager(vouMag.UFDataConnstringForNet);
                OverTimeVoucher overTime = (OverTimeVoucher)JsonConvert.DeserializeObject(json, typeof(OverTimeVoucher));
                int i = overTimeMag.AddOverTime(overTime,ref errMsg);
                if (i >= 3)
                {
                    //msg.Success = true;
                    //dynamic c = new { code = overTimeMag.ccode };
                    //msg.Data = JsonConvert.SerializeObject(c);
                    //msg.Code = 200;
                    //msg.Msg = "新增成功";
                    int q = overTimeMag.auditOverTime(overTimeMag.ccode, overTime.head, ref errMsg);
                    if (q >= 2)
                    {
                        msg.Success = true;
                        msg.Code = 200;
                        dynamic c = new { code = overTimeMag.ccode };
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
                    msg.Msg = "新增失败"+errMsg;
                }
            }


            HttpContext.Current.Application.Remove(vouMag.GetGUID);
            string str = msg.ToJson();
                return new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };

            }
            catch (Exception ex)
            {

                msg.Success = false;
                msg.Code = 500;
                msg.Msg = ex.Message.ToString();
                string str = msg.ToJson();
                return new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };

            }

        }
        /// <summary>
        /// 审核加班单
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="ccode">加班单号</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AuditOverTime")]
        public HttpResponseMessage AuditOverTime(string token, string ccode)
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
                OverTimeManager  overTimeMag = new OverTimeManager(vouMag.UFDataConnstringForNet);
                int i = overTimeMag.auditOverTime(ccode, vouMag.cUserName, vouMag.cUserID, ref errMsg);
                if (i >= 2)
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
