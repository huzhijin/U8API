using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.PU
{
	/// <summary>
	///请购单
	/// </summary>
	[Serializable]
	public class PurchaseRequisition
    {
		public pu_AppHead head;
		public List<pu_AppBody> body;

	}

		/// <summary>
		/// pu_AppHead:实体类(属性说明自动提取数据库字段的描述信息)
		/// </summary>
		[Serializable]
		public partial class pu_AppHead
		{
			public pu_AppHead()
			{ }
			#region Model
			private int _ivtid;
			private DateTime _ddate;
			private int _id;
			private string _ccode;
			private string _cptcode;
			private string _cptname;
			private string _cdepcode;
			private string _cdepname;
			private string _cpersoncode;
			private string _cpersonname;
			private string _cmemo;
			private string _cbustype;
			private string _cmaker;
			private string _ccloser;
			private string _cverifier;
			private int _ireturncount;
			private int _iverifystateex;
			private bool _iswfcontrolled;
			private string _cdefine1;
			private string _cdefine2;
			private string _cdefine3;
			private DateTime? _cdefine4;
			private int? _cdefine5;
			private DateTime? _cdefine6;
			private decimal? _cdefine7;
			private string _cdefine8;
			private string _cdefine9;
			private string _cdefine10;
			private string _cdefine11;
			private string _cdefine12;
			private string _cdefine13;
			private string _cdefine14;
			private int? _cdefine15;
			private decimal? _cdefine16;
			private string _clocker;
			private DateTime? _cmaketime;
			private DateTime? _cmodifytime;
			private DateTime? _caudittime;
			private DateTime? _cauditdate;
			private DateTime? _cmodifydate;
			private string _creviser;
			private string _cchanger;
			private string _cbg_auditor;
			private string _cbg_audittime;
			private int? _controlresult;
			private int? _ibg_overflag;
			private int? _iflowid;
			private string _cflowname;
			private int _iprintcount;
			private string _cvoucherstate;
			private DateTime? _dclosedate;
			private DateTime? _dclosetime;
			private string _csysbarcode;
			private string _ccurrentauditor;
			private string _cchangverifier;
			private DateTime? _cchangaudittime;
			private DateTime? _cchangauditdate;
			/// <summary>
			/// 
			/// </summary>
			public int ivtid
			{
				set { _ivtid = value; }
				get { return _ivtid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime ddate
			{
				set { _ddate = value; }
				get { return _ddate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int id
			{
				set { _id = value; }
				get { return _id; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string ccode
			{
				set { _ccode = value; }
				get { return _ccode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cptcode
			{
				set { _cptcode = value; }
				get { return _cptcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cptname
			{
				set { _cptname = value; }
				get { return _cptname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdepcode
			{
				set { _cdepcode = value; }
				get { return _cdepcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdepname
			{
				set { _cdepname = value; }
				get { return _cdepname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cpersoncode
			{
				set { _cpersoncode = value; }
				get { return _cpersoncode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cpersonname
			{
				set { _cpersonname = value; }
				get { return _cpersonname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cmemo
			{
				set { _cmemo = value; }
				get { return _cmemo; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbustype
			{
				set { _cbustype = value; }
				get { return _cbustype; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cmaker
			{
				set { _cmaker = value; }
				get { return _cmaker; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string ccloser
			{
				set { _ccloser = value; }
				get { return _ccloser; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cverifier
			{
				set { _cverifier = value; }
				get { return _cverifier; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int ireturncount
			{
				set { _ireturncount = value; }
				get { return _ireturncount; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int iverifystateex
			{
				set { _iverifystateex = value; }
				get { return _iverifystateex; }
			}
			/// <summary>
			/// 
			/// </summary>
			public bool iswfcontrolled
			{
				set { _iswfcontrolled = value; }
				get { return _iswfcontrolled; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine1
			{
				set { _cdefine1 = value; }
				get { return _cdefine1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine2
			{
				set { _cdefine2 = value; }
				get { return _cdefine2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine3
			{
				set { _cdefine3 = value; }
				get { return _cdefine3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cdefine4
			{
				set { _cdefine4 = value; }
				get { return _cdefine4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cdefine5
			{
				set { _cdefine5 = value; }
				get { return _cdefine5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cdefine6
			{
				set { _cdefine6 = value; }
				get { return _cdefine6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cdefine7
			{
				set { _cdefine7 = value; }
				get { return _cdefine7; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine8
			{
				set { _cdefine8 = value; }
				get { return _cdefine8; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine9
			{
				set { _cdefine9 = value; }
				get { return _cdefine9; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine10
			{
				set { _cdefine10 = value; }
				get { return _cdefine10; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine11
			{
				set { _cdefine11 = value; }
				get { return _cdefine11; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine12
			{
				set { _cdefine12 = value; }
				get { return _cdefine12; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine13
			{
				set { _cdefine13 = value; }
				get { return _cdefine13; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine14
			{
				set { _cdefine14 = value; }
				get { return _cdefine14; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cdefine15
			{
				set { _cdefine15 = value; }
				get { return _cdefine15; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cdefine16
			{
				set { _cdefine16 = value; }
				get { return _cdefine16; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string clocker
			{
				set { _clocker = value; }
				get { return _clocker; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cmaketime
			{
				set { _cmaketime = value; }
				get { return _cmaketime; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cmodifytime
			{
				set { _cmodifytime = value; }
				get { return _cmodifytime; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? caudittime
			{
				set { _caudittime = value; }
				get { return _caudittime; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cauditdate
			{
				set { _cauditdate = value; }
				get { return _cauditdate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cmodifydate
			{
				set { _cmodifydate = value; }
				get { return _cmodifydate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string creviser
			{
				set { _creviser = value; }
				get { return _creviser; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cchanger
			{
				set { _cchanger = value; }
				get { return _cchanger; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_auditor
			{
				set { _cbg_auditor = value; }
				get { return _cbg_auditor; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_audittime
			{
				set { _cbg_audittime = value; }
				get { return _cbg_audittime; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? controlresult
			{
				set { _controlresult = value; }
				get { return _controlresult; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? ibg_overflag
			{
				set { _ibg_overflag = value; }
				get { return _ibg_overflag; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? iflowid
			{
				set { _iflowid = value; }
				get { return _iflowid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cflowname
			{
				set { _cflowname = value; }
				get { return _cflowname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int iprintcount
			{
				set { _iprintcount = value; }
				get { return _iprintcount; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvoucherstate
			{
				set { _cvoucherstate = value; }
				get { return _cvoucherstate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? dclosedate
			{
				set { _dclosedate = value; }
				get { return _dclosedate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? dclosetime
			{
				set { _dclosetime = value; }
				get { return _dclosetime; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string csysbarcode
			{
				set { _csysbarcode = value; }
				get { return _csysbarcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string ccurrentauditor
			{
				set { _ccurrentauditor = value; }
				get { return _ccurrentauditor; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cchangverifier
			{
				set { _cchangverifier = value; }
				get { return _cchangverifier; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cchangaudittime
			{
				set { _cchangaudittime = value; }
				get { return _cchangaudittime; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cchangauditdate
			{
				set { _cchangauditdate = value; }
				get { return _cchangauditdate; }
			}
			#endregion Model

		}
	



	/// <summary>
	/// pu_AppBody:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
		public partial class pu_AppBody
		{
			public pu_AppBody()
			{ }
			#region Model
			private int _id;
			private int _autoid;
			private string _cinvcode;
			private int? _igrouptype;
			private string _cinvaddcode;
			private string _cgroupcode;
			private string _cinvname;
			private string _cinvstd;
			private string _cinvccode;
			private string _cinvm_unit;
			private decimal? _ipertaxrate;
			private decimal _fquantity;
			private decimal? _funitprice;
			private decimal? _ftaxprice;
			private decimal? _fmoney;
			private string _cbcloser;
			private DateTime? _drequirdate;
			private DateTime? _darrivedate;
			private string _cfree1;
			private string _cfree2;
			private string _cdefine22;
			private string _cdefine23;
			private string _cdefine24;
			private string _cdefine25;
			private decimal? _cdefine26;
			private decimal? _cdefine27;
			private string _cdefine28;
			private string _cdefine29;
			private string _cdefine30;
			private string _cdefine31;
			private string _cdefine32;
			private string _cdefine33;
			private int? _cdefine34;
			private int? _cdefine35;
			private DateTime? _cdefine36;
			private DateTime? _cdefine37;
			private decimal? _iinvmpcost;
			private string _citemcode;
			private string _citemname;
			private string _citem_class;
			private string _citem_name;
			private string _cvencode;
			private string _cvenabbname;
			private string _cfree3;
			private string _cfree4;
			private string _cfree5;
			private string _cfree6;
			private string _cfree7;
			private string _cfree8;
			private string _cfree9;
			private string _cfree10;
			private string _cinvdefine1;
			private string _cinvdefine2;
			private string _cinvdefine3;
			private string _cinvdefine4;
			private string _cinvdefine5;
			private string _cinvdefine6;
			private string _cinvdefine7;
			private string _cinvdefine8;
			private string _cinvdefine9;
			private string _cinvdefine10;
			private int? _cinvdefine11;
			private int? _cinvdefine12;
			private decimal? _cinvdefine13;
			private decimal? _cinvdefine14;
			private DateTime? _cinvdefine15;
			private DateTime? _cinvdefine16;
			private int? _cinvauthid;
			private int? _cauthid;
			private bool _btaxcost;
			private string _csocode;
			private string _csource;
			private string _sodid;
			private int? _iropsid;
			private int? _imrpsid;
			private string _cdemandcode;
			private string _cdetailsdemandmemo;
			private int? _irowno;
			private int _sotype;
			private string _cdemandmemo;
			private int? _ippartid;
			private decimal? _ipquantity;
			private int? _iptoseq;
			private decimal? _fnum;
			private string _cunitid;
			private string _ccomunitcode;
			private string _cinva_unit;
			private decimal? _iinvexchrate;
			private string _cpersoncodeexec;
			private string _cpersonnameexec;
			private string _cdepcodeexec;
			private string _cdepnameexec;
			private decimal? _ireceivedqty;
			private decimal? _ireceivednum;
			private decimal? _ioricost;
			private decimal? _ioritaxcost;
			private decimal? _iorimoney;
			private decimal? _ioritaxprice;
			private decimal? _iorisum;
			private decimal? _imoney;
			private decimal? _itaxprice;
			private string _cexch_name;
			private decimal? _iexchrate;
			private string _cbg_itemcode;
			private string _cbg_itemname;
			private string _cbg_caliberkey1;
			private string _cbg_caliberkeyname1;
			private string _cbg_caliberkey2;
			private string _cbg_caliberkeyname2;
			private string _cbg_caliberkey3;
			private string _cbg_caliberkeyname3;
			private string _cbg_calibercode1;
			private string _cbg_calibername1;
			private string _cbg_calibercode2;
			private string _cbg_calibername2;
			private string _cbg_calibercode3;
			private string _cbg_calibername3;
			private string _cbg_caliberkey4;
			private string _cbg_caliberkeyname4;
			private string _cbg_caliberkey5;
			private string _cbg_caliberkeyname5;
			private string _cbg_caliberkey6;
			private string _cbg_caliberkeyname6;
			private string _cbg_calibercode4;
			private string _cbg_calibername4;
			private string _cbg_calibercode5;
			private string _cbg_calibername5;
			private string _cbg_calibercode6;
			private string _cbg_calibername6;
			private int? _ibg_ctrl;
			private string _cbg_auditopinion;
			private string _mocode;
			private int? _ivouchrowno;
			private decimal? _fconquantity;
			private decimal? _fconnum;
			private decimal? _fconmoney;
			private decimal? _fconorimoney;
			private string _csrpolicy;
			private int? _irequiretrackstyle;
			private decimal? _isumxjqty;
			private decimal? _isumxjcgqty;
			private DateTime? _dbclosedate;
			private DateTime? _dbclosetime;
			private int _cappadvancecondic;
			private string _cbmemo;
			private string _cbsysbarcode;
			private int? _isosid;
			private int? _iorderdid;
			private int _iordertype;
			private string _csoordercode;
			private int? _iorderseq;
			private string _planlotnumber;
			private string _cplanmethod;
			private string _cfactorycode;
			private string _cfactoryname;
			/// <summary>
			/// 
			/// </summary>
			public int id
			{
				set { _id = value; }
				get { return _id; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int autoid
			{
				set { _autoid = value; }
				get { return _autoid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvcode
			{
				set { _cinvcode = value; }
				get { return _cinvcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? igrouptype
			{
				set { _igrouptype = value; }
				get { return _igrouptype; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvaddcode
			{
				set { _cinvaddcode = value; }
				get { return _cinvaddcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cgroupcode
			{
				set { _cgroupcode = value; }
				get { return _cgroupcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvname
			{
				set { _cinvname = value; }
				get { return _cinvname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvstd
			{
				set { _cinvstd = value; }
				get { return _cinvstd; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvccode
			{
				set { _cinvccode = value; }
				get { return _cinvccode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvm_unit
			{
				set { _cinvm_unit = value; }
				get { return _cinvm_unit; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ipertaxrate
			{
				set { _ipertaxrate = value; }
				get { return _ipertaxrate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal fquantity
			{
				set { _fquantity = value; }
				get { return _fquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? funitprice
			{
				set { _funitprice = value; }
				get { return _funitprice; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ftaxprice
			{
				set { _ftaxprice = value; }
				get { return _ftaxprice; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fmoney
			{
				set { _fmoney = value; }
				get { return _fmoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbcloser
			{
				set { _cbcloser = value; }
				get { return _cbcloser; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? drequirdate
			{
				set { _drequirdate = value; }
				get { return _drequirdate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? darrivedate
			{
				set { _darrivedate = value; }
				get { return _darrivedate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree1
			{
				set { _cfree1 = value; }
				get { return _cfree1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree2
			{
				set { _cfree2 = value; }
				get { return _cfree2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine22
			{
				set { _cdefine22 = value; }
				get { return _cdefine22; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine23
			{
				set { _cdefine23 = value; }
				get { return _cdefine23; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine24
			{
				set { _cdefine24 = value; }
				get { return _cdefine24; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine25
			{
				set { _cdefine25 = value; }
				get { return _cdefine25; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cdefine26
			{
				set { _cdefine26 = value; }
				get { return _cdefine26; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cdefine27
			{
				set { _cdefine27 = value; }
				get { return _cdefine27; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine28
			{
				set { _cdefine28 = value; }
				get { return _cdefine28; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine29
			{
				set { _cdefine29 = value; }
				get { return _cdefine29; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine30
			{
				set { _cdefine30 = value; }
				get { return _cdefine30; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine31
			{
				set { _cdefine31 = value; }
				get { return _cdefine31; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine32
			{
				set { _cdefine32 = value; }
				get { return _cdefine32; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdefine33
			{
				set { _cdefine33 = value; }
				get { return _cdefine33; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cdefine34
			{
				set { _cdefine34 = value; }
				get { return _cdefine34; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cdefine35
			{
				set { _cdefine35 = value; }
				get { return _cdefine35; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cdefine36
			{
				set { _cdefine36 = value; }
				get { return _cdefine36; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cdefine37
			{
				set { _cdefine37 = value; }
				get { return _cdefine37; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iinvmpcost
			{
				set { _iinvmpcost = value; }
				get { return _iinvmpcost; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string citemcode
			{
				set { _citemcode = value; }
				get { return _citemcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string citemname
			{
				set { _citemname = value; }
				get { return _citemname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string citem_class
			{
				set { _citem_class = value; }
				get { return _citem_class; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string citem_name
			{
				set { _citem_name = value; }
				get { return _citem_name; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvencode
			{
				set { _cvencode = value; }
				get { return _cvencode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenabbname
			{
				set { _cvenabbname = value; }
				get { return _cvenabbname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree3
			{
				set { _cfree3 = value; }
				get { return _cfree3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree4
			{
				set { _cfree4 = value; }
				get { return _cfree4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree5
			{
				set { _cfree5 = value; }
				get { return _cfree5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree6
			{
				set { _cfree6 = value; }
				get { return _cfree6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree7
			{
				set { _cfree7 = value; }
				get { return _cfree7; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree8
			{
				set { _cfree8 = value; }
				get { return _cfree8; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree9
			{
				set { _cfree9 = value; }
				get { return _cfree9; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfree10
			{
				set { _cfree10 = value; }
				get { return _cfree10; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine1
			{
				set { _cinvdefine1 = value; }
				get { return _cinvdefine1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine2
			{
				set { _cinvdefine2 = value; }
				get { return _cinvdefine2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine3
			{
				set { _cinvdefine3 = value; }
				get { return _cinvdefine3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine4
			{
				set { _cinvdefine4 = value; }
				get { return _cinvdefine4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine5
			{
				set { _cinvdefine5 = value; }
				get { return _cinvdefine5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine6
			{
				set { _cinvdefine6 = value; }
				get { return _cinvdefine6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine7
			{
				set { _cinvdefine7 = value; }
				get { return _cinvdefine7; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine8
			{
				set { _cinvdefine8 = value; }
				get { return _cinvdefine8; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine9
			{
				set { _cinvdefine9 = value; }
				get { return _cinvdefine9; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinvdefine10
			{
				set { _cinvdefine10 = value; }
				get { return _cinvdefine10; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cinvdefine11
			{
				set { _cinvdefine11 = value; }
				get { return _cinvdefine11; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cinvdefine12
			{
				set { _cinvdefine12 = value; }
				get { return _cinvdefine12; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cinvdefine13
			{
				set { _cinvdefine13 = value; }
				get { return _cinvdefine13; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cinvdefine14
			{
				set { _cinvdefine14 = value; }
				get { return _cinvdefine14; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cinvdefine15
			{
				set { _cinvdefine15 = value; }
				get { return _cinvdefine15; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cinvdefine16
			{
				set { _cinvdefine16 = value; }
				get { return _cinvdefine16; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cinvauthid
			{
				set { _cinvauthid = value; }
				get { return _cinvauthid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cauthid
			{
				set { _cauthid = value; }
				get { return _cauthid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public bool btaxcost
			{
				set { _btaxcost = value; }
				get { return _btaxcost; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string csocode
			{
				set { _csocode = value; }
				get { return _csocode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string csource
			{
				set { _csource = value; }
				get { return _csource; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string sodid
			{
				set { _sodid = value; }
				get { return _sodid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? iropsid
			{
				set { _iropsid = value; }
				get { return _iropsid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? imrpsid
			{
				set { _imrpsid = value; }
				get { return _imrpsid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdemandcode
			{
				set { _cdemandcode = value; }
				get { return _cdemandcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdetailsdemandmemo
			{
				set { _cdetailsdemandmemo = value; }
				get { return _cdetailsdemandmemo; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? irowno
			{
				set { _irowno = value; }
				get { return _irowno; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int sotype
			{
				set { _sotype = value; }
				get { return _sotype; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdemandmemo
			{
				set { _cdemandmemo = value; }
				get { return _cdemandmemo; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? ippartid
			{
				set { _ippartid = value; }
				get { return _ippartid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ipquantity
			{
				set { _ipquantity = value; }
				get { return _ipquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? iptoseq
			{
				set { _iptoseq = value; }
				get { return _iptoseq; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fnum
			{
				set { _fnum = value; }
				get { return _fnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cunitid
			{
				set { _cunitid = value; }
				get { return _cunitid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string ccomunitcode
			{
				set { _ccomunitcode = value; }
				get { return _ccomunitcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cinva_unit
			{
				set { _cinva_unit = value; }
				get { return _cinva_unit; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iinvexchrate
			{
				set { _iinvexchrate = value; }
				get { return _iinvexchrate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cpersoncodeexec
			{
				set { _cpersoncodeexec = value; }
				get { return _cpersoncodeexec; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cpersonnameexec
			{
				set { _cpersonnameexec = value; }
				get { return _cpersonnameexec; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdepcodeexec
			{
				set { _cdepcodeexec = value; }
				get { return _cdepcodeexec; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cdepnameexec
			{
				set { _cdepnameexec = value; }
				get { return _cdepnameexec; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ireceivedqty
			{
				set { _ireceivedqty = value; }
				get { return _ireceivedqty; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iReceivednum
			{
				set { _ireceivednum = value; }
				get { return _ireceivednum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ioricost
			{
				set { _ioricost = value; }
				get { return _ioricost; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ioritaxcost
			{
				set { _ioritaxcost = value; }
				get { return _ioritaxcost; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iorimoney
			{
				set { _iorimoney = value; }
				get { return _iorimoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ioritaxprice
			{
				set { _ioritaxprice = value; }
				get { return _ioritaxprice; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iorisum
			{
				set { _iorisum = value; }
				get { return _iorisum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? imoney
			{
				set { _imoney = value; }
				get { return _imoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? itaxprice
			{
				set { _itaxprice = value; }
				get { return _itaxprice; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cexch_name
			{
				set { _cexch_name = value; }
				get { return _cexch_name; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iexchrate
			{
				set { _iexchrate = value; }
				get { return _iexchrate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_itemcode
			{
				set { _cbg_itemcode = value; }
				get { return _cbg_itemcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_itemname
			{
				set { _cbg_itemname = value; }
				get { return _cbg_itemname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkey1
			{
				set { _cbg_caliberkey1 = value; }
				get { return _cbg_caliberkey1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkeyname1
			{
				set { _cbg_caliberkeyname1 = value; }
				get { return _cbg_caliberkeyname1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkey2
			{
				set { _cbg_caliberkey2 = value; }
				get { return _cbg_caliberkey2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkeyname2
			{
				set { _cbg_caliberkeyname2 = value; }
				get { return _cbg_caliberkeyname2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkey3
			{
				set { _cbg_caliberkey3 = value; }
				get { return _cbg_caliberkey3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkeyname3
			{
				set { _cbg_caliberkeyname3 = value; }
				get { return _cbg_caliberkeyname3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibercode1
			{
				set { _cbg_calibercode1 = value; }
				get { return _cbg_calibercode1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibername1
			{
				set { _cbg_calibername1 = value; }
				get { return _cbg_calibername1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibercode2
			{
				set { _cbg_calibercode2 = value; }
				get { return _cbg_calibercode2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibername2
			{
				set { _cbg_calibername2 = value; }
				get { return _cbg_calibername2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibercode3
			{
				set { _cbg_calibercode3 = value; }
				get { return _cbg_calibercode3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibername3
			{
				set { _cbg_calibername3 = value; }
				get { return _cbg_calibername3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkey4
			{
				set { _cbg_caliberkey4 = value; }
				get { return _cbg_caliberkey4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkeyname4
			{
				set { _cbg_caliberkeyname4 = value; }
				get { return _cbg_caliberkeyname4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkey5
			{
				set { _cbg_caliberkey5 = value; }
				get { return _cbg_caliberkey5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkeyname5
			{
				set { _cbg_caliberkeyname5 = value; }
				get { return _cbg_caliberkeyname5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkey6
			{
				set { _cbg_caliberkey6 = value; }
				get { return _cbg_caliberkey6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_caliberkeyname6
			{
				set { _cbg_caliberkeyname6 = value; }
				get { return _cbg_caliberkeyname6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibercode4
			{
				set { _cbg_calibercode4 = value; }
				get { return _cbg_calibercode4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibername4
			{
				set { _cbg_calibername4 = value; }
				get { return _cbg_calibername4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibercode5
			{
				set { _cbg_calibercode5 = value; }
				get { return _cbg_calibercode5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibername5
			{
				set { _cbg_calibername5 = value; }
				get { return _cbg_calibername5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibercode6
			{
				set { _cbg_calibercode6 = value; }
				get { return _cbg_calibercode6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_calibername6
			{
				set { _cbg_calibername6 = value; }
				get { return _cbg_calibername6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? ibg_ctrl
			{
				set { _ibg_ctrl = value; }
				get { return _ibg_ctrl; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbg_auditopinion
			{
				set { _cbg_auditopinion = value; }
				get { return _cbg_auditopinion; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string mocode
			{
				set { _mocode = value; }
				get { return _mocode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? ivouchrowno
			{
				set { _ivouchrowno = value; }
				get { return _ivouchrowno; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fconquantity
			{
				set { _fconquantity = value; }
				get { return _fconquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fconnum
			{
				set { _fconnum = value; }
				get { return _fconnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fconmoney
			{
				set { _fconmoney = value; }
				get { return _fconmoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fconorimoney
			{
				set { _fconorimoney = value; }
				get { return _fconorimoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string csrpolicy
			{
				set { _csrpolicy = value; }
				get { return _csrpolicy; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? irequiretrackstyle
			{
				set { _irequiretrackstyle = value; }
				get { return _irequiretrackstyle; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? isumxjqty
			{
				set { _isumxjqty = value; }
				get { return _isumxjqty; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? isumxjcgqty
			{
				set { _isumxjcgqty = value; }
				get { return _isumxjcgqty; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? dbclosedate
			{
				set { _dbclosedate = value; }
				get { return _dbclosedate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? dbclosetime
			{
				set { _dbclosetime = value; }
				get { return _dbclosetime; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int cAppAdvanceCondic
			{
				set { _cappadvancecondic = value; }
				get { return _cappadvancecondic; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbmemo
			{
				set { _cbmemo = value; }
				get { return _cbmemo; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbsysbarcode
			{
				set { _cbsysbarcode = value; }
				get { return _cbsysbarcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? isosid
			{
				set { _isosid = value; }
				get { return _isosid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? iorderdid
			{
				set { _iorderdid = value; }
				get { return _iorderdid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int iordertype
			{
				set { _iordertype = value; }
				get { return _iordertype; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string csoordercode
			{
				set { _csoordercode = value; }
				get { return _csoordercode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? iorderseq
			{
				set { _iorderseq = value; }
				get { return _iorderseq; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string planlotnumber
			{
				set { _planlotnumber = value; }
				get { return _planlotnumber; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cplanmethod
			{
				set { _cplanmethod = value; }
				get { return _cplanmethod; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfactorycode
			{
				set { _cfactorycode = value; }
				get { return _cfactorycode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cfactoryname
			{
				set { _cfactoryname = value; }
				get { return _cfactoryname; }
			}
			#endregion Model

		}
	


}
