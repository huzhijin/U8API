using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.Common
{
    public  class ReceiveLog
    {
        public Guid uuid { get; set; }
        public string interfaceCode { get; set; }


        public string interfaceDesc { get; set; }


        public string op { get; set; }


        public string receiveData { get; set; }


        public DateTime? receiveTime { get; set; }


        public int? returnFlag { get; set; }


        public string returnDesc { get; set; }


        public string returnData { get; set; }


        public DateTime? returnTime { get; set; }
    }
}
