//using System;
//using System.Collections.Generic;
//using System.Text;
//using UFIDA.U8.MomServiceCommon;
//using UFIDA.U8.U8MOMAPIFramework;
//using UFIDA.U8.U8APIFramework;
//using UFIDA.U8.U8APIFramework.Meta;
//using UFIDA.U8.U8APIFramework.Parameter;
//using MSXML2;
//using System.Runtime.InteropServices;
//using System.Data;
//using System.Windows.Forms;

//namespace YYAPI1
//{
//    public class YongYouAPI1
//    {
//        #region 外销合同生成销售订单
//        public void ToYYSaleOrderFromExpPact()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2015-01-26");
//            string sSubId = "AS";
//            string sAccID = "999";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_999_2014;Timeout=60";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from SaleOrderQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "id", "1000000284"); //主关键字段，int类型
//            setAttribute(ele, "csocode", "0000000269");//"0000000259"; //订 单 号，string类型
//            setAttribute(ele, "ddate", dtCreateDate.ToString("yyyy-MM-dd")); //订单日期，DateTime类型
//            string strcbustype = "普通销售";
//            setAttribute(ele, "cbustype", strcbustype); //业务类型，int类型
//            setAttribute(ele, "cstname", "外销"); //销售类型，string类型
//            setAttribute(ele, "ccusabbname", "世纪天华集团公司");//"淘宝"; //客户简称，string类型
//            setAttribute(ele, "cdepname", "销售部");//"电子商务"; //销售部门，string类型
//            setAttribute(ele, "itaxrate", "0"); //税率，double类型
//            setAttribute(ele, "cexch_name", "美元"); //币种，string类型
//            setAttribute(ele, "cmaker", "demo");//strUserID);// "demo"; //制单人，string类型
//            setAttribute(ele, "breturnflag", "0"); //退货标志，string类型
//            //setAttribute(ele,"ufts",""; //时间戳，string类型
//            setAttribute(ele, "cstcode", "02"); //销售类型编号，string类型
//            setAttribute(ele, "cdepcode", "0302");//"0304"; //部门编码，string类型
//            setAttribute(ele, "ccuscode", "00000001");//"0901"; //客户编码，string类型
//            //setAttribute(ele,"ccushand",""; //客户联系人手机，string类型
//            //setAttribute(ele,"cpsnophone",""; //业务员办公电话，string类型
//            //setAttribute(ele,"cpsnmobilephone",""; //业务员手机，string类型
//            //setAttribute(ele,"cattachment",""; //附件，string类型
//            //setAttribute(ele,"csscode",""; //结算方式编码，string类型
//            //setAttribute(ele,"cssname",""; //结算方式，string类型
//            setAttribute(ele, "cinvoicecompany", "00000001"); //"0901"; //开票单位编码，string类型
//            setAttribute(ele, "cinvoicecompanyabbname", "世纪天华集团公司");// "淘宝"; //开票单位简称，string类型
//            //setAttribute(ele,"ccuspersoncode",""; //联系人编码，string类型
//            //setAttribute(ele,"dclosedate",""; //关闭日期，string类型
//            //setAttribute(ele,"dclosesystime",""; //关闭时间，string类型
//            setAttribute(ele, "bmustbook", "0"); //必有定金，string类型
//            //setAttribute(ele,"fbookratio",""; //定金比例，string类型
//            //setAttribute(ele,"cgathingcode",""; //收款单号，string类型
//            //setAttribute(ele,"fbooksum",""; //定金原币金额，string类型
//            //setAttribute(ele,"fbooknatsum",""; //定金本币金额，string类型
//            //setAttribute(ele,"fgbooknatsum",""; //定金累计实收本币金额，string类型
//            //setAttribute(ele,"fgbooksum",""; //定金累计实收原币金额，string类型
//            setAttribute(ele, "ccrmpersonname", "");// "王铭"; //相关员工，string类型
//            //setAttribute(ele,"csysbarcode",""; //单据条码，string类型
//            //setAttribute(ele,"ioppid",""; //销售机会ID，string类型
//            setAttribute(ele, "contract_status", "1"); //contract_status，string类型
//            //setAttribute(ele,"csvouchtype",""; //来源电商，string类型
//            setAttribute(ele, "bcashsale", "0"); //现款结算，string类型
//            setAttribute(ele, "iflowid", ""); //流程id，string类型
//            //setAttribute(ele,"cflowname",""; //流程分支描述，string类型
//            //setAttribute(ele,"cchangeverifier",""; //变更审批人，string类型
//            //setAttribute(ele,"dchangeverifydate",""; //变更审批日期，string类型
//            //setAttribute(ele,"dchangeverifytime",""; //变更审批时间，string类型

//            ///***************************** 以下是非必输字段 ****************************/
//            //setAttribute(ele,"fstockquanO",""; //现存件数，double类型
//            //setAttribute(ele,"fcanusequanO",""; //可用件数，double类型
//            //setAttribute(ele,"iverifystate","0"); //iverifystate，string类型
//            //setAttribute(ele,"ireturncount","0"); //ireturncount，string类型
//            //setAttribute(ele,"icreditstate",""; //icreditstate，string类型
//            //setAttribute(ele, "iswfcontrolled", "0"); //iswfcontrolled，string类型
//            //setAttribute(ele,"dpredatebt",""; //预发货日期，DateTime类型
//            //setAttribute(ele,"dpremodatebt",""; //预完工日期，DateTime类型
//            //setAttribute(ele,"caddcode",""; //收货地址编码，string类型
//            //setAttribute(ele,"cdeliverunit",""; //收货单位，string类型
//            //setAttribute(ele,"ccontactname",""; //收货联系人，string类型
//            //setAttribute(ele,"cofficephone",""; //收货联系电话，string类型
//            //setAttribute(ele,"cmobilephone",""; //收货联系人手机，string类型
//            //setAttribute(ele,"cpayname",""; //付款条件，string类型
//            //setAttribute(ele,"cpersonname",""; //业 务 员，string类型
//            setAttribute(ele, "iexchrate", "6.3"); //汇率，double类型
//            setAttribute(ele, "cmemo", "底层API测试"); //备    注，string类型
//            //setAttribute(ele,"cverifier",""; //审核人，string类型
//            //setAttribute(ele,"ccloser",""; //关闭人，string类型
//            //setAttribute(ele,"clocker",""; //锁定人，string类型
//            setAttribute(ele, "ivtid", "95"); //单据模版号，int类型
//            //setAttribute(ele, "istatus", "1"); //订单状态，string类型
//            //setAttribute(ele,"ccrechppass",""; //信用审核口令，string类型
//            //setAttribute(ele,"clowpricepass",""; //最低售价口令，string类型
//            //setAttribute(ele,"bcontinue",""; //是否继续，string类型
//            //setAttribute(ele,"isumx",""; //价税合计，double类型
//            //setAttribute(ele,"zdsum",""; //整单合计，double类型
//            //setAttribute(ele,"ccusname",""; //客户名称，string类型
//            //setAttribute(ele,"ccusphone",""; //联系电话，string类型
//            //setAttribute(ele,"csccode",""; //发运方式编码，string类型
//            //setAttribute(ele,"cpaycode",""; //付款条件编码，string类型
//            //setAttribute(ele,"ccusperson",""; //联系人，string类型
//            //setAttribute(ele,"coppcode",""; //商机编码，string类型
//            //setAttribute(ele,"ccusaddress",""; //客户地址，string类型
//            setAttribute(ele, "cpersoncode", "00023");  //业务员编码，string类型
//            //setAttribute(ele,"iarmoney",""; //客户应收余额，double类型
//            //setAttribute(ele,"ccusoaddress",""; //发货地址，string类型
//            //setAttribute(ele,"imoney",""; //定    金，double类型
//            //setAttribute(ele,"cscname",""; //发运方式，string类型
//            //setAttribute(ele,"cchanger",""; //变更人，string类型
//            //setAttribute(ele,"dcreatesystime","2015-10-10"); //制单时间，DateTime类型
//            //setAttribute(ele,"dverifysystime",""; //审核时间，DateTime类型
//            //setAttribute(ele,"dmodifysystime",""; //修改时间，DateTime类型
//            //setAttribute(ele,"cmodifier",""; //修改人，string类型
//            //setAttribute(ele,"dmoddate",""; //修改日期，DateTime类型
//            //setAttribute(ele,"dverifydate",""; //审核日期，DateTime类型
//            //setAttribute(ele,"cdefine16",""; //表头自定义项16，double类型
//            //setAttribute(ele,"ccrechpname",""; //信用审核人，string类型
//            //setAttribute(ele,"ccusdefine1",""; //客户自定义项1，string类型
//            //setAttribute(ele,"ccusdefine2",""; //客户自定义项2，string类型
//            //setAttribute(ele,"ccusdefine3",""; //客户自定义项3，string类型
//            //setAttribute(ele,"ccusdefine4",""; //客户自定义项4，string类型
//            //setAttribute(ele,"zdsumdx",""; //整单合计（大写），string类型
//            //setAttribute(ele,"isumdx",""; //价税合计（大写），string类型
//            //setAttribute(ele,"ccusdefine5",""; //客户自定义项5，string类型
//            //setAttribute(ele,"ccusdefine6",""; //客户自定义项6，string类型
//            //setAttribute(ele,"ccusdefine7",""; //客户自定义项7，string类型
//            //setAttribute(ele,"ccusdefine8",""; //客户自定义项8，string类型
//            //setAttribute(ele,"ccusdefine9",""; //客户自定义项9，string类型
//            //setAttribute(ele,"ccusdefine10",""; //客户自定义项10，string类型
//            //setAttribute(ele,"ccusdefine11",""; //客户自定义项11，string类型
//            //setAttribute(ele,"ccusdefine12",""; //客户自定义项12，string类型
//            //setAttribute(ele,"ccusdefine13",""; //客户自定义项13，string类型
//            //setAttribute(ele,"ccusdefine14",""; //客户自定义项14，string类型
//            //setAttribute(ele,"ccusdefine15",""; //客户自定义项15，string类型
//            //setAttribute(ele,"ccusdefine16",""; //客户自定义项16，string类型
//            //setAttribute(ele,"icuscreline",""; //用户信用度，double类型
//            //setAttribute(ele,"fstockquan",""; //现存数量，double类型
//            //setAttribute(ele,"fcanusequan",""; //可用数量，double类型
//            //setAttribute(ele, "cdefine1","");//表头自定义项1，string类型
//            //setAttribute(ele,"cdefine2",""; //表头自定义项2，string类型
//            //setAttribute(ele,"cdefine3",""; //表头自定义项3，string类型
//            //setAttribute(ele,"cdefine4",""; //表头自定义项4，DateTime类型
//            //setAttribute(ele,"cdefine5",""; //表头自定义项5，int类型
//            //setAttribute(ele,"cdefine6",""; //表头自定义项6，DateTime类型
//            //setAttribute(ele,"cdefine7",""; //表头自定义项7，double类型
//            //setAttribute(ele,"cdefine8",""; //表头自定义项8，string类型
//            //setAttribute(ele,"cdefine9",""; //表头自定义项9，string类型
//            setAttribute(ele, "cdefine10", "");  //表头自定义项10，string类型
//            //setAttribute(ele,"cdefine11",""; //表头自定义项11，string类型
//            //setAttribute(ele,"cdefine12",""; //表头自定义项12，string类型
//            //setAttribute(ele,"cdefine13",""; //表头自定义项13，string类型
//            //setAttribute(ele,"cdefine14",""; //表头自定义项14，string类型
//            //setAttribute(ele,"cdefine15",""; //表头自定义项15，int类型
//            //setAttribute(ele,"ccreditcuscode",""; //信用单位编码，string类型
//            //setAttribute(ele,"ccreditcusname",""; //信用单位名称，string类型
//            //setAttribute(ele,"cgatheringplan",""; //收付款协议编码，string类型
//            //setAttribute(ele,"cgatheringplanname",""; //收付款协议名称，string类型

//            //broker.AssignNormalValue("domHead", domHead);

//            //给BO表体参数domBody赋值，此BO参数的业务类型为销售订单，属表体参数。BO参数均按引用传递
//            //提示：给BO表体参数domBody赋值有两种方法

//            //方法一是直接传入MSXML2.DOMDocumentClass对象
//            //broker.AssignNormalValue("domBody", new MSXML2.DOMDocumentClass())
//            strSQL = "select * from SaleOrderSQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domBody, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();
//            rs = null;

//            //增加表体数据节点z:row
//            eleBody = domBody.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domBody = broker.GetBoParam("domBody");
//            //domBody.RowCount = 1; //设置BO对象行数
//            //可以自由设置BO对象行数为大于零的整数，也可以不设置而自动增加行数
//            //给BO对象的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            decimal decQuantity = 20.00M;
//            //含税单价
//            decimal decprice = 10.00M;
//            //含税金额
//            decimal decamount = decimal.Round(decQuantity * decprice, 2);
//            //税率
//            decimal decTaxRate = 0.00M;
//            //不含税金额
//            decimal decNotTaxAmount = decimal.Round(decamount / (1 + decTaxRate), 2);
//            if (decTaxRate == 0)
//                decNotTaxAmount = decamount;
//            //不含税单价
//            decimal decNotTaxPrice = decimal.Round(decNotTaxAmount / decQuantity, 2);
//            if (decTaxRate == 0)
//                decNotTaxPrice = decprice;
//            //税额
//            decimal decTax = decamount - decNotTaxAmount;

//            ele = domBody.createElement("z:row");
//            eleBody.appendChild(ele);

//            setAttribute(ele, "isosid", "0"); //主关键字段，int类型
//            setAttribute(ele, "cinvname", "桌面PC"); // "壁挂炉"; //存货名称，string类型
//            setAttribute(ele, "cinvcode", "0301");//"1008"; //存货编码，string类型
//            setAttribute(ele, "autoid", "0"); //销售订单 2，int类型
//            setAttribute(ele, "iquantity", decQuantity.ToString()); //数量，double类型
//            setAttribute(ele, "dpredate", dtCreateDate.ToString("yyyy-MM-dd"));// "2015-01-31"; //预发货日期，DateTime类型
//            setAttribute(ele, "dpremodate", dtCreateDate.ToString("yyyy-MM-dd"));// "2015-01-31"; //预完工日期，DateTime类型
//            setAttribute(ele, "borderbom", "0"); //是否订单BOM，int类型
//            setAttribute(ele, "borderbomover", "0"); //订单BOM是否完成，int类型
//            setAttribute(ele, "id", "0"); //主表id，int类型
//            decimal iinvexchrate = 0;//换算率，double类型
//            setAttribute(ele, "iinvexchrate", iinvexchrate.ToString());// "0"; //换算率，double类型
//            //setAttribute(ele, "cunitid","0102"; //销售单位编码，string类型
//            //setAttribute(ele, "cinva_unit","0102"; //销售单位，string类型
//            setAttribute(ele, "cinvm_unit", "0102");//"0102"; //主计量单位，string类型
//            //setAttribute(ele, "igrouptype",""; //单位类型，uint类型
//            setAttribute(ele, "cgroupcode", "01");// "01"; //计量单位组，string类型
//            //setAttribute(ele, "dreleasedate",""; //预留失效日期，DateTime类型
//            setAttribute(ele, "editprop", "A"); //编辑属性：A表新增，M表修改，D表删除，string类型
//            //setAttribute(ele, "fstockquano",""; //现存件数，string类型
//            //setAttribute(ele, "fcanusequano",""; //可用件数，string类型
//            //setAttribute(ele, "iimid",""; //进口订单明细行，string类型
//            //setAttribute(ele, "btracksalebill",""; //PE跟单，string类型
//            //setAttribute(ele, "ccorvouchtype",""; //来源单据类型，string类型
//            //setAttribute(ele, "ccorvouchtypename",""; //来源单据名称，string类型
//            //setAttribute(ele, "icorrowno",""; //来源单据行号，string类型
//            //setAttribute(ele, "fcanusequan",""; //可用量，string类型
//            //setAttribute(ele, "fstockquan",""; //现存量，string类型
//            setAttribute(ele, "bsaleprice", "1"); //报价含税，string类型
//            setAttribute(ele, "bgift", "0"); //赠品，string类型
//            //setAttribute(ele, "forecastdid",""; //预测单子表ID，string类型
//            //setAttribute(ele, "cdetailsdemandcode",""; //子件需求分类代号，string类型
//            //setAttribute(ele, "cdetailsdemandmemo",""; //子件需求分类说明，string类型
//            //setAttribute(ele, "cbsysbarcode",""; //单据行条码，string类型
//            //setAttribute(ele, "busecusbom",""; //使用客户BOM，string类型
//            //setAttribute(ele, "bptomodel",""; //bptomodel，string类型
//            //setAttribute(ele, "cparentcode",""; //父节点编码，string类型
//            //setAttribute(ele, "cchildcode",""; //子节点编码，string类型
//            //setAttribute(ele, "icalctype",""; //发货模式，string类型
//            //setAttribute(ele, "fchildqty",""; //使用数量，string类型
//            //setAttribute(ele, "fchildrate",""; //权重比例，string类型

//            ///***************************** 以下是非必输字段 ****************************/
//            //setAttribute(ele, "natoseqid",""; //ato行id，string类型
//            //setAttribute(ele, "natostatus",""; //ato行编辑状态，string类型
//            //setAttribute(ele, "iquoid",""; //报价id，string类型
//            //setAttribute(ele, "cscloser",""; //行关闭人，string类型
//            setAttribute(ele, "irowno", "1");//"1"; //行号，string类型
//            //setAttribute(ele, "cconfigstatus",""; //选配标志，int类型
//            //setAttribute(ele, "ippartseqid",""; //选配序号，string类型
//            //setAttribute(ele, "cquocode",""; //报价单号，string类型
//            //setAttribute(ele, "cinvstd",""; //规格型号，string类型
//            //setAttribute(ele, "ccontractid",""; //合同编码，string类型
//            //setAttribute(ele, "ccontractrowguid",""; //合同标的RowGuid，string类型
//            //setAttribute(ele, "ccontracttagcode",""; //合同标的编码，string类型
//            //setAttribute(ele, "icusbomid",""; //客户BomID，string类型
//            //setAttribute(ele, "ippartqty",""; //母件数量，string类型
//            //setAttribute(ele, "ippartid",""; //母件物料ID，string类型
//            //setAttribute(ele, "imoquantity",""; //下达生产量，double类型
//            //setAttribute(ele, "batomodel",""; //是否ATO件，int类型
//            //setAttribute(ele, "inum",""; //件数，double类型
//            //setAttribute(ele, "fsalecost",""; //零售单价，double类型
//            setAttribute(ele, "itaxunitprice", decprice.ToString()); //含税单价，double类型
//            setAttribute(ele, "iquotedprice", decprice.ToString());//报价，double类型
//            setAttribute(ele, "iunitprice", decNotTaxPrice.ToString()); //无税单价，double类型
//            setAttribute(ele, "imoney", decNotTaxAmount.ToString()); //无税金额，double类型
//            setAttribute(ele, "itax", decTax.ToString()); //税额，double类型
//            setAttribute(ele, "isum", decamount.ToString()); //价税合计，double类型
//            //setAttribute(ele, "fsaleprice",""; //零售金额，double类型
//            setAttribute(ele, "inatunitprice", decNotTaxPrice.ToString()); //本币单价，double类型
//            setAttribute(ele, "inatmoney", decNotTaxAmount.ToString()); //本币金额，double类型
//            setAttribute(ele, "inattax", decTax.ToString());  //本币税额，double类型
//            setAttribute(ele, "inatsum", decamount.ToString());  //本币价税合计，double类型
//            //setAttribute(ele, "inatdiscount",""; //本币折扣额，double类型
//            //setAttribute(ele, "idiscount",""; //折扣额，double类型
//            //setAttribute(ele, "ifhquantity",""; //发货数量，double类型
//            //setAttribute(ele, "ifhnum",""; //发货件数，double类型
//            //setAttribute(ele, "ifhmoney",""; //发货金额，double类型
//            //setAttribute(ele, "ikpquantity",""; //开票数量，double类型
//            //setAttribute(ele, "ikpnum",""; //开票件数，double类型
//            //setAttribute(ele, "ikpmoney",""; //开票金额，double类型
//            //setAttribute(ele, "iinvlscost",""; //最低售价，double类型
//            //setAttribute(ele, "cfree1",""; //自由项1，string类型
//            //setAttribute(ele, "cfree2",""; //自由项2，string类型
//            //setAttribute(ele, "bservice",""; //是否应税劳务，string类型
//            //setAttribute(ele, "bfree1",""; //是否有自由项1，string类型
//            //setAttribute(ele, "bfree2",""; //是否有自由项2，string类型
//            //setAttribute(ele, "bfree3",""; //是否有自由项3，string类型
//            //setAttribute(ele, "bfree4",""; //是否有自由项4，string类型
//            //setAttribute(ele, "bfree5",""; //是否有自由项5，string类型
//            //setAttribute(ele, "bfree6",""; //是否有自由项6，string类型
//            //setAttribute(ele, "bfree7",""; //是否有自由项7，string类型
//            //setAttribute(ele, "bfree8",""; //是否有自由项8，string类型
//            //setAttribute(ele, "bfree9",""; //是否有自由项9，string类型
//            //setAttribute(ele, "bfree10",""; //是否有自由项10，string类型
//            //setAttribute(ele, "cmemo",""; //备注，string类型
//            //setAttribute(ele, "cinvdefine1",""; //存货自定义项1，string类型
//            //setAttribute(ele, "cinvdefine4",""; //存货自定义项4，string类型
//            //setAttribute(ele, "cinvdefine5",""; //存货自定义项5，string类型
//            //setAttribute(ele, "cinvdefine6",""; //存货自定义项6，string类型
//            //setAttribute(ele, "cinvdefine7",""; //存货自定义项7，string类型
//            //setAttribute(ele, "bsalepricefree1",""; //是否自由项定价1，string类型
//            //setAttribute(ele, "bsalepricefree2",""; //是否自由项定价2，string类型
//            //setAttribute(ele, "bsalepricefree3",""; //是否自由项定价3，string类型
//            //setAttribute(ele, "bsalepricefree4",""; //是否自由项定价4，string类型
//            //setAttribute(ele, "bsalepricefree5",""; //是否自由项定价5，string类型
//            //setAttribute(ele, "bsalepricefree6",""; //是否自由项定价6，string类型
//            //setAttribute(ele, "bsalepricefree7",""; //是否自由项定价7，string类型
//            //setAttribute(ele, "bsalepricefree8",""; //是否自由项定价8，string类型
//            //setAttribute(ele, "bsalepricefree9",""; //是否自由项定价9，string类型
//            //setAttribute(ele, "bsalepricefree10",""; //是否自由项定价10，string类型
//            //setAttribute(ele, "iaoids",""; //預訂單子表id，int类型
//            //setAttribute(ele, "cpreordercode",""; //预订单号，int类型
//            //setAttribute(ele, "idemandtype",""; //需求跟踪方式，int类型
//            //setAttribute(ele, "cdemandcode",""; //需求分类代号，string类型
//            //setAttribute(ele, "cdemandmemo",""; //需求分类说明，string类型
//            //setAttribute(ele, "cinvdefine8",""; //存货自定义项8，string类型
//            //setAttribute(ele, "cinvdefine9",""; //存货自定义项9，string类型
//            //setAttribute(ele, "cinvdefine10",""; //存货自定义项10，string类型
//            //setAttribute(ele, "cinvdefine11",""; //存货自定义项11，string类型
//            //setAttribute(ele, "cinvdefine12",""; //存货自定义项12，string类型
//            //setAttribute(ele, "cinvdefine13",""; //存货自定义项13，string类型
//            //setAttribute(ele, "cinvdefine14",""; //存货自定义项14，string类型
//            //setAttribute(ele, "cinvdefine15",""; //存货自定义项15，string类型
//            //setAttribute(ele, "cinvdefine16",""; //存货自定义项16，string类型
//            //setAttribute(ele, "cinvdefine2",""; //存货自定义项2，string类型
//            //setAttribute(ele, "cinvdefine3",""; //存货自定义项3，string类型
//            //setAttribute(ele, "binvtype",""; //存货类型，string类型
//            //setAttribute(ele, "cdefine22",""; //表体自定义项1，string类型
//            //setAttribute(ele, "cdefine23",""; //表体自定义项2，string类型
//            //setAttribute(ele, "cdefine24",""; //表体自定义项3，string类型
//            //setAttribute(ele, "cdefine25",""; //表体自定义项4，string类型
//            //setAttribute(ele, "cdefine26",""; //表体自定义项5，double类型
//            //setAttribute(ele, "cdefine27",""; //表体自定义项6，double类型
//            //setAttribute(ele, "itaxrate","0"); //税率（％），double类型
//            //setAttribute(ele, "kl2",""; //扣率2（％），double类型
//            //setAttribute(ele, "citemcode",""; //项目编码，string类型
//            //setAttribute(ele, "citem_class",""; //项目大类编码，string类型
//            //setAttribute(ele, "dkl1",""; //倒扣1（％），double类型
//            //setAttribute(ele, "dkl2",""; //倒扣2（％），double类型
//            //setAttribute(ele, "citemname",""; //项目名称，string类型
//            //setAttribute(ele, "citem_cname",""; //项目大类名称，string类型
//            //setAttribute(ele, "cfree3",""; //自由项3，string类型
//            //setAttribute(ele, "cfree4",""; //自由项4，string类型
//            //setAttribute(ele, "cfree5",""; //自由项5，string类型
//            //setAttribute(ele, "cfree6",""; //自由项6，string类型
//            //setAttribute(ele, "cfree7",""; //自由项7，string类型
//            //setAttribute(ele, "cfree8",""; //自由项8，string类型
//            //setAttribute(ele, "cfree9",""; //自由项9，string类型
//            //setAttribute(ele, "cfree10",""; //自由项10，string类型
//            //setAttribute(ele, "cdefine28",""; //表体自定义项7，string类型
//            //setAttribute(ele, "cdefine29",""; //表体自定义项8，string类型
//            //setAttribute(ele, "cdefine30",""; //表体自定义项9，string类型
//            //setAttribute(ele, "cdefine31",""; //表体自定义项10，string类型
//            //setAttribute(ele, "cdefine32",""; //表体自定义项11，string类型
//            //setAttribute(ele, "corufts",""; //对应单据时间戳，string类型
//            //setAttribute(ele, "cdefine33",""; //表体自定义项12，string类型
//            //setAttribute(ele, "cdefine34"] = dsU8.Tables["T_ExpPactProduct"].DefaultView[iRow]["SerialID"].ToString();  //表体自定义项13，int类型
//            //setAttribute(ele, "cdefine35",""; //表体自定义项14，int类型
//            //setAttribute(ele, "cdefine36",""; //表体自定义项15，DateTime类型
//            //setAttribute(ele, "cdefine37",""; //表体自定义项16，DateTime类型
//            //setAttribute(ele, "binvmodel",""; //是否模型件，int类型
//            //setAttribute(ele, "csrpolicy",""; //供需政策，string类型
//            //setAttribute(ele, "iprekeepquantity",""; //预留数量，double类型
//            //setAttribute(ele, "iprekeepnum",""; //预留件数，double类型
//            //setAttribute(ele, "iprekeeptotquantity",""; //预留母件和子件数量，double类型
//            //setAttribute(ele, "iprekeeptotnum",""; //预留母件子件件数，double类型
//            //setAttribute(ele, "fcusminprice",""; //客户最低售价，double类型
//            //setAttribute(ele, "ccusinvcode",""; //客户存货编码，string类型
//            //setAttribute(ele, "ccusinvname",""; //客户存货名称，string类型
//            //setAttribute(ele, "cinvaddcode",""; //存货代码，string类型
//            //setAttribute(ele, "dbclosedate",""; //关闭日期，DateTime类型
//            //setAttribute(ele, "dbclosesystime",""; //关闭时间，DateTime类型
//            //setAttribute(ele, "kl",""; //扣率（％），double类型
//            //

//            //domHead.loadXML(strH);
//            //domBody.loadXML(strB);

