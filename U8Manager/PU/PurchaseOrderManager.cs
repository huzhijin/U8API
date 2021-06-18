using MSXML2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U8Model.PU;
using U8Services.PU;
using Helper.DOM;
using U8Manager.Common;

namespace U8Manager.PU
{
    /// <summary>
    /// 采购订单manager
    /// </summary>
    public class PurchaseOrderManager
    {
        PurchaseOrderService poService;
        U8Login.clsLogin g_oLogin;
        public PurchaseOrderManager(VoucherManager vou)
        {
            poService = new PurchaseOrderService(vou.UFDataConnstringForNet);
            g_oLogin = vou.u8Login;
        }
        public string ccode { get; set; }
        public bool AddPO(PurchaseOrder purchase, ref string errMsg)
        {
            #region 采购订单
           
                IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
                IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
                MSXML2.IXMLDOMElement eleHead;
                MSXML2.IXMLDOMElement eleBody;
                MSXML2.IXMLDOMElement ele;
                string strSQL;      
               strSQL = "select * from zpurpoheader where 1=0";
             domHead = DomHelper.getDom(strSQL, g_oLogin.UfDbName);

                //增加表头数据节点z:row
                eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
                ele = domHead.createElement("z:row");
                //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
                eleHead.appendChild(ele);

                //方法二是构造BusinessObject对象，具体方法如下：
                //BusinessObject domHead = broker.GetBoParam("domHead");
                //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
                //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
                //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

                /****************************** 以下是必输字段 ****************************/
                DomHelper.setAttribute(ele, "poid", "0"); //主关键字段，int类型
                DomHelper.setAttribute(ele, "cbustype", "普通采购"); //业务类型，int类型
                DomHelper.setAttribute(ele, "dpodate", g_oLogin.CurDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
                DomHelper.setAttribute(ele, "cpoid", "0000000041"); //订单编号，string类型
                DomHelper.setAttribute(ele, "cvenabbname", "辰环手机配件"); //供货单位，string类型
                DomHelper.setAttribute(ele, "cexch_name", "人民币"); //币种，string类型
                DomHelper.setAttribute(ele, "nflat", "1"); //汇率，double类型
                DomHelper.setAttribute(ele, "cmaker", "demo"); //制单人，string类型
                DomHelper.setAttribute(ele, "cvencode", "01002"); //供货单位编号，string类型
                                                        //DomHead[0]["ufts"] = ""; //时间戳，string类型
                DomHelper.setAttribute(ele, "idiscounttaxtype", "0"); //扣税类别，int类型
                                                            //DomHead[0]["contractcodet"] = ""; //合同号，string类型
                                                            //DomHead[0]["iflowid"] = ""; //流程ID，string类型
                                                            //DomHead[0]["cflowname"] = ""; //流程模式描述，string类型
                                                            //DomHead[0]["dclosetime"] = ""; //关闭时间，string类型
                                                            //DomHead[0]["dclosedate"] = ""; //关闭日期，string类型
                                                            //DomHead[0]["ccontactcode"] = ""; //供方联系人编码，string类型
                                                            //DomHead[0]["cmobilephone"] = ""; //供方联系人手机号，string类型
                                                            //DomHead[0]["cappcode"] = ""; //请购单号，string类型
                                                            //DomHead[0]["csysbarcode"] = ""; //单据条码，string类型
                                                            //DomHead[0]["cchangverifier"] = ""; //变更审批人，string类型
                                                            //DomHead[0]["cchangaudittime"] = ""; //变更审批时间，string类型
                                                            //DomHead[0]["cchangauditdate"] = ""; //变更审批日期，string类型
                                                            //DomHead[0]["controlresult"] = ""; //controlresult，string类型
                                                            //DomHead[0]["ibg_overflag"] = ""; //预算审批状态，string类型
                                                            //DomHead[0]["cbg_auditor"] = ""; //预算审批人，string类型
                                                            //DomHead[0]["cbg_audittime"] = ""; //预算审批时间，string类型

                /***************************** 以下是非必输字段 ****************************/
                //DomHead[0]["ipresent"] = ""; //现存量，string类型
                //DomHead[0]["cmaketime"] = ""; //制单时间，DateTime类型
                //DomHead[0]["cmodifytime"] = ""; //修改时间，DateTime类型
                //DomHead[0]["caudittime"] = ""; //审核时间，DateTime类型
                //DomHead[0]["cauditdate"] = ""; //审核日期，DateTime类型
                //DomHead[0]["cmodifydate"] = ""; //修改日期，DateTime类型
                //DomHead[0]["creviser"] = ""; //修改人，string类型
                //DomHead[0]["cptname"] = ""; //采购类型，string类型
                //DomHead[0]["cvenname"] = ""; //供应商全称，string类型
                //DomHead[0]["iverifystateex"] = ""; //审核状态，string类型
                //DomHead[0]["ireturncount"] = ""; //打回次数，string类型
                //DomHead[0]["iswfcontrolled"] = "0"; //是否启用工作流，string类型
                //DomHead[0]["cdepname"] = ""; //部门，string类型
                //DomHead[0]["cpersonname"] = ""; //业务员，string类型
                DomHelper.setAttribute(ele, "itaxrate", "17"); //税率，double类型
                                                     //DomHead[0]["cpayname"] = ""; //付款条件，string类型
                DomHelper.setAttribute(ele, "cmemo", "底层API测试"); //备注，string类型
                                                       //DomHead[0]["dplanarrdate"] = ""; //计划到货日期，DateTime类型
                                                       //DomHead[0]["cverifier"] = ""; //审核人，string类型
                                                       //DomHead[0]["cchanger"] = ""; //变更人，string类型
                                                       //DomHead[0]["ccloser"] = ""; //关闭人，string类型
                DomHelper.setAttribute(ele, "ivtid", "8173"); //单据模版号，int类型
                                                    //DomHead[0]["cvenbank"] = ""; //供方银行名称，string类型
                                                    //DomHead[0]["cptcode"] = ""; //采购类型编号，string类型
                                                    //DomHead[0]["myname"] = ""; //地址，double类型
                                                    //DomHead[0]["myphone"] = ""; //电话，double类型
                                                    //DomHead[0]["myfax"] = ""; //传真，double类型
                                                    //DomHead[0]["myzip"] = ""; //邮编，double类型
                                                    //DomHead[0]["cvenaddress"] = ""; //供方地址，string类型
                                                    //DomHead[0]["cvenphone"] = ""; //供方电话，string类型
                                                    //DomHead[0]["cvenfax"] = ""; //供方传真，string类型
                                                    //DomHead[0]["cvenpostcode"] = ""; //供方邮编，string类型
                                                    //DomHead[0]["cvenperson"] = ""; //供方联系人，string类型
                                                    //DomHead[0]["cvenaccount"] = ""; //供方银行账号，string类型
                                                    //DomHead[0]["cvenregcode"] = ""; //供方纳税登记号，string类型
                                                    //DomHead[0]["cstate"] = "1"; //状态（数据库），string类型
                                                    //DomHead[0]["cperiod"] = ""; //计划周期，string类型
                                                    //DomHead[0]["carrivalplace"] = ""; //到货地址，string类型
                                                    //DomHead[0]["ibargain"] = ""; //订金，double类型
                                                    //DomHead[0]["csccode"] = ""; //运输方式编号，string类型
                                                    //DomHead[0]["icost"] = ""; //运费，double类型
                                                    //DomHead[0]["cscname"] = ""; //运输方式，string类型
                                                    //DomHead[0]["cpaycode"] = ""; //付款条件编号，string类型
                DomHelper.setAttribute(ele, "cpersoncode", "00043"); //业务员编号，string类型
                DomHelper.setAttribute(ele, "cdepcode", "0401"); //部门编号，string类型
                                                       //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
                                                       //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
                                                       //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
                                                       //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型
                                                       //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
                                                       //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
                                                       //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
                                                       //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
                                                       //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
                                                       //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
                                                       //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
                                                       //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
                                                       //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
                                                       //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
                                                       //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
                                                       //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
                                                       //DomHead[0]["cvendefine1"] = ""; //供应商自定义项1，string类型
                                                       //DomHead[0]["cvendefine2"] = ""; //供应商自定义项2，string类型
                                                       //DomHead[0]["cvendefine3"] = ""; //供应商自定义项3，string类型
                                                       //DomHead[0]["cvendefine4"] = ""; //供应商自定义项4，string类型
                                                       //DomHead[0]["cvendefine5"] = ""; //供应商自定义项5，string类型
                                                       //DomHead[0]["cvendefine6"] = ""; //供应商自定义项6，string类型
                                                       //DomHead[0]["cvendefine7"] = ""; //供应商自定义项7，string类型
                                                       //DomHead[0]["cvendefine8"] = ""; //供应商自定义项8，string类型
                                                       //DomHead[0]["cvendefine9"] = ""; //供应商自定义项9，string类型
                                                       //DomHead[0]["cvendefine10"] = ""; //供应商自定义项10，string类型
                                                       //DomHead[0]["cvenpuomprotocol"] = ""; //收付款协议编码，string类型
                                                       //DomHead[0]["cvendefine11"] = ""; //供应商自定义项11，string类型
                                                       //DomHead[0]["cvenpuomprotocolname"] = ""; //收付款协议名称，string类型
                                                       //DomHead[0]["cvendefine12"] = ""; //供应商自定义项12，string类型
                                                       //DomHead[0]["cvendefine13"] = ""; //供应商自定义项13，string类型
                                                       //DomHead[0]["cvendefine14"] = ""; //供应商自定义项14，string类型
                                                       //DomHead[0]["cvendefine15"] = ""; //供应商自定义项15，string类型
                                                       //DomHead[0]["cvendefine16"] = ""; //供应商自定义项16，string类型
                                                       //DomHead[0]["clocker"] = ""; //锁定人，string类型

                //broker.AssignNormalValue("domHead", domHead);

                //给BO表体参数domBody赋值，此BO参数的业务类型为销售订单，属表体参数。BO参数均按引用传递
                //提示：给BO表体参数domBody赋值有两种方法

                //方法一是直接传入MSXML2.DOMDocumentClass对象
                //broker.AssignNormalValue("domBody", new MSXML2.DOMDocumentClass())
                strSQL = "select * from zpurpotail where 1=0";
             domBody = DomHelper.getDom(strSQL, g_oLogin.UfDbName);

            //增加表体数据节点z:row
            eleBody = domBody.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
                //方法二是构造BusinessObject对象，具体方法如下：
                //BusinessObject domBody = broker.GetBoParam("domBody");
                //domBody.RowCount = 1; //设置BO对象行数
                //可以自由设置BO对象行数为大于零的整数，也可以不设置而自动增加行数
                //给BO对象的字段赋值，值可以是真实类型，也可以是无类型字符串
                //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

                /****************************** 以下是必输字段 ****************************/
                for (int i = 0; i < 2; i++)
                {
                    decimal decQuantity = 20.00M;
                    //含税单价
                    decimal decprice = 10.00M;
                    //含税金额
                    decimal decamount = decimal.Round(decQuantity * decprice, 2);
                    //税率
                    decimal decTaxRate = 0.00M;
                    //不含税金额
                    decimal decNotTaxAmount = decimal.Round(decamount / (1 + decTaxRate), 2);
                    if (decTaxRate == 0)
                        decNotTaxAmount = decamount;
                    //不含税单价
                    decimal decNotTaxPrice = decimal.Round(decNotTaxAmount / decQuantity, 2);
                    if (decTaxRate == 0)
                        decNotTaxPrice = decprice;
                    //税额
                    decimal decTax = decamount - decNotTaxAmount;

                    ele = domBody.createElement("z:row");
                    eleBody.appendChild(ele);

                    DomHelper.setAttribute(ele, "id", "0"); //主关键字段，int类型
                    DomHelper.setAttribute(ele, "cfactorycode", "001");
                    DomHelper.setAttribute(ele, "cfactoryname", "工厂一");
                    DomHelper.setAttribute(ele, "cinvcode", "17001"); //存货编码，string类型
                    DomHelper.setAttribute(ele, "iquantity", "1"); //数量，double类型
                    DomHelper.setAttribute(ele, "darrivedate",g_oLogin.CurDate.ToString("yyyy-MM-dd")); //计划到货日期，DateTime类型
                    DomHelper.setAttribute(ele, "ipertaxrate", "17"); //税率，double类型
                    DomHelper.setAttribute(ele, "poid", "0"); //主表id，int类型
                    DomHelper.setAttribute(ele, "bgsp", "0"); //是否检验，int类型
                    DomHelper.setAttribute(ele, "editprop", "A"); //编辑属性：A表新增，M表修改，D表删除，string类型
                                                        //domBody[0]["cbg_itemcode"] = ""; //预算项目编码，string类型
                                                        //domBody[0]["cbg_itemname"] = ""; //预算项目，string类型
                                                        //domBody[0]["cbg_caliberkey1"] = ""; //口径1类型编码，string类型
                                                        //domBody[0]["cbg_caliberkeyname1"] = ""; //口径1类型名称，string类型
                                                        //domBody[0]["cbg_caliberkey2"] = ""; //口径2类型编码，string类型
                                                        //domBody[0]["cbg_caliberkeyname2"] = ""; //口径2类型名称，string类型
                                                        //domBody[0]["cbg_caliberkey3"] = ""; //口径3类型编码，string类型
                                                        //domBody[0]["cbg_caliberkeyname3"] = ""; //口径3类型名称，string类型
                                                        //domBody[0]["cbg_calibercode1"] = ""; //口径1编码，string类型
                                                        //domBody[0]["cbg_calibername1"] = ""; //口径1名称，string类型
                                                        //domBody[0]["cbg_calibercode2"] = ""; //口径2编码，string类型
                                                        //domBody[0]["cbg_calibername2"] = ""; //口径2名称，string类型
                                                        //domBody[0]["cbg_calibercode3"] = ""; //口径3编码，string类型
                                                        //domBody[0]["cbg_calibername3"] = ""; //口径3名称，string类型
                                                        //domBody[0]["cbg_auditopinion"] = ""; //审批意见，string类型
                                                        //domBody[0]["ibg_ctrl"] = ""; //是否预算控制，string类型
                                                        //domBody[0]["fexquantity"] = ""; //累计出口数量，string类型
                    DomHelper.setAttribute(ele, "ivouchrowno", i); //行号，string类型
                                                         //domBody[0]["cbg_caliberkeyname4"] = ""; //口径4类型名称，string类型
                                                         //domBody[0]["cbg_caliberkey5"] = ""; //口径5类型编码，string类型
                                                         //domBody[0]["cbg_caliberkeyname5"] = ""; //口径5类型名称，string类型
                                                         //domBody[0]["cbg_caliberkey6"] = ""; //口径6类型编码，string类型
                                                         //domBody[0]["cbg_caliberkeyname6"] = ""; //口径6类型名称，string类型
                                                         //domBody[0]["cbg_calibercode4"] = ""; //口径4编码，string类型
                                                         //domBody[0]["cbg_calibername4"] = ""; //口径4名称，string类型
                                                         //domBody[0]["cbg_calibercode5"] = ""; //口径5编码，string类型
                                                         //domBody[0]["cbg_calibername5"] = ""; //口径5名称，string类型
                                                         //domBody[0]["cbg_calibercode6"] = ""; //口径6编码，string类型
                                                         //domBody[0]["cbg_calibername6"] = ""; //口径6名称，string类型
                                                         //domBody[0]["csrpolicy"] = ""; //供需政策，string类型
                                                         //domBody[0]["irequiretrackstyle"] = ""; //存货需求跟踪方式，string类型
                                                         //domBody[0]["ipresentb"] = ""; //现存量，string类型
                                                         //domBody[0]["cbg_caliberkey4"] = ""; //口径4类型编码，string类型
                                                         //domBody[0]["cxjspdids"] = ""; //采购比价审批单子表ID，string类型
                    DomHelper.setAttribute(ele, "cbmemo", "cqz" + i.ToString()); //备注，string类型
                                                                       //domBody[0]["cbsysbarcode"] = ""; //单据行条码，string类型
                                                                       //domBody[0]["planlotnumber"] = ""; //计划批号，string类型
                                                                       //domBody[0]["cplanmethod"] = ""; //计划方法，string类型

                    /***************************** 以下是非必输字段 ****************************/
                    //domBody[0]["iinvexchrate"] = ""; //换算率，double类型
                    //domBody[0]["cinvname"] = ""; //存货名称，string类型
                    //domBody[0]["cinvstd"] = ""; //规格型号，string类型
                    //domBody[0]["iquotedprice"] = ""; //报价，double类型
                    //domBody[0]["inum"] = ""; //件数，double类型
                    //domBody[0]["iunitprice"] = ""; //原币单价，double类型
                    //domBody[0]["imoney"] = ""; //原币金额，double类型
                    //domBody[0]["itax"] = ""; //原币税额，double类型
                    //domBody[0]["idiscount"] = ""; //折扣额，double类型
                    //domBody[0]["inatunitprice"] = ""; //本币单价，double类型
                    //domBody[0]["inatmoney"] = ""; //本币金额，double类型
                    //domBody[0]["inattax"] = ""; //本币税额，double类型
                    //domBody[0]["inatsum"] = ""; //本币价税合计，double类型
                    //domBody[0]["inatdiscount"] = ""; //本币折扣额，double类型
                    //domBody[0]["isum"] = ""; //原币价税合计，double类型
                    //domBody[0]["cfree2"] = ""; //自由项2，string类型
                    //domBody[0]["cfree1"] = ""; //自由项1，string类型
                    //domBody[0]["bmark"] = ""; //标志，double类型
                    //domBody[0]["cdefine22"] = ""; //表体自定义项1，string类型
                    //domBody[0]["cdefine23"] = ""; //表体自定义项2，string类型
                    //domBody[0]["cdefine24"] = ""; //表体自定义项3，string类型
                    //domBody[0]["cdefine25"] = ""; //表体自定义项4，string类型
                    //domBody[0]["cdefine26"] = ""; //表体自定义项5，double类型
                    //domBody[0]["cdefine27"] = ""; //表体自定义项6，double类型
                    //domBody[0]["cinvdefine1"] = ""; //存货自定义项1，string类型
                    //domBody[0]["cinvdefine4"] = ""; //存货自定义项4，string类型
                    //domBody[0]["cinvdefine5"] = ""; //存货自定义项5，string类型
                    //domBody[0]["cinvdefine6"] = ""; //存货自定义项6，string类型
                    //domBody[0]["cinvdefine7"] = ""; //存货自定义项7，string类型
                    //domBody[0]["cinvdefine8"] = ""; //存货自定义项8，string类型
                    //domBody[0]["cinvdefine9"] = ""; //存货自定义项9，string类型
                    //domBody[0]["cinvdefine10"] = ""; //存货自定义项10，string类型
                    //domBody[0]["cinvdefine11"] = ""; //存货自定义项11，string类型
                    //domBody[0]["cinvdefine12"] = ""; //存货自定义项12，string类型
                    //domBody[0]["cinvdefine13"] = ""; //存货自定义项13，string类型
                    //domBody[0]["cinvdefine14"] = ""; //存货自定义项14，string类型
                    //domBody[0]["cinvdefine15"] = ""; //存货自定义项15，string类型
                    //domBody[0]["cinvdefine16"] = ""; //存货自定义项16，string类型
                    //domBody[0]["cinvdefine2"] = ""; //存货自定义项2，string类型
                    //domBody[0]["cinvdefine3"] = ""; //存货自定义项3，string类型
                    //domBody[0]["citemcode"] = ""; //项目编码，string类型
                    //domBody[0]["citem_class"] = ""; //项目大类编码，string类型
                    //domBody[0]["ppcids"] = ""; //采购计划子表ID，string类型
                    //domBody[0]["citemname"] = ""; //项目名称，string类型
                    //domBody[0]["citem_name"] = ""; //项目大类名称，string类型
                    //domBody[0]["cfree3"] = ""; //自由项3，string类型
                    //domBody[0]["cfree4"] = ""; //自由项4，string类型
                    //domBody[0]["cfree5"] = ""; //自由项5，string类型
                    //domBody[0]["cfree6"] = ""; //自由项6，string类型
                    //domBody[0]["cfree7"] = ""; //自由项7，string类型
                    //domBody[0]["cfree8"] = ""; //自由项8，string类型
                    //domBody[0]["cfree9"] = ""; //自由项9，string类型
                    //domBody[0]["cfree10"] = ""; //自由项10，string类型
                    //domBody[0]["imainid"] = ""; //对应单据主表id，string类型
                    //domBody[0]["btaxcost"] = ""; //单价标准，string类型
                    //domBody[0]["corufts"] = ""; //对应单据时间戳，string类型
                    //domBody[0]["itaxprice"] = ""; //含税单价，double类型
                    //domBody[0]["cunitid"] = ""; //单位编码，string类型
                    //domBody[0]["cinva_unit"] = ""; //采购单位，string类型
                    //domBody[0]["cinvm_unit"] = ""; //主计量，string类型
                    //domBody[0]["igrouptype"] = ""; //分组类型，string类型
                    //domBody[0]["iappids"] = ""; //请购单子表id，int类型
                    //domBody[0]["isosid"] = ""; //订单子表id，int类型
                    //domBody[0]["cdefine28"] = ""; //表体自定义项7，string类型
                    //domBody[0]["cdefine29"] = ""; //表体自定义项8，string类型
                    //domBody[0]["cdefine30"] = ""; //表体自定义项9，string类型
                    //domBody[0]["cdefine31"] = ""; //表体自定义项10，string类型
                    //domBody[0]["cdefine32"] = ""; //表体自定义项11，string类型
                    //domBody[0]["cdefine33"] = ""; //表体自定义项12，string类型
                    //domBody[0]["cdefine34"] = ""; //表体自定义项13，int类型
                    //domBody[0]["cdefine35"] = ""; //表体自定义项14，int类型
                    //domBody[0]["cdefine36"] = ""; //表体自定义项15，DateTime类型
                    //domBody[0]["cdefine37"] = ""; //表体自定义项16，DateTime类型
                    //domBody[0]["csource"] = ""; //单据来源，string类型
                    //domBody[0]["cinvaddcode"] = ""; //存货代码，string类型
                    //domBody[0]["cbcloser"] = ""; //行关闭人，string类型
                    //domBody[0]["cveninvcode"] = ""; //供应商存货编码，string类型
                    //domBody[0]["cveninvname"] = ""; //供应商存货名称，string类型
                    //domBody[0]["ippartid"] = ""; //母件Id，int类型
                    //domBody[0]["ipquantity"] = ""; //母件数量，int类型
                    //domBody[0]["iptoseq"] = ""; //选配序号，int类型
                    //domBody[0]["contractrowno"] = ""; //合同标的编码，string类型
                    //domBody[0]["contractrowguid"] = ""; //合同标的GUID，string类型
                    //domBody[0]["contractcode"] = ""; //合同号，string类型
                    //domBody[0]["sotype"] = ""; //需求跟踪方式，int类型
                    //domBody[0]["csocode"] = ""; //需求跟踪号，string类型
                    //domBody[0]["irowno"] = ""; //需求跟踪行号，string类型
                    //domBody[0]["sodid"] = ""; //需求跟踪子表ID，string类型
                    //domBody[0]["cbclosetime"] = ""; //关闭时间，DateTime类型
                    //domBody[0]["cbclosedate"] = ""; //关闭日期，DateTime类型
                    //domBody[0]["upsotype"] = ""; //上游单据类型，int类型
                    //domBody[0]["cupsocode"] = ""; //上游单据号，string类型
                    //domBody[0]["iinvmpcost"] = ""; //最高进价，double类型
                    //domBody[0]["cdemandmemo"] = ""; //需求分类代号说明，string类型
                    //domBody[0]["iorderdid"] = ""; //销售订单子表id，int类型
                    //domBody[0]["iordertype"] = ""; //销售订单类型，int类型
                    //domBody[0]["csoordercode"] = ""; //销售订单号，string类型
                    //domBody[0]["iorderseq"] = ""; //销售订单行号，int类型
                    //domBody[0]["bgift"] = ""; //赠品，string类型
                    //

                    //domHead.loadXML(strH);
                    //domBody.loadXML(strB);
                }


                if (true)
                {
                    VoucherCO_PU.clsVoucherCO_PU obj = new VoucherCO_PU.clsVoucherCO_PU();
                    //
                    bool bPositive = true;
                    string sBillType = "";
                    string sBusType = "普通采购";
                    VoucherVerify.UseMode um = VoucherVerify.UseMode.CS;
                    string sfBusType = "普通采购";
                    string sPtCode = "07";
                    //
                    Info_PU.ClsS_Infor clsinfo = new Info_PU.ClsS_Infor();
                    string str = clsinfo.Init(ref g_oLogin, sBusType, sPtCode);
                    ADODB.Connection oCon = new ADODB.Connection();
                    oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                    oCon.ConnectionString = g_oLogin.UFDataConnstringForNet;
                    oCon.Open(g_oLogin.UfDbName, "", "", -1);
                //
                obj.Init(VoucherCO_PU.vouchertype.采购订单, ref g_oLogin, ref oCon, ref clsinfo, ref bPositive, ref sBillType, ref sBusType, ref um, sfBusType, sPtCode);
                    obj.bOutTrans = false;
                    //
                    short VoucherState = 2;//增加
                    object vNewID = "";
                    IXMLDOMDocument2 CurDom = new MSXML2.DOMDocument();
                    string sOverDetailsXml = "";
                    IXMLDOMDocument2 DomMsg = new MSXML2.DOMDocument();
                    Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    string strRet = obj.VoucherSave(domHead, domBody, VoucherState, ref vNewID, ref CurDom, um, ref sOverDetailsXml, ref DomMsg);
                    Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                if (string.IsNullOrEmpty(strRet))
                {
                    return true;
                }
                else 
                {
                    errMsg = strRet;
                    return false;
                }
                   
                }
           
            #endregion
        }
    }
}
