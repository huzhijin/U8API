using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using U8Login;
using U8Model.Common;

namespace U8Manager.Common
{
    public class VoucherManager
    {

        /// <summary>
        /// 账套号
        /// </summary>
        public string AccId { get; set; }
        public string GetGUID { get; set; }
        public string userToken { get; set; }
        public string UFDataConnstringForNet { get; set; }

        public string cUserID { get; set; }
        public string cUserName { get; set; }
        public U8Login.clsLogin u8Login { get; set; }

        public ReturnMessage rtnMsg { get; set; }
       
        public VoucherManager()
        {

            rtnMsg = new ReturnMessage();
        }
        public ReturnMessage LoginU8(string sSubId, string sAccID, string sYear, string sUserID, string sPassword, string sDate, string sServer, string sSerial)
        {
            ReturnMessage msg = new ReturnMessage();
            u8Login = new U8Login.clsLogin();
            try
            {
                if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
                {
                    string error = u8Login.ShareString;
                    Marshal.FinalReleaseComObject(u8Login);
                    msg.Success = false;
                    msg.Msg = error;
                    msg.Code = 500;
                }
                else
                {
                    userToken = u8Login.userToken;
                    UFDataConnstringForNet = u8Login.UFDataConnstringForNet;
                    cUserID = u8Login.cUserId;
                    cUserName = u8Login.cUserName;                  
                    msg.Success = true;
                    msg.Msg = "";
                }


            }
            catch (Exception ex)
            {
                msg.Success = false;
                msg.Msg = ex.Message.ToString();
                msg.Code = 500;
            }
            return msg;
        }

        public string getEAIPercess(string DataXML)
        {
            try
            {

                //引用U8SOFT\EAI\U8Distribute.dll

                U8Distribute.iDistributeClass eaiBroker = new U8Distribute.iDistributeClass(); //创建EAI服务代理接口对象


                String responseXml = eaiBroker.Process(DataXML); //调用EAI服务代理的数据交换方法Process，传入Request交换消息， 并获取EAI返回的Response消息。


                //处理返回结果
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(eaiBroker); //释放EAI服务代理接口对象

                return responseXml;
            }
            catch (Exception e)
            {

                return e.Message.ToString();
            }

        }
    }
}