//            if (false)
//            {
//                string strErrMsg = "aa";
//                VoucherCO_Sa.ClsVoucherCO_SA obj = new VoucherCO_Sa.ClsVoucherCO_SA();
//                string strUserMode = "CS";
//                //
//                USSAServer.clsSystem clsSAWeb = new USSAServer.clsSystem();
//                if (clsSAWeb.Init(ref g_oLogin, ref strErrMsg) == false)
//                {
//                    if (strErrMsg == null)
//                        strErrMsg = "错误：但是没有出错信息";
//                    MessageBox.Show(strErrMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }
//                object a = new object();
//                a = clsSAWeb;
//                obj.Init(VoucherCO_Sa.VoucherTypeSA.SODetails, ref g_oLogin, ref oCon, ref strUserMode, ref a);
//                //
//                short VoucherState = 0;//增加
//                object vNewID = "";
//                IXMLDOMDocument2 DomConfig = new MSXML2.DOMDocument();
//                string strRet = obj.Save(domHead, domBody, VoucherState, ref vNewID, ref DomConfig);
//                MessageBox.Show(strRet);
//            }
//            if (true)
//            {
//                string strErrMsg = "";
//                VoucherCO_Sa.ClsVoucherCO_SA obj = new VoucherCO_Sa.ClsVoucherCO_SA();
//                string strUserMode = "CS";
//                //
//                USSAServer.clsSystem objT = new USSAServer.clsSystem();
//                Type type = objT.GetType();
//                object clsSAWeb = Activator.CreateInstance(type);
//                object[] par = new object[] { g_oLogin, strErrMsg };
//                bool bSuccess = (bool)type.InvokeMember("Init", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, clsSAWeb, par);
//                if (!bSuccess)
//                {
//                    if (strErrMsg == null)
//                        strErrMsg = "错误：但是没有出错信息";
//                    MessageBox.Show(strErrMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }
//                obj.Init(VoucherCO_Sa.VoucherTypeSA.SODetails, ref g_oLogin, ref oCon, ref strUserMode, ref clsSAWeb);
//                //
//                //UFIDA.U8.HR.TM.Biz.Leave tm= new UFIDA.U8.HR.TM.Biz.Leave)_
//                short VoucherState = 0;//增加
//                object vNewID = "";
//                IXMLDOMDocument2 DomConfig = new MSXML2.DOMDocument();
//                string strRet = obj.Save(domHead, domBody, VoucherState, ref vNewID, ref DomConfig);
//                MessageBox.Show(strRet);
//            }
//        }
//        #endregion

//        #region 审核/弃审销售订单
//        public void AuditYYSaleOrderFromExpPact(bool bISAudit)
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2015-01-26");
//            string sSubId = "AS";
//            string sAccID = "999";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_999_2014;Timeout=60";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from SaleOrderQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "id", "1000000288"); //主关键字段，int类型
//            setAttribute(ele, "csocode", "0000000273");//"0000000259"; //订 单 号，string类型
//            setAttribute(ele, "ddate", dtCreateDate.ToString("yyyy-MM-dd")); //订单日期，DateTime类型
//            string strcbustype = "普通销售";
//            setAttribute(ele, "cbustype", strcbustype); //业务类型，int类型
//            //setAttribute(ele, "cstname", "外销"); //销售类型，string类型
//            //setAttribute(ele, "ccusabbname", "世纪天华集团公司");//"淘宝"; //客户简称，string类型
//            //setAttribute(ele, "cdepname", "销售部");//"电子商务"; //销售部门，string类型
//            //setAttribute(ele, "itaxrate", "0"); //税率，double类型
//            //setAttribute(ele, "cexch_name", "美元"); //币种，string类型
//            //setAttribute(ele, "cmaker", "demo");//strUserID);// "demo"; //制单人，string类型
//            //setAttribute(ele, "breturnflag", "0"); //退货标志，string类型
//            //setAttribute(ele,"ufts",""; //时间戳，string类型
//            //setAttribute(ele, "cstcode", "02"); //销售类型编号，string类型
//            //setAttribute(ele, "cdepcode", "0302");//"0304"; //部门编码，string类型
//            //setAttribute(ele, "ccuscode", "00000001");//"0901"; //客户编码，string类型
//            //setAttribute(ele,"ccushand",""; //客户联系人手机，string类型
//            //setAttribute(ele,"cpsnophone",""; //业务员办公电话，string类型
//            //setAttribute(ele,"cpsnmobilephone",""; //业务员手机，string类型
//            //setAttribute(ele,"cattachment",""; //附件，string类型
//            //setAttribute(ele,"csscode",""; //结算方式编码，string类型
//            //setAttribute(ele,"cssname",""; //结算方式，string类型
//            //setAttribute(ele, "cinvoicecompany", "00000001"); //"0901"; //开票单位编码，string类型
//            //setAttribute(ele, "cinvoicecompanyabbname", "世纪天华集团公司");// "淘宝"; //开票单位简称，string类型
//            //setAttribute(ele,"ccuspersoncode",""; //联系人编码，string类型
//            //setAttribute(ele,"dclosedate",""; //关闭日期，string类型
//            //setAttribute(ele,"dclosesystime",""; //关闭时间，string类型
//            //setAttribute(ele, "bmustbook", "0"); //必有定金，string类型
//            //setAttribute(ele,"fbookratio",""; //定金比例，string类型
//            //setAttribute(ele,"cgathingcode",""; //收款单号，string类型
//            //setAttribute(ele,"fbooksum",""; //定金原币金额，string类型
//            //setAttribute(ele,"fbooknatsum",""; //定金本币金额，string类型
//            //setAttribute(ele,"fgbooknatsum",""; //定金累计实收本币金额，string类型
//            //setAttribute(ele,"fgbooksum",""; //定金累计实收原币金额，string类型
//            //setAttribute(ele, "ccrmpersonname", "");// "王铭"; //相关员工，string类型
//            //setAttribute(ele,"csysbarcode",""; //单据条码，string类型
//            //setAttribute(ele,"ioppid",""; //销售机会ID，string类型
//            //setAttribute(ele, "contract_status", "1"); //contract_status，string类型
//            //setAttribute(ele,"csvouchtype",""; //来源电商，string类型
//            //setAttribute(ele, "bcashsale", "0"); //现款结算，string类型
//            //setAttribute(ele, "iflowid", ""); //流程id，string类型
//            //setAttribute(ele,"cflowname",""; //流程分支描述，string类型
//            //setAttribute(ele,"cchangeverifier",""; //变更审批人，string类型
//            //setAttribute(ele,"dchangeverifydate",""; //变更审批日期，string类型
//            //setAttribute(ele,"dchangeverifytime",""; //变更审批时间，string类型

//            ///***************************** 以下是非必输字段 ****************************/
//            //setAttribute(ele,"fstockquanO",""; //现存件数，double类型
//            //setAttribute(ele,"fcanusequanO",""; //可用件数，double类型
//            //setAttribute(ele,"iverifystate","0"); //iverifystate，string类型
//            //setAttribute(ele,"ireturncount","0"); //ireturncount，string类型
//            //setAttribute(ele,"icreditstate",""; //icreditstate，string类型
//            //setAttribute(ele, "iswfcontrolled", "0"); //iswfcontrolled，string类型
//            //setAttribute(ele,"dpredatebt",""; //预发货日期，DateTime类型
//            //setAttribute(ele,"dpremodatebt",""; //预完工日期，DateTime类型
//            //setAttribute(ele,"caddcode",""; //收货地址编码，string类型
//            //setAttribute(ele,"cdeliverunit",""; //收货单位，string类型
//            //setAttribute(ele,"ccontactname",""; //收货联系人，string类型
//            //setAttribute(ele,"cofficephone",""; //收货联系电话，string类型
//            //setAttribute(ele,"cmobilephone",""; //收货联系人手机，string类型
//            //setAttribute(ele,"cpayname",""; //付款条件，string类型
//            //setAttribute(ele,"cpersonname",""; //业 务 员，string类型
//            //setAttribute(ele, "iexchrate", "6.3"); //汇率，double类型
//            //setAttribute(ele, "cmemo", "底层API测试"); //备    注，string类型
//            //setAttribute(ele,"cverifier",""; //审核人，string类型
//            //setAttribute(ele,"ccloser",""; //关闭人，string类型
//            //setAttribute(ele,"clocker",""; //锁定人，string类型
//            //setAttribute(ele, "ivtid", "95"); //单据模版号，int类型
//            //setAttribute(ele, "istatus", "1"); //订单状态，string类型
//            //setAttribute(ele,"ccrechppass",""; //信用审核口令，string类型
//            //setAttribute(ele,"clowpricepass",""; //最低售价口令，string类型
//            //setAttribute(ele,"bcontinue",""; //是否继续，string类型
//            //setAttribute(ele,"isumx",""; //价税合计，double类型
//            //setAttribute(ele,"zdsum",""; //整单合计，double类型
//            //setAttribute(ele,"ccusname",""; //客户名称，string类型
//            //setAttribute(ele,"ccusphone",""; //联系电话，string类型
//            //setAttribute(ele,"csccode",""; //发运方式编码，string类型
//            //setAttribute(ele,"cpaycode",""; //付款条件编码，string类型
//            //setAttribute(ele,"ccusperson",""; //联系人，string类型
//            //setAttribute(ele,"coppcode",""; //商机编码，string类型
//            //setAttribute(ele,"ccusaddress",""; //客户地址，string类型
//            //setAttribute(ele, "cpersoncode", "00023");  //业务员编码，string类型
//            //setAttribute(ele,"iarmoney",""; //客户应收余额，double类型
//            //setAttribute(ele,"ccusoaddress",""; //发货地址，string类型
//            //setAttribute(ele,"imoney",""; //定    金，double类型
//            //setAttribute(ele,"cscname",""; //发运方式，string类型
//            //setAttribute(ele,"cchanger",""; //变更人，string类型
//            //setAttribute(ele,"dcreatesystime","2015-10-10"); //制单时间，DateTime类型
//            //setAttribute(ele,"dverifysystime",""; //审核时间，DateTime类型
//            //setAttribute(ele,"dmodifysystime",""; //修改时间，DateTime类型
//            //setAttribute(ele,"cmodifier",""; //修改人，string类型
//            //setAttribute(ele,"dmoddate",""; //修改日期，DateTime类型
//            //setAttribute(ele,"dverifydate",""; //审核日期，DateTime类型
//            //setAttribute(ele,"cdefine16",""; //表头自定义项16，double类型
//            //setAttribute(ele,"ccrechpname",""; //信用审核人，string类型
//            //setAttribute(ele,"ccusdefine1",""; //客户自定义项1，string类型
//            //setAttribute(ele,"ccusdefine2",""; //客户自定义项2，string类型
//            //setAttribute(ele,"ccusdefine3",""; //客户自定义项3，string类型
//            //setAttribute(ele,"ccusdefine4",""; //客户自定义项4，string类型
//            //setAttribute(ele,"zdsumdx",""; //整单合计（大写），string类型
//            //setAttribute(ele,"isumdx",""; //价税合计（大写），string类型
//            //setAttribute(ele,"ccusdefine5",""; //客户自定义项5，string类型
//            //setAttribute(ele,"ccusdefine6",""; //客户自定义项6，string类型
//            //setAttribute(ele,"ccusdefine7",""; //客户自定义项7，string类型
//            //setAttribute(ele,"ccusdefine8",""; //客户自定义项8，string类型
//            //setAttribute(ele,"ccusdefine9",""; //客户自定义项9，string类型
//            //setAttribute(ele,"ccusdefine10",""; //客户自定义项10，string类型
//            //setAttribute(ele,"ccusdefine11",""; //客户自定义项11，string类型
//            //setAttribute(ele,"ccusdefine12",""; //客户自定义项12，string类型
//            //setAttribute(ele,"ccusdefine13",""; //客户自定义项13，string类型
//            //setAttribute(ele,"ccusdefine14",""; //客户自定义项14，string类型
//            //setAttribute(ele,"ccusdefine15",""; //客户自定义项15，string类型
//            //setAttribute(ele,"ccusdefine16",""; //客户自定义项16，string类型
//            //setAttribute(ele,"icuscreline",""; //用户信用度，double类型
//            //setAttribute(ele,"fstockquan",""; //现存数量，double类型
//            //setAttribute(ele,"fcanusequan",""; //可用数量，double类型
//            //setAttribute(ele, "cdefine1","");//表头自定义项1，string类型
//            //setAttribute(ele,"cdefine2",""; //表头自定义项2，string类型
//            //setAttribute(ele,"cdefine3",""; //表头自定义项3，string类型
//            //setAttribute(ele,"cdefine4",""; //表头自定义项4，DateTime类型
//            //setAttribute(ele,"cdefine5",""; //表头自定义项5，int类型
//            //setAttribute(ele,"cdefine6",""; //表头自定义项6，DateTime类型
//            //setAttribute(ele,"cdefine7",""; //表头自定义项7，double类型
//            //setAttribute(ele,"cdefine8",""; //表头自定义项8，string类型
//            //setAttribute(ele,"cdefine9",""; //表头自定义项9，string类型
//            //setAttribute(ele, "cdefine10", "");  //表头自定义项10，string类型
//            //setAttribute(ele,"cdefine11",""; //表头自定义项11，string类型
//            //setAttribute(ele,"cdefine12",""; //表头自定义项12，string类型
//            //setAttribute(ele,"cdefine13",""; //表头自定义项13，string类型
//            //setAttribute(ele,"cdefine14",""; //表头自定义项14，string类型
//            //setAttribute(ele,"cdefine15",""; //表头自定义项15，int类型
//            //setAttribute(ele,"ccreditcuscode",""; //信用单位编码，string类型
//            //setAttribute(ele,"ccreditcusname",""; //信用单位名称，string类型
//            //setAttribute(ele,"cgatheringplan",""; //收付款协议编码，string类型
//            //setAttribute(ele,"cgatheringplanname",""; //收付款协议名称，string类型

//            //broker.AssignNormalValue("domHead", domHead);

//            if (false)
//            {
//                string strErrMsg = "aa";
//                VoucherCO_Sa.ClsVoucherCO_SA obj = new VoucherCO_Sa.ClsVoucherCO_SA();
//                string strUserMode = "CS";
//                //
//                USSAServer.clsSystem clsSAWeb = new USSAServer.clsSystem();
//                if (clsSAWeb.Init(ref g_oLogin, ref strErrMsg) == false)
//                {
//                    if (strErrMsg == null)
//                        strErrMsg = "错误：但是没有出错信息";
//                    MessageBox.Show(strErrMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }
//                object a = new object();
//                a = clsSAWeb;
//                obj.Init(VoucherCO_Sa.VoucherTypeSA.SODetails, ref g_oLogin, ref oCon, ref strUserMode, ref a);
//                //
//                string strRet = obj.VerifyVouch(ref domHead, ref bISAudit);
//                MessageBox.Show(strRet);
//            }
//            if (true)
//            {
//                string strErrMsg = "";
//                VoucherCO_Sa.ClsVoucherCO_SA obj = new VoucherCO_Sa.ClsVoucherCO_SA();
//                string strUserMode = "CS";
//                //
//                USSAServer.clsSystem objT = new USSAServer.clsSystem();
//                Type type = objT.GetType();
//                object clsSAWeb = Activator.CreateInstance(type);
//                object[] par = new object[] { g_oLogin, strErrMsg };
//                bool bSuccess = (bool)type.InvokeMember("Init", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, clsSAWeb, par);
//                if (!bSuccess)
//                {
//                    if (strErrMsg == null)
//                        strErrMsg = "错误：但是没有出错信息";
//                    MessageBox.Show(strErrMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }
//                obj.Init(VoucherCO_Sa.VoucherTypeSA.SODetails, ref g_oLogin, ref oCon, ref strUserMode, ref clsSAWeb);
//                //
//                string strRet = obj.VerifyVouch(ref domHead, ref bISAudit);
//                MessageBox.Show(strRet);
//            }
//        }
//        #endregion

//        #region 删除销售订单
//        public void DeleteYYSaleOrderFromExpPact()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2015-01-26");
//            string sSubId = "AS";
//            string sAccID = "999";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_999_2014;Timeout=60";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from SaleOrderQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "id", "1000000288"); //主关键字段，int类型
//            setAttribute(ele, "csocode", "0000000273");//"0000000259"; //订 单 号，string类型
//            setAttribute(ele, "ddate", dtCreateDate.ToString("yyyy-MM-dd")); //订单日期，DateTime类型
//            string strcbustype = "普通销售";
//            setAttribute(ele, "cbustype", strcbustype); //业务类型，int类型
//            //setAttribute(ele, "cstname", "外销"); //销售类型，string类型
//            //setAttribute(ele, "ccusabbname", "世纪天华集团公司");//"淘宝"; //客户简称，string类型
//            //setAttribute(ele, "cdepname", "销售部");//"电子商务"; //销售部门，string类型
//            //setAttribute(ele, "itaxrate", "0"); //税率，double类型
//            //setAttribute(ele, "cexch_name", "美元"); //币种，string类型
//            //setAttribute(ele, "cmaker", "demo");//strUserID);// "demo"; //制单人，string类型
//            //setAttribute(ele, "breturnflag", "0"); //退货标志，string类型
//            //setAttribute(ele,"ufts",""; //时间戳，string类型
//            //setAttribute(ele, "cstcode", "02"); //销售类型编号，string类型
//            //setAttribute(ele, "cdepcode", "0302");//"0304"; //部门编码，string类型
//            setAttribute(ele, "ccuscode", "00000001");//"0901"; //客户编码，string类型
//            //setAttribute(ele,"ccushand",""; //客户联系人手机，string类型
//            //setAttribute(ele,"cpsnophone",""; //业务员办公电话，string类型
//            //setAttribute(ele,"cpsnmobilephone",""; //业务员手机，string类型
//            //setAttribute(ele,"cattachment",""; //附件，string类型
//            //setAttribute(ele,"csscode",""; //结算方式编码，string类型
//            //setAttribute(ele,"cssname",""; //结算方式，string类型
//            //setAttribute(ele, "cinvoicecompany", "00000001"); //"0901"; //开票单位编码，string类型
//            //setAttribute(ele, "cinvoicecompanyabbname", "世纪天华集团公司");// "淘宝"; //开票单位简称，string类型
//            //setAttribute(ele,"ccuspersoncode",""; //联系人编码，string类型
//            //setAttribute(ele,"dclosedate",""; //关闭日期，string类型
//            //setAttribute(ele,"dclosesystime",""; //关闭时间，string类型
//            //setAttribute(ele, "bmustbook", "0"); //必有定金，string类型
//            //setAttribute(ele,"fbookratio",""; //定金比例，string类型
//            //setAttribute(ele,"cgathingcode",""; //收款单号，string类型
//            //setAttribute(ele,"fbooksum",""; //定金原币金额，string类型
//            //setAttribute(ele,"fbooknatsum",""; //定金本币金额，string类型
//            //setAttribute(ele,"fgbooknatsum",""; //定金累计实收本币金额，string类型
//            //setAttribute(ele,"fgbooksum",""; //定金累计实收原币金额，string类型
//            //setAttribute(ele, "ccrmpersonname", "");// "王铭"; //相关员工，string类型
//            //setAttribute(ele,"csysbarcode",""; //单据条码，string类型
//            //setAttribute(ele,"ioppid",""; //销售机会ID，string类型
//            //setAttribute(ele, "contract_status", "1"); //contract_status，string类型
//            //setAttribute(ele,"csvouchtype",""; //来源电商，string类型
//            //setAttribute(ele, "bcashsale", "0"); //现款结算，string类型
//            //setAttribute(ele, "iflowid", ""); //流程id，string类型
//            //setAttribute(ele,"cflowname",""; //流程分支描述，string类型
//            //setAttribute(ele,"cchangeverifier",""; //变更审批人，string类型
//            //setAttribute(ele,"dchangeverifydate",""; //变更审批日期，string类型
//            //setAttribute(ele,"dchangeverifytime",""; //变更审批时间，string类型

//            ///***************************** 以下是非必输字段 ****************************/
//            //setAttribute(ele,"fstockquanO",""; //现存件数，double类型
//            //setAttribute(ele,"fcanusequanO",""; //可用件数，double类型
//            //setAttribute(ele,"iverifystate","0"); //iverifystate，string类型
//            //setAttribute(ele,"ireturncount","0"); //ireturncount，string类型
//            //setAttribute(ele,"icreditstate",""; //icreditstate，string类型
//            //setAttribute(ele, "iswfcontrolled", "0"); //iswfcontrolled，string类型
//            //setAttribute(ele,"dpredatebt",""; //预发货日期，DateTime类型
//            //setAttribute(ele,"dpremodatebt",""; //预完工日期，DateTime类型
//            //setAttribute(ele,"caddcode",""; //收货地址编码，string类型
//            //setAttribute(ele,"cdeliverunit",""; //收货单位，string类型
//            //setAttribute(ele,"ccontactname",""; //收货联系人，string类型
//            //setAttribute(ele,"cofficephone",""; //收货联系电话，string类型
//            //setAttribute(ele,"cmobilephone",""; //收货联系人手机，string类型
//            //setAttribute(ele,"cpayname",""; //付款条件，string类型
//            //setAttribute(ele,"cpersonname",""; //业 务 员，string类型
//            //setAttribute(ele, "iexchrate", "6.3"); //汇率，double类型
//            //setAttribute(ele, "cmemo", "底层API测试"); //备    注，string类型
//            //setAttribute(ele,"cverifier",""; //审核人，string类型
//            //setAttribute(ele,"ccloser",""; //关闭人，string类型
//            //setAttribute(ele,"clocker",""; //锁定人，string类型
//            //setAttribute(ele, "ivtid", "95"); //单据模版号，int类型
//            //setAttribute(ele, "istatus", "1"); //订单状态，string类型
//            //setAttribute(ele,"ccrechppass",""; //信用审核口令，string类型
//            //setAttribute(ele,"clowpricepass",""; //最低售价口令，string类型
//            //setAttribute(ele,"bcontinue",""; //是否继续，string类型
//            //setAttribute(ele,"isumx",""; //价税合计，double类型
//            //setAttribute(ele,"zdsum",""; //整单合计，double类型
//            //setAttribute(ele,"ccusname",""; //客户名称，string类型
//            //setAttribute(ele,"ccusphone",""; //联系电话，string类型
//            //setAttribute(ele,"csccode",""; //发运方式编码，string类型
//            //setAttribute(ele,"cpaycode",""; //付款条件编码，string类型
//            //setAttribute(ele,"ccusperson",""; //联系人，string类型
//            //setAttribute(ele,"coppcode",""; //商机编码，string类型
//            //setAttribute(ele,"ccusaddress",""; //客户地址，string类型
//            //setAttribute(ele, "cpersoncode", "00023");  //业务员编码，string类型
//            //setAttribute(ele,"iarmoney",""; //客户应收余额，double类型
//            //setAttribute(ele,"ccusoaddress",""; //发货地址，string类型
//            //setAttribute(ele,"imoney",""; //定    金，double类型
//            //setAttribute(ele,"cscname",""; //发运方式，string类型
//            //setAttribute(ele,"cchanger",""; //变更人，string类型
//            //setAttribute(ele,"dcreatesystime","2015-10-10"); //制单时间，DateTime类型
//            //setAttribute(ele,"dverifysystime",""; //审核时间，DateTime类型
//            //setAttribute(ele,"dmodifysystime",""; //修改时间，DateTime类型
//            //setAttribute(ele,"cmodifier",""; //修改人，string类型
//            //setAttribute(ele,"dmoddate",""; //修改日期，DateTime类型
//            //setAttribute(ele,"dverifydate",""; //审核日期，DateTime类型
//            //setAttribute(ele,"cdefine16",""; //表头自定义项16，double类型
//            //setAttribute(ele,"ccrechpname",""; //信用审核人，string类型
//            //setAttribute(ele,"ccusdefine1",""; //客户自定义项1，string类型
//            //setAttribute(ele,"ccusdefine2",""; //客户自定义项2，string类型
//            //setAttribute(ele,"ccusdefine3",""; //客户自定义项3，string类型
//            //setAttribute(ele,"ccusdefine4",""; //客户自定义项4，string类型
//            //setAttribute(ele,"zdsumdx",""; //整单合计（大写），string类型
//            //setAttribute(ele,"isumdx",""; //价税合计（大写），string类型
//            //setAttribute(ele,"ccusdefine5",""; //客户自定义项5，string类型
//            //setAttribute(ele,"ccusdefine6",""; //客户自定义项6，string类型
//            //setAttribute(ele,"ccusdefine7",""; //客户自定义项7，string类型
//            //setAttribute(ele,"ccusdefine8",""; //客户自定义项8，string类型
//            //setAttribute(ele,"ccusdefine9",""; //客户自定义项9，string类型
//            //setAttribute(ele,"ccusdefine10",""; //客户自定义项10，string类型
//            //setAttribute(ele,"ccusdefine11",""; //客户自定义项11，string类型
//            //setAttribute(ele,"ccusdefine12",""; //客户自定义项12，string类型
//            //setAttribute(ele,"ccusdefine13",""; //客户自定义项13，string类型
//            //setAttribute(ele,"ccusdefine14",""; //客户自定义项14，string类型
//            //setAttribute(ele,"ccusdefine15",""; //客户自定义项15，string类型
//            //setAttribute(ele,"ccusdefine16",""; //客户自定义项16，string类型
//            //setAttribute(ele,"icuscreline",""; //用户信用度，double类型
//            //setAttribute(ele,"fstockquan",""; //现存数量，double类型
//            //setAttribute(ele,"fcanusequan",""; //可用数量，double类型
//            //setAttribute(ele, "cdefine1","");//表头自定义项1，string类型
//            //setAttribute(ele,"cdefine2",""; //表头自定义项2，string类型
//            //setAttribute(ele,"cdefine3",""; //表头自定义项3，string类型
//            //setAttribute(ele,"cdefine4",""; //表头自定义项4，DateTime类型
//            //setAttribute(ele,"cdefine5",""; //表头自定义项5，int类型
//            //setAttribute(ele,"cdefine6",""; //表头自定义项6，DateTime类型
//            //setAttribute(ele,"cdefine7",""; //表头自定义项7，double类型
//            //setAttribute(ele,"cdefine8",""; //表头自定义项8，string类型
//            //setAttribute(ele,"cdefine9",""; //表头自定义项9，string类型
//            //setAttribute(ele, "cdefine10", "");  //表头自定义项10，string类型
//            //setAttribute(ele,"cdefine11",""; //表头自定义项11，string类型
//            //setAttribute(ele,"cdefine12",""; //表头自定义项12，string类型
//            //setAttribute(ele,"cdefine13",""; //表头自定义项13，string类型
//            //setAttribute(ele,"cdefine14",""; //表头自定义项14，string类型
//            //setAttribute(ele,"cdefine15",""; //表头自定义项15，int类型
//            //setAttribute(ele,"ccreditcuscode",""; //信用单位编码，string类型
//            //setAttribute(ele,"ccreditcusname",""; //信用单位名称，string类型
//            //setAttribute(ele,"cgatheringplan",""; //收付款协议编码，string类型
//            //setAttribute(ele,"cgatheringplanname",""; //收付款协议名称，string类型

//            //broker.AssignNormalValue("domHead", domHead);

//            if (false)
//            {
//                string strErrMsg = "aa";
//                VoucherCO_Sa.ClsVoucherCO_SA obj = new VoucherCO_Sa.ClsVoucherCO_SA();
//                string strUserMode = "CS";
//                //
//                USSAServer.clsSystem clsSAWeb = new USSAServer.clsSystem();
//                if (clsSAWeb.Init(ref g_oLogin, ref strErrMsg) == false)
//                {
//                    if (strErrMsg == null)
//                        strErrMsg = "错误：但是没有出错信息";
//                    MessageBox.Show(strErrMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }
//                object a = new object();
//                a = clsSAWeb;
//                obj.Init(VoucherCO_Sa.VoucherTypeSA.SODetails, ref g_oLogin, ref oCon, ref strUserMode, ref a);
//                //
//                IXMLDOMDocument2 domBodyForLog = new MSXML2.DOMDocument();
//                string strRet = obj.Delete(ref domHead, ref domBodyForLog);
//                MessageBox.Show(strRet);
//            }
//            if (true)
//            {
//                string strErrMsg = "";
//                VoucherCO_Sa.ClsVoucherCO_SA obj = new VoucherCO_Sa.ClsVoucherCO_SA();
//                string strUserMode = "CS";
//                //
//                USSAServer.clsSystem objT = new USSAServer.clsSystem();
//                Type type = objT.GetType();
//                object clsSAWeb = Activator.CreateInstance(type);
//                object[] par = new object[] { g_oLogin, strErrMsg };
//                bool bSuccess = (bool)type.InvokeMember("Init", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, clsSAWeb, par);
//                if (!bSuccess)
//                {
//                    if (strErrMsg == null)
//                        strErrMsg = "错误：但是没有出错信息";
//                    MessageBox.Show(strErrMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }
//                obj.Init(VoucherCO_Sa.VoucherTypeSA.SODetails, ref g_oLogin, ref oCon, ref strUserMode, ref clsSAWeb);
//                //
//                IXMLDOMDocument2 domBodyForLog = new MSXML2.DOMDocument();
//                string strRet = obj.Delete(ref domHead, ref domBodyForLog);
//                MessageBox.Show(strRet);
//            }
//        }
//        #endregion

