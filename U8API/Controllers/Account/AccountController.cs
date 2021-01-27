using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using Helper.JWT;
using Newtonsoft.Json;
using U8Manager.Common;
using U8Model.Common;

namespace U8API.Controllers.Account
{
    /// <summary>
    /// 账户信息
    /// </summary>
    public class AccountController : ApiController
    {
        /// <summary>
        /// 获取token
        /// </summary>
        /// <param name="accid">账套号</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>token</returns>
        [HttpPost]
        public HttpResponseMessage GetToken(string accid = "", string username = "", string password = "")
        {
            VoucherManager vouMag = new VoucherManager();
            String sSubId = "AS";
            String sYear = DateTime.Today.Year.ToString();
            String sServer = "localhost";
            String sUserID = username;
            String sPassword = password;
            String sDate = DateTime.Today.ToString("yyyy-MM-dd");
            String sSerial = "";
            string DBSource = "(default)";
            ReturnMessage rtnMessage = vouMag.LoginU8(sSubId, DBSource + "@" + accid, sYear, sUserID, sPassword, sDate, sServer, sSerial);
            if (rtnMessage.Success)
            {
                //string sercert =ConfigurationManager.AppSettings["Secret"].ToString();
                //JWTHelper.secret = sercert;
                // var payload = new Dictionary<string, object>
                //{
                //    {"ufconn",vouMag.UFDataConnstringForNet}
                //};
                // vouMag.GetGUID = JWTHelper.SetJwtEncode(payload);
                vouMag.AccId = accid;
                vouMag.GetGUID = Guid.NewGuid().ToString();
                HttpContext.Current.Application.Add(vouMag.GetGUID, vouMag);
                rtnMessage.Data = vouMag.GetGUID.ToString();
                rtnMessage.Code = 200;
            }
            string msg = rtnMessage.ToJson();
            return new HttpResponseMessage { Content = new StringContent(msg, Encoding.GetEncoding("UTF-8"), "application/json") };
        
        }
    }
}
