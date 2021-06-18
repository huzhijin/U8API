//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;

//namespace U8testVoucherCo
//{
//    public partial class Form1 : Form
//    {
//        #region "常量定义区"
//        //帐套参数
//        public static String sSubId = "AS";
//        public static String sAccID = "(default)@003";
//        public static String sYear = "2021";
//        public static String sDate = "2021-05-05";
//        public static String sServer = "127.0.0.1";
//        public static String sUserID = "demo";
//        public static String sPassword = "";
//        public static String sSerial = "";
//        #endregion
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)//采购订单
//        {

//            U8Login.clsLogin u8Login = new U8Login.clsLogin();

//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {

//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..zpurpoheader_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..zpurpotail_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from zpurpoheader Where cpoid='" + textBox1.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from zpurpotail Where POID IN (SELECT POID FROM zpurpoheader Where cpoid='" + textBox1.Text + "')");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);

//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                //初始化CO
//                Info_PU.ClsS_InforClass Cls = new Info_PU.ClsS_InforClass();
//                Cls.Init(u8Login);
//                //调用CO生成单据
//                VoucherCO_PU.clsVoucherCO_PUClass Co = new VoucherCO_PU.clsVoucherCO_PUClass();
//                Co.Init(VoucherCO_PU.vouchertype.采购订单, u8Login, null, Cls, true, "", "普通采购");//初始化参数
//                var curID = new Object();
//                string Result = Co.VoucherSave(domHead, domBody, 2, ref curID);
//                if (Result == null)
//                {
//                    MessageBox.Show(curID.ToString());
//                }
//                else
//                {
//                    MessageBox.Show(Result);
//                }

//            }
//        }


//        private void button2_Click(object sender, EventArgs e)//采购到货单
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();
//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..pu_ArrHead_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..pu_ArrBody_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from pu_ArrHead Where cCode='" + textBox2.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from pu_ArrBody Where  ID IN (SELECT ID FROM pu_ArrHead Where cCode='" + textBox2.Text + "')");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());

//                Info_PU.ClsS_InforClass Cls = new Info_PU.ClsS_InforClass();
//                Cls.Init(u8Login);
//                VoucherCO_PU.clsVoucherCO_PUClass Co = new VoucherCO_PU.clsVoucherCO_PUClass();
//                Co.Init(VoucherCO_PU.vouchertype.采购到货单, u8Login, null, Cls, true, "0", "普通采购");
//                var curID = new Object();
//                string Result = Co.VoucherSave(domHead, domBody, 2, ref curID);
//                if (Result == null)
//                {
//                    MessageBox.Show(curID.ToString());
//                }
//                else
//                {
//                    MessageBox.Show(Result);
//                }
//            }
//        }

//        private void button3_Click(object sender, EventArgs e) //采购入库单
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();
//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..zpurRkdHead_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..zpurRkdTail_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from zpurRkdHead Where cCode='" + textBox3.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from zpurRkdTail Where  ID IN (SELECT ID FROM zpurRkdHead Where cCode='" + textBox3.Text + "')");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                USERPCO.VoucherCO Co = new USERPCO.VoucherCO();
//                string errMsg = "";
//                Co = new USERPCO.VoucherCO();
//                Co.IniLogin(u8Login, errMsg);
//                string sRet = "";
//                string vNewId = "";
//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                bool Result = Co.Insert("10", domHead, domBody, null, ref sRet, null, ref vNewId);
//                if (Result)
//                {
//                    MessageBox.Show(vNewId.ToString());
//                }
//                else
//                {
//                    MessageBox.Show(sRet.ToString());
//                }
//            }
//        }

//        private void button6_Click(object sender, EventArgs e)//销售订订单
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();

//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {

//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..SaleOrderQ_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..SaleOrderSQ_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from SaleOrderQ Where ID='1000000001'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from SaleOrderSQ  Where ID='1000000001'");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);

//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());

//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                USSAServer.clsSystem Cls = new USSAServer.clsSystem();
//                Cls.Init(u8Login);
//                VoucherCO_Sa.ClsVoucherCO_SAClass Co = new VoucherCO_Sa.ClsVoucherCO_SAClass();
//                Co.Init(VoucherCO_Sa.VoucherTypeSA.SODetails, u8Login, null, "CS", Cls);
//                var curID = new Object();
//                string Result = Co.Save(domHead, domBody, 0, curID);