//        #region 空白发货单
//        public void ToYYFHD()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2015-01-26");
//            string sSubId = "AS";
//            string sAccID = "999";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_999_2014;Timeout=60";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from DispatchList where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "dlid", "0"); //主关键字段，int类型
//            setAttribute(ele, "cdlcode", "0000000105"); //发货单号，string类型
//            setAttribute(ele, "ddate", dtCreateDate.ToString("yyyy-MM-dd")); //发货日期，DateTime类型
//            setAttribute(ele, "cbustype", "普通销售"); //业务类型，int类型
//            setAttribute(ele, "cstname", "直运销售"); //表SaleType 销售类型，string类型
//            setAttribute(ele, "ccusabbname", "世纪天华集团公司"); //表Customer 客户简称，string类型
//            setAttribute(ele, "cdepname", "销售部"); //表Department销售部门，string类型
//            setAttribute(ele, "cstcode", "02"); //销售类型编码，string类型
//            //domHead[0]["separateid"] = ""; //分拣号，string类型
//            //domHead[0]["cchangememo"] = ""; //变更原因，string类型
//            setAttribute(ele, "bsigncreate", "0"); //签回损失生成，string类型
//            //domHead[0]["cinvoicecompany"] = "000"; //开票单位编码，string类型
//            //domHead[0]["cinvoicecompanyabbname"] = "000"; //开票单位简称，string类型
//            //domHead[0]["febweight"] = ""; //重量，string类型
//            //domHead[0]["cebweightunit"] = ""; //重量单位，string类型
//            //domHead[0]["cebexpresscode"] = ""; //快递单号，string类型
//            //domHead[0]["iebexpresscoid"] = ""; //物流公司ID，string类型
//            //domHead[0]["cexpressconame"] = ""; //物流公司名称，string类型
//            //domHead[0]["iflowid"] = ""; //流程id，string类型
//            //domHead[0]["cflowname"] = ""; //流程分支描述，string类型
//            setAttribute(ele, "bcashsale", "0"); //现款结算，string类型
//            //domHead[0]["cgathingcode"] = ""; //收款单号，string类型
//            //domHead[0]["cchanger"] = ""; //变更人，string类型
//            //domHead[0]["ccushand"] = ""; //客户联系人手机，string类型
//            //domHead[0]["cpsnophone"] = ""; //业务员办公电话，string类型
//            //domHead[0]["cpsnmobilephone"] = ""; //业务员手机，string类型
//            //domHead[0]["ccuspersoncode"] = ""; //联系人编码，string类型
//            //domHead[0]["brequestsign"] = ""; //需要签回，string类型
//            setAttribute(ele, "bmustbook", "0"); //必有定金，string类型
//            setAttribute(ele, "baccswitchflag", "0"); //存货核算切换选项，string类型
//            //domHead[0]["dsverifydate"] = ""; //来源单据审核日期，string类型
//            //domHead[0]["csourcecode"] = ""; //来源单据号，string类型
//            //domHead[0]["csscode"] = ""; //结算方式编码，string类型
//            //domHead[0]["cssname"] = ""; //结算方式，string类型
//            //domHead[0]["csysbarcode"] = ""; //单据条码，string类型
//            setAttribute(ele, "bsaleoutcreatebill", "0"); //出库单开发票，string类型
//            setAttribute(ele, "bnottogoldtax", "0"); //bnottogoldtax，string类型

//            /***************************** 以下是非必输字段 ****************************/
//            //domHead[0]["caddcode"] = ""; //收货地址编码，string类型
//            //domHead[0]["cdeliverunit"] = ""; //收货单位，string类型
//            //domHead[0]["ccontactname"] = ""; //收货联系人，string类型
//            //domHead[0]["cofficephone"] = ""; //收货联系电话，string类型
//            //domHead[0]["cmobilephone"] = ""; //收货联系人手机，string类型
//            //domHead[0]["fstockquanO"] = ""; //现存件数，double类型
//            //domHead[0]["fcanusequanO"] = ""; //可用件数，double类型
//            //domHead[0]["iverifystate"] = ""; //iverifystate，string类型
//            //domHead[0]["ireturncount"] = ""; //ireturncount，string类型
//            //domHead[0]["icreditstate"] = ""; //icreditstate，string类型
//            //domHead[0]["iswfcontrolled"] = ""; //iswfcontrolled，string类型
//            //domHead[0]["csocode"] = ""; //订单号，string类型
//            //domHead[0]["csbvcode"] = ""; //发票号，string类型
//            //domHead[0]["cpersonname"] = ""; //业 务 员，string类型
//            //domHead[0]["cshipaddress"] = ""; //发货地址，string类型
//            //domHead[0]["cscname"] = ""; //发运方式，string类型
//            //domHead[0]["cpayname"] = ""; //付款条件，string类型
//            //domHead[0]["itaxrate"] = ""; //税率，double类型
//            setAttribute(ele, "cexch_name", "人民币"); //币种，string类型
//            setAttribute(ele, "iexchrate", "1"); //汇率，double类型
//            setAttribute(ele, "cmemo", "底层API测试"); //备    注，string类型
//            setAttribute(ele, "cmaker", "demo"); //制单人，string类型
//            //domHead[0]["cverifier"] = ""; //审核人，string类型
//            //domHead[0]["ccloser"] = ""; //关闭人，string类型
//            //domHead[0]["ccuspaycond"] = ""; //客户付款条件，string类型
//            setAttribute(ele, "sbvid", "0"); //销售发票ID，string类型
//            setAttribute(ele, "isale", "0"); //是否先发货，string类型
//            setAttribute(ele, "ivtid", "71"); //单据模版号，int类型
//            setAttribute(ele, "ccusname", "世纪天华集团公司"); //客户名称，string类型
//            //domHead[0]["ccusphone"] = ""; //联系电话，string类型
//            //domHead[0]["ccusperson"] = ""; //联系人，string类型
//            //domHead[0]["ccuspostcode"] = ""; //邮政编码，string类型
//            //domHead[0]["icuscreline"] = ""; //用户信用度，double类型
//            //domHead[0]["ccusaddress"] = ""; //客户地址，string类型
//            //domHead[0]["iarmoney"] = ""; //客户应收余额，double类型
//            //domHead[0]["cpersoncode"] = ""; //业务员编码，string类型
//            setAttribute(ele, "bfirst", "0"); //期初标志，string类型
//            setAttribute(ele, "cdepcode", "0302"); //部门编码，string类型
//            //domHead[0]["cvouchname"] = ""; //单据类型名称，int类型
//            setAttribute(ele, "cvouchtype", "05"); //单据类型编码，string类型
//            //domHead[0]["cmodifier"] = ""; //修改人，string类型
//            //domHead[0]["dmoddate"] = ""; //修改日期，DateTime类型
//            //domHead[0]["dverifydate"] = ""; //审核日期，DateTime类型
//            //domHead[0]["csvouchtype"] = ""; //csvouchtype，string类型
//            //domHead[0]["dcreatesystime"] = ""; //制单时间，DateTime类型
//            //domHead[0]["dverifysystime"] = ""; //审核时间，DateTime类型
//            //domHead[0]["dmodifysystime"] = ""; //修改时间，DateTime类型
//            setAttribute(ele, "ccuscode", "00000001"); //客户编码，string类型
//            //domHead[0]["csccode"] = ""; //发运方式编码，string类型
//            //domHead[0]["cpaycode"] = ""; //付款条件编码，string类型
//            setAttribute(ele, "breturnflag", "0"); //退货标识，string类型
//            //domHead[0]["brefdisp"] = ""; //单据来源，string类型
//            //domHead[0]["ccrechpname"] = ""; //信用审核人，string类型
//            //domHead[0]["fstockquan"] = ""; //现存数量，double类型
//            //domHead[0]["fcanusequan"] = ""; //可用数量，double类型
//            //domHead[0]["ccusdefine1"] = ""; //客户自定义项1，string类型
//            //domHead[0]["ccusdefine2"] = ""; //客户自定义项2，string类型
//            //domHead[0]["ccusdefine3"] = ""; //客户自定义项3，string类型
//            //domHead[0]["ccusdefine4"] = ""; //客户自定义项4，string类型
//            //domHead[0]["ccusdefine5"] = ""; //客户自定义项5，string类型
//            //domHead[0]["ccusdefine6"] = ""; //客户自定义项6，string类型
//            //domHead[0]["ccusdefine7"] = ""; //客户自定义项7，string类型
//            //domHead[0]["ccusdefine8"] = ""; //客户自定义项8，string类型
//            //domHead[0]["ccusdefine9"] = ""; //客户自定义项9，string类型
//            //domHead[0]["ccusdefine10"] = ""; //客户自定义项10，string类型
//            //domHead[0]["ccusdefine11"] = ""; //客户自定义项11，string类型
//            //domHead[0]["ccusdefine12"] = ""; //客户自定义项12，string类型
//            //domHead[0]["ccusdefine13"] = ""; //客户自定义项13，string类型
//            //domHead[0]["ccusdefine14"] = ""; //客户自定义项14，string类型
//            //domHead[0]["ccusdefine15"] = ""; //客户自定义项15，string类型
//            //domHead[0]["ccusdefine16"] = ""; //客户自定义项16，string类型
//            //domHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //domHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //domHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            //domHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型
//            //domHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//            //domHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//            //domHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//            //domHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//            //domHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//            //domHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//            //domHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //domHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //domHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //domHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //domHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//            //domHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//            //domHead[0]["ufts"] = ""; //时间戳，string类型
//            //domHead[0]["zdsumdx"] = ""; //整单合计（大写），string类型
//            //domHead[0]["isumdx"] = ""; //价税合计（大写），string类型
//            //domHead[0]["zdsum"] = ""; //整单合计，double类型
//            //domHead[0]["isumx"] = ""; //价税合计，double类型
//            //domHead[0]["ccrechppass"] = ""; //信用审核口令，string类型
//            //domHead[0]["clowpricepass"] = ""; //最低售价口令，string类型
//            setAttribute(ele, "bcredit", "0"); //是否为立账单据，int类型
//            //domHead[0]["ccreditcuscode"] = ""; //信用单位编码，string类型
//            //domHead[0]["ccreditcusname"] = ""; //信用单位名称，string类型
//            //domHead[0]["cgatheringplan"] = ""; //收付款协议编码，string类型
//            //domHead[0]["cgatheringplanname"] = ""; //收付款协议名称，string类型
//            //domHead[0]["dcreditstart"] = ""; //立账日，DateTime类型
//            //domHead[0]["dgatheringdate"] = ""; //到期日，DateTime类型
//            //domHead[0]["icreditdays"] = ""; //账期，int类型
//            //domHead[0]["bcontinue"] = ""; //是否继续，string类型

//            //broker.AssignNormalValue("domHead", domHead);

//            //给BO表体参数domBody赋值，此BO参数的业务类型为销售订单，属表体参数。BO参数均按引用传递
//            //提示：给BO表体参数domBody赋值有两种方法

//            //方法一是直接传入MSXML2.DOMDocumentClass对象
//            //broker.AssignNormalValue("domBody", new MSXML2.DOMDocumentClass())
//            strSQL = "select * from DispatchLists where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domBody, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();
//            rs = null;

//            //增加表体数据节点z:row
//            eleBody = domBody.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domBody = broker.GetBoParam("domBody");
//            //domBody.RowCount = 1; //设置BO对象行数
//            //可以自由设置BO对象行数为大于零的整数，也可以不设置而自动增加行数
//            //给BO对象的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            decimal decQuantity = 20.00M;
//            //含税单价
//            decimal decprice = 10.00M;
//            //含税金额
//            decimal decamount = decimal.Round(decQuantity * decprice, 2);
//            //税率
//            decimal decTaxRate = 0.00M;
//            //不含税金额
//            decimal decNotTaxAmount = decimal.Round(decamount / (1 + decTaxRate), 2);
//            if (decTaxRate == 0)
//                decNotTaxAmount = decamount;
//            //不含税单价
//            decimal decNotTaxPrice = decimal.Round(decNotTaxAmount / decQuantity, 2);
//            if (decTaxRate == 0)
//                decNotTaxPrice = decprice;
//            //税额
//            decimal decTax = decamount - decNotTaxAmount;

//            ele = domBody.createElement("z:row");
//            eleBody.appendChild(ele);

//            setAttribute(ele, "idlsid", "0"); //这个值是什么意思？主关键字段，0类型
//            setAttribute(ele, "cinvname", "桌面PC"); //表Inventory存货名称，string类型
//            setAttribute(ele, "cinvcode", "0301"); //存货编码，string类型
//            setAttribute(ele, "iquantity", "1"); //数量，double类型
//            setAttribute(ele, "editprop", "A"); //编辑属性：A表新增，M表修改，D表删除，string类型
//            //domBody[0]["fstockquano"] = ""; //现存件数，string类型
//            //domBody[0]["fcanusequano"] = ""; //可用件数，string类型
//            setAttribute(ele, "bneedsign", "0"); //需要签回，string类型
//            setAttribute(ele, "bsignover", "0"); //发货签回完成，string类型
//            setAttribute(ele, "bneedloss", "0"); //需要损失处理，string类型
//            //domBody[0]["flossrate"] = ""; //发货合理损耗率，string类型
//            //domBody[0]["frlossqty"] = ""; //合理损耗数量，string类型
//            //domBody[0]["fulossqty"] = ""; //非合理损耗数量，string类型
//            //domBody[0]["isettletype"] = ""; //责任承担处理，string类型
//            //domBody[0]["crelacuscode"] = ""; //责任客户编码，string类型
//            //domBody[0]["crelacusname"] = ""; //责任客户名称，string类型
//            //domBody[0]["creasoncode"] = ""; //退货原因编码，string类型
//            //domBody[0]["creasonname"] = ""; //退货原因，string类型
//            //domBody[0]["iinvsncount"] = ""; //序列号个数，string类型
//            //domBody[0]["bserial"] = ""; //序列号管理，string类型
//            setAttribute(ele, "cmemo", ""); //备注，string类型
//            //domBody[0]["binvmodel"] = ""; //是否模型件，string类型
//            //domBody[0]["btracksalebill"] = ""; //PE跟单，string类型
//            //domBody[0]["cinvouchtype"] = ""; //cinvouchtype，string类型
//            //domBody[0]["dkeepdate"] = ""; //记账日期，string类型
//            //domBody[0]["cscloser"] = ""; //行关闭人，string类型
//            //domBody[0]["fcanusequan"] = ""; //可用量，string类型
//            //domBody[0]["fstockquan"] = ""; //现存量，string类型
//            setAttribute(ele, "bsaleprice", "1"); //报价含税，string类型
//            setAttribute(ele, "bgift", "0"); //赠品，string类型
//            //domBody[0]["autoid2"] = ""; //序列号行号，string类型
//            //cqz setAttribute(ele,"cvencode", "03003"); //这个值是怎么来的？入库单供应商编码，string类型
//            setAttribute(ele, "irowno", "1"); //行号，string类型
//            //domBody[0]["snlist"] = ""; //序列号，string类型
//            setAttribute(ele, "bmpforderclosed", "0"); //是否订单关闭，string类型
//            //domBody[0]["cbsysbarcode"] = ""; //单据行条码，string类型
//            //domBody[0]["fxjquantity"] = ""; //已拣货量，string类型
//            //domBody[0]["fxjnum"] = ""; //已拣货件数，string类型
//            //domBody[0]["bptomodel"] = ""; //bptomodel，string类型
//            setAttribute(ele, "cparentcode", ""); //父节点编码，string类型
//            //domBody[0]["cchildcode"] = ""; //子节点编码，string类型
//            //domBody[0]["icalctype"] = ""; //发货模式，string类型
//            //domBody[0]["fchildqty"] = ""; //使用数量，string类型
//            //domBody[0]["fchildrate"] = ""; //权重比例，string类型
//            //domBody[0]["crtnappcode"] = ""; //退货申请单号，string类型
//            //domBody[0]["irtnappid"] = ""; //退货申请单id，string类型
//            //domBody[0]["taskguid"] = ""; //退货申请单id，string类型
//            //domBody[0]["fappretwkpqty"] = ""; //未开票退货申请数量，string类型
//            //domBody[0]["fappretwkpsum"] = ""; //未开票退货申请金额，string类型
//            //domBody[0]["fappretykpqty"] = ""; //已开票退货申请数量，string类型
//            //domBody[0]["fappretykpsum"] = ""; //已开票退货申请金额，string类型

//            /***************************** 以下是非必输字段 ****************************/
//            //domBody[0]["cwhname"] = ""; //仓库名称，string类型
//            setAttribute(ele, "autoid", "0"); //自动编号，string类型
//            //domBody[0]["ccontractid"] = ""; //合同编码，string类型
//            //domBody[0]["ccontractrowguid"] = ""; //合同标的RowGuid，string类型
//            //domBody[0]["ccontracttagcode"] = ""; //合同标的编码，string类型
//            //domBody[0]["csettleall"] = ""; //关闭标志，int类型
//            //domBody[0]["cinvstd"] = ""; //规格型号，string类型
//            //domBody[0]["ippartqty"] = ""; //母件数量，string类型
//            //domBody[0]["ippartid"] = ""; //母件物料ID，string类型
//            //domBody[0]["batomodel"] = ""; //是否ATO件，int类型
//            //domBody[0]["ippartseqid"] = ""; //选配序号，string类型
//            setAttribute(ele, "cmassunit", "0"); //保质期单位，int类型
//            setAttribute(ele, "cwhcode", "03"); //仓库编码，string类型
//            //domBody[0]["inum"] = ""; //件数，double类型
//            //domBody[0]["itaxunitprice"] = ""; //含税单价，double类型
//            //domBody[0]["iunitprice"] = ""; //无税单价，double类型
//            //domBody[0]["isettlenum"] = ""; //开票金额，double类型
//            //domBody[0]["isettlequantity"] = ""; //开票数量，double类型
//            //domBody[0]["iquotedprice"] = ""; //报价，double类型
//            //domBody[0]["imoney"] = ""; //无税金额，double类型
//            //domBody[0]["itax"] = ""; //税额，double类型
//            //domBody[0]["isum"] = ""; //价税合计，double类型
//            //domBody[0]["cfree1"] = ""; //自由项1，string类型
//            //domBody[0]["cfree2"] = ""; //自由项2，string类型
//            //domBody[0]["idiscount"] = ""; //折扣额，double类型
//            setAttribute(ele, "dlid", "0"); //这个值是什么意思？发货单 38，int类型
//            //domBody[0]["icorid"] = ""; //原发货单ID，int类型
//            //domBody[0]["inatunitprice"] = ""; //本币单价，double类型
//            //domBody[0]["inatmoney"] = ""; //本币金额，double类型
//            //domBody[0]["inattax"] = ""; //本币税额，double类型
//            //domBody[0]["inatsum"] = ""; //本币价税合计，double类型
//            //domBody[0]["inatdiscount"] = ""; //本币折扣额，double类型
//            //domBody[0]["iinvlscost"] = ""; //最低售价，double类型
//            //domBody[0]["ibatch"] = ""; //批次，string类型
//            setAttribute(ele, "itaxrate", "17"); //税率（％），double类型
//            //domBody[0]["bfree1"] = ""; //是否有自由项1，string类型
//            //domBody[0]["bfree2"] = ""; //是否有自由项2，string类型
//            //domBody[0]["bfree3"] = ""; //是否有自由项3，string类型
//            //domBody[0]["bfree4"] = ""; //是否有自由项4，string类型
//            //domBody[0]["bfree5"] = ""; //是否有自由项5，string类型
//            //domBody[0]["bfree6"] = ""; //是否有自由项6，string类型
//            //domBody[0]["bfree7"] = ""; //是否有自由项7，string类型
//            //domBody[0]["bfree8"] = ""; //是否有自由项8，string类型
//            //domBody[0]["bfree9"] = ""; //是否有自由项9，string类型
//            //domBody[0]["bfree10"] = ""; //是否有自由项10，string类型
//            //domBody[0]["cbatch"] = ""; //批号，string类型
//            //domBody[0]["cinvdefine1"] = ""; //存货自定义项1，string类型
//            //domBody[0]["cexpirationdate"] = ""; //有效期至，string类型
//            setAttribute(ele, "iexpiratdatecalcu", "0"); //有效期推算方式，int类型
//            //domBody[0]["dexpirationdate"] = ""; //有效期计算项，string类型
//            //domBody[0]["bsalepricefree1"] = ""; //是否自由项定价1，string类型
//            //domBody[0]["bsalepricefree2"] = ""; //是否自由项定价2，string类型
//            //domBody[0]["bsalepricefree3"] = ""; //是否自由项定价3，string类型
//            //domBody[0]["bsalepricefree4"] = ""; //是否自由项定价4，string类型
//            //domBody[0]["bsalepricefree5"] = ""; //是否自由项定价5，string类型
//            //domBody[0]["bsalepricefree6"] = ""; //是否自由项定价6，string类型
//            //domBody[0]["bsalepricefree7"] = ""; //是否自由项定价7，string类型
//            //domBody[0]["bsalepricefree8"] = ""; //是否自由项定价8，string类型
//            //domBody[0]["bsalepricefree9"] = ""; //是否自由项定价9，string类型
//            //domBody[0]["bsalepricefree10"] = ""; //是否自由项定价10，string类型
//            //domBody[0]["idemandtype"] = ""; //需求跟踪方式，int类型
//            //domBody[0]["cdemandcode"] = ""; //需求跟踪号，string类型
//            //domBody[0]["cdemandmemo"] = ""; //需求分类说明，string类型
//            //domBody[0]["cdemandid"] = ""; //需求跟踪id，string类型
//            //domBody[0]["idemandseq"] = ""; //需求跟踪行号，string类型
//            //domBody[0]["cbatchproperty1"] = ""; //批次属性1，double类型
//            //domBody[0]["cbatchproperty2"] = ""; //批次属性2，double类型
//            //domBody[0]["cbatchproperty3"] = ""; //批次属性3，double类型
//            //domBody[0]["cbatchproperty4"] = ""; //批次属性4，double类型
//            //domBody[0]["cbatchproperty5"] = ""; //批次属性5，double类型
//            //domBody[0]["cbatchproperty6"] = ""; //批次属性6，string类型
//            //domBody[0]["cbatchproperty7"] = ""; //批次属性7，string类型
//            //domBody[0]["cbatchproperty8"] = ""; //批次属性8，string类型
//            //domBody[0]["cbatchproperty9"] = ""; //批次属性9，string类型
//            //domBody[0]["cbatchproperty10"] = ""; //批次属性10，DateTime类型
//            //domBody[0]["bbatchproperty1"] = ""; //是否启用批次属性1，string类型
//            //domBody[0]["bbatchproperty2"] = ""; //是否启用批次属性2，string类型
//            //domBody[0]["bbatchproperty3"] = ""; //是否启用批次属性3，string类型
//            //domBody[0]["bbatchproperty4"] = ""; //是否启用批次属性4，string类型
//            //domBody[0]["bbatchproperty5"] = ""; //是否启用批次属性5，string类型
//            //domBody[0]["bbatchproperty6"] = ""; //是否启用批次属性6，string类型
//            //domBody[0]["bbatchproperty7"] = ""; //是否启用批次属性7，string类型
//            //domBody[0]["bbatchproperty8"] = ""; //是否启用批次属性8，string类型
//            //domBody[0]["bbatchproperty9"] = ""; //是否启用批次属性9，string类型
//            //domBody[0]["bbatchproperty10"] = ""; //是否启用批次属性10，string类型
//            //domBody[0]["bbatchcreate"] = ""; //批次属性是否建档，string类型
//            //domBody[0]["cinvdefine4"] = ""; //存货自定义项4，string类型
//            //domBody[0]["cinvdefine5"] = ""; //存货自定义项5，string类型
//            //domBody[0]["cinvdefine6"] = ""; //存货自定义项6，string类型
//            //domBody[0]["cinvdefine7"] = ""; //存货自定义项7，string类型
//            //domBody[0]["cinvdefine8"] = ""; //存货自定义项8，string类型
//            //domBody[0]["cinvdefine9"] = ""; //存货自定义项9，string类型
//            //domBody[0]["cinvdefine10"] = ""; //存货自定义项10，string类型
//            //domBody[0]["cinvdefine11"] = ""; //存货自定义项11，string类型
//            //domBody[0]["cinvdefine12"] = ""; //存货自定义项12，string类型
//            //domBody[0]["cinvdefine13"] = ""; //存货自定义项13，string类型
//            //domBody[0]["cinvdefine14"] = ""; //存货自定义项14，string类型
//            //domBody[0]["cinvdefine15"] = ""; //存货自定义项15，string类型
//            //domBody[0]["cinvdefine16"] = ""; //存货自定义项16，string类型
//            //domBody[0]["cinvdefine2"] = ""; //存货自定义项2，string类型
//            //domBody[0]["cinvdefine3"] = ""; //存货自定义项3，string类型
//            //domBody[0]["binvtype"] = ""; //存货类型，string类型
//            setAttribute(ele, "itb", "0"); //退补标志，int类型
//            //domBody[0]["dvdate"] = ""; //失效日期，DateTime类型
//            //domBody[0]["cdefine22"] = ""; //表体自定义项1，string类型
//            //domBody[0]["cdefine23"] = ""; //表体自定义项2，string类型
//            //domBody[0]["cdefine24"] = ""; //表体自定义项3，string类型
//            //domBody[0]["cdefine25"] = ""; //表体自定义项4，string类型
//            //domBody[0]["cdefine26"] = ""; //表体自定义项5，double类型
//            //domBody[0]["cdefine27"] = ""; //表体自定义项6，double类型
//            //domBody[0]["kl2"] = ""; //扣率2（％），double类型
//            //domBody[0]["isosid"] = ""; //对应订单子表ID，int类型
//            //domBody[0]["citemcode"] = ""; //项目编码，string类型
//            //domBody[0]["citem_class"] = ""; //项目大类编码，string类型
//            //domBody[0]["csocode"] = ""; //订单号，string类型
//            //domBody[0]["iinvweight"] = ""; //单位重量，double类型
//            //domBody[0]["dkl1"] = ""; //倒扣1（％），double类型
//            //domBody[0]["dkl2"] = ""; //倒扣2（％），double类型
//            //domBody[0]["cvenabbname"] = ""; //产地，string类型
//            //domBody[0]["fsalecost"] = ""; //零售单价，double类型
//            //domBody[0]["fsaleprice"] = ""; //零售金额，double类型
//            //domBody[0]["citemname"] = ""; //项目名称，string类型
//            //domBody[0]["citem_cname"] = ""; //项目大类名称，string类型
//            //domBody[0]["cfree3"] = ""; //自由项3，string类型
//            //domBody[0]["cfree4"] = ""; //自由项4，string类型
//            //domBody[0]["cfree5"] = ""; //自由项5，string类型
//            //domBody[0]["cfree6"] = ""; //自由项6，string类型
//            //domBody[0]["cfree7"] = ""; //自由项7，string类型
//            //domBody[0]["cfree8"] = ""; //自由项8，string类型
//            //domBody[0]["cfree9"] = ""; //自由项9，string类型
//            //domBody[0]["cfree10"] = ""; //自由项10，string类型
//            //domBody[0]["corufts"] = ""; //对应单据时间戳，string类型
//            //domBody[0]["inufts"] = ""; //入库单时间戳，string类型
//            //domBody[0]["iretquantity"] = ""; //退货数量，double类型
//            //domBody[0]["iinvexchrate"] = ""; //换算率，double类型
//            //domBody[0]["cunitid"] = ""; //销售单位编码，string类型
//            //domBody[0]["cinva_unit"] = ""; //销售单位，string类型
//            //domBody[0]["cinvm_unit"] = ""; //主计量单位，string类型
//            setAttribute(ele, "cgroupcode", "01"); //表Inventory.cgroupcode 计量单位组，string类型
//            setAttribute(ele, "igrouptype", "0"); //表Inventory.igrouptype 单位类型，uint类型
//            //domBody[0]["cdefine28"] = ""; //表体自定义项7，string类型
//            //domBody[0]["cdefine29"] = ""; //表体自定义项8，string类型
//            //domBody[0]["cdefine30"] = ""; //表体自定义项9，string类型
//            //domBody[0]["cdefine31"] = ""; //表体自定义项10，string类型
//            //domBody[0]["cdefine32"] = ""; //表体自定义项11，string类型
//            //domBody[0]["cdefine33"] = ""; //表体自定义项12，string类型
//            //domBody[0]["fsumsignquantity"] = ""; //累计签回数量，double类型
//            //domBody[0]["cvmivencode"] = ""; //供货商编码，string类型
//            //domBody[0]["cvmivenname"] = ""; //供货商名称，string类型
//            //domBody[0]["cordercode"] = ""; //订单号，string类型
//            //domBody[0]["iorderrowno"] = ""; //订单行号，string类型
//            //domBody[0]["fcusminprice"] = ""; //客户最低售价，double类型
//            //domBody[0]["imoneysum"] = ""; //累计本币收款金额，double类型
//            //domBody[0]["iexchsum"] = ""; //累计原币收款金额，double类型
//            //domBody[0]["cdefine34"] = ""; //表体自定义项13，int类型
//            //domBody[0]["fsumsignnum"] = ""; //累计签回件数，double类型
//            //domBody[0]["cdefine35"] = ""; //表体自定义项14，int类型
//            //domBody[0]["cdefine36"] = ""; //表体自定义项15，DateTime类型
//            //domBody[0]["funsignquantity"] = ""; //可签收数量，double类型
//            //domBody[0]["funsignnum"] = ""; //可签收件数，double类型
//            //domBody[0]["cdefine37"] = ""; //表体自定义项16，DateTime类型
//            //domBody[0]["dmdate"] = ""; //生产日期，DateTime类型
//            setAttribute(ele, "bgsp", "0"); //是否gsp检验，int类型
//            //domBody[0]["imassdate"] = ""; //保质期，int类型
//            //domBody[0]["binvquality"] = ""; //是否保质期管理，int类型
//            //domBody[0]["ccode"] = ""; //入库单号，string类型
//            //domBody[0]["btrack"] = ""; //是否追踪，int类型
//            //domBody[0]["bproxywh"] = ""; //是否代管仓，int类型
//            //domBody[0]["bisstqc"] = ""; //库存期初，int类型
//            //domBody[0]["csrpolicy"] = ""; //供需政策，string类型
//            //domBody[0]["cinvaddcode"] = ""; //存货代码，string类型
//            //domBody[0]["iqanum"] = ""; //检验合格件数，double类型
//            //domBody[0]["iqaquantity"] = ""; //检验合格数量，double类型
//            //domBody[0]["ccusinvcode"] = ""; //客户存货编码，string类型
//            //domBody[0]["ccusinvname"] = ""; //客户存货名称，string类型
//            //domBody[0]["bqachecking"] = ""; //是否在检，int类型
//            //domBody[0]["bqaneedcheck"] = ""; //是否质量检验，int类型
//            //domBody[0]["bqachecked"] = ""; //是否报检，int类型
//            //domBody[0]["bqaurgency"] = ""; //是否急料，int类型
//            //domBody[0]["cbaccounter"] = ""; //记账人，string类型
//            //domBody[0]["binvbatch"] = ""; //是否批次管理，string类型
//            //domBody[0]["bsettleall"] = ""; //结算标志，string类型
//            //domBody[0]["bservice"] = ""; //是否应税劳务，string类型
//            //domBody[0]["kl"] = ""; //扣率（％），double类型
//            //

