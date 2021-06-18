using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.PU
{
    /// <summary>
    /// 采购订单
    /// </summary>
	[Serializable]
    public class PurchaseOrder
    {
		public zpurpoheader head { get; set; }
		public List<zpurpotail> body { get; set; }
	} 
		/// <summary>
		/// zpurpoheader:实体类(属性说明自动提取数据库字段的描述信息)
		/// </summary>
		[Serializable]
		public partial class zpurpoheader
		{
			public zpurpoheader()
			{ }
			#region Model
			private int _ivtid;
			private int _poid;
			private string _cchanger;
			private string _cbustype;
			private string _cpoid;
			private DateTime _dpodate;
			private string _cvencode;
			private string _cdepcode;
			private string _cpersoncode;
			private string _carrivalplace;
			private string _csccode;
			private decimal? _nflat;
			private decimal? _itaxrate;
			private string _cpaycode;
			private decimal? _icost;
			private decimal? _ibargain;
			private string _cmemo;
			private int? _cstate;
			private int? _idiscounttaxtype;
			private string _cdefine1;
			private string _cdefine2;
			private string _cdefine3;
			private string _cvenabbname;
			private string _cdepname;
			private string _cpayname;
			private string _cpersonname;
			private string _cexch_name;
			private string _cptcode;
			private string _cperiod;
			private string _cmaker;
			private int _ireturncount;
			private int _iverifystateex;
			private bool _iswfcontrolled;
			private string _cverifier;
			private string _cvenname;
			private string _ccloser;
			private string _cptname;
			private string _cscname;
			private DateTime? _cdefine4;
			private int? _cdefine5;
			private DateTime? _cdefine6;
			private decimal? _cdefine7;
			private string _cdefine8;
			private string _cdefine9;
			private string _cvenaddress;
			private string _cvenpostcode;
			private string _cvenregcode;
			private string _cvoucherstate;
			private int? _dplanarrdate;
			private string _cvenbank;
			private string _cvenaccount;
			private string _cvenfax;
			private string _ccontactcode;
			private string _cvenperson;
			private string _cappcode;
			private string _cvenphone;
			private string _cmobilephone;
			private string _cdefine10;
			private string _cdefine11;
			private string _cdefine12;
			private string _cdefine13;
			private string _cdefine14;
			private int? _cdefine15;
			private decimal? _cdefine16;
			private int? _cauthid;
			private string _cvendefine1;
			private string _cvendefine2;
			private string _cvendefine3;
			private string _cvendefine4;
			private string _cvendefine5;
			private string _cvendefine6;
			private string _cvendefine7;
			private string _cvendefine8;
			private string _cvendefine9;
			private string _cvendefine10;
			private int? _cvendefine11;
			private int? _cvendefine12;
			private decimal? _cvendefine13;
			private decimal? _cvendefine14;
			private DateTime? _cvendefine15;
			private DateTime? _cvendefine16;
			private string _clocker;
			private DateTime? _cmaketime;
			private DateTime? _cmodifytime;
			private DateTime? _caudittime;
			private DateTime? _cmodifydate;
			private DateTime? _cauditdate;
			private string _creviser;
			private string _cvenpuomprotocol;
			private string _cvenpuomprotocolname;
			private string _cchangverifier;
			private DateTime? _cchangaudittime;
			private DateTime? _cchangauditdate;
			private string _cbg_auditor;
			private string _cbg_audittime;
			private int? _controlresult;
			private int? _ibg_overflag;
			private int? _iflowid;
			private string _cflowname;
			private bool _bflowprocess;
			private bool _bstorageorder;
			private int _iprintcount;
			private DateTime? _dclosedate;
			private DateTime? _dclosetime;
			private string _csysbarcode;
			private string _ccurrentauditor;
			private string _cgcroutecode;
			private string _cgcroutename;
			private bool _bgctransforming;
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
			public int poid
			{
				set { _poid = value; }
				get { return _poid; }
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
			public string cbustype
			{
				set { _cbustype = value; }
				get { return _cbustype; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cpoid
			{
				set { _cpoid = value; }
				get { return _cpoid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime dpodate
			{
				set { _dpodate = value; }
				get { return _dpodate; }
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
			public string cdepcode
			{
				set { _cdepcode = value; }
				get { return _cdepcode; }
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
			public string carrivalplace
			{
				set { _carrivalplace = value; }
				get { return _carrivalplace; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string csccode
			{
				set { _csccode = value; }
				get { return _csccode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? nflat
			{
				set { _nflat = value; }
				get { return _nflat; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? itaxrate
			{
				set { _itaxrate = value; }
				get { return _itaxrate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cpaycode
			{
				set { _cpaycode = value; }
				get { return _cpaycode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? icost
			{
				set { _icost = value; }
				get { return _icost; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ibargain
			{
				set { _ibargain = value; }
				get { return _ibargain; }
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
			public int? cstate
			{
				set { _cstate = value; }
				get { return _cstate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? idiscounttaxtype
			{
				set { _idiscounttaxtype = value; }
				get { return _idiscounttaxtype; }
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
			public string cvenabbname
			{
				set { _cvenabbname = value; }
				get { return _cvenabbname; }
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
			public string cpayname
			{
				set { _cpayname = value; }
				get { return _cpayname; }
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
			public string cexch_name
			{
				set { _cexch_name = value; }
				get { return _cexch_name; }
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
			public string cperiod
			{
				set { _cperiod = value; }
				get { return _cperiod; }
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
			public string cverifier
			{
				set { _cverifier = value; }
				get { return _cverifier; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenname
			{
				set { _cvenname = value; }
				get { return _cvenname; }
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
			public string cptname
			{
				set { _cptname = value; }
				get { return _cptname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cscname
			{
				set { _cscname = value; }
				get { return _cscname; }
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
			public string cvenaddress
			{
				set { _cvenaddress = value; }
				get { return _cvenaddress; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenpostcode
			{
				set { _cvenpostcode = value; }
				get { return _cvenpostcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenregcode
			{
				set { _cvenregcode = value; }
				get { return _cvenregcode; }
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
			public int? dplanarrdate
			{
				set { _dplanarrdate = value; }
				get { return _dplanarrdate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenbank
			{
				set { _cvenbank = value; }
				get { return _cvenbank; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenaccount
			{
				set { _cvenaccount = value; }
				get { return _cvenaccount; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenfax
			{
				set { _cvenfax = value; }
				get { return _cvenfax; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string ccontactcode
			{
				set { _ccontactcode = value; }
				get { return _ccontactcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenperson
			{
				set { _cvenperson = value; }
				get { return _cvenperson; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cappcode
			{
				set { _cappcode = value; }
				get { return _cappcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenphone
			{
				set { _cvenphone = value; }
				get { return _cvenphone; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cmobilephone
			{
				set { _cmobilephone = value; }
				get { return _cmobilephone; }
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
			public int? cauthid
			{
				set { _cauthid = value; }
				get { return _cauthid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine1
			{
				set { _cvendefine1 = value; }
				get { return _cvendefine1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine2
			{
				set { _cvendefine2 = value; }
				get { return _cvendefine2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine3
			{
				set { _cvendefine3 = value; }
				get { return _cvendefine3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine4
			{
				set { _cvendefine4 = value; }
				get { return _cvendefine4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine5
			{
				set { _cvendefine5 = value; }
				get { return _cvendefine5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine6
			{
				set { _cvendefine6 = value; }
				get { return _cvendefine6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine7
			{
				set { _cvendefine7 = value; }
				get { return _cvendefine7; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine8
			{
				set { _cvendefine8 = value; }
				get { return _cvendefine8; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine9
			{
				set { _cvendefine9 = value; }
				get { return _cvendefine9; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvendefine10
			{
				set { _cvendefine10 = value; }
				get { return _cvendefine10; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cvendefine11
			{
				set { _cvendefine11 = value; }
				get { return _cvendefine11; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cvendefine12
			{
				set { _cvendefine12 = value; }
				get { return _cvendefine12; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cvendefine13
			{
				set { _cvendefine13 = value; }
				get { return _cvendefine13; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cvendefine14
			{
				set { _cvendefine14 = value; }
				get { return _cvendefine14; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cvendefine15
			{
				set { _cvendefine15 = value; }
				get { return _cvendefine15; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cvendefine16
			{
				set { _cvendefine16 = value; }
				get { return _cvendefine16; }
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
			public DateTime? cmodifydate
			{
				set { _cmodifydate = value; }
				get { return _cmodifydate; }
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
			public string creviser
			{
				set { _creviser = value; }
				get { return _creviser; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenpuomprotocol
			{
				set { _cvenpuomprotocol = value; }
				get { return _cvenpuomprotocol; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvenpuomprotocolname
			{
				set { _cvenpuomprotocolname = value; }
				get { return _cvenpuomprotocolname; }
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
			public bool bflowprocess
			{
				set { _bflowprocess = value; }
				get { return _bflowprocess; }
			}
			/// <summary>
			/// 
			/// </summary>
			public bool bstorageorder
			{
				set { _bstorageorder = value; }
				get { return _bstorageorder; }
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
			public string cgcroutecode
			{
				set { _cgcroutecode = value; }
				get { return _cgcroutecode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cgcroutename
			{
				set { _cgcroutename = value; }
				get { return _cgcroutename; }
			}
			/// <summary>
			/// 
			/// </summary>
			public bool bGCTransforming
			{
				set { _bgctransforming = value; }
				get { return _bgctransforming; }
			}
		#endregion Model

	}


		/// <summary>
		/// zpurpotail:实体类(属性说明自动提取数据库字段的描述信息)
		/// </summary>
		[Serializable]
		public partial class zpurpotail
		{
			public zpurpotail()
			{ }
			#region Model
			private int _id;
			private int? _poid;
			private int? _iappids;
			private string _cinvcode;
			private string _cinvname;
			private string _cinvstd;
			private string _cinvaddcode;
			private decimal? _iquotedprice;
			private decimal? _iquantity;
			private decimal? _inum;
			private decimal? _iunitprice;
			private decimal? _imoney;
			private decimal? _itax;
			private decimal? _isum;
			private decimal? _idiscount;
			private decimal? _inatunitprice;
			private decimal? _inatmoney;
			private decimal? _inattax;
			private decimal? _inatsum;
			private decimal? _inatdiscount;
			private DateTime? _darrivedate;
			private string _cfree2;
			private string _cfree1;
			private string _cunitid;
			private string _cinvm_unit;
			private int? _igrouptype;
			private string _cgroupcode;
			private string _cinva_unit;
			private decimal? _iinvexchrate;
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
			private string _ccomunitcode;
			private int? _cinvdefine11;
			private int? _cinvdefine12;
			private decimal? _cinvdefine13;
			private decimal? _cinvdefine14;
			private DateTime? _cinvdefine15;
			private DateTime? _cinvdefine16;
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
			private decimal? _ipertaxrate;
			private string _citemcode;
			private string _citemname;
			private string _citem_class;
			private string _citem_name;
			private int? _ppcids;
			private Guid _contractrowguid;
			private string _cfree3;
			private string _cfree4;
			private string _cfree5;
			private string _cfree6;
			private string _cfree7;
			private string _cfree8;
			private string _cfree9;
			private string _cfree10;
			private decimal? _itaxprice;
			private int? _isosid;
			private int? _cinvauthid;
			private bool _btaxcost;
			private decimal? _iarrqty;
			private decimal? _iarrnum;
			private decimal? _iarrmoney;
			private decimal? _inatarrmoney;
			private decimal? _ireceivedqty;
			private decimal? _ireceivednum;
			private decimal? _ireceivedmoney;
			private decimal? _iinvqty;
			private decimal? _iinvnum;
			private decimal? _iinvmoney;
			private decimal? _inatinvmoney;
			private decimal? _ioritotal;
			private decimal? _itotal;
			private int _bgsp;
			private string _csource;
			private string _csocode;
			private string _contractcode;
			private string _contractrowno;
			private int? _irowno;
			private int _sotype;
			private string _sodid;
			private decimal? _iinvmpcost;
			private string _cbcloser;
			private int? _ippartid;
			private decimal? _ipquantity;
			private int? _iptoseq;
			private string _cveninvcode;
			private string _cveninvname;
			private string _cupsocode;
			private string _upsotype;
			private int _iordertype;
			private string _csoordercode;
			private int? _iorderseq;
			private int? _iorderdid;
			private string _cdemandmemo;
			private DateTime? _cbclosetime;
			private DateTime? _cbclosedate;
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
			private decimal? _fexquantity;
			private decimal? _fexnum;
			private int? _ivouchrowno;
			private string _csrpolicy;
			private string _cxjspdids;
			private int? _irequiretrackstyle;
			private int? _ipresentb;
			private string _cinvccode;
			private bool _binvtype;
			private bool _bservice;
			private string _cbmemo;
			private string _cbsysbarcode;
			private string _cplanmethod;
			private string _planlotnumber;
			private int? _bgift;
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
			public int? poid
			{
				set { _poid = value; }
				get { return _poid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? iappids
			{
				set { _iappids = value; }
				get { return _iappids; }
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
			public string cinvaddcode
			{
				set { _cinvaddcode = value; }
				get { return _cinvaddcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iquotedprice
			{
				set { _iquotedprice = value; }
				get { return _iquotedprice; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iquantity
			{
				set { _iquantity = value; }
				get { return _iquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inum
			{
				set { _inum = value; }
				get { return _inum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iunitprice
			{
				set { _iunitprice = value; }
				get { return _iunitprice; }
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
			public decimal? itax
			{
				set { _itax = value; }
				get { return _itax; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? isum
			{
				set { _isum = value; }
				get { return _isum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? idiscount
			{
				set { _idiscount = value; }
				get { return _idiscount; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inatunitprice
			{
				set { _inatunitprice = value; }
				get { return _inatunitprice; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inatmoney
			{
				set { _inatmoney = value; }
				get { return _inatmoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inattax
			{
				set { _inattax = value; }
				get { return _inattax; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inatsum
			{
				set { _inatsum = value; }
				get { return _inatsum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inatdiscount
			{
				set { _inatdiscount = value; }
				get { return _inatdiscount; }
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
			public string cfree2
			{
				set { _cfree2 = value; }
				get { return _cfree2; }
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
			public string cunitid
			{
				set { _cunitid = value; }
				get { return _cunitid; }
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
			public int? igrouptype
			{
				set { _igrouptype = value; }
				get { return _igrouptype; }
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
			public string ccomunitcode
			{
				set { _ccomunitcode = value; }
				get { return _ccomunitcode; }
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
			public decimal? ipertaxrate
			{
				set { _ipertaxrate = value; }
				get { return _ipertaxrate; }
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
			public int? ppcids
			{
				set { _ppcids = value; }
				get { return _ppcids; }
			}
			/// <summary>
			/// 
			/// </summary>
			public Guid contractrowguid
			{
				set { _contractrowguid = value; }
				get { return _contractrowguid; }
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
			public decimal? itaxprice
			{
				set { _itaxprice = value; }
				get { return _itaxprice; }
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
			public int? cinvauthid
			{
				set { _cinvauthid = value; }
				get { return _cinvauthid; }
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
			public decimal? iarrqty
			{
				set { _iarrqty = value; }
				get { return _iarrqty; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iarrnum
			{
				set { _iarrnum = value; }
				get { return _iarrnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iarrmoney
			{
				set { _iarrmoney = value; }
				get { return _iarrmoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inatarrmoney
			{
				set { _inatarrmoney = value; }
				get { return _inatarrmoney; }
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
			public decimal? ireceivednum
			{
				set { _ireceivednum = value; }
				get { return _ireceivednum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ireceivedmoney
			{
				set { _ireceivedmoney = value; }
				get { return _ireceivedmoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iinvqty
			{
				set { _iinvqty = value; }
				get { return _iinvqty; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iinvnum
			{
				set { _iinvnum = value; }
				get { return _iinvnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? iinvmoney
			{
				set { _iinvmoney = value; }
				get { return _iinvmoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inatinvmoney
			{
				set { _inatinvmoney = value; }
				get { return _inatinvmoney; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? ioritotal
			{
				set { _ioritotal = value; }
				get { return _ioritotal; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? itotal
			{
				set { _itotal = value; }
				get { return _itotal; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int bgsp
			{
				set { _bgsp = value; }
				get { return _bgsp; }
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
			public string csocode
			{
				set { _csocode = value; }
				get { return _csocode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string contractcode
			{
				set { _contractcode = value; }
				get { return _contractcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string contractrowno
			{
				set { _contractrowno = value; }
				get { return _contractrowno; }
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
			public string sodid
			{
				set { _sodid = value; }
				get { return _sodid; }
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
			public string cbcloser
			{
				set { _cbcloser = value; }
				get { return _cbcloser; }
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
			public string cveninvcode
			{
				set { _cveninvcode = value; }
				get { return _cveninvcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cveninvname
			{
				set { _cveninvname = value; }
				get { return _cveninvname; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cupsocode
			{
				set { _cupsocode = value; }
				get { return _cupsocode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string upsotype
			{
				set { _upsotype = value; }
				get { return _upsotype; }
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
			public int? iorderdid
			{
				set { _iorderdid = value; }
				get { return _iorderdid; }
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
			public DateTime? cbclosetime
			{
				set { _cbclosetime = value; }
				get { return _cbclosetime; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cbclosedate
			{
				set { _cbclosedate = value; }
				get { return _cbclosedate; }
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
			public decimal? fexquantity
			{
				set { _fexquantity = value; }
				get { return _fexquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fexnum
			{
				set { _fexnum = value; }
				get { return _fexnum; }
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
			public string csrpolicy
			{
				set { _csrpolicy = value; }
				get { return _csrpolicy; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cxjspdids
			{
				set { _cxjspdids = value; }
				get { return _cxjspdids; }
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
			public int? ipresentb
			{
				set { _ipresentb = value; }
				get { return _ipresentb; }
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
			public bool binvtype
			{
				set { _binvtype = value; }
				get { return _binvtype; }
			}
			/// <summary>
			/// 
			/// </summary>
			public bool bservice
			{
				set { _bservice = value; }
				get { return _bservice; }
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
			public string cplanmethod
			{
				set { _cplanmethod = value; }
				get { return _cplanmethod; }
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
			public int? bgift
			{
				set { _bgift = value; }
				get { return _bgift; }
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
