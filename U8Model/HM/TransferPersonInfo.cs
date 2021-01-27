using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.HM
{
    public class TransferPersonInfo
    {
        public string cDepName{set;get;}
        public string synGLDept{set;get;}
        public bool IsChange{set;get;}
        public bool IsReadOnly{set;get;}
        public string PK_HR_HI_Transfer_PSN{set;get;}
        public string cPsn_Num{set;get;}
        public string cDepCode{set;get;}
        public DateTime? dPValidDate{set;get;}
        public DateTime? dPInValidDate{set;get;}
        public int iCreDate{set;get;}
        public Decimal fCreditQuantity{set;get;}
        public string cCreGrade{set;get;}
        public int CheckFlag{set;get;}
        public string VoucherID{set;get;}
    }
}
