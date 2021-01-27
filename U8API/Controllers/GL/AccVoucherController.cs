using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using U8Manager.Common;
using U8Manager.GL;
using U8Model.Common;
using U8Model.GL;

namespace U8API.Controllers.GL
{

    /// <summary>
    /// 凭证
    /// </summary>
    public class AccVoucherController : ApiController
    {
        public VoucherManager vouMag { get; set; }
        /// <summary>
        /// xml格式新增凭证
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="xmlDoc">凭证XML</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddPZForXML")]
        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(LeaveVoucher))]
        public HttpResponseMessage AddPZForXML(string token, string xmlDoc)
        {
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
                GLAccVouchManager glMag = new GLAccVouchManager(vouMag.UFDataConnstringForNet);
                msg = glMag.AddForGL(vouMag,xmlDoc);              
                
            }

            HttpContext.Current.Application.Remove(vouMag.GetGUID);
            string str = msg.ToJson();
            return new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };

        }
        /// <summary>
        /// json格式新增凭证
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="jsonStr">凭证json</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddPZForJson")]
        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(LeaveVoucher))]
        public HttpResponseMessage AddPZForJson(string token, string jsonStr)
        {
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
                GLAccVouchManager glMag = new GLAccVouchManager(vouMag.UFDataConnstringForNet);
                GL_accvouch glAcc= (GL_accvouch)JsonConvert.DeserializeObject(jsonStr, typeof(GL_accvouch));
                string xml = glMag.getVoucherXml(vouMag.AccId, glAcc);
                msg = glMag.AddForGL(vouMag, xml);

            }

            HttpContext.Current.Application.Remove(vouMag.GetGUID);
            string str = msg.ToJson();
            return new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };

        }
    }
}
