using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using U8Manager.Common;
using U8Model.Common;
using U8Model.GL;
using U8Services.GL;

namespace U8Manager.GL
{
    public class GLAccVouchManager
    {
        AccVouchService vouServer = null;
        public GLAccVouchManager(string _conn)
        {
            vouServer = new AccVouchService(_conn);
        }
        private string setNull(string value)
        {
            if (value == null) return "";
            else return value;
        }
        public string PZDate { set; get; }
        public string getVoucherXml(string sender, GL_accvouch voucher)
        {
            StringBuilder xml = new StringBuilder();
            xml.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            xml.Append("<ufinterface roottag=\"voucher\" receiver=\"u8\" sender=\"" + sender + "\" proc=\"add\" renewproofno=\"y\" codeexchanged=\"y\" exportneedexch=\"N\" >");
            xml.Append("<voucher id=\"" + setNull(voucher.head.voucher_id) + "\">");
            xml.Append("<voucher_head>");
            xml.Append("<company>" + setNull(voucher.head.company) + "</company>");
            xml.Append("<voucher_type>" + setNull(voucher.head.voucher_type) + "</voucher_type>");
            xml.Append("<fiscal_year>" + setNull(voucher.head.fiscal_year) + "</fiscal_year>");
            xml.Append("<accounting_period>" + setNull(voucher.head.accounting_period) + "</accounting_period>");
            xml.Append("<voucher_id>" + setNull(voucher.head.voucher_id) + "</voucher_id>");
            xml.Append("<attachment_number>" + setNull(voucher.head.attachment_number) + "</attachment_number>");
            xml.Append("<date>" + setNull(voucher.head.date) + "</date>");
            xml.Append("<enter>" + setNull(voucher.head.enter) + "</enter>");
            xml.Append("<cashier>" + setNull(voucher.head.cashier) + "</cashier>");
            xml.Append("<signature>" + setNull(voucher.head.signature) + "</signature>");
            xml.Append("<checker>" + setNull(voucher.head.checker) + "</checker>");
            xml.Append("<posting_date>" + setNull(voucher.head.posting_date) + "</posting_date>");
            xml.Append("<posting_person>" + setNull(voucher.head.posting_person) + "</posting_person>");
            xml.Append("<voucher_making_system>" + setNull(voucher.head.voucher_making_system) + "</voucher_making_system>");
            xml.Append("<memo1>" + setNull(voucher.head.memo1) + "</memo1>");
            xml.Append("<memo2>" + setNull(voucher.head.memo2) + "</memo2>");
            xml.Append("<reserve1>" + setNull(voucher.head.reserve1) + "</reserve1>");
            xml.Append("<reserve2>" + setNull(voucher.head.reserve2) + "</reserve2>");
            xml.Append("<revokeflag>" + setNull(voucher.head.revokeflag) + "</revokeflag>");
            xml.Append("</voucher_head>");
            xml.Append("<voucher_body>");
            for (int i = 0; i < voucher.body.Count; i++)
            {
                xml.Append("<entry>");
                xml.Append("<entry_id>" + setNull(voucher.body[i].entry_id) + "</entry_id>");
                xml.Append("<account_code>" + setNull(voucher.body[i].account_code) + "</account_code>");
                xml.Append("<abstract>" + setNull(voucher.body[i].Abstract) + "</abstract>");
                xml.Append("<settlement>" + setNull(voucher.body[i].settlement) + "</settlement>");
                xml.Append("<document_id>" + setNull(voucher.body[i].document_id) + "</document_id>");
                xml.Append("<document_date>" + setNull(voucher.body[i].document_date) + "</document_date>");
                xml.Append("<currency>" + setNull(voucher.body[i].currency) + "</currency>");
                xml.Append("<unit_price>" + setNull(voucher.body[i].unit_price) + "</unit_price>");
                xml.Append("<exchange_rate1>" + setNull(voucher.body[i].exchange_rate1) + "</exchange_rate1>");
                xml.Append("<exchange_rate2>" + setNull(voucher.body[i].exchange_rate2) + "</exchange_rate2>");
                xml.Append("<debit_quantity>" + setNull(voucher.body[i].debit_quantity) + "</debit_quantity>");
                xml.Append("<primary_debit_amount>" + setNull(voucher.body[i].primary_debit_amount) + "</primary_debit_amount>");
                xml.Append("<secondary_debit_amount>" + setNull(voucher.body[i].secondary_debit_amount) + "</secondary_debit_amount>");
                xml.Append("<natural_debit_currency>" + setNull(voucher.body[i].natural_debit_currency) + "</natural_debit_currency>");
                xml.Append("<credit_quantity>" + setNull(voucher.body[i].credit_quantity) + "</credit_quantity>");
                xml.Append("<primary_credit_amount>" + setNull(voucher.body[i].primary_credit_amount) + "</primary_credit_amount>");
                xml.Append("<secondary_credit_amount>" + setNull(voucher.body[i].secondary_credit_amount) + "</secondary_credit_amount>");
                xml.Append("<natural_credit_currency>" + setNull(voucher.body[i].natural_credit_currency) + "</natural_credit_currency>");
                xml.Append("<bill_type>" + setNull(voucher.body[i].bill_type) + "</bill_type>");
                xml.Append("<bill_id>" + setNull(voucher.body[i].bill_id) + "</bill_id>");
                xml.Append("<bill_date>" + setNull(voucher.body[i].bill_date) + "</bill_date>");
                xml.Append("<auxiliary_accounting>");
                xml.Append("<item name=\"dept_id\">" + setNull(voucher.body[i].accounting.dept_id) + "</item>");
                xml.Append("<item name=\"personnel_id\">" + setNull(voucher.body[i].accounting.personnel_id) + "</item>");
                xml.Append("<item name=\"cust_id\">" + setNull(voucher.body[i].accounting.cust_id) + "</item>");
                xml.Append("<item name=\"supplier_id\">" + setNull(voucher.body[i].accounting.supplier_id) + "</item>");
                xml.Append("<item name=\"item_id\">" + setNull(voucher.body[i].accounting.item_id) + "</item>");
                xml.Append("<item name=\"item_class\">" + setNull(voucher.body[i].accounting.item_class) + "</item>");
                xml.Append("<item name=\"operator\">" + setNull(voucher.body[i].accounting.Operator) + "</item>");
                xml.Append("<item name=\"self_define1\">" + setNull(voucher.body[i].accounting.self_define1) + "</item>");
                xml.Append("<item name=\"self_define2\">" + setNull(voucher.body[i].accounting.self_define2) + "</item>");
                xml.Append("<item name=\"self_define3\">" + setNull(voucher.body[i].accounting.self_define3) + "</item>");
                xml.Append("<item name=\"self_define4\">" + setNull(voucher.body[i].accounting.self_define4) + "</item>");
                xml.Append("<item name=\"self_define5\">" + setNull(voucher.body[i].accounting.self_define5) + "</item>");
                xml.Append("<item name=\"self_define6\">" + setNull(voucher.body[i].accounting.self_define6) + "</item>");
                xml.Append("<item name=\"self_define7\">" + setNull(voucher.body[i].accounting.self_define7) + "</item>");
                xml.Append("<item name=\"self_define8\">" + setNull(voucher.body[i].accounting.self_define8) + "</item>");
                xml.Append("<item name=\"self_define9\">" + setNull(voucher.body[i].accounting.self_define9) + "</item>");
                xml.Append("<item name=\"self_define10\">" + setNull(voucher.body[i].accounting.self_define10) + "</item>");
                xml.Append("<item name=\"self_define11\">" + setNull(voucher.body[i].accounting.self_define11) + "</item>");
                xml.Append("<item name=\"self_define12\">" + setNull(voucher.body[i].accounting.self_define12) + "</item>");
                xml.Append("<item name=\"self_define13\">" + setNull(voucher.body[i].accounting.self_define13) + "</item>");
                xml.Append("<item name=\"self_define14\">" + setNull(voucher.body[i].accounting.self_define14) + "</item>");
                xml.Append("<item name=\"self_define15\">" + setNull(voucher.body[i].accounting.self_define15) + "</item>");
                xml.Append("<item name=\"self_define16\">" + setNull(voucher.body[i].accounting.self_define16) + "</item>");
                xml.Append("</auxiliary_accounting>");
                xml.Append("<detail>");
                xml.Append("<cash_flow_statement>");
                if (voucher.body[i].detail != null)
                {
                    for (int q = 0; q < voucher.body[i].detail.Count; q++)
                    {
                        if (!string.IsNullOrEmpty(voucher.body[i].detail[q].cash_item))
                        {
                            try
                            {
                                //xml.Append("<cash_flow cash_item=\"" + setNull(voucher.body[i].detail[q].cash_item) + "\" natural_debit_currency=\"" + setNull(voucher.body[i].detail[q].natural_debit_currency) + "\" natural_credit_currency=\"" + setNull(voucher.body[i].detail[q].natural_credit_currency) + "\" />");
                                xml.Append("<cash_flow cash_item=\"" + setNull(voucher.body[i].detail[q].cash_item) +
                               "\" natural_debit_currency=\"" + setNull(voucher.body[i].detail[q].natural_debit_currency) +
                               "\" natural_credit_currency=\"" + setNull(voucher.body[i].detail[q].natural_credit_currency) +
                               "\" dbill_date=\"" + setNull(voucher.body[i].detail[q].dbill_date) +
                               "\" cCashItem=\"" + setNull(voucher.body[i].detail[q].cash_item) +
                               "\" md=\"" + setNull(voucher.body[i].detail[q].natural_debit_currency) +
                               "\" mc=\"" + setNull(voucher.body[i].detail[q].natural_credit_currency) +
                               "\" ccode=\"" + setNull(voucher.body[i].account_code) +
                               "\" md_f=\"" + setNull(voucher.body[i].secondary_debit_amount) +
                               "\" mc_f=\"" + setNull(voucher.body[i].secondary_credit_amount) +
                               "\" nd_s=\"" + setNull(voucher.body[i].debit_quantity) +
                               "\" nc_s=\"" + setNull(voucher.body[i].credit_quantity) +
                               "\" cdept_id=\"" + setNull(voucher.body[i].accounting.dept_id) +
                               "\" cperson_id=\"" + setNull(voucher.body[i].accounting.personnel_id) +
                               "\" ccus_id=\"" + setNull(voucher.body[i].accounting.cust_id) +
                               "\" csup_id=\"" + setNull(voucher.body[i].accounting.supplier_id) +
                               "\" citem_class=\"" + setNull(voucher.body[i].accounting.item_class) +
                               "\" citem_id=\"" + setNull(voucher.body[i].accounting.item_id) +
                               "\" cDefine1=\"" + setNull(voucher.body[i].accounting.self_define1) +
                               "\" cDefine2=\"" + setNull(voucher.body[i].accounting.self_define2) +
                               "\" cDefine3=\"" + setNull(voucher.body[i].accounting.self_define3) +
                               "\" cDefine4=\"" + setNull(voucher.body[i].accounting.self_define4) +
                               "\" cDefine5=\"" + setNull(voucher.body[i].accounting.self_define5) +
                               "\" cDefine6=\"" + setNull(voucher.body[i].accounting.self_define6) +
                               "\" cDefine7=\"" + setNull(voucher.body[i].accounting.self_define7) +
                               "\" cDefine8=\"" + setNull(voucher.body[i].accounting.self_define8) +
                               "\" cDefine9=\"" + setNull(voucher.body[i].accounting.self_define9) +
                               "\" cDefine10=\"" + setNull(voucher.body[i].accounting.self_define10) +
                               "\" cDefine11=\"" + setNull(voucher.body[i].accounting.self_define11) +
                               "\" cDefine12=\"" + setNull(voucher.body[i].accounting.self_define12) +
                               "\" cDefine13=\"" + setNull(voucher.body[i].accounting.self_define13) +
                               "\" cDefine14=\"" + setNull(voucher.body[i].accounting.self_define14) +
                               "\" cDefine15=\"" + setNull(voucher.body[i].accounting.self_define15) +
                               "\" cDefine16=\"" + setNull(voucher.body[i].accounting.self_define16) +
                               "\" csign=\"" + setNull(voucher.head.voucher_type) +
                               "\" iyear=\"" + setNull(voucher.head.fiscal_year) +
                               "\" iYPeriod=\"" + setNull(voucher.head.fiscal_year + voucher.head.accounting_period.ToString().PadLeft(2, '0')) +
                               "\" cexch_name=\"" + setNull(voucher.body[i].currency) +
                               "\" />");
                            }
                            catch (Exception e)
                            {
                                string msg = e.Message.ToString();
                                throw;
                            }


                        }
                        else
                        {
                            xml.Append("<cash_flow cash_item=\"" +
                                "\" natural_debit_currency=\"" +
                                "\" natural_credit_currency=\"" +
                                "\" dbill_date=\"" +
                                "\" />");
                        }

                    }

                }
                xml.Append("</cash_flow_statement>");
                xml.Append("<code_remark_statement></code_remark_statement>");
                xml.Append("</detail>");
                xml.Append("</entry>");
            }
            xml.Append("</voucher_body>");
            xml.Append("</voucher>");
            xml.Append("</ufinterface>");
            return xml.ToString();
        }

