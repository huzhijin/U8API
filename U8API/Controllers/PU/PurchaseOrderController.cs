using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using U8Manager.Common;
using U8Manager.PU;
using U8Model.Common;
using U8Model.PU;

namespace U8API.Controllers.PU
{
    
    public class PurchaseOrderController : ApiController
    {
        public VoucherManager vouMag { get; set; }
        /// <summary>
        /// 新增采购订单
        /// </summary>
        /// <param name="token">token</param>
        /// <param name="jsonStr">采购订单json</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddPO")]
        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(LeaveVoucher))]
        public HttpResponseMessage AddPO(string token, string jsonStr)
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
                PurchaseOrderManager poMag = new PurchaseOrderManager(vouMag);
                PurchaseOrder po = new PurchaseOrder();
                string mes = "";
                bool reult = poMag.AddPO(po, ref mes);
                if (reult)
                {
                    msg.Success = true;
                    msg.Msg = "成功";
                    msg.Code = 200;
                }
                else 
                {
                    msg.Success = false;
                    msg.Msg = mes;
                    msg.Code = 500;
                }

            }

            HttpContext.Current.Application.Remove(vouMag.GetGUID);
            string str = msg.ToJson();
            return new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };

        }
    }
}