//            //domHead.loadXML(strH);
//            //domBody.loadXML(strB);

//            if (true)
//            {
//                string strErrMsg = "aa";
//                VoucherCO_Sa.ClsVoucherCO_SA obj = new VoucherCO_Sa.ClsVoucherCO_SA();
//                string strUserMode = "CS";
//                //
//                USSAServer.clsSystem clsSAWeb = new USSAServer.clsSystem();
//                if (clsSAWeb.Init(ref g_oLogin, ref strErrMsg) == false)
//                {
//                    if (strErrMsg == null)
//                        strErrMsg = "错误：但是没有出错信息";
//                    MessageBox.Show(strErrMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }
//                object a = new object();
//                a = clsSAWeb;
//                obj.Init(VoucherCO_Sa.VoucherTypeSA.DispatchBlue, ref g_oLogin, ref oCon, ref strUserMode, ref a);
//                //
//                short VoucherState = 0;//增加
//                object vNewID = "";
//                IXMLDOMDocument2 DomConfig = new MSXML2.DOMDocument();
//                string strRet = obj.Save(domHead, domBody, VoucherState, ref vNewID, ref DomConfig);
//                MessageBox.Show(strRet);
//            }
//            if (false)
//            {
//                string strErrMsg = "";
//                VoucherCO_Sa.ClsVoucherCO_SA obj = new VoucherCO_Sa.ClsVoucherCO_SA();
//                string strUserMode = "CS";
//                //
//                USSAServer.clsSystem objT = new USSAServer.clsSystem();
//                Type type = objT.GetType();
//                object clsSAWeb = Activator.CreateInstance(type);
//                object[] par = new object[] { g_oLogin, strErrMsg };
//                bool bSuccess = (bool)type.InvokeMember("Init", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, clsSAWeb, par);
//                if (!bSuccess)
//                {
//                    if (strErrMsg == null)
//                        strErrMsg = "错误：但是没有出错信息";
//                    MessageBox.Show(strErrMsg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }
//                obj.Init(VoucherCO_Sa.VoucherTypeSA.SODetails, ref g_oLogin, ref oCon, ref strUserMode, ref clsSAWeb);
//                //
//                short VoucherState = 0;//增加
//                object vNewID = "";
//                IXMLDOMDocument2 DomConfig = new MSXML2.DOMDocument();
//                string strRet = obj.Save(domHead, domBody, VoucherState, ref vNewID, ref DomConfig);
//                MessageBox.Show(strRet);
//            }
//        }
//        #endregion

//        #region 采购订单
//        public void ToYYStockPact()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2015-01-26");
//            string sSubId = "AS";
//            string sAccID = "999";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=Sa1;Initial Catalog=UFDATA_999_2014;Timeout=60";
//            strConn = "data source=127.0.0.1;user id=sa;password=huzhijin123@;initial catalog=UFDATA_999_2014;Connect Timeout=30;Persist Security Info=True";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from zpurpoheader where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "poid", "0"); //主关键字段，int类型
//            setAttribute(ele, "cbustype", "普通采购"); //业务类型，int类型
//            setAttribute(ele, "dpodate", dtCreateDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
//            setAttribute(ele, "cpoid", "0000000041"); //订单编号，string类型
//            setAttribute(ele, "cvenabbname", "辰环手机配件"); //供货单位，string类型
//            setAttribute(ele, "cexch_name", "人民币"); //币种，string类型
//            setAttribute(ele, "nflat", "1"); //汇率，double类型
//            setAttribute(ele, "cmaker", "demo"); //制单人，string类型
//            setAttribute(ele, "cvencode", "01002"); //供货单位编号，string类型
//            //DomHead[0]["ufts"] = ""; //时间戳，string类型
//            setAttribute(ele, "idiscounttaxtype", "0"); //扣税类别，int类型
//            //DomHead[0]["contractcodet"] = ""; //合同号，string类型
//            //DomHead[0]["iflowid"] = ""; //流程ID，string类型
//            //DomHead[0]["cflowname"] = ""; //流程模式描述，string类型
//            //DomHead[0]["dclosetime"] = ""; //关闭时间，string类型
//            //DomHead[0]["dclosedate"] = ""; //关闭日期，string类型
//            //DomHead[0]["ccontactcode"] = ""; //供方联系人编码，string类型
//            //DomHead[0]["cmobilephone"] = ""; //供方联系人手机号，string类型
//            //DomHead[0]["cappcode"] = ""; //请购单号，string类型
//            //DomHead[0]["csysbarcode"] = ""; //单据条码，string类型
//            //DomHead[0]["cchangverifier"] = ""; //变更审批人，string类型
//            //DomHead[0]["cchangaudittime"] = ""; //变更审批时间，string类型
//            //DomHead[0]["cchangauditdate"] = ""; //变更审批日期，string类型
//            //DomHead[0]["controlresult"] = ""; //controlresult，string类型
//            //DomHead[0]["ibg_overflag"] = ""; //预算审批状态，string类型
//            //DomHead[0]["cbg_auditor"] = ""; //预算审批人，string类型
//            //DomHead[0]["cbg_audittime"] = ""; //预算审批时间，string类型

//            /***************************** 以下是非必输字段 ****************************/
//            //DomHead[0]["ipresent"] = ""; //现存量，string类型
//            //DomHead[0]["cmaketime"] = ""; //制单时间，DateTime类型
//            //DomHead[0]["cmodifytime"] = ""; //修改时间，DateTime类型
//            //DomHead[0]["caudittime"] = ""; //审核时间，DateTime类型
//            //DomHead[0]["cauditdate"] = ""; //审核日期，DateTime类型
//            //DomHead[0]["cmodifydate"] = ""; //修改日期，DateTime类型
//            //DomHead[0]["creviser"] = ""; //修改人，string类型
//            //DomHead[0]["cptname"] = ""; //采购类型，string类型
//            //DomHead[0]["cvenname"] = ""; //供应商全称，string类型
//            //DomHead[0]["iverifystateex"] = ""; //审核状态，string类型
//            //DomHead[0]["ireturncount"] = ""; //打回次数，string类型
//            //DomHead[0]["iswfcontrolled"] = "0"; //是否启用工作流，string类型
//            //DomHead[0]["cdepname"] = ""; //部门，string类型
//            //DomHead[0]["cpersonname"] = ""; //业务员，string类型
//            setAttribute(ele, "itaxrate", "17"); //税率，double类型
//            //DomHead[0]["cpayname"] = ""; //付款条件，string类型
//            setAttribute(ele, "cmemo", "底层API测试"); //备注，string类型
//            //DomHead[0]["dplanarrdate"] = ""; //计划到货日期，DateTime类型
//            //DomHead[0]["cverifier"] = ""; //审核人，string类型
//            //DomHead[0]["cchanger"] = ""; //变更人，string类型
//            //DomHead[0]["ccloser"] = ""; //关闭人，string类型
//            setAttribute(ele, "ivtid", "8173"); //单据模版号，int类型
//            //DomHead[0]["cvenbank"] = ""; //供方银行名称，string类型
//            //DomHead[0]["cptcode"] = ""; //采购类型编号，string类型
//            //DomHead[0]["myname"] = ""; //地址，double类型
//            //DomHead[0]["myphone"] = ""; //电话，double类型
//            //DomHead[0]["myfax"] = ""; //传真，double类型
//            //DomHead[0]["myzip"] = ""; //邮编，double类型
//            //DomHead[0]["cvenaddress"] = ""; //供方地址，string类型
//            //DomHead[0]["cvenphone"] = ""; //供方电话，string类型
//            //DomHead[0]["cvenfax"] = ""; //供方传真，string类型
//            //DomHead[0]["cvenpostcode"] = ""; //供方邮编，string类型
//            //DomHead[0]["cvenperson"] = ""; //供方联系人，string类型
//            //DomHead[0]["cvenaccount"] = ""; //供方银行账号，string类型
//            //DomHead[0]["cvenregcode"] = ""; //供方纳税登记号，string类型
//            //DomHead[0]["cstate"] = "1"; //状态（数据库），string类型
//            //DomHead[0]["cperiod"] = ""; //计划周期，string类型
//            //DomHead[0]["carrivalplace"] = ""; //到货地址，string类型
//            //DomHead[0]["ibargain"] = ""; //订金，double类型
//            //DomHead[0]["csccode"] = ""; //运输方式编号，string类型
//            //DomHead[0]["icost"] = ""; //运费，double类型
//            //DomHead[0]["cscname"] = ""; //运输方式，string类型
//            //DomHead[0]["cpaycode"] = ""; //付款条件编号，string类型
//            setAttribute(ele, "cpersoncode", "00043"); //业务员编号，string类型
//            setAttribute(ele, "cdepcode", "0401"); //部门编号，string类型
//            //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型
//            //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//            //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//            //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//            //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//            //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//            //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//            //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//            //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//            //DomHead[0]["cvendefine1"] = ""; //供应商自定义项1，string类型
//            //DomHead[0]["cvendefine2"] = ""; //供应商自定义项2，string类型
//            //DomHead[0]["cvendefine3"] = ""; //供应商自定义项3，string类型
//            //DomHead[0]["cvendefine4"] = ""; //供应商自定义项4，string类型
//            //DomHead[0]["cvendefine5"] = ""; //供应商自定义项5，string类型
//            //DomHead[0]["cvendefine6"] = ""; //供应商自定义项6，string类型
//            //DomHead[0]["cvendefine7"] = ""; //供应商自定义项7，string类型
//            //DomHead[0]["cvendefine8"] = ""; //供应商自定义项8，string类型
//            //DomHead[0]["cvendefine9"] = ""; //供应商自定义项9，string类型
//            //DomHead[0]["cvendefine10"] = ""; //供应商自定义项10，string类型
//            //DomHead[0]["cvenpuomprotocol"] = ""; //收付款协议编码，string类型
//            //DomHead[0]["cvendefine11"] = ""; //供应商自定义项11，string类型
//            //DomHead[0]["cvenpuomprotocolname"] = ""; //收付款协议名称，string类型
//            //DomHead[0]["cvendefine12"] = ""; //供应商自定义项12，string类型
//            //DomHead[0]["cvendefine13"] = ""; //供应商自定义项13，string类型
//            //DomHead[0]["cvendefine14"] = ""; //供应商自定义项14，string类型
//            //DomHead[0]["cvendefine15"] = ""; //供应商自定义项15，string类型
//            //DomHead[0]["cvendefine16"] = ""; //供应商自定义项16，string类型
//            //DomHead[0]["clocker"] = ""; //锁定人，string类型

//            //broker.AssignNormalValue("domHead", domHead);

//            //给BO表体参数domBody赋值，此BO参数的业务类型为销售订单，属表体参数。BO参数均按引用传递
//            //提示：给BO表体参数domBody赋值有两种方法

//            //方法一是直接传入MSXML2.DOMDocumentClass对象
//            //broker.AssignNormalValue("domBody", new MSXML2.DOMDocumentClass())
//            strSQL = "select * from zpurpotail where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domBody, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();
//            rs = null;

//            //增加表体数据节点z:row
//            eleBody = domBody.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domBody = broker.GetBoParam("domBody");
//            //domBody.RowCount = 1; //设置BO对象行数
//            //可以自由设置BO对象行数为大于零的整数，也可以不设置而自动增加行数
//            //给BO对象的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            for (int i = 0; i < 4000; i++)
//            {
//                decimal decQuantity = 20.00M;
//                //含税单价
//                decimal decprice = 10.00M;
//                //含税金额
//                decimal decamount = decimal.Round(decQuantity * decprice, 2);
//                //税率
//                decimal decTaxRate = 0.00M;
//                //不含税金额
//                decimal decNotTaxAmount = decimal.Round(decamount / (1 + decTaxRate), 2);
//                if (decTaxRate == 0)
//                    decNotTaxAmount = decamount;
//                //不含税单价
//                decimal decNotTaxPrice = decimal.Round(decNotTaxAmount / decQuantity, 2);
//                if (decTaxRate == 0)
//                    decNotTaxPrice = decprice;
//                //税额
//                decimal decTax = decamount - decNotTaxAmount;

//                ele = domBody.createElement("z:row");
//                eleBody.appendChild(ele);

//                setAttribute(ele, "id", "0"); //主关键字段，int类型
//                setAttribute(ele, "cfactorycode", "001");
//                setAttribute(ele, "cfactoryname", "工厂一");
//                setAttribute(ele, "cinvcode", "17001"); //存货编码，string类型
//                setAttribute(ele, "iquantity", "1"); //数量，double类型
//                setAttribute(ele, "darrivedate", dtCreateDate.ToString("yyyy-MM-dd")); //计划到货日期，DateTime类型
//                setAttribute(ele, "ipertaxrate", "17"); //税率，double类型
//                setAttribute(ele, "poid", "0"); //主表id，int类型
//                setAttribute(ele, "bgsp", "0"); //是否检验，int类型
//                setAttribute(ele, "editprop", "A"); //编辑属性：A表新增，M表修改，D表删除，string类型
//                                                    //domBody[0]["cbg_itemcode"] = ""; //预算项目编码，string类型
//                                                    //domBody[0]["cbg_itemname"] = ""; //预算项目，string类型
//                                                    //domBody[0]["cbg_caliberkey1"] = ""; //口径1类型编码，string类型
//                                                    //domBody[0]["cbg_caliberkeyname1"] = ""; //口径1类型名称，string类型
//                                                    //domBody[0]["cbg_caliberkey2"] = ""; //口径2类型编码，string类型
//                                                    //domBody[0]["cbg_caliberkeyname2"] = ""; //口径2类型名称，string类型
//                                                    //domBody[0]["cbg_caliberkey3"] = ""; //口径3类型编码，string类型
//                                                    //domBody[0]["cbg_caliberkeyname3"] = ""; //口径3类型名称，string类型
//                                                    //domBody[0]["cbg_calibercode1"] = ""; //口径1编码，string类型
//                                                    //domBody[0]["cbg_calibername1"] = ""; //口径1名称，string类型
//                                                    //domBody[0]["cbg_calibercode2"] = ""; //口径2编码，string类型
//                                                    //domBody[0]["cbg_calibername2"] = ""; //口径2名称，string类型
//                                                    //domBody[0]["cbg_calibercode3"] = ""; //口径3编码，string类型
//                                                    //domBody[0]["cbg_calibername3"] = ""; //口径3名称，string类型
//                                                    //domBody[0]["cbg_auditopinion"] = ""; //审批意见，string类型
//                                                    //domBody[0]["ibg_ctrl"] = ""; //是否预算控制，string类型
//                                                    //domBody[0]["fexquantity"] = ""; //累计出口数量，string类型
//                setAttribute(ele, "ivouchrowno", i); //行号，string类型
//                                                     //domBody[0]["cbg_caliberkeyname4"] = ""; //口径4类型名称，string类型
//                                                     //domBody[0]["cbg_caliberkey5"] = ""; //口径5类型编码，string类型
//                                                     //domBody[0]["cbg_caliberkeyname5"] = ""; //口径5类型名称，string类型
//                                                     //domBody[0]["cbg_caliberkey6"] = ""; //口径6类型编码，string类型
//                                                     //domBody[0]["cbg_caliberkeyname6"] = ""; //口径6类型名称，string类型
//                                                     //domBody[0]["cbg_calibercode4"] = ""; //口径4编码，string类型
//                                                     //domBody[0]["cbg_calibername4"] = ""; //口径4名称，string类型
//                                                     //domBody[0]["cbg_calibercode5"] = ""; //口径5编码，string类型
//                                                     //domBody[0]["cbg_calibername5"] = ""; //口径5名称，string类型
//                                                     //domBody[0]["cbg_calibercode6"] = ""; //口径6编码，string类型
//                                                     //domBody[0]["cbg_calibername6"] = ""; //口径6名称，string类型
//                                                     //domBody[0]["csrpolicy"] = ""; //供需政策，string类型
//                                                     //domBody[0]["irequiretrackstyle"] = ""; //存货需求跟踪方式，string类型
//                                                     //domBody[0]["ipresentb"] = ""; //现存量，string类型
//                                                     //domBody[0]["cbg_caliberkey4"] = ""; //口径4类型编码，string类型
//                                                     //domBody[0]["cxjspdids"] = ""; //采购比价审批单子表ID，string类型
//                setAttribute(ele, "cbmemo", "cqz" + i.ToString()); //备注，string类型
//                                                                   //domBody[0]["cbsysbarcode"] = ""; //单据行条码，string类型
//                                                                   //domBody[0]["planlotnumber"] = ""; //计划批号，string类型
//                                                                   //domBody[0]["cplanmethod"] = ""; //计划方法，string类型

//                /***************************** 以下是非必输字段 ****************************/
//                //domBody[0]["iinvexchrate"] = ""; //换算率，double类型
//                //domBody[0]["cinvname"] = ""; //存货名称，string类型
//                //domBody[0]["cinvstd"] = ""; //规格型号，string类型
//                //domBody[0]["iquotedprice"] = ""; //报价，double类型
//                //domBody[0]["inum"] = ""; //件数，double类型
//                //domBody[0]["iunitprice"] = ""; //原币单价，double类型
//                //domBody[0]["imoney"] = ""; //原币金额，double类型
//                //domBody[0]["itax"] = ""; //原币税额，double类型
//                //domBody[0]["idiscount"] = ""; //折扣额，double类型
//                //domBody[0]["inatunitprice"] = ""; //本币单价，double类型
//                //domBody[0]["inatmoney"] = ""; //本币金额，double类型
//                //domBody[0]["inattax"] = ""; //本币税额，double类型
//                //domBody[0]["inatsum"] = ""; //本币价税合计，double类型
//                //domBody[0]["inatdiscount"] = ""; //本币折扣额，double类型
//                //domBody[0]["isum"] = ""; //原币价税合计，double类型
//                //domBody[0]["cfree2"] = ""; //自由项2，string类型
//                //domBody[0]["cfree1"] = ""; //自由项1，string类型
//                //domBody[0]["bmark"] = ""; //标志，double类型
//                //domBody[0]["cdefine22"] = ""; //表体自定义项1，string类型
//                //domBody[0]["cdefine23"] = ""; //表体自定义项2，string类型
//                //domBody[0]["cdefine24"] = ""; //表体自定义项3，string类型
//                //domBody[0]["cdefine25"] = ""; //表体自定义项4，string类型
//                //domBody[0]["cdefine26"] = ""; //表体自定义项5，double类型
//                //domBody[0]["cdefine27"] = ""; //表体自定义项6，double类型
//                //domBody[0]["cinvdefine1"] = ""; //存货自定义项1，string类型
//                //domBody[0]["cinvdefine4"] = ""; //存货自定义项4，string类型
//                //domBody[0]["cinvdefine5"] = ""; //存货自定义项5，string类型
//                //domBody[0]["cinvdefine6"] = ""; //存货自定义项6，string类型
//                //domBody[0]["cinvdefine7"] = ""; //存货自定义项7，string类型
//                //domBody[0]["cinvdefine8"] = ""; //存货自定义项8，string类型
//                //domBody[0]["cinvdefine9"] = ""; //存货自定义项9，string类型
//                //domBody[0]["cinvdefine10"] = ""; //存货自定义项10，string类型
//                //domBody[0]["cinvdefine11"] = ""; //存货自定义项11，string类型
//                //domBody[0]["cinvdefine12"] = ""; //存货自定义项12，string类型
//                //domBody[0]["cinvdefine13"] = ""; //存货自定义项13，string类型
//                //domBody[0]["cinvdefine14"] = ""; //存货自定义项14，string类型
//                //domBody[0]["cinvdefine15"] = ""; //存货自定义项15，string类型
//                //domBody[0]["cinvdefine16"] = ""; //存货自定义项16，string类型
//                //domBody[0]["cinvdefine2"] = ""; //存货自定义项2，string类型
//                //domBody[0]["cinvdefine3"] = ""; //存货自定义项3，string类型
//                //domBody[0]["citemcode"] = ""; //项目编码，string类型
//                //domBody[0]["citem_class"] = ""; //项目大类编码，string类型
//                //domBody[0]["ppcids"] = ""; //采购计划子表ID，string类型
//                //domBody[0]["citemname"] = ""; //项目名称，string类型
//                //domBody[0]["citem_name"] = ""; //项目大类名称，string类型
//                //domBody[0]["cfree3"] = ""; //自由项3，string类型
//                //domBody[0]["cfree4"] = ""; //自由项4，string类型
//                //domBody[0]["cfree5"] = ""; //自由项5，string类型
//                //domBody[0]["cfree6"] = ""; //自由项6，string类型
//                //domBody[0]["cfree7"] = ""; //自由项7，string类型
//                //domBody[0]["cfree8"] = ""; //自由项8，string类型
//                //domBody[0]["cfree9"] = ""; //自由项9，string类型
//                //domBody[0]["cfree10"] = ""; //自由项10，string类型
//                //domBody[0]["imainid"] = ""; //对应单据主表id，string类型
//                //domBody[0]["btaxcost"] = ""; //单价标准，string类型
//                //domBody[0]["corufts"] = ""; //对应单据时间戳，string类型
//                //domBody[0]["itaxprice"] = ""; //含税单价，double类型
//                //domBody[0]["cunitid"] = ""; //单位编码，string类型
//                //domBody[0]["cinva_unit"] = ""; //采购单位，string类型
//                //domBody[0]["cinvm_unit"] = ""; //主计量，string类型
//                //domBody[0]["igrouptype"] = ""; //分组类型，string类型
//                //domBody[0]["iappids"] = ""; //请购单子表id，int类型
//                //domBody[0]["isosid"] = ""; //订单子表id，int类型
//                //domBody[0]["cdefine28"] = ""; //表体自定义项7，string类型
//                //domBody[0]["cdefine29"] = ""; //表体自定义项8，string类型
//                //domBody[0]["cdefine30"] = ""; //表体自定义项9，string类型
//                //domBody[0]["cdefine31"] = ""; //表体自定义项10，string类型
//                //domBody[0]["cdefine32"] = ""; //表体自定义项11，string类型
//                //domBody[0]["cdefine33"] = ""; //表体自定义项12，string类型
//                //domBody[0]["cdefine34"] = ""; //表体自定义项13，int类型
//                //domBody[0]["cdefine35"] = ""; //表体自定义项14，int类型
//                //domBody[0]["cdefine36"] = ""; //表体自定义项15，DateTime类型
//                //domBody[0]["cdefine37"] = ""; //表体自定义项16，DateTime类型
//                //domBody[0]["csource"] = ""; //单据来源，string类型
//                //domBody[0]["cinvaddcode"] = ""; //存货代码，string类型
//                //domBody[0]["cbcloser"] = ""; //行关闭人，string类型
//                //domBody[0]["cveninvcode"] = ""; //供应商存货编码，string类型
//                //domBody[0]["cveninvname"] = ""; //供应商存货名称，string类型
//                //domBody[0]["ippartid"] = ""; //母件Id，int类型
//                //domBody[0]["ipquantity"] = ""; //母件数量，int类型
//                //domBody[0]["iptoseq"] = ""; //选配序号，int类型
//                //domBody[0]["contractrowno"] = ""; //合同标的编码，string类型
//                //domBody[0]["contractrowguid"] = ""; //合同标的GUID，string类型
//                //domBody[0]["contractcode"] = ""; //合同号，string类型
//                //domBody[0]["sotype"] = ""; //需求跟踪方式，int类型
//                //domBody[0]["csocode"] = ""; //需求跟踪号，string类型
//                //domBody[0]["irowno"] = ""; //需求跟踪行号，string类型
//                //domBody[0]["sodid"] = ""; //需求跟踪子表ID，string类型
//                //domBody[0]["cbclosetime"] = ""; //关闭时间，DateTime类型
//                //domBody[0]["cbclosedate"] = ""; //关闭日期，DateTime类型
//                //domBody[0]["upsotype"] = ""; //上游单据类型，int类型
//                //domBody[0]["cupsocode"] = ""; //上游单据号，string类型
//                //domBody[0]["iinvmpcost"] = ""; //最高进价，double类型
//                //domBody[0]["cdemandmemo"] = ""; //需求分类代号说明，string类型
//                //domBody[0]["iorderdid"] = ""; //销售订单子表id，int类型
//                //domBody[0]["iordertype"] = ""; //销售订单类型，int类型
//                //domBody[0]["csoordercode"] = ""; //销售订单号，string类型
//                //domBody[0]["iorderseq"] = ""; //销售订单行号，int类型
//                //domBody[0]["bgift"] = ""; //赠品，string类型
//                //

//                //domHead.loadXML(strH);
//                //domBody.loadXML(strB);
//            }


//            if (true)
//            {
//                VoucherCO_PU.clsVoucherCO_PU obj = new VoucherCO_PU.clsVoucherCO_PU();
//                //
//                bool bPositive = true;
//                string sBillType = "";
//                string sBusType = "普通采购";
//                VoucherVerify.UseMode um = VoucherVerify.UseMode.CS;
//                string sfBusType = "普通采购";
//                string sPtCode = "07";
//                //
//                Info_PU.ClsS_Infor clsinfo = new Info_PU.ClsS_Infor();
//                string str = clsinfo.Init(ref g_oLogin, sBusType, sPtCode);
//                //
//                obj.Init(VoucherCO_PU.vouchertype.采购订单, ref g_oLogin, ref oCon, ref clsinfo, ref bPositive, ref sBillType, ref sBusType, ref um, sfBusType, sPtCode);
//                obj.bOutTrans = false;
//                //
//                short VoucherState = 2;//增加
//                object vNewID = "";
//                IXMLDOMDocument2 CurDom = new MSXML2.DOMDocument();
//                string sOverDetailsXml = "";
//                IXMLDOMDocument2 DomMsg = new MSXML2.DOMDocument();
//                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
//                string strRet = obj.VoucherSave(domHead, domBody, VoucherState, ref vNewID, ref CurDom, um, ref sOverDetailsXml, ref DomMsg);
//                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
//                MessageBox.Show(strRet);
//            }
//        }
//        #endregion

//        #region 审核采购订单
//        public void AuditYYStockPact()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2015-01-26");
//            string sSubId = "AS";
//            string sAccID = "999";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_999_2014;Timeout=60";
//            strConn = "data source=127.0.0.1;user id=sa;password=Sa1;initial catalog=UFDATA_999_2014;Connect Timeout=30;Persist Security Info=True";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from zpurpoheader where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "poid", "1000000072"); //主关键字段，int类型
//            setAttribute(ele, "cbustype", "普通采购"); //业务类型，int类型
//            setAttribute(ele, "dpodate", dtCreateDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
//            setAttribute(ele, "cpoid", "0000000041"); //订单编号，string类型
//            //DomHead[0]["cvenabbname"] = ""; //供货单位，string类型
//            //DomHead[0]["cexch_name"] = ""; //币种，string类型
//            //DomHead[0]["nflat"] = ""; //汇率，double类型
//            //DomHead[0]["cmaker"] = ""; //制单人，string类型
//            //DomHead[0]["cvencode"] = ""; //供货单位编号，string类型
//            //DomHead[0]["ufts"] = ""; //时间戳，string类型
//            //DomHead[0]["idiscounttaxtype"] = ""; //扣税类别，int类型
//            //DomHead[0]["contractcodet"] = ""; //合同号，string类型
//            //DomHead[0]["iflowid"] = ""; //流程ID，string类型
//            //DomHead[0]["cflowname"] = ""; //流程模式描述，string类型
//            //DomHead[0]["dclosetime"] = ""; //关闭时间，string类型
//            //DomHead[0]["dclosedate"] = ""; //关闭日期，string类型
//            //DomHead[0]["ccontactcode"] = ""; //供方联系人编码，string类型
//            //DomHead[0]["cmobilephone"] = ""; //供方联系人手机号，string类型
//            //DomHead[0]["cappcode"] = ""; //请购单号，string类型
//            //DomHead[0]["csysbarcode"] = ""; //单据条码，string类型
//            //DomHead[0]["cchangverifier"] = ""; //变更审批人，string类型
//            //DomHead[0]["cchangaudittime"] = ""; //变更审批时间，string类型
//            //DomHead[0]["cchangauditdate"] = ""; //变更审批日期，string类型
//            //DomHead[0]["controlresult"] = ""; //controlresult，string类型
//            //DomHead[0]["ibg_overflag"] = ""; //预算审批状态，string类型
//            //DomHead[0]["cbg_auditor"] = ""; //预算审批人，string类型
//            //DomHead[0]["cbg_audittime"] = ""; //预算审批时间，string类型

