﻿using System;
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
    /// 出差单
    /// </summary>
    public class ErrandController : ApiController
    {
        public VoucherManager vouMag { get; set; }
        /// <summary>
        /// 新增出差单
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="json">出差单json</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddErrand")]        
        public HttpResponseMessage AddErrand(string token,string json)
        {
            string errMsg = "";
            ReturnMessage msg= new ReturnMessage();
            try
            {
            ReceiveLog receive = new ReceiveLog();
            receive.uuid = Guid.NewGuid();
            receive.receiveData = json;
            receive.interfaceCode = "Errand";
            receive.interfaceDesc = "出差单新增";
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
                    ErrandManager errandMag = new ErrandManager(vouMag.UFDataConnstringForNet);
                ErrandVoucher errand = (ErrandVoucher)JsonConvert.DeserializeObject(json, typeof(ErrandVoucher));
                int i = errandMag.AddErrand(errand,ref errMsg);
                if (i >= 2)
                {
                    //msg.Success = true;
                    //dynamic c = new { code = errandMag.ccode };
                    //msg.Data = JsonConvert.SerializeObject(c);
                    //msg.Code = 200;
                    //msg.Msg = "新增成功";
                    int q = errandMag.auditErrand(errandMag.ccode, errand.head, ref errMsg);
                    if (q >= 2)
                    {
                        msg.Success = true;
                        msg.Code = 200;
                        dynamic c = new { code = errandMag.ccode };
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
                    receive = logManager.getReturnDesc(receive, msg);
                    logManager.UpdateReceiveLog(receive, ref errMsg);
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
        /// 审核出差单
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="ccode">出差单号</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AuditErrand")]
        public HttpResponseMessage AuditErrand(string token, string ccode)
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
                ErrandManager errandMag = new ErrandManager(vouMag.UFDataConnstringForNet);
                int i = errandMag.auditErrand(ccode, vouMag.cUserName, vouMag.cUserID, ref errMsg);
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