        public bool bPerson(string ccode, string year)
        {
            return vouServer.bPerson(ccode, year);
        }
        public bool bCus(string ccode, string year)
        {
            return vouServer.bCus(ccode, year);
        }
        public bool bBank(string ccode, string year)
        {
            return vouServer.bBank(ccode, year);
        }
        public bool bCash(string ccode, string year)
        {
            return vouServer.bCash(ccode, year);
        }
        public bool bCashItem(string ccode, string year)
        {
            return vouServer.bCashItem(ccode, year);
        }
        public ReturnMessage Add(VoucherManager voucher, string DataStr)
        {
            XmlDocument dataDoc = new XmlDocument();
            ReturnMessage msg = new ReturnMessage();
            try
            {
                dataDoc.LoadXml(DataStr);
                XmlElement dataXml = dataDoc.DocumentElement;
                string year = dataXml.SelectSingleNode("voucher/voucher_head/fiscal_year").InnerXml;
                string csign = dataXml.SelectSingleNode("voucher/voucher_head/voucher_type").InnerXml;
                string peroid = dataXml.SelectSingleNode("voucher/voucher_head/accounting_period").InnerXml;
                PZDate = dataXml.SelectSingleNode("voucher/voucher_head/date").InnerXml;
                //int q = dataXml.SelectSingleNode("voucher/voucher_body").ChildNodes.Count;
                //for (int i = 0; i < q; i++) 
                //{
                //    XmlNode bodyXml = dataXml.SelectSingleNode("voucher/voucher_body").ChildNodes.Item(i);
                //    string ccode = bodyXml.SelectSingleNode("account_code").Value;
                //    string md_f=bodyXml.SelectSingleNode("secondary_debit_amount").Value;
                //    string mc_f=bodyXml.SelectSingleNode("secondary_credit_amount").Value;
                //    string nd_s=bodyXml.SelectSingleNode("debit_quantity").Value;
                //    string nc_s=bodyXml.SelectSingleNode("credit_quantity").Value;
                //    string exchName=bodyXml.SelectSingleNode("currency").Value;
                //    //辅助项信息
                //    XmlNode accountingXml = bodyXml.SelectSingleNode("auxiliary_accounting");
                //    string dept_id = accountingXml.Attributes["dept_id"].Value;
                //    string personnel_id = accountingXml.Attributes["personnel_id"].Value;
                //    string cust_id = accountingXml.Attributes["cust_id"].Value;
                //    string supplier_id = accountingXml.Attributes["supplier_id"].Value;
                //    string item_id = accountingXml.Attributes["item_id"].Value;
                //    string item_class = accountingXml.Attributes["item_class"].Value;
                //    //string _operator = accountingXml.Attributes["operator"].Value;
                //    string self_define1 = accountingXml.Attributes["self_define1"].Value;
                //    string self_define2 = accountingXml.Attributes["self_define2"].Value;
                //    string self_define3 = accountingXml.Attributes["self_define3"].Value;
                //    string self_define4 = accountingXml.Attributes["self_define4"].Value;
                //    string self_define5 = accountingXml.Attributes["self_define5"].Value;
                //    string self_define6 = accountingXml.Attributes["self_define6"].Value;
                //    string self_define7 = accountingXml.Attributes["self_define7"].Value;
                //    string self_define8 = accountingXml.Attributes["self_define8"].Value;
                //    string self_define9 = accountingXml.Attributes["self_define9"].Value;
                //    string self_define10 = accountingXml.Attributes["self_define10"].Value;
                //    string self_define11 = accountingXml.Attributes["self_define11"].Value;
                //    string self_define12 = accountingXml.Attributes["self_define12"].Value;
                //    string self_define13 = accountingXml.Attributes["self_define13"].Value;
                //    string self_define14 = accountingXml.Attributes["self_define14"].Value;
                //    string self_define15 = accountingXml.Attributes["self_define15"].Value;
                //    string self_define16 = accountingXml.Attributes["self_define16"].Value;
                //    //现金流信息
                //    int k = bodyXml.SelectSingleNode("detail/cash_flow_statement").ChildNodes.Count;
                //    for (int j = 0; j < k; j++)
                //    {
                //        XmlNode cashXml = bodyXml.SelectSingleNode("detail/cash_flow_statement").ChildNodes.Item(j);
                //       string cashItem= cashXml.Attributes["cash_item"].Value;
                //       if (!String.IsNullOrEmpty(cashItem)) 
                //       {
                //           string md = cashXml.Attributes["natural_debit_currency"].Value;
                //           string mc = cashXml.Attributes["natural_credit_currency"].Value;
                //           CreateAttribute(cashXml, "cCashItem", cashItem);
                //           CreateAttribute(cashXml, "ccode", ccode);
                //           CreateAttribute(cashXml, "md", md);
                //           CreateAttribute(cashXml, "mc", mc);
                //           CreateAttribute(cashXml, "md_f",md_f );
                //           CreateAttribute(cashXml, "mc_f", mc_f);
                //           CreateAttribute(cashXml, "nd_s", nd_s);
                //           CreateAttribute(cashXml, "nc_s", nc_s);
                //           CreateAttribute(cashXml, "cdept_id", dept_id);
                //           CreateAttribute(cashXml, "cperson_id", personnel_id);
                //           CreateAttribute(cashXml, "ccus_id", cust_id);
                //           CreateAttribute(cashXml, "csup_id", supplier_id);
                //           CreateAttribute(cashXml, "citem_class", item_class);
                //           CreateAttribute(cashXml, "citem_id", item_id);
                //           CreateAttribute(cashXml, "cDefine1", self_define1);
                //           CreateAttribute(cashXml, "cDefine2", self_define2);
                //           CreateAttribute(cashXml, "cDefine3", self_define3);
                //           CreateAttribute(cashXml, "cDefine4", self_define4);
                //           CreateAttribute(cashXml, "cDefine5", self_define5);
                //           CreateAttribute(cashXml, "cDefine6", self_define6);
                //           CreateAttribute(cashXml, "cDefine7", self_define7);
                //           CreateAttribute(cashXml, "cDefine8", self_define8);
                //           CreateAttribute(cashXml, "cDefine9", self_define9);
                //           CreateAttribute(cashXml, "cDefine10", self_define10);
                //           CreateAttribute(cashXml, "cDefine11", self_define11);
                //           CreateAttribute(cashXml, "cDefine12", self_define12);
                //           CreateAttribute(cashXml, "cDefine13", self_define13);
                //           CreateAttribute(cashXml, "cDefine14", self_define14);
                //           CreateAttribute(cashXml, "cDefine15", self_define15);
                //           CreateAttribute(cashXml, "cDefine16", self_define16);
                //           CreateAttribute(cashXml, "csign", csign);
                //           CreateAttribute(cashXml, "iyear", year);
                //           CreateAttribute(cashXml, "iYPeriod", year+peroid.ToString().PadLeft(2, '0'));
                //           CreateAttribute(cashXml, "cexch_name", exchName);
                //       }

                //    }

                //}

                string result = voucher.getEAIPercess(DataStr);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(result);
                XmlElement xml = doc.DocumentElement;
                string succeed = xml.FirstChild.Attributes["succeed"].InnerText;
                string dsc = xml.FirstChild.Attributes["dsc"].InnerText;



                if (succeed == "0" && !dsc.Equals("数据重复上传"))
                {

                    string period = xml.FirstChild.Attributes["u8accounting_period"].InnerText;
                    string id = xml.FirstChild.Attributes["u8voucher_id"].InnerText;
                    int iperiod = Convert.ToInt32(period);
                    int _id = Convert.ToInt32(id);
                    string vouid = year + iperiod.ToString("00") + _id.ToString("0000");

                    msg.Success = true;
                    msg.Msg = dsc;
                    msg.Code = 200;
                   
                }
                else
                {
                    msg.Success = false;
                    msg.Msg = dsc;
                    msg.Code = 500;

                }
            }
            catch (Exception e)
            {
                msg.Success = false;
                msg.Msg = e.Message;
                msg.Code = 500;
            }
            return msg;
        }

