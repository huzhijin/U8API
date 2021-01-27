using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.Common
{
    [Serializable]
    public class ReturnMessage
    {
        /// <summary>
        ///是否调用成功
        /// </summary>
        public bool Success { set; get; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Msg { set; get; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public  object Data { set; get; }
        /// <summary>
        /// 操作码
        /// </summary>
        public int Code { set; get; }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