//            ///***************************** 以下是非必输字段 ****************************/
//            //DomHead[0]["ipresent"] = ""; //现存量，string类型
//            //DomHead[0]["cmaketime"] = ""; //制单时间，DateTime类型
//            //DomHead[0]["cmodifytime"] = ""; //修改时间，DateTime类型
//            //DomHead[0]["caudittime"] = ""; //审核时间，DateTime类型
//            //DomHead[0]["cauditdate"] = ""; //审核日期，DateTime类型
//            //DomHead[0]["cmodifydate"] = ""; //修改日期，DateTime类型
//            //DomHead[0]["creviser"] = ""; //修改人，string类型
//            //DomHead[0]["cptname"] = ""; //采购类型，string类型
//            //DomHead[0]["cvenname"] = ""; //供应商全称，string类型
//            //DomHead[0]["iverifystateex"] = ""; //审核状态，string类型
//            //DomHead[0]["ireturncount"] = ""; //打回次数，string类型
//            //DomHead[0]["iswfcontrolled"] = ""; //是否启用工作流，string类型
//            //DomHead[0]["cdepname"] = ""; //部门，string类型
//            //DomHead[0]["cpersonname"] = ""; //业务员，string类型
//            //DomHead[0]["itaxrate"] = ""; //税率，double类型
//            //DomHead[0]["cpayname"] = ""; //付款条件，string类型
//            //DomHead[0]["cmemo"] = ""; //备注，string类型
//            //DomHead[0]["dplanarrdate"] = ""; //计划到货日期，DateTime类型
//            //DomHead[0]["cverifier"] = ""; //审核人，string类型
//            //DomHead[0]["cchanger"] = ""; //变更人，string类型
//            //DomHead[0]["ccloser"] = ""; //关闭人，string类型
//            //DomHead[0]["ivtid"] = ""; //单据模版号，int类型
//            //DomHead[0]["cvenbank"] = ""; //供方银行名称，string类型
//            //DomHead[0]["cptcode"] = ""; //采购类型编号，string类型
//            //DomHead[0]["myname"] = ""; //地址，double类型
//            //DomHead[0]["myphone"] = ""; //电话，double类型
//            //DomHead[0]["myfax"] = ""; //传真，double类型
//            //DomHead[0]["myzip"] = ""; //邮编，double类型
//            //DomHead[0]["cvenaddress"] = ""; //供方地址，string类型
//            //DomHead[0]["cvenphone"] = ""; //供方电话，string类型
//            //DomHead[0]["cvenfax"] = ""; //供方传真，string类型
//            //DomHead[0]["cvenpostcode"] = ""; //供方邮编，string类型
//            //DomHead[0]["cvenperson"] = ""; //供方联系人，string类型
//            //DomHead[0]["cvenaccount"] = ""; //供方银行账号，string类型
//            //DomHead[0]["cvenregcode"] = ""; //供方纳税登记号，string类型
//            //DomHead[0]["cstate"] = ""; //状态（数据库），string类型
//            //DomHead[0]["cperiod"] = ""; //计划周期，string类型
//            //DomHead[0]["carrivalplace"] = ""; //到货地址，string类型
//            //DomHead[0]["ibargain"] = ""; //订金，double类型
//            //DomHead[0]["csccode"] = ""; //运输方式编号，string类型
//            //DomHead[0]["icost"] = ""; //运费，double类型
//            //DomHead[0]["cscname"] = ""; //运输方式，string类型
//            //DomHead[0]["cpaycode"] = ""; //付款条件编号，string类型
//            //DomHead[0]["cpersoncode"] = ""; //业务员编号，string类型
//            //DomHead[0]["cdepcode"] = ""; //部门编号，string类型
//            //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型
//            //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//            //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//            //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//            //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//            //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//            //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//            //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//            //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//            //DomHead[0]["cvendefine1"] = ""; //供应商自定义项1，string类型
//            //DomHead[0]["cvendefine2"] = ""; //供应商自定义项2，string类型
//            //DomHead[0]["cvendefine3"] = ""; //供应商自定义项3，string类型
//            //DomHead[0]["cvendefine4"] = ""; //供应商自定义项4，string类型
//            //DomHead[0]["cvendefine5"] = ""; //供应商自定义项5，string类型
//            //DomHead[0]["cvendefine6"] = ""; //供应商自定义项6，string类型
//            //DomHead[0]["cvendefine7"] = ""; //供应商自定义项7，string类型
//            //DomHead[0]["cvendefine8"] = ""; //供应商自定义项8，string类型
//            //DomHead[0]["cvendefine9"] = ""; //供应商自定义项9，string类型
//            //DomHead[0]["cvendefine10"] = ""; //供应商自定义项10，string类型
//            //DomHead[0]["cvenpuomprotocol"] = ""; //收付款协议编码，string类型
//            //DomHead[0]["cvendefine11"] = ""; //供应商自定义项11，string类型
//            //DomHead[0]["cvenpuomprotocolname"] = ""; //收付款协议名称，string类型
//            //DomHead[0]["cvendefine12"] = ""; //供应商自定义项12，string类型
//            //DomHead[0]["cvendefine13"] = ""; //供应商自定义项13，string类型
//            //DomHead[0]["cvendefine14"] = ""; //供应商自定义项14，string类型
//            //DomHead[0]["cvendefine15"] = ""; //供应商自定义项15，string类型
//            //DomHead[0]["cvendefine16"] = ""; //供应商自定义项16，string类型
//            //DomHead[0]["clocker"] = ""; //锁定人，string类型

//            if (true)
//            {
//                VoucherCO_PU.clsVoucherCO_PU obj = new VoucherCO_PU.clsVoucherCO_PU();
//                //
//                bool bPositive = true;
//                string sBillType = "";
//                string sBusType = "普通采购";
//                VoucherVerify.UseMode um = VoucherVerify.UseMode.CS;
//                string sfBusType = "普通采购";
//                string sPtCode = "07";
//                //
//                Info_PU.ClsS_Infor clsinfo = new Info_PU.ClsS_Infor();
//                string str = clsinfo.Init(ref g_oLogin, sBusType, sPtCode);
//                //
//                obj.Init(VoucherCO_PU.vouchertype.采购订单, ref g_oLogin, ref oCon, ref clsinfo, ref bPositive, ref sBillType, ref sBusType, ref um, sfBusType, sPtCode);
//                obj.bOutTrans = false;
//                //
//                IXMLDOMDocument2 DomMsg = new MSXML2.DOMDocument();
//                string strRet = obj.ConfirmPO(domHead, ref DomMsg);
//                MessageBox.Show(strRet);
//            }
//        }
//        #endregion

//        #region 弃审采购订单
//        public void CancelAuditYYStockPact()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2015-01-26");
//            string sSubId = "AS";
//            string sAccID = "999";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=Sa1;Initial Catalog=UFDATA_999_2014;Timeout=60";
//            strConn = "data source=127.0.0.1;user id=sa;password=Sa1;initial catalog=UFDATA_999_2014;Connect Timeout=30;Persist Security Info=True";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from zpurpoheader where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "poid", "1000000057"); //主关键字段，int类型
//            setAttribute(ele, "cbustype", "普通采购"); //业务类型，int类型
//            setAttribute(ele, "dpodate", dtCreateDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
//            setAttribute(ele, "cpoid", "0000000041"); //订单编号，string类型
//            //DomHead[0]["cvenabbname"] = ""; //供货单位，string类型
//            //DomHead[0]["cexch_name"] = ""; //币种，string类型
//            //DomHead[0]["nflat"] = ""; //汇率，double类型
//            //DomHead[0]["cmaker"] = ""; //制单人，string类型
//            //DomHead[0]["cvencode"] = ""; //供货单位编号，string类型
//            //DomHead[0]["ufts"] = ""; //时间戳，string类型
//            //DomHead[0]["idiscounttaxtype"] = ""; //扣税类别，int类型
//            //DomHead[0]["contractcodet"] = ""; //合同号，string类型
//            //DomHead[0]["iflowid"] = ""; //流程ID，string类型
//            //DomHead[0]["cflowname"] = ""; //流程模式描述，string类型
//            //DomHead[0]["dclosetime"] = ""; //关闭时间，string类型
//            //DomHead[0]["dclosedate"] = ""; //关闭日期，string类型
//            //DomHead[0]["ccontactcode"] = ""; //供方联系人编码，string类型
//            //DomHead[0]["cmobilephone"] = ""; //供方联系人手机号，string类型
//            //DomHead[0]["cappcode"] = ""; //请购单号，string类型
//            //DomHead[0]["csysbarcode"] = ""; //单据条码，string类型
//            //DomHead[0]["cchangverifier"] = ""; //变更审批人，string类型
//            //DomHead[0]["cchangaudittime"] = ""; //变更审批时间，string类型
//            //DomHead[0]["cchangauditdate"] = ""; //变更审批日期，string类型
//            //DomHead[0]["controlresult"] = ""; //controlresult，string类型
//            //DomHead[0]["ibg_overflag"] = ""; //预算审批状态，string类型
//            //DomHead[0]["cbg_auditor"] = ""; //预算审批人，string类型
//            //DomHead[0]["cbg_audittime"] = ""; //预算审批时间，string类型

//            ///***************************** 以下是非必输字段 ****************************/
//            //DomHead[0]["ipresent"] = ""; //现存量，string类型
//            //DomHead[0]["cmaketime"] = ""; //制单时间，DateTime类型
//            //DomHead[0]["cmodifytime"] = ""; //修改时间，DateTime类型
//            //DomHead[0]["caudittime"] = ""; //审核时间，DateTime类型
//            //DomHead[0]["cauditdate"] = ""; //审核日期，DateTime类型
//            //DomHead[0]["cmodifydate"] = ""; //修改日期，DateTime类型
//            //DomHead[0]["creviser"] = ""; //修改人，string类型
//            //DomHead[0]["cptname"] = ""; //采购类型，string类型
//            //DomHead[0]["cvenname"] = ""; //供应商全称，string类型
//            //DomHead[0]["iverifystateex"] = ""; //审核状态，string类型
//            //DomHead[0]["ireturncount"] = ""; //打回次数，string类型
//            //DomHead[0]["iswfcontrolled"] = ""; //是否启用工作流，string类型
//            //DomHead[0]["cdepname"] = ""; //部门，string类型
//            //DomHead[0]["cpersonname"] = ""; //业务员，string类型
//            //DomHead[0]["itaxrate"] = ""; //税率，double类型
//            //DomHead[0]["cpayname"] = ""; //付款条件，string类型
//            //DomHead[0]["cmemo"] = ""; //备注，string类型
//            //DomHead[0]["dplanarrdate"] = ""; //计划到货日期，DateTime类型
//            //DomHead[0]["cverifier"] = ""; //审核人，string类型
//            //DomHead[0]["cchanger"] = ""; //变更人，string类型
//            //DomHead[0]["ccloser"] = ""; //关闭人，string类型
//            //DomHead[0]["ivtid"] = ""; //单据模版号，int类型
//            //DomHead[0]["cvenbank"] = ""; //供方银行名称，string类型
//            //DomHead[0]["cptcode"] = ""; //采购类型编号，string类型
//            //DomHead[0]["myname"] = ""; //地址，double类型
//            //DomHead[0]["myphone"] = ""; //电话，double类型
//            //DomHead[0]["myfax"] = ""; //传真，double类型
//            //DomHead[0]["myzip"] = ""; //邮编，double类型
//            //DomHead[0]["cvenaddress"] = ""; //供方地址，string类型
//            //DomHead[0]["cvenphone"] = ""; //供方电话，string类型
//            //DomHead[0]["cvenfax"] = ""; //供方传真，string类型
//            //DomHead[0]["cvenpostcode"] = ""; //供方邮编，string类型
//            //DomHead[0]["cvenperson"] = ""; //供方联系人，string类型
//            //DomHead[0]["cvenaccount"] = ""; //供方银行账号，string类型
//            //DomHead[0]["cvenregcode"] = ""; //供方纳税登记号，string类型
//            //DomHead[0]["cstate"] = ""; //状态（数据库），string类型
//            //DomHead[0]["cperiod"] = ""; //计划周期，string类型
//            //DomHead[0]["carrivalplace"] = ""; //到货地址，string类型
//            //DomHead[0]["ibargain"] = ""; //订金，double类型
//            //DomHead[0]["csccode"] = ""; //运输方式编号，string类型
//            //DomHead[0]["icost"] = ""; //运费，double类型
//            //DomHead[0]["cscname"] = ""; //运输方式，string类型
//            //DomHead[0]["cpaycode"] = ""; //付款条件编号，string类型
//            //DomHead[0]["cpersoncode"] = ""; //业务员编号，string类型
//            //DomHead[0]["cdepcode"] = ""; //部门编号，string类型
//            //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型
//            //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//            //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//            //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//            //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//            //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//            //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//            //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//            //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//            //DomHead[0]["cvendefine1"] = ""; //供应商自定义项1，string类型
//            //DomHead[0]["cvendefine2"] = ""; //供应商自定义项2，string类型
//            //DomHead[0]["cvendefine3"] = ""; //供应商自定义项3，string类型
//            //DomHead[0]["cvendefine4"] = ""; //供应商自定义项4，string类型
//            //DomHead[0]["cvendefine5"] = ""; //供应商自定义项5，string类型
//            //DomHead[0]["cvendefine6"] = ""; //供应商自定义项6，string类型
//            //DomHead[0]["cvendefine7"] = ""; //供应商自定义项7，string类型
//            //DomHead[0]["cvendefine8"] = ""; //供应商自定义项8，string类型
//            //DomHead[0]["cvendefine9"] = ""; //供应商自定义项9，string类型
//            //DomHead[0]["cvendefine10"] = ""; //供应商自定义项10，string类型
//            //DomHead[0]["cvenpuomprotocol"] = ""; //收付款协议编码，string类型
//            //DomHead[0]["cvendefine11"] = ""; //供应商自定义项11，string类型
//            //DomHead[0]["cvenpuomprotocolname"] = ""; //收付款协议名称，string类型
//            //DomHead[0]["cvendefine12"] = ""; //供应商自定义项12，string类型
//            //DomHead[0]["cvendefine13"] = ""; //供应商自定义项13，string类型
//            //DomHead[0]["cvendefine14"] = ""; //供应商自定义项14，string类型
//            //DomHead[0]["cvendefine15"] = ""; //供应商自定义项15，string类型
//            //DomHead[0]["cvendefine16"] = ""; //供应商自定义项16，string类型
//            //DomHead[0]["clocker"] = ""; //锁定人，string类型

//            if (true)
//            {
//                VoucherCO_PU.clsVoucherCO_PU obj = new VoucherCO_PU.clsVoucherCO_PU();
//                //
//                bool bPositive = true;
//                string sBillType = "";
//                string sBusType = "普通采购";
//                VoucherVerify.UseMode um = VoucherVerify.UseMode.CS;
//                string sfBusType = "普通采购";
//                string sPtCode = "07";
//                //
//                Info_PU.ClsS_Infor clsinfo = new Info_PU.ClsS_Infor();
//                string str = clsinfo.Init(ref g_oLogin, sBusType, sPtCode);
//                //
//                obj.Init(VoucherCO_PU.vouchertype.采购订单, ref g_oLogin, ref oCon, ref clsinfo, ref bPositive, ref sBillType, ref sBusType, ref um, sfBusType, sPtCode);
//                obj.bOutTrans = false;
//                //
//                string strRet = obj.CancelconfirmPO(domHead);
//                MessageBox.Show(strRet);
//            }
//        }
//        #endregion

//        #region 删除采购订单
//        public void DeleteYYStockPact()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2015-01-26");
//            string sSubId = "AS";
//            string sAccID = "999";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=Sa1;Initial Catalog=UFDATA_999_2014;Timeout=60";
//            strConn = "data source=127.0.0.1;user id=sa;password=Sa1;initial catalog=UFDATA_999_2014;Connect Timeout=30;Persist Security Info=True";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from zpurpoheader where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "poid", "1000000057"); //主关键字段，int类型
//            setAttribute(ele, "cbustype", "普通采购"); //业务类型，int类型
//            setAttribute(ele, "dpodate", dtCreateDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
//            setAttribute(ele, "cpoid", "0000000041"); //订单编号，string类型
//            //DomHead[0]["cvenabbname"] = ""; //供货单位，string类型
//            //DomHead[0]["cexch_name"] = ""; //币种，string类型
//            //DomHead[0]["nflat"] = ""; //汇率，double类型
//            //DomHead[0]["cmaker"] = ""; //制单人，string类型
//            //DomHead[0]["cvencode"] = ""; //供货单位编号，string类型
//            setAttribute(ele, "ufts", "                     1028.1222"); //时间戳，string类型
//            //DomHead[0]["idiscounttaxtype"] = ""; //扣税类别，int类型
//            //DomHead[0]["contractcodet"] = ""; //合同号，string类型
//            //DomHead[0]["iflowid"] = ""; //流程ID，string类型
//            //DomHead[0]["cflowname"] = ""; //流程模式描述，string类型
//            //DomHead[0]["dclosetime"] = ""; //关闭时间，string类型
//            //DomHead[0]["dclosedate"] = ""; //关闭日期，string类型
//            //DomHead[0]["ccontactcode"] = ""; //供方联系人编码，string类型
//            //DomHead[0]["cmobilephone"] = ""; //供方联系人手机号，string类型
//            //DomHead[0]["cappcode"] = ""; //请购单号，string类型
//            //DomHead[0]["csysbarcode"] = ""; //单据条码，string类型
//            //DomHead[0]["cchangverifier"] = ""; //变更审批人，string类型
//            //DomHead[0]["cchangaudittime"] = ""; //变更审批时间，string类型
//            //DomHead[0]["cchangauditdate"] = ""; //变更审批日期，string类型
//            //DomHead[0]["controlresult"] = ""; //controlresult，string类型
//            //DomHead[0]["ibg_overflag"] = ""; //预算审批状态，string类型
//            //DomHead[0]["cbg_auditor"] = ""; //预算审批人，string类型
//            //DomHead[0]["cbg_audittime"] = ""; //预算审批时间，string类型

//            ///***************************** 以下是非必输字段 ****************************/
//            //DomHead[0]["ipresent"] = ""; //现存量，string类型
//            //DomHead[0]["cmaketime"] = ""; //制单时间，DateTime类型
//            //DomHead[0]["cmodifytime"] = ""; //修改时间，DateTime类型
//            //DomHead[0]["caudittime"] = ""; //审核时间，DateTime类型
//            //DomHead[0]["cauditdate"] = ""; //审核日期，DateTime类型
//            //DomHead[0]["cmodifydate"] = ""; //修改日期，DateTime类型
//            //DomHead[0]["creviser"] = ""; //修改人，string类型
//            //DomHead[0]["cptname"] = ""; //采购类型，string类型
//            //DomHead[0]["cvenname"] = ""; //供应商全称，string类型
//            //DomHead[0]["iverifystateex"] = ""; //审核状态，string类型
//            //DomHead[0]["ireturncount"] = ""; //打回次数，string类型
//            //DomHead[0]["iswfcontrolled"] = ""; //是否启用工作流，string类型
//            //DomHead[0]["cdepname"] = ""; //部门，string类型
//            //DomHead[0]["cpersonname"] = ""; //业务员，string类型
//            //DomHead[0]["itaxrate"] = ""; //税率，double类型
//            //DomHead[0]["cpayname"] = ""; //付款条件，string类型
//            //DomHead[0]["cmemo"] = ""; //备注，string类型
//            //DomHead[0]["dplanarrdate"] = ""; //计划到货日期，DateTime类型
//            //DomHead[0]["cverifier"] = ""; //审核人，string类型
//            //DomHead[0]["cchanger"] = ""; //变更人，string类型
//            //DomHead[0]["ccloser"] = ""; //关闭人，string类型
//            //DomHead[0]["ivtid"] = ""; //单据模版号，int类型
//            //DomHead[0]["cvenbank"] = ""; //供方银行名称，string类型
//            //DomHead[0]["cptcode"] = ""; //采购类型编号，string类型
//            //DomHead[0]["myname"] = ""; //地址，double类型
//            //DomHead[0]["myphone"] = ""; //电话，double类型
//            //DomHead[0]["myfax"] = ""; //传真，double类型
//            //DomHead[0]["myzip"] = ""; //邮编，double类型
//            //DomHead[0]["cvenaddress"] = ""; //供方地址，string类型
//            //DomHead[0]["cvenphone"] = ""; //供方电话，string类型
//            //DomHead[0]["cvenfax"] = ""; //供方传真，string类型
//            //DomHead[0]["cvenpostcode"] = ""; //供方邮编，string类型
//            //DomHead[0]["cvenperson"] = ""; //供方联系人，string类型
//            //DomHead[0]["cvenaccount"] = ""; //供方银行账号，string类型
//            //DomHead[0]["cvenregcode"] = ""; //供方纳税登记号，string类型
//            //DomHead[0]["cstate"] = ""; //状态（数据库），string类型
//            //DomHead[0]["cperiod"] = ""; //计划周期，string类型
//            //DomHead[0]["carrivalplace"] = ""; //到货地址，string类型
//            //DomHead[0]["ibargain"] = ""; //订金，double类型
//            //DomHead[0]["csccode"] = ""; //运输方式编号，string类型
//            //DomHead[0]["icost"] = ""; //运费，double类型
//            //DomHead[0]["cscname"] = ""; //运输方式，string类型
//            //DomHead[0]["cpaycode"] = ""; //付款条件编号，string类型
//            //DomHead[0]["cpersoncode"] = ""; //业务员编号，string类型
//            //DomHead[0]["cdepcode"] = ""; //部门编号，string类型
//            //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型
//            //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//            //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//            //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//            //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//            //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//            //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//            //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//            //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//            //DomHead[0]["cvendefine1"] = ""; //供应商自定义项1，string类型
//            //DomHead[0]["cvendefine2"] = ""; //供应商自定义项2，string类型
//            //DomHead[0]["cvendefine3"] = ""; //供应商自定义项3，string类型
//            //DomHead[0]["cvendefine4"] = ""; //供应商自定义项4，string类型
//            //DomHead[0]["cvendefine5"] = ""; //供应商自定义项5，string类型
//            //DomHead[0]["cvendefine6"] = ""; //供应商自定义项6，string类型
//            //DomHead[0]["cvendefine7"] = ""; //供应商自定义项7，string类型
//            //DomHead[0]["cvendefine8"] = ""; //供应商自定义项8，string类型
//            //DomHead[0]["cvendefine9"] = ""; //供应商自定义项9，string类型
//            //DomHead[0]["cvendefine10"] = ""; //供应商自定义项10，string类型
//            //DomHead[0]["cvenpuomprotocol"] = ""; //收付款协议编码，string类型
//            //DomHead[0]["cvendefine11"] = ""; //供应商自定义项11，string类型
//            //DomHead[0]["cvenpuomprotocolname"] = ""; //收付款协议名称，string类型
//            //DomHead[0]["cvendefine12"] = ""; //供应商自定义项12，string类型
//            //DomHead[0]["cvendefine13"] = ""; //供应商自定义项13，string类型
//            //DomHead[0]["cvendefine14"] = ""; //供应商自定义项14，string类型
//            //DomHead[0]["cvendefine15"] = ""; //供应商自定义项15，string类型
//            //DomHead[0]["cvendefine16"] = ""; //供应商自定义项16，string类型
//            //DomHead[0]["clocker"] = ""; //锁定人，string类型

//            if (true)
//            {
//                VoucherCO_PU.clsVoucherCO_PU obj = new VoucherCO_PU.clsVoucherCO_PU();
//                //
//                bool bPositive = true;
//                string sBillType = "";
//                string sBusType = "普通采购";
//                VoucherVerify.UseMode um = VoucherVerify.UseMode.CS;
//                string sfBusType = "普通采购";
//                string sPtCode = "07";
//                //
//                Info_PU.ClsS_Infor clsinfo = new Info_PU.ClsS_Infor();
//                string str = clsinfo.Init(ref g_oLogin, sBusType, sPtCode);
//                //
//                obj.Init(VoucherCO_PU.vouchertype.采购订单, ref g_oLogin, ref oCon, ref clsinfo, ref bPositive, ref sBillType, ref sBusType, ref um, sfBusType, sPtCode);
//                obj.bOutTrans = false;
//                //
//                IXMLDOMDocument2 DomMsg = new MSXML2.DOMDocument();
//                string strRet = obj.Delete(domHead, domBody, ref DomMsg);
//                MessageBox.Show(strRet);
//            }
//        }
//        #endregion

//        #region 新增空白材料出库单
//        public void ToYYRdRecord11()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2018-04-26");
//            string sSubId = "AS";
//            string sAccID = "001";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_001_2018;Timeout=60";
//            strConn = "data source=127.0.0.1;user id=sa;password=huzhijin123@;initial catalog=UFDATA_001_2018;Connect Timeout=30;Persist Security Info=True";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from RecordOutQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "id", "0"); //主关键字段，int类型
//            setAttribute(ele, "ccode", "test123");  //出库单号，string类型
//            setAttribute(ele, "ddate", dtCreateDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
//            setAttribute(ele, "cwhname", "饮料仓"); //仓库，string类型
//                                                 //setAttribute(ele, "csysbarcode", ""); ///单据条码，string类型
//                                                 //setAttribute(ele, "bmotran", "0"); //自动编号，string类型
//                                                 //setAttribute(ele, "isourcerowno", "");//来源单行号，string类型
//                                                 //setAttribute(ele, "chinvsn", ""); //序列号，string类型




//            ///***************************** 以下是非必输字段 ****************************/
//            //DomHead[0]["cmodifyperson"] = ""; //修改人，string类型
//            //DomHead[0]["dmodifydate"] = ""; //修改日期，DateTime类型
//            setAttribute(ele, "dnmaketime", dtCreateDate.ToString("yyyy-MM-dd"));//制单时间，DateTime类型            
//            //DomHead[0]["dnmodifytime"] = ""; //修改时间，DateTime类型
//            //DomHead[0]["dnverifytime"] = ""; //审核时间，DateTime类型
//            //DomHead[0]["hcinvdefine1"] = ""; //存货自定义项1，string类型
//            //DomHead[0]["hcinvdefine2"] = ""; //存货自定义项2，string类型
//            //DomHead[0]["hcinvdefine3"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine4"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine5"] = ""; //存货自定义项5，string类型
//            //DomHead[0]["hcinvdefine6"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine7"] = ""; //存货自定义项7，string类型
//            //DomHead[0]["hcinvdefine8"] = ""; //存货自定义项8，string类型
//            //DomHead[0]["hcinvdefine9"] = ""; //存货自定义项9，string类型
//            //DomHead[0]["hcinvdefine10"] = ""; //存货自定义项10，string类型
//            //DomHead[0]["hcinvdefine11"] = ""; //存货自定义项11，int类型
//            //DomHead[0]["hcinvdefine12"] = ""; //存货自定义项12，int类型
//            //DomHead[0]["hcinvdefine13"] = ""; //存货自定义项13，double类型
//            //DomHead[0]["hcinvdefine14"] = ""; //存货自定义项14，double类型
//            //DomHead[0]["hcinvdefine15"] = ""; //存货自定义项15，DateTime类型
//            //DomHead[0]["hcinvdefine16"] = ""; //存货自定义项16，DateTime类型
//            setAttribute(ele, "cinvstd", "");//规格型号，string类型           
//            //DomHead[0]["imquantity"] = ""; //产量，double类型
//            //DomHead[0]["cprobatch"] = ""; //生产批号，string类型
//            setAttribute(ele, "cbustype", "领料"); //业务类型，int类型
//            //DomHead[0]["cbuscode"] = ""; //业务号，string类型
//            //DomHead[0]["cchkperson"] = ""; //检验员，string类型
//            //DomHead[0]["crdname"] = ""; //出库类别，string类型
//            //DomHead[0]["cdepname"] = ""; //部门，string类型
//            //DomHead[0]["itopsum"] = ""; //最高库存量，string类型
//            //DomHead[0]["ilowsum"] = ""; //最低库存量，string类型
//            //DomHead[0]["cvenabbname"] = ""; //委外商，string类型
//            //DomHead[0]["bomfirst"] = ""; //bomfirst，string类型
//            //DomHead[0]["isafesum"] = ""; //安全库存量，string类型
//            //DomHead[0]["dveridate"] = ""; //审核日期，DateTime类型
//            //DomHead[0]["crdcode"] = ""; //出库类别编码，string类型
//            setAttribute(ele, "cmemo", "CO生成");//备注，string类型
//            setAttribute(ele, "cmaker", "demo");//制单人，string类型
//            //DomHead[0]["chandler"] = ""; //审核人，string类型
//            //DomHead[0]["caccounter"] = ""; //记账人，string类型
//            //DomHead[0]["ipresent"] = ""; //现存量，string类型
//            //DomHead[0]["cinvname"] = ""; //产品名称，string类型
//            //DomHead[0]["biscomplement"] = ""; //补料标志，int类型
//            //DomHead[0]["cpersonname"] = ""; //业务员，string类型
//            //DomHead[0]["bpositive"] = ""; //红蓝标识，string类型
//            //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            setAttribute(ele, "csource", "库存");  //单据来源，int类型
//                                                 //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//                                                 //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//                                                 //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//                                                 //DomHead[0]["brdflag"] = ""; //收发标志，string类型
//                                                 //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//                                                 //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//                                                 //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//                                                 //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//                                                 //DomHead[0]["cvencode"] = ""; //委外商编码，string类型
//                                                 //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//                                                 //DomHead[0]["cvouchtype"] = ""; //单据类型，string类型
//            setAttribute(ele, "cwhcode", "01"); //仓库编码，string类型
//            //DomHead[0]["cdepcode"] = ""; //部门编码，string类型
//            //DomHead[0]["cpersoncode"] = ""; //业务员编码，string类型
//            setAttribute(ele, "vt_id", "65");//模版号，int类型
//            //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型