//            }
//        }



//        private void button5_Click(object sender, EventArgs e)//发货单
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();

//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..Sales_FHD_T_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..Sales_FHD_W_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from Sales_FHD_T Where DLID='1000000003'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from Sales_FHD_W  Where DLID='1000000003'");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);

//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());

//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                USSAServer.clsSystem Cls = new USSAServer.clsSystem();
//                Cls.Init(u8Login);
//                VoucherCO_Sa.ClsVoucherCO_SAClass Co = new VoucherCO_Sa.ClsVoucherCO_SAClass();
//                Co.Init(VoucherCO_Sa.VoucherTypeSA.DispatchBlue, u8Login, null, "CS", Cls);
//                var curID = new Object();
//                string Result = Co.Save(domHead, domBody, 0, ref curID);

//            }
//        }
//        private void button4_Click(object sender, EventArgs e)//销售出库单 KCSaleOutH KCSaleOutB
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();
//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..KCSaleOutH_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..KCSaleOutB_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from KCSaleOutH  Where cCode='" + textBox8.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from KCSaleOutB  Where cCode='" + textBox8.Text + "'");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                USERPCO.VoucherCO Co = new USERPCO.VoucherCO();
//                string errMsg = "";
//                Co = new USERPCO.VoucherCO();
//                Co.IniLogin(u8Login, errMsg);
//                string sRet = "";
//                string vNewId = "";
//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                bool Result = Co.Insert("32", domHead, domBody, null, ref sRet, null, ref vNewId);
//                if (Result)
//                {
//                    MessageBox.Show(vNewId.ToString());
//                }

//            }

//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void button7_Click(object sender, EventArgs e)
//        {

//        }

//        private void button7_Click_1(object sender, EventArgs e)//产成品入库单  RecordInQ RecordInSQ
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();
//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..RecordInQ_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..RecordInSQ_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from RecordInQ Where ccode='" + textBox5.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from RecordInSQ Where  ID IN (SELECT ID FROM RecordInQ Where ccode='" + textBox5.Text + "')");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                USERPCO.VoucherCO Co = new USERPCO.VoucherCO();
//                string errMsg = "";
//                Co = new USERPCO.VoucherCO();
//                Co.IniLogin(u8Login, errMsg);
//                string sRet = "";
//                string vNewId = "";
//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                bool Result = Co.Insert("10", domHead, domBody, null, ref sRet, null, ref vNewId);
//                if (Result)
//                {
//                    MessageBox.Show(vNewId.ToString());
//                }
//                else
//                {
//                    MessageBox.Show(sRet.ToString());
//                }
//            }
//        }

//        private void button8_Click(object sender, EventArgs e)//其他入库单 KCOtherInH KCOtherInB
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();
//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..zpurRkdHead_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..zpurRkdTail_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from KCOtherInH Where ccode='" + textBox6.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from KCOtherInB Where  ID IN (SELECT ID FROM KCOtherInH Where ccode='" + textBox6.Text + "')");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                USERPCO.VoucherCO Co = new USERPCO.VoucherCO();
//                string errMsg = "";
//                Co = new USERPCO.VoucherCO();
//                Co.IniLogin(u8Login, errMsg);
//                string sRet = "";
//                string vNewId = "";
//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                bool Result = Co.Insert("08", domHead, domBody, null, ref sRet, null, ref vNewId);
//                if (Result)
//                {
//                    MessageBox.Show(vNewId.ToString());
//                }
//                else
//                {
//                    MessageBox.Show(sRet.ToString());
//                }
//            }
//        }

//        private void button9_Click(object sender, EventArgs e)//材料出库单 RecordOutQ RecordOutSQ
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();
//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..RecordOutQ_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..RecordOutSQ_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from RecordOutQ Where ccode='" + textBox7.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from RecordOutSQ Where  ID IN (SELECT ID FROM RecordOutQ Where ccode='" + textBox7.Text + "')");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                USERPCO.VoucherCO Co = new USERPCO.VoucherCO();
//                string errMsg = "";
//                Co = new USERPCO.VoucherCO();
//                Co.IniLogin(u8Login, errMsg);
//                string sRet = "";
//                string vNewId = "";
//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                bool Result = Co.Insert("11", domHead, domBody, null, ref sRet, null, ref vNewId);
//                if (Result)
//                {
//                    MessageBox.Show(vNewId.ToString());
//                }
//                else
//                {
//                    MessageBox.Show(sRet.ToString());
//                }
//            }
//        }