        public ReturnMessage AddForGL(VoucherManager voucher,string DataStr)
        {
            XmlDocument dataDoc = new XmlDocument();
            ReturnMessage msg = new ReturnMessage();
            try
            {
                dataDoc.LoadXml(DataStr);
                XmlElement dataXml = dataDoc.DocumentElement;
                string year = dataXml.SelectSingleNode("voucher/voucher_head/fiscal_year").InnerXml;
                string csign = dataXml.SelectSingleNode("voucher/voucher_head/voucher_type").InnerXml;
                string peroid = dataXml.SelectSingleNode("voucher/voucher_head/accounting_period").InnerXml;
                PZDate = dataXml.SelectSingleNode("voucher/voucher_head/date").InnerXml;
                int q = dataXml.SelectSingleNode("voucher/voucher_body").ChildNodes.Count;
                for (int i = 0; i < q; i++)
                {
                    XmlNode bodyXml = dataXml.SelectSingleNode("voucher/voucher_body").ChildNodes.Item(i);
                    string ccode = bodyXml.SelectSingleNode("account_code").Value;
                    string md_f = bodyXml.SelectSingleNode("secondary_debit_amount").Value;
                    string mc_f = bodyXml.SelectSingleNode("secondary_credit_amount").Value;
                    string nd_s = bodyXml.SelectSingleNode("debit_quantity").Value;
                    string nc_s = bodyXml.SelectSingleNode("credit_quantity").Value;
                    string exchName = bodyXml.SelectSingleNode("currency").Value;
                    //辅助项信息
                    XmlNode accountingXml = bodyXml.SelectSingleNode("auxiliary_accounting");
                    GL_accvouchting body = new GL_accvouchting();
                    PropertyInfo[] propertys = body.GetType().GetProperties();


                    foreach (XmlNode item in accountingXml.ChildNodes)
                    {

                        string filename = item.Attributes["name"].Value;
                        foreach (PropertyInfo prop in propertys)
                        {
                            if (prop.Name.ToLower().Equals(filename.ToLower()))
                            {
                                prop.SetValue(body, item.InnerText, null);
                            }
                        }



                    }

                    //现金流信息
                    int k = bodyXml.SelectSingleNode("detail/cash_flow_statement").ChildNodes.Count;
                    for (int j = 0; j < k; j++)
                    {
                        XmlNode cashXml = bodyXml.SelectSingleNode("detail/cash_flow_statement").ChildNodes.Item(j);
                        string cashItem = cashXml.Attributes["cash_item"].Value;
                        if (!String.IsNullOrEmpty(cashItem))
                        {
                            string md = cashXml.Attributes["natural_debit_currency"].Value;
                            string mc = cashXml.Attributes["natural_credit_currency"].Value;

                            CreateAttribute(cashXml, "cCashItem", cashItem);
                            CreateAttribute(cashXml, "ccode", ccode);
                            CreateAttribute(cashXml, "md", md);
                            CreateAttribute(cashXml, "mc", mc);
                            CreateAttribute(cashXml, "md_f", md_f);
                            CreateAttribute(cashXml, "mc_f", mc_f);
                            CreateAttribute(cashXml, "nd_s", nd_s);
                            CreateAttribute(cashXml, "nc_s", nc_s);
                            CreateAttribute(cashXml, "cdept_id", body.dept_id);
                            CreateAttribute(cashXml, "cperson_id", body.personnel_id);
                            CreateAttribute(cashXml, "ccus_id", body.cust_id);
                            CreateAttribute(cashXml, "csup_id", body.supplier_id);
                            CreateAttribute(cashXml, "citem_class", body.item_class);
                            CreateAttribute(cashXml, "citem_id", body.item_id);
                            CreateAttribute(cashXml, "cDefine1", body.self_define1);
                            CreateAttribute(cashXml, "cDefine2", body.self_define2);
                            CreateAttribute(cashXml, "cDefine3", body.self_define3);
                            CreateAttribute(cashXml, "cDefine4", body.self_define4);
                            CreateAttribute(cashXml, "cDefine5", body.self_define5);
                            CreateAttribute(cashXml, "cDefine6", body.self_define6);
                            CreateAttribute(cashXml, "cDefine7", body.self_define7);
                            CreateAttribute(cashXml, "cDefine8", body.self_define8);
                            CreateAttribute(cashXml, "cDefine9", body.self_define9);
                            CreateAttribute(cashXml, "cDefine10", body.self_define10);
                            CreateAttribute(cashXml, "cDefine11", body.self_define11);
                            CreateAttribute(cashXml, "cDefine12", body.self_define12);
                            CreateAttribute(cashXml, "cDefine13", body.self_define13);
                            CreateAttribute(cashXml, "cDefine14", body.self_define14);
                            CreateAttribute(cashXml, "cDefine15", body.self_define15);
                            CreateAttribute(cashXml, "cDefine16", body.self_define16);
                            CreateAttribute(cashXml, "csign", csign);
                            CreateAttribute(cashXml, "iyear", year);
                            CreateAttribute(cashXml, "iYPeriod", year + peroid.ToString().PadLeft(2, '0'));
                            CreateAttribute(cashXml, "cexch_name", exchName);
                        }

                    }

                }
                string result = voucher.getEAIPercess(dataXml.ParentNode.OuterXml);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(result);
                XmlElement xml = doc.DocumentElement;
                string succeed = xml.FirstChild.Attributes["succeed"].InnerText;
                string dsc = xml.FirstChild.Attributes["dsc"].InnerText;



                if (succeed == "0" && !dsc.Equals("数据重复上传"))
                {

                    string period = xml.FirstChild.Attributes["u8accounting_period"].InnerText;
                    string id = xml.FirstChild.Attributes["u8voucher_id"].InnerText;
                    int iperiod = Convert.ToInt32(period);
                    int _id = Convert.ToInt32(id);
                    string vouid = year + iperiod.ToString("00") + _id.ToString("0000");

                    msg.Success = true;
                    msg.Msg = dsc;
                    msg.Code = 200;
                    dynamic c = new { pzCode =vouid};
                    msg.Data = JsonConvert.SerializeObject(c);

                }
                else
                {
                    msg.Success = false;
                    msg.Msg = dsc;
                    msg.Code = 500;

                }
            }
            catch (Exception e)
            {
                msg.Success = false;
                msg.Msg = e.Message;
                msg.Code = 500;
            }
            return msg;
        }
        /// <summary>
        /// xml添加属性
        /// </summary>
        /// <param name="node"></param>
        /// <param name="attributeName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public XmlAttribute CreateAttribute(XmlNode node, string attributeName, string value)
        {
            try
            {
                XmlDocument doc = node.OwnerDocument;
                XmlAttribute attr = null;
                attr = doc.CreateAttribute(attributeName);
                attr.Value = value;
                node.Attributes.SetNamedItem(attr);
                return attr;
            }
            catch (Exception err)
            {
                string desc = err.Message;
                return null;
            }
        }



        public void BindVoucher(string accid, string coutid, string csign, string vouno, string coutsign, string coutbillsign)
        {
            string coutno_id = vouServer.GetCoutNO(csign, vouno);
            vouServer.BindVoucher(accid, coutid, csign, vouno, coutno_id, coutsign, coutbillsign);

        }
        public void auditPZ(string csign, string vouno, string userName, string aduitDate)
        {
            string coutno_id = vouServer.GetCoutNO(csign, vouno);
            vouServer.auditPZ(coutno_id, userName, aduitDate);
        }
    }
}