//            //broker.AssignNormalValue("domHead", domHead);

//            //给BO表体参数domBody赋值，此BO参数的业务类型为销售订单，属表体参数。BO参数均按引用传递
//            //提示：给BO表体参数domBody赋值有两种方法

//            //方法一是直接传入MSXML2.DOMDocumentClass对象
//            //broker.AssignNormalValue("domBody", new MSXML2.DOMDocumentClass())
//            strSQL = "select * from RecordOutSQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domBody, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();
//            rs = null;

//            //增加表体数据节点z:row
//            eleBody = domBody.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domBody = broker.GetBoParam("domBody");
//            //domBody.RowCount = 1; //设置BO对象行数
//            //可以自由设置BO对象行数为大于零的整数，也可以不设置而自动增加行数
//            //给BO对象的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/


//            ele = domBody.createElement("z:row");
//            eleBody.appendChild(ele);


//            setAttribute(ele, "autoid", "0"); //主关键字段，int类型
//            setAttribute(ele, "cinvcode", "02003"); //材料编码，string类型
//            setAttribute(ele, "editprop", "A"); //编辑属性：A表新增，M表修改，D表删除，string类型
//                                                //domBody[0]["cbsysbarcode"] = ""; //单据行条码，string类型
//                                                //domBody[0]["iavaquantity"] = ""; //可用量，string类型
//                                                //domBody[0]["iavanum"] = ""; //可用件数，string类型
//                                                //domBody[0]["ipresent"] = ""; //现存量，string类型
//                                                //domBody[0]["iinvsncount"] = ""; //序列号个数，string类型
//                                                //domBody[0]["imaids"] = ""; //领料申请单子表id，string类型
//                                                //domBody[0]["csourcemocode"] = ""; //源订单号，string类型
//                                                //domBody[0]["isourcemodetailsid"] = ""; //源订单子表标识，string类型
//            setAttribute(ele, "invstd", "");  //产品规格，string类型
//            //domBody[0]["cbmemo"] = ""; //备注，string类型
//            //domBody[0]["applycode"] = ""; //子件补料申请单号，string类型
//            //domBody[0]["applydid"] = ""; //applydid，string类型
//            setAttribute(ele, "irowno", "1"); //行号，string类型
//            //domBody[0]["cbinvsn"] = ""; //序列号，string类型
//            //domBody[0]["strowguid"] = ""; //rowguid，string类型
//            //domBody[0]["cservicecode"] = ""; //服务单号，string类型
//            //domBody[0]["cinvouchtype"] = ""; //对应入库单类型，string类型
//            //domBody[0]["coutvouchid"] = ""; //对应蓝字出库单id，string类型
//            //domBody[0]["coutvouchtype"] = ""; //对应蓝字出库单类型，string类型
//            //domBody[0]["isredoutquantity"] = ""; //对应蓝字出库单退回数量，string类型
//            //domBody[0]["isredoutnum"] = ""; //对应蓝字出库单退回件数，string类型
//            //domBody[0]["ipesotype"] = ""; //需求跟踪方式，string类型
//            //domBody[0]["ipesodid"] = ""; //销售订单子表，string类型
//            //domBody[0]["cpesocode"] = ""; //需求跟踪号，string类型
//            //domBody[0]["ipesoseq"] = ""; //需求跟踪行号，string类型
//            //domBody[0]["bsupersede"] = ""; //替代料，string类型
//            //domBody[0]["isupersedeqty"] = ""; //替代数量，string类型
//            //domBody[0]["isupersedempoids"] = ""; //被替代料生产订单子表id，string类型
//            //domBody[0]["imoallocatesubid"] = ""; //替代料子表subid，string类型
//            //domBody[0]["cinvoucherlineid"] = ""; //源单行ID，string类型
//            //domBody[0]["cinvouchercode"] = ""; //源单号，string类型
//            //domBody[0]["cinvouchertype"] = ""; //源单类型，string类型
//            //domBody[0]["ipresentnum"] = ""; //现存件数，string类型
//            //domBody[0]["cplanlotcode"] = ""; //计划批号，string类型
//            //domBody[0]["bcanreplace"] = ""; //可替代，string类型
//            //domBody[0]["taskguid"] = ""; //taskguid，string类型


//            /***************************** 以下是非必输字段 ****************************/
//            setAttribute(ele, "id", "0");//与主表关联项，int类型
//            //domBody[0]["cinvaddcode"] = ""; //材料代码，string类型
//            setAttribute(ele, "cinvname", "碳酸饮料"); //材料名称，string类型
//            setAttribute(ele, "cinvstd", ""); //规格型号，string类型
//            //setAttribute(ele, "cinvm_unit", "个"); //主计量单位，string类型
//            setAttribute(ele, "cinva_unit", "个"); //库存单位，string类型
//                                                  //domBody[0]["creplaceitem"] = ""; //替换件，string类型
//                                                  //domBody[0]["cposition"] = ""; //货位编码，string类型
//                                                  //domBody[0]["cinvdefine1"] = ""; //存货自定义项1，string类型
//                                                  //domBody[0]["cinvdefine2"] = ""; //存货自定义项2，string类型
//                                                  //domBody[0]["cinvdefine3"] = ""; //存货自定义项3，string类型
//                                                  //setAttribute(ele, "cfree1", "蓝色"); //存货自由项1，string类型
//                                                  //domBody[0]["cbatchproperty1"] = ""; //批次属性1，double类型
//                                                  //domBody[0]["cbatchproperty2"] = ""; //批次属性2，double类型
//                                                  //domBody[0]["cfree2"] = ""; //存货自由项2，string类型
//                                                  //setAttribute(ele, "cbatch", "123"); //批号，string类型
//                                                  //domBody[0]["iinvexchrate"] = ""; //换算率，double类型
//                                                  //domBody[0]["inum"] = ""; //件数，double类型
//            setAttribute(ele, "iquantity", 1); //数量，double类型
//                                               //domBody[0]["iunitcost"] = ""; //单价，double类型
//                                               //domBody[0]["iprice"] = ""; //金额，double类型
//                                               //domBody[0]["ipunitcost"] = ""; //计划单价，double类型
//                                               //domBody[0]["ipprice"] = ""; //计划金额，double类型
//                                               //domBody[0]["dvdate"] = ""; //失效日期，DateTime类型
//                                               //domBody[0]["cobjcode"] = ""; //成本对象编码，string类型
//                                               //domBody[0]["cname"] = ""; //项目，string类型
//                                               //domBody[0]["isoutquantity"] = ""; //累计出库数量，double类型
//                                               //domBody[0]["isoutnum"] = ""; //累计出库件数，double类型
//                                               //domBody[0]["dsdate"] = ""; //结算日期，DateTime类型
//                                               //domBody[0]["ifquantity"] = ""; //实际数量，double类型
//                                               //domBody[0]["ifnum"] = ""; //实际件数，double类型
//                                               //domBody[0]["cvouchcode"] = ""; //对应入库单id，string类型
//                                               //domBody[0]["cbatchproperty3"] = ""; //批次属性3，double类型
//                                               //domBody[0]["cfree3"] = ""; //存货自由项3，string类型
//                                               //domBody[0]["cfree4"] = ""; //存货自由项4，string类型
//                                               //domBody[0]["cbatchproperty4"] = ""; //批次属性4，double类型
//                                               //domBody[0]["cbatchproperty5"] = ""; //批次属性5，double类型
//                                               //domBody[0]["cfree5"] = ""; //存货自由项5，string类型
//                                               //domBody[0]["cfree6"] = ""; //存货自由项6，string类型
//                                               //domBody[0]["cbatchproperty6"] = ""; //批次属性6，string类型
//                                               //domBody[0]["cbatchproperty7"] = ""; //批次属性7，string类型
//                                               //domBody[0]["cfree7"] = ""; //存货自由项7，string类型
//                                               //domBody[0]["cfree8"] = ""; //存货自由项8，string类型
//                                               //domBody[0]["cbatchproperty8"] = ""; //批次属性8，string类型
//                                               //domBody[0]["cbatchproperty9"] = ""; //批次属性9，string类型
//                                               //domBody[0]["cfree9"] = ""; //存货自由项9，string类型
//                                               //domBody[0]["cfree10"] = ""; //存货自由项10，string类型
//                                               //domBody[0]["cbatchproperty10"] = ""; //批次属性10，DateTime类型
//                                               //domBody[0]["cdefine36"] = ""; //表体自定义项15，DateTime类型
//                                               //domBody[0]["cdefine37"] = ""; //表体自定义项16，DateTime类型
//                                               //domBody[0]["cinvdefine13"] = ""; //存货自定义项13，string类型
//                                               //domBody[0]["cinvdefine14"] = ""; //存货自定义项14，string类型
//                                               //domBody[0]["cinvdefine15"] = ""; //存货自定义项15，string类型
//                                               //domBody[0]["cinvdefine16"] = ""; //存货自定义项16，string类型
//                                               //domBody[0]["inquantity"] = ""; //应发数量，double类型
//                                               //domBody[0]["innum"] = ""; //应发件数，double类型
//                                               //domBody[0]["dmadedate"] = ""; //生产日期，DateTime类型
//                                               //domBody[0]["impoids"] = ""; //生产订单子表ID，int类型
//                                               //domBody[0]["isodid"] = ""; //销售订单子表ID，string类型
//                                               //domBody[0]["iomomid"] = ""; //委外用料表ID，int类型
//                                               //domBody[0]["iomodid"] = ""; //委外订单子表ID，int类型
//                                               //domBody[0]["cbvencode"] = ""; //供应商编码，string类型
//                                               //domBody[0]["cinvouchcode"] = ""; //对应入库单号，string类型
//                                               //domBody[0]["imassdate"] = ""; //保质期，int类型
//                                               //domBody[0]["cassunit"] = ""; //库存单位码，string类型
//                                               //domBody[0]["cvenname"] = ""; //供应商，string类型
//                                               //domBody[0]["cposname"] = ""; //货位，string类型
//                                               //domBody[0]["corufts"] = ""; //对应单据时间戳，string类型
//                                               //domBody[0]["cmolotcode"] = ""; //生产批号，string类型
//                                               //domBody[0]["dmsdate"] = ""; //核销日期，DateTime类型
//                                               //domBody[0]["cmassunit"] = ""; //保质期单位，int类型
//                                               //domBody[0]["csocode"] = ""; //需求跟踪号，string类型
//                                               //domBody[0]["cmocode"] = ""; //生产订单号，string类型
//                                               //domBody[0]["comcode"] = ""; //委外订单号，string类型
//                                               //domBody[0]["cvmivencode"] = ""; //代管商代码，string类型
//                                               //domBody[0]["cvmivenname"] = ""; //代管商，string类型
//                                               //domBody[0]["bvmiused"] = ""; //代管消耗标识，int类型
//                                               //domBody[0]["ivmisettlequantity"] = ""; //代管挂账确认单数量，double类型
//                                               //domBody[0]["ivmisettlenum"] = ""; //代管挂账确认单件数，double类型
//                                               //domBody[0]["productinids"] = ""; //productinids，int类型
//                                               //domBody[0]["crejectcode"] = ""; //在库不良品处理单号，string类型
//                                               //domBody[0]["cdemandmemo"] = ""; //需求分类代号说明，string类型
//                                               //domBody[0]["iordertype"] = ""; //销售订单类别，int类型
//                                               //domBody[0]["iorderdid"] = ""; //iorderdid，int类型
//                                               //domBody[0]["iordercode"] = ""; //销售订单号，string类型
//                                               //domBody[0]["iorderseq"] = ""; //销售订单行号，string类型
//                                               //domBody[0]["iexpiratdatecalcu"] = ""; //有效期推算方式，int类型
//                                               //domBody[0]["cexpirationdate"] = ""; //有效期至，string类型
//                                               //domBody[0]["dexpirationdate"] = ""; //有效期计算项，string类型
//                                               //domBody[0]["cciqbookcode"] = ""; //手册号，string类型
//                                               //domBody[0]["ibondedsumqty"] = ""; //累计保税处理抽取数量，string类型
//                                               //domBody[0]["copdesc"] = ""; //工序说明，string类型
//                                               //domBody[0]["cmworkcentercode"] = ""; //工作中心编码，string类型
//                                               //domBody[0]["cmworkcenter"] = ""; //工作中心，string类型
//                                               //domBody[0]["invcode"] = ""; //产品编码，string类型
//                                               //domBody[0]["invname"] = ""; //产品，string类型
//                                               //domBody[0]["cwhpersonname"] = ""; //库管员名称，string类型
//                                               //domBody[0]["cbaccounter"] = ""; //记账人，string类型
//                                               //domBody[0]["bcosting"] = ""; //是否核算，string类型
//                                               //domBody[0]["isotype"] = ""; //需求跟踪方式，int类型
//                                               //domBody[0]["isoseq"] = ""; //需求跟踪行号，string类型
//                                               //domBody[0]["imoseq"] = ""; //生产订单行号，string类型
//                                               //domBody[0]["iopseq"] = ""; //工序行号，string类型
//                                               //domBody[0]["isquantity"] = ""; //累计核销数量，double类型
//                                               //domBody[0]["ismaterialfee"] = ""; //累计核销金额，double类型
//                                               //domBody[0]["cdefine34"] = ""; //表体自定义项13，int类型
//                                               //domBody[0]["cdefine35"] = ""; //表体自定义项14，int类型
//                                               //domBody[0]["cwhpersoncode"] = ""; //库管员编码，string类型
//                                               //domBody[0]["cdefine22"] = ""; //表体自定义项1，string类型
//                                               //domBody[0]["cdefine28"] = ""; //表体自定义项7，string类型
//                                               //domBody[0]["cdefine29"] = ""; //表体自定义项8，string类型
//                                               //domBody[0]["cdefine30"] = ""; //表体自定义项9，string类型
//                                               //domBody[0]["cdefine31"] = ""; //表体自定义项10，string类型
//                                               //domBody[0]["cdefine32"] = ""; //表体自定义项11，string类型
//                                               //domBody[0]["cdefine33"] = ""; //表体自定义项12，string类型
//                                               //domBody[0]["cinvdefine4"] = ""; //存货自定义项4，string类型
//                                               //domBody[0]["cinvdefine5"] = ""; //存货自定义项5，string类型
//                                               //domBody[0]["cinvdefine6"] = ""; //存货自定义项6，string类型
//                                               //domBody[0]["cinvdefine7"] = ""; //存货自定义项7，string类型
//                                               //domBody[0]["cinvdefine8"] = ""; //存货自定义项8，string类型
//                                               //domBody[0]["cinvdefine9"] = ""; //存货自定义项9，string类型
//                                               //domBody[0]["cinvdefine10"] = ""; //存货自定义项10，string类型
//                                               //domBody[0]["cinvdefine11"] = ""; //存货自定义项11，string类型
//                                               //domBody[0]["cinvdefine12"] = ""; //存货自定义项12，string类型
//                                               //domBody[0]["cbarcode"] = ""; //条形码，string类型
//                                               //domBody[0]["cdefine23"] = ""; //表体自定义项2，string类型
//                                               //domBody[0]["cdefine24"] = ""; //表体自定义项3，string类型
//                                               //domBody[0]["itrids"] = ""; //特殊单据子表标识，double类型
//                                               //domBody[0]["cdefine25"] = ""; //表体自定义项4，string类型
//                                               //domBody[0]["cdefine26"] = ""; //表体自定义项5，double类型
//                                               //domBody[0]["cdefine27"] = ""; //表体自定义项6，double类型
//                                               //domBody[0]["citemcode"] = ""; //项目编码，string类型
//                                               //domBody[0]["citem_class"] = ""; //项目大类编码，string类型
//                                               //domBody[0]["citemcname"] = ""; //项目大类名称，string类型

//            //domHead.loadXML(strH);
//            //domBody.loadXML(strB);


//            string errMsg = "";
//            USERPCO.VoucherCO objPCO = new USERPCO.VoucherCO();
//            objPCO.IniLogin(g_oLogin, errMsg);
//            object domPosition = null;
//            ADODB.Connection cnnFrom = null;
//            string VouchId = "";
//            MSXML2.IXMLDOMDocument2 domMsg = new MSXML2.DOMDocument();
//            bool bCheck = false;
//            bool bBeforCheckStock = false;
//            bool bIsRedVouch = false;
//            string sAddedState = "";
//            bool bReMote = false;
//            string voucherType = "11";
//            bool res = objPCO.Insert(voucherType, domHead, domBody, domPosition, ref errMsg, cnnFrom, VouchId, ref domMsg, ref bCheck, ref bBeforCheckStock, bIsRedVouch, sAddedState, bReMote);
//            if (res)
//            {
//                MessageBox.Show("ok");
//            }
//            else
//            {
//                MessageBox.Show(errMsg);
//            }

//        }
//        #endregion

//        #region 审核材料出库单
//        public void ToYYAuditRdRecord11()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2018-04-26");
//            string sSubId = "AS";
//            string sAccID = "001";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //g_oLogin.cAuditor = "丁一";
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_001_2018;Timeout=60";
//            strConn = "data source=127.0.0.1;user id=sa;password=huzhijin123@;initial catalog=UFDATA_001_2018;Connect Timeout=30;Persist Security Info=True";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from RecordOutQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "id", "1000000490"); //主关键字段，int类型
//            setAttribute(ele, "ccode", "0000000210");  //出库单号，string类型
//            setAttribute(ele, "ddate", dtCreateDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
//            setAttribute(ele, "cwhname", "饮料仓"); //仓库，string类型
//            //setAttribute(ele, "csysbarcode", ""); ///单据条码，string类型
//            //setAttribute(ele, "bmotran", "0"); //自动编号，string类型
//            //setAttribute(ele, "isourcerowno", "");//来源单行号，string类型
//            //setAttribute(ele, "chinvsn", ""); //序列号，string类型




//            ///***************************** 以下是非必输字段 ****************************/
//            //DomHead[0]["cmodifyperson"] = ""; //修改人，string类型
//            //DomHead[0]["dmodifydate"] = ""; //修改日期，DateTime类型
//            setAttribute(ele, "dnmaketime", dtCreateDate.ToString("yyyy-MM-dd"));//制单时间，DateTime类型            
//            //DomHead[0]["dnmodifytime"] = ""; //修改时间，DateTime类型
//            //DomHead[0]["dnverifytime"] = ""; //审核时间，DateTime类型
//            //DomHead[0]["hcinvdefine1"] = ""; //存货自定义项1，string类型
//            //DomHead[0]["hcinvdefine2"] = ""; //存货自定义项2，string类型
//            //DomHead[0]["hcinvdefine3"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine4"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine5"] = ""; //存货自定义项5，string类型
//            //DomHead[0]["hcinvdefine6"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine7"] = ""; //存货自定义项7，string类型
//            //DomHead[0]["hcinvdefine8"] = ""; //存货自定义项8，string类型
//            //DomHead[0]["hcinvdefine9"] = ""; //存货自定义项9，string类型
//            //DomHead[0]["hcinvdefine10"] = ""; //存货自定义项10，string类型
//            //DomHead[0]["hcinvdefine11"] = ""; //存货自定义项11，int类型
//            //DomHead[0]["hcinvdefine12"] = ""; //存货自定义项12，int类型
//            //DomHead[0]["hcinvdefine13"] = ""; //存货自定义项13，double类型
//            //DomHead[0]["hcinvdefine14"] = ""; //存货自定义项14，double类型
//            //DomHead[0]["hcinvdefine15"] = ""; //存货自定义项15，DateTime类型
//            //DomHead[0]["hcinvdefine16"] = ""; //存货自定义项16，DateTime类型
//            setAttribute(ele, "cinvstd", "");//规格型号，string类型           
//            //DomHead[0]["imquantity"] = ""; //产量，double类型
//            //DomHead[0]["cprobatch"] = ""; //生产批号，string类型
//            setAttribute(ele, "cbustype", "领料"); //业务类型，int类型
//            //DomHead[0]["cbuscode"] = ""; //业务号，string类型
//            //DomHead[0]["cchkperson"] = ""; //检验员，string类型
//            //DomHead[0]["crdname"] = ""; //出库类别，string类型
//            //DomHead[0]["cdepname"] = ""; //部门，string类型
//            //DomHead[0]["itopsum"] = ""; //最高库存量，string类型
//            //DomHead[0]["ilowsum"] = ""; //最低库存量，string类型
//            //DomHead[0]["cvenabbname"] = ""; //委外商，string类型
//            //DomHead[0]["bomfirst"] = ""; //bomfirst，string类型
//            //DomHead[0]["isafesum"] = ""; //安全库存量，string类型
//            //DomHead[0]["dveridate"] = ""; //审核日期，DateTime类型
//            //DomHead[0]["crdcode"] = ""; //出库类别编码，string类型
//            setAttribute(ele, "cmemo", "CO生成");//备注，string类型
//            setAttribute(ele, "cmaker", "demo");//制单人，string类型
//            //DomHead[0]["chandler"] = ""; //审核人，string类型
//            //DomHead[0]["caccounter"] = ""; //记账人，string类型
//            //DomHead[0]["ipresent"] = ""; //现存量，string类型
//            //DomHead[0]["cinvname"] = ""; //产品名称，string类型
//            //DomHead[0]["biscomplement"] = ""; //补料标志，int类型
//            //DomHead[0]["cpersonname"] = ""; //业务员，string类型
//            //DomHead[0]["bpositive"] = ""; //红蓝标识，string类型
//            //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            setAttribute(ele, "csource", "库存");  //单据来源，int类型
//            //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//            //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//            //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//            //DomHead[0]["brdflag"] = ""; //收发标志，string类型
//            //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//            //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//            //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//            //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//            //DomHead[0]["cvencode"] = ""; //委外商编码，string类型
//            //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//            //DomHead[0]["cvouchtype"] = ""; //单据类型，string类型
//            setAttribute(ele, "cwhcode", "01"); //仓库编码，string类型
//            //DomHead[0]["cdepcode"] = ""; //部门编码，string类型
//            //DomHead[0]["cpersoncode"] = ""; //业务员编码，string类型
//            setAttribute(ele, "vt_id", "65");//模版号，int类型
//            //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型


//            //broker.AssignNormalValue("domHead", domHead);

//            //给BO表体参数domBody赋值，此BO参数的业务类型为销售订单，属表体参数。BO参数均按引用传递
//            //提示：给BO表体参数domBody赋值有两种方法

//            //方法一是直接传入MSXML2.DOMDocumentClass对象
//            //broker.AssignNormalValue("domBody", new MSXML2.DOMDocumentClass())
//            strSQL = "select * from RecordOutSQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domBody, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();
//            rs = null;

//            //增加表体数据节点z:row
//            eleBody = domBody.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domBody = broker.GetBoParam("domBody");
//            //domBody.RowCount = 1; //设置BO对象行数
//            //可以自由设置BO对象行数为大于零的整数，也可以不设置而自动增加行数
//            //给BO对象的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/


//            ele = domBody.createElement("z:row");
//            eleBody.appendChild(ele);


//            setAttribute(ele, "autoid", "0"); //主关键字段，int类型
//            setAttribute(ele, "cinvcode", "02003"); //材料编码，string类型
//            setAttribute(ele, "editprop", "A"); //编辑属性：A表新增，M表修改，D表删除，string类型
//            //domBody[0]["cbsysbarcode"] = ""; //单据行条码，string类型
//            //domBody[0]["iavaquantity"] = ""; //可用量，string类型
//            //domBody[0]["iavanum"] = ""; //可用件数，string类型
//            //domBody[0]["ipresent"] = ""; //现存量，string类型
//            //domBody[0]["iinvsncount"] = ""; //序列号个数，string类型
//            //domBody[0]["imaids"] = ""; //领料申请单子表id，string类型
//            //domBody[0]["csourcemocode"] = ""; //源订单号，string类型
//            //domBody[0]["isourcemodetailsid"] = ""; //源订单子表标识，string类型
//            setAttribute(ele, "invstd", "");  //产品规格，string类型
//            //domBody[0]["cbmemo"] = ""; //备注，string类型
//            //domBody[0]["applycode"] = ""; //子件补料申请单号，string类型
//            //domBody[0]["applydid"] = ""; //applydid，string类型
//            setAttribute(ele, "irowno", "1"); //行号，string类型
//            //domBody[0]["cbinvsn"] = ""; //序列号，string类型
//            //domBody[0]["strowguid"] = ""; //rowguid，string类型
//            //domBody[0]["cservicecode"] = ""; //服务单号，string类型
//            //domBody[0]["cinvouchtype"] = ""; //对应入库单类型，string类型
//            //domBody[0]["coutvouchid"] = ""; //对应蓝字出库单id，string类型
//            //domBody[0]["coutvouchtype"] = ""; //对应蓝字出库单类型，string类型
//            //domBody[0]["isredoutquantity"] = ""; //对应蓝字出库单退回数量，string类型
//            //domBody[0]["isredoutnum"] = ""; //对应蓝字出库单退回件数，string类型
//            //domBody[0]["ipesotype"] = ""; //需求跟踪方式，string类型
//            //domBody[0]["ipesodid"] = ""; //销售订单子表，string类型
//            //domBody[0]["cpesocode"] = ""; //需求跟踪号，string类型
//            //domBody[0]["ipesoseq"] = ""; //需求跟踪行号，string类型
//            //domBody[0]["bsupersede"] = ""; //替代料，string类型
//            //domBody[0]["isupersedeqty"] = ""; //替代数量，string类型
//            //domBody[0]["isupersedempoids"] = ""; //被替代料生产订单子表id，string类型
//            //domBody[0]["imoallocatesubid"] = ""; //替代料子表subid，string类型
//            //domBody[0]["cinvoucherlineid"] = ""; //源单行ID，string类型
//            //domBody[0]["cinvouchercode"] = ""; //源单号，string类型
//            //domBody[0]["cinvouchertype"] = ""; //源单类型，string类型
//            //domBody[0]["ipresentnum"] = ""; //现存件数，string类型
//            //domBody[0]["cplanlotcode"] = ""; //计划批号，string类型
//            //domBody[0]["bcanreplace"] = ""; //可替代，string类型
//            //domBody[0]["taskguid"] = ""; //taskguid，string类型