//        private void button11_Click(object sender, EventArgs e)//其他出库单 KCOtherOutH  KCOtherOutB
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();
//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..zpurRkdHead_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..zpurRkdTail_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from KCOtherOutH Where ccode='" + textBox9.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from  KCOtherOutB Where  ID IN (SELECT ID FROM KCOtherOutH Where ccode='" + textBox9.Text + "')");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                USERPCO.VoucherCO Co = new USERPCO.VoucherCO();
//                string errMsg = "";
//                Co = new USERPCO.VoucherCO();
//                Co.IniLogin(u8Login, errMsg);
//                string sRet = "";
//                string vNewId = "";
//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                bool Result = Co.Insert("01", domHead, domBody, null, ref sRet, null, ref vNewId);
//                if (Result)
//                {
//                    MessageBox.Show(vNewId.ToString());
//                }
//                else
//                {
//                    MessageBox.Show(sRet.ToString());
//                }
//            }
//        }

//        private void button10_Click(object sender, EventArgs e)//销售发票
//        {

//        }

//        private void button12_Click(object sender, EventArgs e)//采购发票
//        {

//        }

//        private void button13_Click(object sender, EventArgs e)//应收单
//        {

//        }

//        private void button14_Click(object sender, EventArgs e)//收款单
//        {

//        }

//        private void button15_Click(object sender, EventArgs e)//应付单
//        {

//        }

//        private void button16_Click(object sender, EventArgs e)//付款单
//        {

//        }

//        private void button17_Click(object sender, EventArgs e)//调拨单 TransM TransD
//        {
//            U8Login.clsLogin u8Login = new U8Login.clsLogin();
//            if (!u8Login.Login(ref sSubId, ref sAccID, ref sYear, ref sUserID, ref sPassword, ref sDate, ref sServer, ref sSerial))
//            {
//                MessageBox.Show("登陆失败，原因：" + u8Login.ShareString);
//                return;
//            }
//            else
//            {
//                U8.DbHelperSQL.connectionString = u8Login.UFDataConnstringForNet;
//                StringBuilder strMsg = new StringBuilder();
//                StringBuilder Strsql = new StringBuilder();
//                string vNewIDRet = "";
//                DataTable head_data = new DataTable();
//                DataTable body_data = new DataTable();
//                string StrHeadName = "tempdb..TransM_" + Guid.NewGuid().ToString().Replace("-", "");
//                string StrBodyName = "tempdb..TransD_" + Guid.NewGuid().ToString().Replace("-", "");
//                Strsql.Append(" select  * into " + StrHeadName + " from TransM Where ctvcode='" + textBox17.Text + "'");
//                Strsql.Append(" \n select *  into " + StrBodyName + " from  TransD Where  ID IN (SELECT ID FROM TransM Where ctvcode='" + textBox17.Text + "')");
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrHeadName);
//                MSXML2.DOMDocument domHead = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append("select editprop='A',* from " + StrBodyName);
//                MSXML2.DOMDocument domBody = U8.DomHelper.getDom(Strsql.ToString(), u8Login.UfDbName);
//                Strsql = new StringBuilder();
//                Strsql.Append(" if not object_id('" + StrHeadName + "') is null drop table " + StrHeadName);
//                Strsql.Append(" if not object_id('" + StrBodyName + "') is null drop table " + StrBodyName);
//                U8.DbHelperSQL.ExecuteSql(Strsql.ToString());
//                USERPCO.VoucherCO Co = new USERPCO.VoucherCO();
//                string errMsg = "";
//                Co = new USERPCO.VoucherCO();
//                Co.IniLogin(u8Login, errMsg);
//                string sRet = "";
//                string vNewId = "";
//                MSXML2.DOMDocument oDomMsg = new MSXML2.DOMDocument();
//                oDomMsg = new MSXML2.DOMDocument();
//                bool Result = Co.Insert("12", domHead, domBody, null, ref sRet, null, ref vNewId);
//                if (Result)
//                {
//                    MessageBox.Show(vNewId.ToString());
//                }
//                else
//                {
//                    MessageBox.Show(sRet.ToString());
//                }
//            }





//        }

//    }
//}
