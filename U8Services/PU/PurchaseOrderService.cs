using Helper.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Services.PU
{
    public class PurchaseOrderService
    {
        private SqlHelper db = null;
        public PurchaseOrderService(string conn)
        {
            db = new SqlHelper(conn);
        }
    }
}