//            /***************************** 以下是非必输字段 ****************************/
//            setAttribute(ele, "id", "0");//与主表关联项，int类型
//            //domBody[0]["cinvaddcode"] = ""; //材料代码，string类型
//            setAttribute(ele, "cinvname", "碳酸饮料"); //材料名称，string类型
//            setAttribute(ele, "cinvstd", ""); //规格型号，string类型
//            setAttribute(ele, "cinvm_unit", "个"); //主计量单位，string类型
//            setAttribute(ele, "cinva_unit", "个"); //库存单位，string类型
//            //domBody[0]["creplaceitem"] = ""; //替换件，string类型
//            //domBody[0]["cposition"] = ""; //货位编码，string类型
//            //domBody[0]["cinvdefine1"] = ""; //存货自定义项1，string类型
//            //domBody[0]["cinvdefine2"] = ""; //存货自定义项2，string类型
//            //domBody[0]["cinvdefine3"] = ""; //存货自定义项3，string类型
//            //setAttribute(ele, "cfree1", "蓝色"); //存货自由项1，string类型
//            //domBody[0]["cbatchproperty1"] = ""; //批次属性1，double类型
//            //domBody[0]["cbatchproperty2"] = ""; //批次属性2，double类型
//            //domBody[0]["cfree2"] = ""; //存货自由项2，string类型
//            //setAttribute(ele, "cbatch", "123"); //批号，string类型
//            //domBody[0]["iinvexchrate"] = ""; //换算率，double类型
//            //domBody[0]["inum"] = ""; //件数，double类型
//            setAttribute(ele, "iquantity", 1); //数量，double类型
//            //domBody[0]["iunitcost"] = ""; //单价，double类型
//            //domBody[0]["iprice"] = ""; //金额，double类型
//            //domBody[0]["ipunitcost"] = ""; //计划单价，double类型
//            //domBody[0]["ipprice"] = ""; //计划金额，double类型
//            //domBody[0]["dvdate"] = ""; //失效日期，DateTime类型
//            //domBody[0]["cobjcode"] = ""; //成本对象编码，string类型
//            //domBody[0]["cname"] = ""; //项目，string类型
//            //domBody[0]["isoutquantity"] = ""; //累计出库数量，double类型
//            //domBody[0]["isoutnum"] = ""; //累计出库件数，double类型
//            //domBody[0]["dsdate"] = ""; //结算日期，DateTime类型
//            //domBody[0]["ifquantity"] = ""; //实际数量，double类型
//            //domBody[0]["ifnum"] = ""; //实际件数，double类型
//            //domBody[0]["cvouchcode"] = ""; //对应入库单id，string类型
//            //domBody[0]["cbatchproperty3"] = ""; //批次属性3，double类型
//            //domBody[0]["cfree3"] = ""; //存货自由项3，string类型
//            //domBody[0]["cfree4"] = ""; //存货自由项4，string类型
//            //domBody[0]["cbatchproperty4"] = ""; //批次属性4，double类型
//            //domBody[0]["cbatchproperty5"] = ""; //批次属性5，double类型
//            //domBody[0]["cfree5"] = ""; //存货自由项5，string类型
//            //domBody[0]["cfree6"] = ""; //存货自由项6，string类型
//            //domBody[0]["cbatchproperty6"] = ""; //批次属性6，string类型
//            //domBody[0]["cbatchproperty7"] = ""; //批次属性7，string类型
//            //domBody[0]["cfree7"] = ""; //存货自由项7，string类型
//            //domBody[0]["cfree8"] = ""; //存货自由项8，string类型
//            //domBody[0]["cbatchproperty8"] = ""; //批次属性8，string类型
//            //domBody[0]["cbatchproperty9"] = ""; //批次属性9，string类型
//            //domBody[0]["cfree9"] = ""; //存货自由项9，string类型
//            //domBody[0]["cfree10"] = ""; //存货自由项10，string类型
//            //domBody[0]["cbatchproperty10"] = ""; //批次属性10，DateTime类型
//            //domBody[0]["cdefine36"] = ""; //表体自定义项15，DateTime类型
//            //domBody[0]["cdefine37"] = ""; //表体自定义项16，DateTime类型
//            //domBody[0]["cinvdefine13"] = ""; //存货自定义项13，string类型
//            //domBody[0]["cinvdefine14"] = ""; //存货自定义项14，string类型
//            //domBody[0]["cinvdefine15"] = ""; //存货自定义项15，string类型
//            //domBody[0]["cinvdefine16"] = ""; //存货自定义项16，string类型
//            //domBody[0]["inquantity"] = ""; //应发数量，double类型
//            //domBody[0]["innum"] = ""; //应发件数，double类型
//            //domBody[0]["dmadedate"] = ""; //生产日期，DateTime类型
//            //domBody[0]["impoids"] = ""; //生产订单子表ID，int类型
//            //domBody[0]["isodid"] = ""; //销售订单子表ID，string类型
//            //domBody[0]["iomomid"] = ""; //委外用料表ID，int类型
//            //domBody[0]["iomodid"] = ""; //委外订单子表ID，int类型
//            //domBody[0]["cbvencode"] = ""; //供应商编码，string类型
//            //domBody[0]["cinvouchcode"] = ""; //对应入库单号，string类型
//            //domBody[0]["imassdate"] = ""; //保质期，int类型
//            //domBody[0]["cassunit"] = ""; //库存单位码，string类型
//            //domBody[0]["cvenname"] = ""; //供应商，string类型
//            //domBody[0]["cposname"] = ""; //货位，string类型
//            //domBody[0]["corufts"] = ""; //对应单据时间戳，string类型
//            //domBody[0]["cmolotcode"] = ""; //生产批号，string类型
//            //domBody[0]["dmsdate"] = ""; //核销日期，DateTime类型
//            //domBody[0]["cmassunit"] = ""; //保质期单位，int类型
//            //domBody[0]["csocode"] = ""; //需求跟踪号，string类型
//            //domBody[0]["cmocode"] = ""; //生产订单号，string类型
//            //domBody[0]["comcode"] = ""; //委外订单号，string类型
//            //domBody[0]["cvmivencode"] = ""; //代管商代码，string类型
//            //domBody[0]["cvmivenname"] = ""; //代管商，string类型
//            //domBody[0]["bvmiused"] = ""; //代管消耗标识，int类型
//            //domBody[0]["ivmisettlequantity"] = ""; //代管挂账确认单数量，double类型
//            //domBody[0]["ivmisettlenum"] = ""; //代管挂账确认单件数，double类型
//            //domBody[0]["productinids"] = ""; //productinids，int类型
//            //domBody[0]["crejectcode"] = ""; //在库不良品处理单号，string类型
//            //domBody[0]["cdemandmemo"] = ""; //需求分类代号说明，string类型
//            //domBody[0]["iordertype"] = ""; //销售订单类别，int类型
//            //domBody[0]["iorderdid"] = ""; //iorderdid，int类型
//            //domBody[0]["iordercode"] = ""; //销售订单号，string类型
//            //domBody[0]["iorderseq"] = ""; //销售订单行号，string类型
//            //domBody[0]["iexpiratdatecalcu"] = ""; //有效期推算方式，int类型
//            //domBody[0]["cexpirationdate"] = ""; //有效期至，string类型
//            //domBody[0]["dexpirationdate"] = ""; //有效期计算项，string类型
//            //domBody[0]["cciqbookcode"] = ""; //手册号，string类型
//            //domBody[0]["ibondedsumqty"] = ""; //累计保税处理抽取数量，string类型
//            //domBody[0]["copdesc"] = ""; //工序说明，string类型
//            //domBody[0]["cmworkcentercode"] = ""; //工作中心编码，string类型
//            //domBody[0]["cmworkcenter"] = ""; //工作中心，string类型
//            //domBody[0]["invcode"] = ""; //产品编码，string类型
//            //domBody[0]["invname"] = ""; //产品，string类型
//            //domBody[0]["cwhpersonname"] = ""; //库管员名称，string类型
//            //domBody[0]["cbaccounter"] = ""; //记账人，string类型
//            //domBody[0]["bcosting"] = ""; //是否核算，string类型
//            //domBody[0]["isotype"] = ""; //需求跟踪方式，int类型
//            //domBody[0]["isoseq"] = ""; //需求跟踪行号，string类型
//            //domBody[0]["imoseq"] = ""; //生产订单行号，string类型
//            //domBody[0]["iopseq"] = ""; //工序行号，string类型
//            //domBody[0]["isquantity"] = ""; //累计核销数量，double类型
//            //domBody[0]["ismaterialfee"] = ""; //累计核销金额，double类型
//            //domBody[0]["cdefine34"] = ""; //表体自定义项13，int类型
//            //domBody[0]["cdefine35"] = ""; //表体自定义项14，int类型
//            //domBody[0]["cwhpersoncode"] = ""; //库管员编码，string类型
//            //domBody[0]["cdefine22"] = ""; //表体自定义项1，string类型
//            //domBody[0]["cdefine28"] = ""; //表体自定义项7，string类型
//            //domBody[0]["cdefine29"] = ""; //表体自定义项8，string类型
//            //domBody[0]["cdefine30"] = ""; //表体自定义项9，string类型
//            //domBody[0]["cdefine31"] = ""; //表体自定义项10，string类型
//            //domBody[0]["cdefine32"] = ""; //表体自定义项11，string类型
//            //domBody[0]["cdefine33"] = ""; //表体自定义项12，string类型
//            //domBody[0]["cinvdefine4"] = ""; //存货自定义项4，string类型
//            //domBody[0]["cinvdefine5"] = ""; //存货自定义项5，string类型
//            //domBody[0]["cinvdefine6"] = ""; //存货自定义项6，string类型
//            //domBody[0]["cinvdefine7"] = ""; //存货自定义项7，string类型
//            //domBody[0]["cinvdefine8"] = ""; //存货自定义项8，string类型
//            //domBody[0]["cinvdefine9"] = ""; //存货自定义项9，string类型
//            //domBody[0]["cinvdefine10"] = ""; //存货自定义项10，string类型
//            //domBody[0]["cinvdefine11"] = ""; //存货自定义项11，string类型
//            //domBody[0]["cinvdefine12"] = ""; //存货自定义项12，string类型
//            //domBody[0]["cbarcode"] = ""; //条形码，string类型
//            //domBody[0]["cdefine23"] = ""; //表体自定义项2，string类型
//            //domBody[0]["cdefine24"] = ""; //表体自定义项3，string类型
//            //domBody[0]["itrids"] = ""; //特殊单据子表标识，double类型
//            //domBody[0]["cdefine25"] = ""; //表体自定义项4，string类型
//            //domBody[0]["cdefine26"] = ""; //表体自定义项5，double类型
//            //domBody[0]["cdefine27"] = ""; //表体自定义项6，double类型
//            //domBody[0]["citemcode"] = ""; //项目编码，string类型
//            //domBody[0]["citem_class"] = ""; //项目大类编码，string类型
//            //domBody[0]["citemcname"] = ""; //项目大类名称，string类型

//            //domHead.loadXML(strH);
//            //domBody.loadXML(strB);


//            string errMsg = "";
//            USERPCO.VoucherCO objPCO = new USERPCO.VoucherCO();
//            objPCO.IniLogin(g_oLogin, errMsg);
//            object domPosition = null;
//            object TimeStamp = null;
//            ADODB.Connection cnnFrom = null;
//            string VouchId = "1000000490";
//            MSXML2.IXMLDOMDocument2 domMsg = new MSXML2.DOMDocument();
//            bool bCheck = false;
//            bool bBeforCheckStock = false;
//            bool bIsRedVouch = false;
//            string sAddedState = "";
//            bool bReMote = false;
//            string voucherType = "11";
//            bool bList = false;
//            VBA.Collection MakeWheres = null;
//            string sWebXml = null;
//            Scripting.Dictionary oGenVouchIds = null;
//            bool auditRes = objPCO.Verify(voucherType, VouchId, ref errMsg, ref cnnFrom, ref TimeStamp, ref domMsg, ref bCheck, ref bBeforCheckStock, ref bList, ref MakeWheres, ref sWebXml, ref oGenVouchIds);
//            if (auditRes)
//            {
//                MessageBox.Show("ok");
//            }
//            else
//            {
//                MessageBox.Show(errMsg);
//            }


//        }
//        #endregion
//        #region 弃审材料出库单
//        public void ToYYUnAuditRdRecord11()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2018-04-26");
//            string sSubId = "AS";
//            string sAccID = "001";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //g_oLogin.cAuditor = "丁一";
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_001_2018;Timeout=60";
//            strConn = "data source=127.0.0.1;user id=sa;password=huzhijin123@;initial catalog=UFDATA_001_2018;Connect Timeout=30;Persist Security Info=True";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from RecordOutQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "id", "1000000490"); //主关键字段，int类型
//            setAttribute(ele, "ccode", "0000000210");  //出库单号，string类型
//            setAttribute(ele, "ddate", dtCreateDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
//            setAttribute(ele, "cwhname", "饮料仓"); //仓库，string类型
//            //setAttribute(ele, "csysbarcode", ""); ///单据条码，string类型
//            //setAttribute(ele, "bmotran", "0"); //自动编号，string类型
//            //setAttribute(ele, "isourcerowno", "");//来源单行号，string类型
//            //setAttribute(ele, "chinvsn", ""); //序列号，string类型




//            ///***************************** 以下是非必输字段 ****************************/
//            //DomHead[0]["cmodifyperson"] = ""; //修改人，string类型
//            //DomHead[0]["dmodifydate"] = ""; //修改日期，DateTime类型
//            setAttribute(ele, "dnmaketime", dtCreateDate.ToString("yyyy-MM-dd"));//制单时间，DateTime类型            
//            //DomHead[0]["dnmodifytime"] = ""; //修改时间，DateTime类型
//            //DomHead[0]["dnverifytime"] = ""; //审核时间，DateTime类型
//            //DomHead[0]["hcinvdefine1"] = ""; //存货自定义项1，string类型
//            //DomHead[0]["hcinvdefine2"] = ""; //存货自定义项2，string类型
//            //DomHead[0]["hcinvdefine3"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine4"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine5"] = ""; //存货自定义项5，string类型
//            //DomHead[0]["hcinvdefine6"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine7"] = ""; //存货自定义项7，string类型
//            //DomHead[0]["hcinvdefine8"] = ""; //存货自定义项8，string类型
//            //DomHead[0]["hcinvdefine9"] = ""; //存货自定义项9，string类型
//            //DomHead[0]["hcinvdefine10"] = ""; //存货自定义项10，string类型
//            //DomHead[0]["hcinvdefine11"] = ""; //存货自定义项11，int类型
//            //DomHead[0]["hcinvdefine12"] = ""; //存货自定义项12，int类型
//            //DomHead[0]["hcinvdefine13"] = ""; //存货自定义项13，double类型
//            //DomHead[0]["hcinvdefine14"] = ""; //存货自定义项14，double类型
//            //DomHead[0]["hcinvdefine15"] = ""; //存货自定义项15，DateTime类型
//            //DomHead[0]["hcinvdefine16"] = ""; //存货自定义项16，DateTime类型
//            setAttribute(ele, "cinvstd", "");//规格型号，string类型           
//            //DomHead[0]["imquantity"] = ""; //产量，double类型
//            //DomHead[0]["cprobatch"] = ""; //生产批号，string类型
//            setAttribute(ele, "cbustype", "领料"); //业务类型，int类型
//            //DomHead[0]["cbuscode"] = ""; //业务号，string类型
//            //DomHead[0]["cchkperson"] = ""; //检验员，string类型
//            //DomHead[0]["crdname"] = ""; //出库类别，string类型
//            //DomHead[0]["cdepname"] = ""; //部门，string类型
//            //DomHead[0]["itopsum"] = ""; //最高库存量，string类型
//            //DomHead[0]["ilowsum"] = ""; //最低库存量，string类型
//            //DomHead[0]["cvenabbname"] = ""; //委外商，string类型
//            //DomHead[0]["bomfirst"] = ""; //bomfirst，string类型
//            //DomHead[0]["isafesum"] = ""; //安全库存量，string类型
//            //DomHead[0]["dveridate"] = ""; //审核日期，DateTime类型
//            //DomHead[0]["crdcode"] = ""; //出库类别编码，string类型
//            setAttribute(ele, "cmemo", "CO生成");//备注，string类型
//            setAttribute(ele, "cmaker", "demo");//制单人，string类型
//            //DomHead[0]["chandler"] = ""; //审核人，string类型
//            //DomHead[0]["caccounter"] = ""; //记账人，string类型
//            //DomHead[0]["ipresent"] = ""; //现存量，string类型
//            //DomHead[0]["cinvname"] = ""; //产品名称，string类型
//            //DomHead[0]["biscomplement"] = ""; //补料标志，int类型
//            //DomHead[0]["cpersonname"] = ""; //业务员，string类型
//            //DomHead[0]["bpositive"] = ""; //红蓝标识，string类型
//            //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            setAttribute(ele, "csource", "库存");  //单据来源，int类型
//            //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//            //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//            //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//            //DomHead[0]["brdflag"] = ""; //收发标志，string类型
//            //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//            //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//            //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//            //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//            //DomHead[0]["cvencode"] = ""; //委外商编码，string类型
//            //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//            //DomHead[0]["cvouchtype"] = ""; //单据类型，string类型
//            setAttribute(ele, "cwhcode", "01"); //仓库编码，string类型
//            //DomHead[0]["cdepcode"] = ""; //部门编码，string类型
//            //DomHead[0]["cpersoncode"] = ""; //业务员编码，string类型
//            setAttribute(ele, "vt_id", "65");//模版号，int类型
//            //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型


//            //broker.AssignNormalValue("domHead", domHead);

//            //给BO表体参数domBody赋值，此BO参数的业务类型为销售订单，属表体参数。BO参数均按引用传递
//            //提示：给BO表体参数domBody赋值有两种方法

//            //方法一是直接传入MSXML2.DOMDocumentClass对象
//            //broker.AssignNormalValue("domBody", new MSXML2.DOMDocumentClass())
//            strSQL = "select * from RecordOutSQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domBody, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();
//            rs = null;

//            //增加表体数据节点z:row
//            eleBody = domBody.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domBody = broker.GetBoParam("domBody");
//            //domBody.RowCount = 1; //设置BO对象行数
//            //可以自由设置BO对象行数为大于零的整数，也可以不设置而自动增加行数
//            //给BO对象的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/


//            ele = domBody.createElement("z:row");
//            eleBody.appendChild(ele);


//            setAttribute(ele, "autoid", "0"); //主关键字段，int类型
//            setAttribute(ele, "cinvcode", "02003"); //材料编码，string类型
//            setAttribute(ele, "editprop", "A"); //编辑属性：A表新增，M表修改，D表删除，string类型
//            //domBody[0]["cbsysbarcode"] = ""; //单据行条码，string类型
//            //domBody[0]["iavaquantity"] = ""; //可用量，string类型
//            //domBody[0]["iavanum"] = ""; //可用件数，string类型
//            //domBody[0]["ipresent"] = ""; //现存量，string类型
//            //domBody[0]["iinvsncount"] = ""; //序列号个数，string类型
//            //domBody[0]["imaids"] = ""; //领料申请单子表id，string类型
//            //domBody[0]["csourcemocode"] = ""; //源订单号，string类型
//            //domBody[0]["isourcemodetailsid"] = ""; //源订单子表标识，string类型
//            setAttribute(ele, "invstd", "");  //产品规格，string类型
//            //domBody[0]["cbmemo"] = ""; //备注，string类型
//            //domBody[0]["applycode"] = ""; //子件补料申请单号，string类型
//            //domBody[0]["applydid"] = ""; //applydid，string类型
//            setAttribute(ele, "irowno", "1"); //行号，string类型
//            //domBody[0]["cbinvsn"] = ""; //序列号，string类型
//            //domBody[0]["strowguid"] = ""; //rowguid，string类型
//            //domBody[0]["cservicecode"] = ""; //服务单号，string类型
//            //domBody[0]["cinvouchtype"] = ""; //对应入库单类型，string类型
//            //domBody[0]["coutvouchid"] = ""; //对应蓝字出库单id，string类型
//            //domBody[0]["coutvouchtype"] = ""; //对应蓝字出库单类型，string类型
//            //domBody[0]["isredoutquantity"] = ""; //对应蓝字出库单退回数量，string类型
//            //domBody[0]["isredoutnum"] = ""; //对应蓝字出库单退回件数，string类型
//            //domBody[0]["ipesotype"] = ""; //需求跟踪方式，string类型
//            //domBody[0]["ipesodid"] = ""; //销售订单子表，string类型
//            //domBody[0]["cpesocode"] = ""; //需求跟踪号，string类型
//            //domBody[0]["ipesoseq"] = ""; //需求跟踪行号，string类型
//            //domBody[0]["bsupersede"] = ""; //替代料，string类型
//            //domBody[0]["isupersedeqty"] = ""; //替代数量，string类型
//            //domBody[0]["isupersedempoids"] = ""; //被替代料生产订单子表id，string类型
//            //domBody[0]["imoallocatesubid"] = ""; //替代料子表subid，string类型
//            //domBody[0]["cinvoucherlineid"] = ""; //源单行ID，string类型
//            //domBody[0]["cinvouchercode"] = ""; //源单号，string类型
//            //domBody[0]["cinvouchertype"] = ""; //源单类型，string类型
//            //domBody[0]["ipresentnum"] = ""; //现存件数，string类型
//            //domBody[0]["cplanlotcode"] = ""; //计划批号，string类型
//            //domBody[0]["bcanreplace"] = ""; //可替代，string类型
//            //domBody[0]["taskguid"] = ""; //taskguid，string类型


//            /***************************** 以下是非必输字段 ****************************/
//            setAttribute(ele, "id", "0");//与主表关联项，int类型
//            //domBody[0]["cinvaddcode"] = ""; //材料代码，string类型
//            setAttribute(ele, "cinvname", "碳酸饮料"); //材料名称，string类型
//            setAttribute(ele, "cinvstd", ""); //规格型号，string类型
//            setAttribute(ele, "cinvm_unit", "个"); //主计量单位，string类型
//            setAttribute(ele, "cinva_unit", "个"); //库存单位，string类型
//            //domBody[0]["creplaceitem"] = ""; //替换件，string类型
//            //domBody[0]["cposition"] = ""; //货位编码，string类型
//            //domBody[0]["cinvdefine1"] = ""; //存货自定义项1，string类型
//            //domBody[0]["cinvdefine2"] = ""; //存货自定义项2，string类型
//            //domBody[0]["cinvdefine3"] = ""; //存货自定义项3，string类型
//            //setAttribute(ele, "cfree1", "蓝色"); //存货自由项1，string类型
//            //domBody[0]["cbatchproperty1"] = ""; //批次属性1，double类型
//            //domBody[0]["cbatchproperty2"] = ""; //批次属性2，double类型
//            //domBody[0]["cfree2"] = ""; //存货自由项2，string类型
//            //setAttribute(ele, "cbatch", "123"); //批号，string类型
//            //domBody[0]["iinvexchrate"] = ""; //换算率，double类型
//            //domBody[0]["inum"] = ""; //件数，double类型
//            setAttribute(ele, "iquantity", 1); //数量，double类型
//            //domBody[0]["iunitcost"] = ""; //单价，double类型
//            //domBody[0]["iprice"] = ""; //金额，double类型
//            //domBody[0]["ipunitcost"] = ""; //计划单价，double类型
//            //domBody[0]["ipprice"] = ""; //计划金额，double类型
//            //domBody[0]["dvdate"] = ""; //失效日期，DateTime类型
//            //domBody[0]["cobjcode"] = ""; //成本对象编码，string类型
//            //domBody[0]["cname"] = ""; //项目，string类型
//            //domBody[0]["isoutquantity"] = ""; //累计出库数量，double类型
//            //domBody[0]["isoutnum"] = ""; //累计出库件数，double类型
//            //domBody[0]["dsdate"] = ""; //结算日期，DateTime类型
//            //domBody[0]["ifquantity"] = ""; //实际数量，double类型
//            //domBody[0]["ifnum"] = ""; //实际件数，double类型
//            //domBody[0]["cvouchcode"] = ""; //对应入库单id，string类型
//            //domBody[0]["cbatchproperty3"] = ""; //批次属性3，double类型
//            //domBody[0]["cfree3"] = ""; //存货自由项3，string类型
//            //domBody[0]["cfree4"] = ""; //存货自由项4，string类型
//            //domBody[0]["cbatchproperty4"] = ""; //批次属性4，double类型
//            //domBody[0]["cbatchproperty5"] = ""; //批次属性5，double类型
//            //domBody[0]["cfree5"] = ""; //存货自由项5，string类型
//            //domBody[0]["cfree6"] = ""; //存货自由项6，string类型
//            //domBody[0]["cbatchproperty6"] = ""; //批次属性6，string类型
//            //domBody[0]["cbatchproperty7"] = ""; //批次属性7，string类型
//            //domBody[0]["cfree7"] = ""; //存货自由项7，string类型
//            //domBody[0]["cfree8"] = ""; //存货自由项8，string类型
//            //domBody[0]["cbatchproperty8"] = ""; //批次属性8，string类型
//            //domBody[0]["cbatchproperty9"] = ""; //批次属性9，string类型
//            //domBody[0]["cfree9"] = ""; //存货自由项9，string类型
//            //domBody[0]["cfree10"] = ""; //存货自由项10，string类型
//            //domBody[0]["cbatchproperty10"] = ""; //批次属性10，DateTime类型
//            //domBody[0]["cdefine36"] = ""; //表体自定义项15，DateTime类型
//            //domBody[0]["cdefine37"] = ""; //表体自定义项16，DateTime类型
//            //domBody[0]["cinvdefine13"] = ""; //存货自定义项13，string类型
//            //domBody[0]["cinvdefine14"] = ""; //存货自定义项14，string类型
//            //domBody[0]["cinvdefine15"] = ""; //存货自定义项15，string类型
//            //domBody[0]["cinvdefine16"] = ""; //存货自定义项16，string类型
//            //domBody[0]["inquantity"] = ""; //应发数量，double类型
//            //domBody[0]["innum"] = ""; //应发件数，double类型
//            //domBody[0]["dmadedate"] = ""; //生产日期，DateTime类型
//            //domBody[0]["impoids"] = ""; //生产订单子表ID，int类型
//            //domBody[0]["isodid"] = ""; //销售订单子表ID，string类型
//            //domBody[0]["iomomid"] = ""; //委外用料表ID，int类型
//            //domBody[0]["iomodid"] = ""; //委外订单子表ID，int类型
//            //domBody[0]["cbvencode"] = ""; //供应商编码，string类型
//            //domBody[0]["cinvouchcode"] = ""; //对应入库单号，string类型
//            //domBody[0]["imassdate"] = ""; //保质期，int类型
//            //domBody[0]["cassunit"] = ""; //库存单位码，string类型
//            //domBody[0]["cvenname"] = ""; //供应商，string类型
//            //domBody[0]["cposname"] = ""; //货位，string类型
//            //domBody[0]["corufts"] = ""; //对应单据时间戳，string类型
//            //domBody[0]["cmolotcode"] = ""; //生产批号，string类型
//            //domBody[0]["dmsdate"] = ""; //核销日期，DateTime类型
//            //domBody[0]["cmassunit"] = ""; //保质期单位，int类型
//            //domBody[0]["csocode"] = ""; //需求跟踪号，string类型
//            //domBody[0]["cmocode"] = ""; //生产订单号，string类型
//            //domBody[0]["comcode"] = ""; //委外订单号，string类型
//            //domBody[0]["cvmivencode"] = ""; //代管商代码，string类型
//            //domBody[0]["cvmivenname"] = ""; //代管商，string类型
//            //domBody[0]["bvmiused"] = ""; //代管消耗标识，int类型
//            //domBody[0]["ivmisettlequantity"] = ""; //代管挂账确认单数量，double类型
//            //domBody[0]["ivmisettlenum"] = ""; //代管挂账确认单件数，double类型
//            //domBody[0]["productinids"] = ""; //productinids，int类型
//            //domBody[0]["crejectcode"] = ""; //在库不良品处理单号，string类型
//            //domBody[0]["cdemandmemo"] = ""; //需求分类代号说明，string类型
//            //domBody[0]["iordertype"] = ""; //销售订单类别，int类型
//            //domBody[0]["iorderdid"] = ""; //iorderdid，int类型
//            //domBody[0]["iordercode"] = ""; //销售订单号，string类型
//            //domBody[0]["iorderseq"] = ""; //销售订单行号，string类型
//            //domBody[0]["iexpiratdatecalcu"] = ""; //有效期推算方式，int类型
//            //domBody[0]["cexpirationdate"] = ""; //有效期至，string类型
//            //domBody[0]["dexpirationdate"] = ""; //有效期计算项，string类型
//            //domBody[0]["cciqbookcode"] = ""; //手册号，string类型
//            //domBody[0]["ibondedsumqty"] = ""; //累计保税处理抽取数量，string类型
//            //domBody[0]["copdesc"] = ""; //工序说明，string类型
//            //domBody[0]["cmworkcentercode"] = ""; //工作中心编码，string类型
//            //domBody[0]["cmworkcenter"] = ""; //工作中心，string类型
//            //domBody[0]["invcode"] = ""; //产品编码，string类型
//            //domBody[0]["invname"] = ""; //产品，string类型
//            //domBody[0]["cwhpersonname"] = ""; //库管员名称，string类型
//            //domBody[0]["cbaccounter"] = ""; //记账人，string类型
//            //domBody[0]["bcosting"] = ""; //是否核算，string类型
//            //domBody[0]["isotype"] = ""; //需求跟踪方式，int类型
//            //domBody[0]["isoseq"] = ""; //需求跟踪行号，string类型
//            //domBody[0]["imoseq"] = ""; //生产订单行号，string类型
//            //domBody[0]["iopseq"] = ""; //工序行号，string类型
//            //domBody[0]["isquantity"] = ""; //累计核销数量，double类型
//            //domBody[0]["ismaterialfee"] = ""; //累计核销金额，double类型
//            //domBody[0]["cdefine34"] = ""; //表体自定义项13，int类型
//            //domBody[0]["cdefine35"] = ""; //表体自定义项14，int类型
//            //domBody[0]["cwhpersoncode"] = ""; //库管员编码，string类型
//            //domBody[0]["cdefine22"] = ""; //表体自定义项1，string类型
//            //domBody[0]["cdefine28"] = ""; //表体自定义项7，string类型
//            //domBody[0]["cdefine29"] = ""; //表体自定义项8，string类型
//            //domBody[0]["cdefine30"] = ""; //表体自定义项9，string类型
//            //domBody[0]["cdefine31"] = ""; //表体自定义项10，string类型
//            //domBody[0]["cdefine32"] = ""; //表体自定义项11，string类型
//            //domBody[0]["cdefine33"] = ""; //表体自定义项12，string类型
//            //domBody[0]["cinvdefine4"] = ""; //存货自定义项4，string类型
//            //domBody[0]["cinvdefine5"] = ""; //存货自定义项5，string类型
//            //domBody[0]["cinvdefine6"] = ""; //存货自定义项6，string类型
//            //domBody[0]["cinvdefine7"] = ""; //存货自定义项7，string类型
//            //domBody[0]["cinvdefine8"] = ""; //存货自定义项8，string类型
//            //domBody[0]["cinvdefine9"] = ""; //存货自定义项9，string类型
//            //domBody[0]["cinvdefine10"] = ""; //存货自定义项10，string类型
//            //domBody[0]["cinvdefine11"] = ""; //存货自定义项11，string类型
//            //domBody[0]["cinvdefine12"] = ""; //存货自定义项12，string类型
//            //domBody[0]["cbarcode"] = ""; //条形码，string类型
//            //domBody[0]["cdefine23"] = ""; //表体自定义项2，string类型
//            //domBody[0]["cdefine24"] = ""; //表体自定义项3，string类型
//            //domBody[0]["itrids"] = ""; //特殊单据子表标识，double类型
//            //domBody[0]["cdefine25"] = ""; //表体自定义项4，string类型
//            //domBody[0]["cdefine26"] = ""; //表体自定义项5，double类型
//            //domBody[0]["cdefine27"] = ""; //表体自定义项6，double类型
//            //domBody[0]["citemcode"] = ""; //项目编码，string类型
//            //domBody[0]["citem_class"] = ""; //项目大类编码，string类型
//            //domBody[0]["citemcname"] = ""; //项目大类名称，string类型

