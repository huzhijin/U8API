using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.GL
{
    /// <summary>
    /// 凭证对象
    /// </summary>
    public class GL_accvouch
    {
        public GL_accvouchHead head { get; set; }
        public List<GL_accvouchBody> body { get; set; }
    }

    public class GL_accvouchHead
    {
        public string company { get; set; }
        public string voucher_type { get; set; }
        public string fiscal_year { get; set; }
        public string accounting_period { get; set; }
        public string voucher_id { get; set; }
        public string attachment_number { get; set; }
        public string date { get; set; }
        public string enter { get; set; }
        public string cashier { get; set; }
        public string signature { get; set; }
        public string checker { get; set; }
        public string posting_date { get; set; }
        public string posting_person { get; set; }
        public string voucher_making_system { get; set; }
        public string memo1 { get; set; }
        public string memo2 { get; set; }
        public string reserve1 { get; set; }
        public string reserve2 { get; set; }
        public string revokeflag { get; set; }
    }

    public class GL_accvouchBody
    {
        public string entry_id { get; set; }
        public string account_code { get; set; }
        public string Abstract { get; set; }
        public string settlement { get; set; }
        public string document_id { get; set; }
        public string document_date { get; set; }
        public string currency { get; set; }
        public string unit_price { get; set; }
        public string exchange_rate1 { get; set; }
        public string exchange_rate2 { get; set; }
        public string debit_quantity { get; set; }
        public string primary_debit_amount { get; set; }
        public string secondary_debit_amount { get; set; }
        public string natural_debit_currency { get; set; }
        public string credit_quantity { get; set; }
        public string primary_credit_amount { get; set; }
        public string secondary_credit_amount { get; set; }
        public string natural_credit_currency { get; set; }
        public string bill_type { get; set; }
        public string bill_id { get; set; }
        public string bill_date { get; set; }

        public GL_accvouchting accounting { get; set; }

        public List<GL_accvouchDetail> detail { get; set; }

    }
    public class GL_accvouchting
    {
        public string dept_id { get; set; }
        public string personnel_id { get; set; }
        public string cust_id { get; set; }
        public string supplier_id { get; set; }
        public string item_id { get; set; }
        public string item_class { get; set; }
        public string Operator { get; set; }
        public string self_define1 { get; set; }
        public string self_define2 { get; set; }
        public string self_define3 { get; set; }
        public string self_define4 { get; set; }
        public string self_define5 { get; set; }
        public string self_define6 { get; set; }
        public string self_define7 { get; set; }
        public string self_define8 { get; set; }
        public string self_define9 { get; set; }
        public string self_define10 { get; set; }
        public string self_define11 { get; set; }
        public string self_define12 { get; set; }
        public string self_define13 { get; set; }
        public string self_define14 { get; set; }
        public string self_define15 { get; set; }
        public string self_define16 { get; set; }

    }

    public class GL_accvouchDetail
    {
        public string cash_item { get; set; }
        public string dbill_date { get; set; }

        public string natural_debit_currency { get; set; }

        public string natural_credit_currency { get; set; }
    }


}