//            //domHead.loadXML(strH);
//            //domBody.loadXML(strB);


//            string errMsg = "";
//            USERPCO.VoucherCO objPCO = new USERPCO.VoucherCO();
//            objPCO.IniLogin(g_oLogin, errMsg);
//            object domPosition = null;
//            object TimeStamp = null;
//            ADODB.Connection cnnFrom = null;
//            string VouchId = "1000000490";
//            MSXML2.IXMLDOMDocument2 domMsg = new MSXML2.DOMDocument();
//            bool bCheck = false;
//            bool bBeforCheckStock = false;
//            bool bIsRedVouch = false;
//            string sAddedState = "";
//            bool bReMote = false;
//            string voucherType = "11";
//            bool bList = false;
//            VBA.Collection MakeWheres = null;
//            string sWebXml = null;
//            Scripting.Dictionary oGenVouchIds = null;
//            bool unAuditRes = objPCO.UnVerify(voucherType, VouchId, ref errMsg, ref cnnFrom, ref TimeStamp, ref domMsg, ref bCheck, ref bList);
//            if (unAuditRes)
//            {
//                MessageBox.Show("ok");
//            }
//            else
//            {
//                MessageBox.Show(errMsg);
//            }


//        }
//        #endregion
//        #region 删除材料出库单
//        public void ToYYDelRdRecord11()
//        {
//            DateTime dtCreateDate = Convert.ToDateTime("2018-04-26");
//            string sSubId = "AS";
//            string sAccID = "001";
//            string sYear = dtCreateDate.ToString("yyyy");
//            string sUserID = "demo";
//            string sPassword = "";
//            string sDate = dtCreateDate.ToString("yyyy-MM-dd");
//            string sServer = "127.0.0.1";
//            string sSerial = "";
//            U8Login.clsLogin g_oLogin = new U8Login.clsLogin();
//            if (!g_oLogin.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + g_oLogin.ShareString, "提示信息");
//                return;
//            }
//            //g_oLogin.cAuditor = "丁一";
//            //
//            string strConn = "Data Source=127.0.0.1;User ID=sa;Password=huzhijin123@;Initial Catalog=UFDATA_001_2018;Timeout=60";
//            strConn = "data source=127.0.0.1;user id=sa;password=huzhijin123@;initial catalog=UFDATA_001_2018;Connect Timeout=30;Persist Security Info=True";
//            strConn = "Provider=SQLOLEDB;" + strConn;
//            ADODB.Connection oCon = new ADODB.Connection();
//            oCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
//            oCon.ConnectionString = strConn;
//            oCon.Open(strConn, "", "", -1);
//            //
//            IXMLDOMDocument2 domHead = new MSXML2.DOMDocument();
//            IXMLDOMDocument2 domBody = new MSXML2.DOMDocument();
//            MSXML2.IXMLDOMElement eleHead;
//            MSXML2.IXMLDOMElement eleBody;
//            MSXML2.IXMLDOMElement ele;
//            ADODB.Recordset rs = new ADODB.Recordset();
//            string strSQL;

//            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

//            strSQL = "select * from RecordOutQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domHead, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();

//            //增加表头数据节点z:row
//            eleHead = domHead.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            ele = domHead.createElement("z:row");
//            //'UPGRADE_WARNING: 未能解析对象 ele 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
//            eleHead.appendChild(ele);

//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domHead = broker.GetBoParam("domHead");
//            //domHead.RowCount = 1; //设置BO对象(表头)行数，只能为一行
//            //给BO对象(表头)的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/
//            setAttribute(ele, "id", "1000000490"); //主关键字段，int类型
//            setAttribute(ele, "ccode", "0000000210");  //出库单号，string类型
//            setAttribute(ele, "ddate", dtCreateDate.ToString("yyyy-MM-dd")); //日期，DateTime类型
//            setAttribute(ele, "cwhname", "饮料仓"); //仓库，string类型
//            //setAttribute(ele, "csysbarcode", ""); ///单据条码，string类型
//            //setAttribute(ele, "bmotran", "0"); //自动编号，string类型
//            //setAttribute(ele, "isourcerowno", "");//来源单行号，string类型
//            //setAttribute(ele, "chinvsn", ""); //序列号，string类型




//            ///***************************** 以下是非必输字段 ****************************/
//            //DomHead[0]["cmodifyperson"] = ""; //修改人，string类型
//            //DomHead[0]["dmodifydate"] = ""; //修改日期，DateTime类型
//            setAttribute(ele, "dnmaketime", dtCreateDate.ToString("yyyy-MM-dd"));//制单时间，DateTime类型            
//            //DomHead[0]["dnmodifytime"] = ""; //修改时间，DateTime类型
//            //DomHead[0]["dnverifytime"] = ""; //审核时间，DateTime类型
//            //DomHead[0]["hcinvdefine1"] = ""; //存货自定义项1，string类型
//            //DomHead[0]["hcinvdefine2"] = ""; //存货自定义项2，string类型
//            //DomHead[0]["hcinvdefine3"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine4"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine5"] = ""; //存货自定义项5，string类型
//            //DomHead[0]["hcinvdefine6"] = ""; //存货自定义项3，string类型
//            //DomHead[0]["hcinvdefine7"] = ""; //存货自定义项7，string类型
//            //DomHead[0]["hcinvdefine8"] = ""; //存货自定义项8，string类型
//            //DomHead[0]["hcinvdefine9"] = ""; //存货自定义项9，string类型
//            //DomHead[0]["hcinvdefine10"] = ""; //存货自定义项10，string类型
//            //DomHead[0]["hcinvdefine11"] = ""; //存货自定义项11，int类型
//            //DomHead[0]["hcinvdefine12"] = ""; //存货自定义项12，int类型
//            //DomHead[0]["hcinvdefine13"] = ""; //存货自定义项13，double类型
//            //DomHead[0]["hcinvdefine14"] = ""; //存货自定义项14，double类型
//            //DomHead[0]["hcinvdefine15"] = ""; //存货自定义项15，DateTime类型
//            //DomHead[0]["hcinvdefine16"] = ""; //存货自定义项16，DateTime类型
//            setAttribute(ele, "cinvstd", "");//规格型号，string类型           
//            //DomHead[0]["imquantity"] = ""; //产量，double类型
//            //DomHead[0]["cprobatch"] = ""; //生产批号，string类型
//            setAttribute(ele, "cbustype", "领料"); //业务类型，int类型
//            //DomHead[0]["cbuscode"] = ""; //业务号，string类型
//            //DomHead[0]["cchkperson"] = ""; //检验员，string类型
//            //DomHead[0]["crdname"] = ""; //出库类别，string类型
//            //DomHead[0]["cdepname"] = ""; //部门，string类型
//            //DomHead[0]["itopsum"] = ""; //最高库存量，string类型
//            //DomHead[0]["ilowsum"] = ""; //最低库存量，string类型
//            //DomHead[0]["cvenabbname"] = ""; //委外商，string类型
//            //DomHead[0]["bomfirst"] = ""; //bomfirst，string类型
//            //DomHead[0]["isafesum"] = ""; //安全库存量，string类型
//            //DomHead[0]["dveridate"] = ""; //审核日期，DateTime类型
//            //DomHead[0]["crdcode"] = ""; //出库类别编码，string类型
//            setAttribute(ele, "cmemo", "CO生成");//备注，string类型
//            setAttribute(ele, "cmaker", "demo");//制单人，string类型
//            //DomHead[0]["chandler"] = ""; //审核人，string类型
//            //DomHead[0]["caccounter"] = ""; //记账人，string类型
//            //DomHead[0]["ipresent"] = ""; //现存量，string类型
//            //DomHead[0]["cinvname"] = ""; //产品名称，string类型
//            //DomHead[0]["biscomplement"] = ""; //补料标志，int类型
//            //DomHead[0]["cpersonname"] = ""; //业务员，string类型
//            //DomHead[0]["bpositive"] = ""; //红蓝标识，string类型
//            //DomHead[0]["cdefine1"] = ""; //表头自定义项1，string类型
//            //DomHead[0]["cdefine11"] = ""; //表头自定义项11，string类型
//            //DomHead[0]["cdefine12"] = ""; //表头自定义项12，string类型
//            //DomHead[0]["cdefine13"] = ""; //表头自定义项13，string类型
//            //DomHead[0]["cdefine14"] = ""; //表头自定义项14，string类型
//            //DomHead[0]["cdefine2"] = ""; //表头自定义项2，string类型
//            //DomHead[0]["cdefine3"] = ""; //表头自定义项3，string类型
//            setAttribute(ele, "csource", "库存");  //单据来源，int类型
//            //DomHead[0]["cdefine5"] = ""; //表头自定义项5，int类型
//            //DomHead[0]["cdefine15"] = ""; //表头自定义项15，int类型
//            //DomHead[0]["cdefine6"] = ""; //表头自定义项6，DateTime类型
//            //DomHead[0]["brdflag"] = ""; //收发标志，string类型
//            //DomHead[0]["cdefine7"] = ""; //表头自定义项7，double类型
//            //DomHead[0]["cdefine16"] = ""; //表头自定义项16，double类型
//            //DomHead[0]["cdefine8"] = ""; //表头自定义项8，string类型
//            //DomHead[0]["cdefine9"] = ""; //表头自定义项9，string类型
//            //DomHead[0]["cvencode"] = ""; //委外商编码，string类型
//            //DomHead[0]["cdefine10"] = ""; //表头自定义项10，string类型
//            //DomHead[0]["cvouchtype"] = ""; //单据类型，string类型
//            setAttribute(ele, "cwhcode", "01"); //仓库编码，string类型
//            //DomHead[0]["cdepcode"] = ""; //部门编码，string类型
//            //DomHead[0]["cpersoncode"] = ""; //业务员编码，string类型
//            setAttribute(ele, "vt_id", "65");//模版号，int类型
//            //DomHead[0]["cdefine4"] = ""; //表头自定义项4，DateTime类型


//            //broker.AssignNormalValue("domHead", domHead);

//            //给BO表体参数domBody赋值，此BO参数的业务类型为销售订单，属表体参数。BO参数均按引用传递
//            //提示：给BO表体参数domBody赋值有两种方法

//            //方法一是直接传入MSXML2.DOMDocumentClass对象
//            //broker.AssignNormalValue("domBody", new MSXML2.DOMDocumentClass())
//            strSQL = "select * from RecordOutSQ where 1=0";
//            rs.Open(strSQL, oCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 0);
//            rs.Save(domBody, ADODB.PersistFormatEnum.adPersistXML);
//            rs.Close();
//            rs = null;

//            //增加表体数据节点z:row
//            eleBody = domBody.selectSingleNode("//rs:data") as MSXML2.IXMLDOMElement;
//            //方法二是构造BusinessObject对象，具体方法如下：
//            //BusinessObject domBody = broker.GetBoParam("domBody");
//            //domBody.RowCount = 1; //设置BO对象行数
//            //可以自由设置BO对象行数为大于零的整数，也可以不设置而自动增加行数
//            //给BO对象的字段赋值，值可以是真实类型，也可以是无类型字符串
//            //以下代码示例只设置第一行值。各字段定义详见API服务接口定义

//            /****************************** 以下是必输字段 ****************************/


//            ele = domBody.createElement("z:row");
//            eleBody.appendChild(ele);


//            setAttribute(ele, "autoid", "0"); //主关键字段，int类型
//            setAttribute(ele, "cinvcode", "02003"); //材料编码，string类型
//            setAttribute(ele, "editprop", "D"); //编辑属性：A表新增，M表修改，D表删除，string类型
//            //domBody[0]["cbsysbarcode"] = ""; //单据行条码，string类型
//            //domBody[0]["iavaquantity"] = ""; //可用量，string类型
//            //domBody[0]["iavanum"] = ""; //可用件数，string类型
//            //domBody[0]["ipresent"] = ""; //现存量，string类型
//            //domBody[0]["iinvsncount"] = ""; //序列号个数，string类型
//            //domBody[0]["imaids"] = ""; //领料申请单子表id，string类型
//            //domBody[0]["csourcemocode"] = ""; //源订单号，string类型
//            //domBody[0]["isourcemodetailsid"] = ""; //源订单子表标识，string类型
//            setAttribute(ele, "invstd", "");  //产品规格，string类型
//            //domBody[0]["cbmemo"] = ""; //备注，string类型
//            //domBody[0]["applycode"] = ""; //子件补料申请单号，string类型
//            //domBody[0]["applydid"] = ""; //applydid，string类型
//            setAttribute(ele, "irowno", "1"); //行号，string类型
//            //domBody[0]["cbinvsn"] = ""; //序列号，string类型
//            //domBody[0]["strowguid"] = ""; //rowguid，string类型
//            //domBody[0]["cservicecode"] = ""; //服务单号，string类型
//            //domBody[0]["cinvouchtype"] = ""; //对应入库单类型，string类型
//            //domBody[0]["coutvouchid"] = ""; //对应蓝字出库单id，string类型
//            //domBody[0]["coutvouchtype"] = ""; //对应蓝字出库单类型，string类型
//            //domBody[0]["isredoutquantity"] = ""; //对应蓝字出库单退回数量，string类型
//            //domBody[0]["isredoutnum"] = ""; //对应蓝字出库单退回件数，string类型
//            //domBody[0]["ipesotype"] = ""; //需求跟踪方式，string类型
//            //domBody[0]["ipesodid"] = ""; //销售订单子表，string类型
//            //domBody[0]["cpesocode"] = ""; //需求跟踪号，string类型
//            //domBody[0]["ipesoseq"] = ""; //需求跟踪行号，string类型
//            //domBody[0]["bsupersede"] = ""; //替代料，string类型
//            //domBody[0]["isupersedeqty"] = ""; //替代数量，string类型
//            //domBody[0]["isupersedempoids"] = ""; //被替代料生产订单子表id，string类型
//            //domBody[0]["imoallocatesubid"] = ""; //替代料子表subid，string类型
//            //domBody[0]["cinvoucherlineid"] = ""; //源单行ID，string类型
//            //domBody[0]["cinvouchercode"] = ""; //源单号，string类型
//            //domBody[0]["cinvouchertype"] = ""; //源单类型，string类型
//            //domBody[0]["ipresentnum"] = ""; //现存件数，string类型
//            //domBody[0]["cplanlotcode"] = ""; //计划批号，string类型
//            //domBody[0]["bcanreplace"] = ""; //可替代，string类型
//            //domBody[0]["taskguid"] = ""; //taskguid，string类型


//            /***************************** 以下是非必输字段 ****************************/
//            setAttribute(ele, "id", "0");//与主表关联项，int类型
//            //domBody[0]["cinvaddcode"] = ""; //材料代码，string类型
//            setAttribute(ele, "cinvname", "碳酸饮料"); //材料名称，string类型
//            setAttribute(ele, "cinvstd", ""); //规格型号，string类型
//            setAttribute(ele, "cinvm_unit", "个"); //主计量单位，string类型
//            setAttribute(ele, "cinva_unit", "个"); //库存单位，string类型
//            //domBody[0]["creplaceitem"] = ""; //替换件，string类型
//            //domBody[0]["cposition"] = ""; //货位编码，string类型
//            //domBody[0]["cinvdefine1"] = ""; //存货自定义项1，string类型
//            //domBody[0]["cinvdefine2"] = ""; //存货自定义项2，string类型
//            //domBody[0]["cinvdefine3"] = ""; //存货自定义项3，string类型
//            //setAttribute(ele, "cfree1", "蓝色"); //存货自由项1，string类型
//            //domBody[0]["cbatchproperty1"] = ""; //批次属性1，double类型
//            //domBody[0]["cbatchproperty2"] = ""; //批次属性2，double类型
//            //domBody[0]["cfree2"] = ""; //存货自由项2，string类型
//            //setAttribute(ele, "cbatch", "123"); //批号，string类型
//            //domBody[0]["iinvexchrate"] = ""; //换算率，double类型
//            //domBody[0]["inum"] = ""; //件数，double类型
//            setAttribute(ele, "iquantity", 1); //数量，double类型
//            //domBody[0]["iunitcost"] = ""; //单价，double类型
//            //domBody[0]["iprice"] = ""; //金额，double类型
//            //domBody[0]["ipunitcost"] = ""; //计划单价，double类型
//            //domBody[0]["ipprice"] = ""; //计划金额，double类型
//            //domBody[0]["dvdate"] = ""; //失效日期，DateTime类型
//            //domBody[0]["cobjcode"] = ""; //成本对象编码，string类型
//            //domBody[0]["cname"] = ""; //项目，string类型
//            //domBody[0]["isoutquantity"] = ""; //累计出库数量，double类型
//            //domBody[0]["isoutnum"] = ""; //累计出库件数，double类型
//            //domBody[0]["dsdate"] = ""; //结算日期，DateTime类型
//            //domBody[0]["ifquantity"] = ""; //实际数量，double类型
//            //domBody[0]["ifnum"] = ""; //实际件数，double类型
//            //domBody[0]["cvouchcode"] = ""; //对应入库单id，string类型
//            //domBody[0]["cbatchproperty3"] = ""; //批次属性3，double类型
//            //domBody[0]["cfree3"] = ""; //存货自由项3，string类型
//            //domBody[0]["cfree4"] = ""; //存货自由项4，string类型
//            //domBody[0]["cbatchproperty4"] = ""; //批次属性4，double类型
//            //domBody[0]["cbatchproperty5"] = ""; //批次属性5，double类型
//            //domBody[0]["cfree5"] = ""; //存货自由项5，string类型
//            //domBody[0]["cfree6"] = ""; //存货自由项6，string类型
//            //domBody[0]["cbatchproperty6"] = ""; //批次属性6，string类型
//            //domBody[0]["cbatchproperty7"] = ""; //批次属性7，string类型
//            //domBody[0]["cfree7"] = ""; //存货自由项7，string类型
//            //domBody[0]["cfree8"] = ""; //存货自由项8，string类型
//            //domBody[0]["cbatchproperty8"] = ""; //批次属性8，string类型
//            //domBody[0]["cbatchproperty9"] = ""; //批次属性9，string类型
//            //domBody[0]["cfree9"] = ""; //存货自由项9，string类型
//            //domBody[0]["cfree10"] = ""; //存货自由项10，string类型
//            //domBody[0]["cbatchproperty10"] = ""; //批次属性10，DateTime类型
//            //domBody[0]["cdefine36"] = ""; //表体自定义项15，DateTime类型
//            //domBody[0]["cdefine37"] = ""; //表体自定义项16，DateTime类型
//            //domBody[0]["cinvdefine13"] = ""; //存货自定义项13，string类型
//            //domBody[0]["cinvdefine14"] = ""; //存货自定义项14，string类型
//            //domBody[0]["cinvdefine15"] = ""; //存货自定义项15，string类型
//            //domBody[0]["cinvdefine16"] = ""; //存货自定义项16，string类型
//            //domBody[0]["inquantity"] = ""; //应发数量，double类型
//            //domBody[0]["innum"] = ""; //应发件数，double类型
//            //domBody[0]["dmadedate"] = ""; //生产日期，DateTime类型
//            //domBody[0]["impoids"] = ""; //生产订单子表ID，int类型
//            //domBody[0]["isodid"] = ""; //销售订单子表ID，string类型
//            //domBody[0]["iomomid"] = ""; //委外用料表ID，int类型
//            //domBody[0]["iomodid"] = ""; //委外订单子表ID，int类型
//            //domBody[0]["cbvencode"] = ""; //供应商编码，string类型
//            //domBody[0]["cinvouchcode"] = ""; //对应入库单号，string类型
//            //domBody[0]["imassdate"] = ""; //保质期，int类型
//            //domBody[0]["cassunit"] = ""; //库存单位码，string类型
//            //domBody[0]["cvenname"] = ""; //供应商，string类型
//            //domBody[0]["cposname"] = ""; //货位，string类型
//            //domBody[0]["corufts"] = ""; //对应单据时间戳，string类型
//            //domBody[0]["cmolotcode"] = ""; //生产批号，string类型
//            //domBody[0]["dmsdate"] = ""; //核销日期，DateTime类型
//            //domBody[0]["cmassunit"] = ""; //保质期单位，int类型
//            //domBody[0]["csocode"] = ""; //需求跟踪号，string类型
//            //domBody[0]["cmocode"] = ""; //生产订单号，string类型
//            //domBody[0]["comcode"] = ""; //委外订单号，string类型
//            //domBody[0]["cvmivencode"] = ""; //代管商代码，string类型
//            //domBody[0]["cvmivenname"] = ""; //代管商，string类型
//            //domBody[0]["bvmiused"] = ""; //代管消耗标识，int类型
//            //domBody[0]["ivmisettlequantity"] = ""; //代管挂账确认单数量，double类型
//            //domBody[0]["ivmisettlenum"] = ""; //代管挂账确认单件数，double类型
//            //domBody[0]["productinids"] = ""; //productinids，int类型
//            //domBody[0]["crejectcode"] = ""; //在库不良品处理单号，string类型
//            //domBody[0]["cdemandmemo"] = ""; //需求分类代号说明，string类型
//            //domBody[0]["iordertype"] = ""; //销售订单类别，int类型
//            //domBody[0]["iorderdid"] = ""; //iorderdid，int类型
//            //domBody[0]["iordercode"] = ""; //销售订单号，string类型
//            //domBody[0]["iorderseq"] = ""; //销售订单行号，string类型
//            //domBody[0]["iexpiratdatecalcu"] = ""; //有效期推算方式，int类型
//            //domBody[0]["cexpirationdate"] = ""; //有效期至，string类型
//            //domBody[0]["dexpirationdate"] = ""; //有效期计算项，string类型
//            //domBody[0]["cciqbookcode"] = ""; //手册号，string类型
//            //domBody[0]["ibondedsumqty"] = ""; //累计保税处理抽取数量，string类型
//            //domBody[0]["copdesc"] = ""; //工序说明，string类型
//            //domBody[0]["cmworkcentercode"] = ""; //工作中心编码，string类型
//            //domBody[0]["cmworkcenter"] = ""; //工作中心，string类型
//            //domBody[0]["invcode"] = ""; //产品编码，string类型
//            //domBody[0]["invname"] = ""; //产品，string类型
//            //domBody[0]["cwhpersonname"] = ""; //库管员名称，string类型
//            //domBody[0]["cbaccounter"] = ""; //记账人，string类型
//            //domBody[0]["bcosting"] = ""; //是否核算，string类型
//            //domBody[0]["isotype"] = ""; //需求跟踪方式，int类型
//            //domBody[0]["isoseq"] = ""; //需求跟踪行号，string类型
//            //domBody[0]["imoseq"] = ""; //生产订单行号，string类型
//            //domBody[0]["iopseq"] = ""; //工序行号，string类型
//            //domBody[0]["isquantity"] = ""; //累计核销数量，double类型
//            //domBody[0]["ismaterialfee"] = ""; //累计核销金额，double类型
//            //domBody[0]["cdefine34"] = ""; //表体自定义项13，int类型
//            //domBody[0]["cdefine35"] = ""; //表体自定义项14，int类型
//            //domBody[0]["cwhpersoncode"] = ""; //库管员编码，string类型
//            //domBody[0]["cdefine22"] = ""; //表体自定义项1，string类型
//            //domBody[0]["cdefine28"] = ""; //表体自定义项7，string类型
//            //domBody[0]["cdefine29"] = ""; //表体自定义项8，string类型
//            //domBody[0]["cdefine30"] = ""; //表体自定义项9，string类型
//            //domBody[0]["cdefine31"] = ""; //表体自定义项10，string类型
//            //domBody[0]["cdefine32"] = ""; //表体自定义项11，string类型
//            //domBody[0]["cdefine33"] = ""; //表体自定义项12，string类型
//            //domBody[0]["cinvdefine4"] = ""; //存货自定义项4，string类型
//            //domBody[0]["cinvdefine5"] = ""; //存货自定义项5，string类型
//            //domBody[0]["cinvdefine6"] = ""; //存货自定义项6，string类型
//            //domBody[0]["cinvdefine7"] = ""; //存货自定义项7，string类型
//            //domBody[0]["cinvdefine8"] = ""; //存货自定义项8，string类型
//            //domBody[0]["cinvdefine9"] = ""; //存货自定义项9，string类型
//            //domBody[0]["cinvdefine10"] = ""; //存货自定义项10，string类型
//            //domBody[0]["cinvdefine11"] = ""; //存货自定义项11，string类型
//            //domBody[0]["cinvdefine12"] = ""; //存货自定义项12，string类型
//            //domBody[0]["cbarcode"] = ""; //条形码，string类型
//            //domBody[0]["cdefine23"] = ""; //表体自定义项2，string类型
//            //domBody[0]["cdefine24"] = ""; //表体自定义项3，string类型
//            //domBody[0]["itrids"] = ""; //特殊单据子表标识，double类型
//            //domBody[0]["cdefine25"] = ""; //表体自定义项4，string类型
//            //domBody[0]["cdefine26"] = ""; //表体自定义项5，double类型
//            //domBody[0]["cdefine27"] = ""; //表体自定义项6，double类型
//            //domBody[0]["citemcode"] = ""; //项目编码，string类型
//            //domBody[0]["citem_class"] = ""; //项目大类编码，string类型
//            //domBody[0]["citemcname"] = ""; //项目大类名称，string类型

//            //domHead.loadXML(strH);
//            //domBody.loadXML(strB);


//            string errMsg = "";
//            USERPCO.VoucherCO objPCO = new USERPCO.VoucherCO();
//            objPCO.IniLogin(g_oLogin, errMsg);
//            object domPosition = null;
//            object TimeStamp = null;
//            ADODB.Connection cnnFrom = null;
//            string VouchId = "1000000490";
//            MSXML2.IXMLDOMDocument2 domMsg = new MSXML2.DOMDocument();
//            bool bCheck = false;
//            bool bBeforCheckStock = false;
//            bool bIsRedVouch = false;
//            string sAddedState = "";
//            bool bReMote = false;
//            string voucherType = "11";
//            bool bList = false;
//            VBA.Collection MakeWheres = null;
//            string sWebXml = null;
//            Scripting.Dictionary oGenVouchIds = null;
//            bool auditRes = objPCO.Delete(voucherType, VouchId, ref errMsg, ref cnnFrom, ref TimeStamp, ref domMsg, ref bCheck, ref bList);
//            if (auditRes)
//            {
//                MessageBox.Show("ok");
//            }
//            else
//            {
//                MessageBox.Show(errMsg);
//            }


//        }
//        #endregion

//        #region 调用U8API的辅助类
//        private void setAttribute(MSXML2.IXMLDOMElement nd, string name, object value)
//        {
//            string strValue = "";
//            if (value != null && value != DBNull.Value)
//                strValue = value.ToString();
//            nd.setAttribute(name, strValue);
//        }
//        #endregion
//    }
//}