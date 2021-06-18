using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8Model.PU
{
    /// <summary>
    /// 到货单
    /// </summary>
   public class ArrivalGoods
    {
		public pu_ArrHead head { get; set; }
		public List<pu_Arrbody> body { get; set; }
	}   
		/// <summary>
		/// pu_ArrHead:实体类(属性说明自动提取数据库字段的描述信息)
		/// </summary>
		[Serializable]
		public partial class pu_ArrHead
		{
			public pu_ArrHead()
			{ }
			#region Model
			private int _ivtid;
			private DateTime _ddate;
			private int _id;
			private string _ccode;
			private string _cptcode;
			private string _cptname;
			private string _cvencode;
			private string _cvenabbname;
			private string _cvenname;
			private string _cdepcode;
			private string _cdepname;
			private string _cpocode;
			private string _cpersoncode;
			private string _cpersonname;
			private string _cpaycode;
			private string _cpayname;
			private string _cexch_name;
			private string _cexch_code;
			private decimal? _iexchrate;
			private string _cmemo;
			private string _cbustype;
			private string _cmaker;
			private int _bnegative;
			private string _ccloser;
			private int? _idiscounttaxtype;
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
			private decimal? _itaxrate;
			private string _csccode;
			private string _cscname;
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
			private int _ibilltype;
			private string _cvouchtype;
			private DateTime? _cmaketime;
			private DateTime? _cmodifytime;
			private DateTime? _cmodifydate;
			private string _creviser;
			private DateTime? _cauditdate;
			private DateTime? _caudittime;
			private string _cverifier;
			private int _iverifystateex;
			private int? _ireturncount;
			private bool _iswfcontrolled;
			private string _cvenpuomprotocol;
			private string _cvenpuomprotocolname;
			private string _cchanger;
			private string _cvoucherstate;
			private int? _iflowid;
			private string _cflowname;
			private bool _bflowprocess;
			private int _bstoragearrivalorder;
			private int _iprintcount;
			private string _csysbarcode;
			private string _ccurrentauditor;
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
			public string cvenname
			{
				set { _cvenname = value; }
				get { return _cvenname; }
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
			public string cpocode
			{
				set { _cpocode = value; }
				get { return _cpocode; }
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
			public string cpaycode
			{
				set { _cpaycode = value; }
				get { return _cpaycode; }
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
			public string cexch_name
			{
				set { _cexch_name = value; }
				get { return _cexch_name; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cexch_code
			{
				set { _cexch_code = value; }
				get { return _cexch_code; }
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
			public int bnegative
			{
				set { _bnegative = value; }
				get { return _bnegative; }
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
			public decimal? itaxrate
			{
				set { _itaxrate = value; }
				get { return _itaxrate; }
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
			public string cscname
			{
				set { _cscname = value; }
				get { return _cscname; }
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
			public int ibilltype
			{
				set { _ibilltype = value; }
				get { return _ibilltype; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cvouchtype
			{
				set { _cvouchtype = value; }
				get { return _cvouchtype; }
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
			public DateTime? cauditdate
			{
				set { _cauditdate = value; }
				get { return _cauditdate; }
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
			public string cverifier
			{
				set { _cverifier = value; }
				get { return _cverifier; }
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
			public int? ireturncount
			{
				set { _ireturncount = value; }
				get { return _ireturncount; }
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
			public string cchanger
			{
				set { _cchanger = value; }
				get { return _cchanger; }
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
			public int bstoragearrivalorder
			{
				set { _bstoragearrivalorder = value; }
				get { return _bstoragearrivalorder; }
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
		#endregion Model

	}

	
		/// <summary>
		/// pu_Arrbody:实体类(属性说明自动提取数据库字段的描述信息)
		/// </summary>
		[Serializable]
		public partial class pu_Arrbody
		{
			public pu_Arrbody()
			{ }
			#region Model
			private int? _id;
			private string _cwhcode;
			private string _cwhname;
			private int _autoid;
			private string _cinvcode;
			private string _cinvaddcode;
			private string _cinvname;
			private string _cinvstd;
			private string _cinvccode;
			private string _cunitid;
			private string _ccomunitcode;
			private string _cinvm_unit;
			private int? _igrouptype;
			private string _cgroupcode;
			private string _cinva_unit;
			private bool _bservice;
			private decimal? _iinvexchrate;
			private bool _binvbatch;
			private string _cbatch;
			private DateTime? _dvdate;
			private DateTime? _dpdate;
			private int? _imassdate;
			private int? _cmassunit;
			private string _cgspstate;
			private string _ccloser;
			private decimal? _ioritaxcost;
			private int? _icorid;
			private decimal _iquantity;
			private decimal? _inum;
			private decimal? _ioricost;
			private decimal? _iorimoney;
			private decimal? _ioritaxprice;
			private decimal? _iorisum;
			private decimal? _icost;
			private decimal? _imoney;
			private decimal? _itaxprice;
			private decimal? _isum;
			private string _cbcloser;
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
			private decimal _itaxrate;
			private string _citemcode;
			private string _citemname;
			private string _citem_class;
			private string _citem_name;
			private int? _iposid;
			private decimal? _fvalidquantity;
			private decimal? _fvalidnum;
			private decimal? _fvalidinquan;
			private decimal? _fvalidinnum;
			private decimal? _fkpquantity;
			private decimal? _finvalidquantity;
			private decimal? _finvalidnum;
			private decimal? _finvalidinquan;
			private decimal? _fretquantity;
			private decimal? _frefusequantity;
			private decimal? _frefusenum;
			private decimal? _frealquantity;
			private decimal? _frealnum;
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
			private bool _rejectsource;
			private int _bgsp;
			private int? _cinvauthid;
			private bool _btaxcost;
			private int _binspect;
			private Guid _contractrowguid;
			private decimal? _iinvmpcost;
			private int? _irowno;
			private int _sotype;
			private string _csocode;
			private string _cdemandmemo;
			private int _iordertype;
			private string _csoordercode;
			private int? _iorderseq;
			private int? _iorderdid;
			private int? _ippartid;
			private decimal? _ipquantity;
			private int? _iptoseq;
			private string _cveninvcode;
			private string _cveninvname;
			private string _sodid;
			private string _cordercode;
			private int _bexigency;
			private string _contractcode;
			private string _contractrowno;
			private decimal? _fretnum;
			private decimal? _fsumrefusequantity;
			private decimal? _fsumrefusenum;
			private decimal? _fdtquantity;
			private decimal? _finvalidinnum;
			private decimal? _finspectquantity;
			private decimal? _finspectnum;
			private int _vouchstate;
			private decimal? _fininquantity;
			private decimal? _fininnum;
			private string _dvalidatedate;
			private decimal? _inspecexchrate;
			private int? _irejectautoid;
			private int? _iexpiratdatecalcu;
			private string _cexpirationdate;
			private DateTime? _dexpirationdate;
			private string _carrivalcode;
			private decimal? _cbatchproperty1;
			private decimal? _cbatchproperty2;
			private decimal? _cbatchproperty3;
			private decimal? _cbatchproperty4;
			private decimal? _cbatchproperty5;
			private string _cbatchproperty6;
			private string _cbatchproperty7;
			private string _cbatchproperty8;
			private string _cbatchproperty9;
			private DateTime? _cbatchproperty10;
			private string _cupsocode;
			private int? _ivouchrowno;
			private string _cbmemo;
			private string _cbsysbarcode;
			private int _iproducttype;
			private string _cmaininvcode;
			private int? _imainmodetailsid;
			private string _isourcemocode;
			private int? _isourcemodetailsid;
			private decimal? _freworkquantity;
			private decimal? _freworknum;
			private decimal? _fsumreworkquantity;
			private decimal? _fsumreworknum;
			private string _planlotnumber;
			private int? _bgift;
			private string _cfactorycode;
			private string _cfactoryname;
			/// <summary>
			/// 
			/// </summary>
			public int? id
			{
				set { _id = value; }
				get { return _id; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cwhcode
			{
				set { _cwhcode = value; }
				get { return _cwhcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cwhname
			{
				set { _cwhname = value; }
				get { return _cwhname; }
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
			public string cinvaddcode
			{
				set { _cinvaddcode = value; }
				get { return _cinvaddcode; }
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
			public bool bservice
			{
				set { _bservice = value; }
				get { return _bservice; }
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
			public bool binvbatch
			{
				set { _binvbatch = value; }
				get { return _binvbatch; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbatch
			{
				set { _cbatch = value; }
				get { return _cbatch; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? dvdate
			{
				set { _dvdate = value; }
				get { return _dvdate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? dpdate
			{
				set { _dpdate = value; }
				get { return _dpdate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? imassdate
			{
				set { _imassdate = value; }
				get { return _imassdate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? cmassunit
			{
				set { _cmassunit = value; }
				get { return _cmassunit; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cgspstate
			{
				set { _cgspstate = value; }
				get { return _cgspstate; }
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
			public decimal? ioritaxcost
			{
				set { _ioritaxcost = value; }
				get { return _ioritaxcost; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? icorid
			{
				set { _icorid = value; }
				get { return _icorid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal iquantity
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
			public decimal? ioricost
			{
				set { _ioricost = value; }
				get { return _ioricost; }
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
			public decimal? icost
			{
				set { _icost = value; }
				get { return _icost; }
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
			public decimal? isum
			{
				set { _isum = value; }
				get { return _isum; }
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
			public decimal itaxrate
			{
				set { _itaxrate = value; }
				get { return _itaxrate; }
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
			public int? iposid
			{
				set { _iposid = value; }
				get { return _iposid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fvalidquantity
			{
				set { _fvalidquantity = value; }
				get { return _fvalidquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fvalidnum
			{
				set { _fvalidnum = value; }
				get { return _fvalidnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fvalidinquan
			{
				set { _fvalidinquan = value; }
				get { return _fvalidinquan; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fvalidinnum
			{
				set { _fvalidinnum = value; }
				get { return _fvalidinnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fkpquantity
			{
				set { _fkpquantity = value; }
				get { return _fkpquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? finvalidquantity
			{
				set { _finvalidquantity = value; }
				get { return _finvalidquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? finvalidnum
			{
				set { _finvalidnum = value; }
				get { return _finvalidnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? finvalidinquan
			{
				set { _finvalidinquan = value; }
				get { return _finvalidinquan; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fretquantity
			{
				set { _fretquantity = value; }
				get { return _fretquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? frefusequantity
			{
				set { _frefusequantity = value; }
				get { return _frefusequantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? frefusenum
			{
				set { _frefusenum = value; }
				get { return _frefusenum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? frealquantity
			{
				set { _frealquantity = value; }
				get { return _frealquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? frealnum
			{
				set { _frealnum = value; }
				get { return _frealnum; }
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
			public bool rejectsource
			{
				set { _rejectsource = value; }
				get { return _rejectsource; }
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
			public int binspect
			{
				set { _binspect = value; }
				get { return _binspect; }
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
			public decimal? iinvmpcost
			{
				set { _iinvmpcost = value; }
				get { return _iinvmpcost; }
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
			public string csocode
			{
				set { _csocode = value; }
				get { return _csocode; }
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
			public string sodid
			{
				set { _sodid = value; }
				get { return _sodid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cordercode
			{
				set { _cordercode = value; }
				get { return _cordercode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int bexigency
			{
				set { _bexigency = value; }
				get { return _bexigency; }
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
			public decimal? fretnum
			{
				set { _fretnum = value; }
				get { return _fretnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fsumrefusequantity
			{
				set { _fsumrefusequantity = value; }
				get { return _fsumrefusequantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fsumrefusenum
			{
				set { _fsumrefusenum = value; }
				get { return _fsumrefusenum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fdtquantity
			{
				set { _fdtquantity = value; }
				get { return _fdtquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? finvalidinnum
			{
				set { _finvalidinnum = value; }
				get { return _finvalidinnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? finspectquantity
			{
				set { _finspectquantity = value; }
				get { return _finspectquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? finspectnum
			{
				set { _finspectnum = value; }
				get { return _finspectnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int vouchstate
			{
				set { _vouchstate = value; }
				get { return _vouchstate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fininquantity
			{
				set { _fininquantity = value; }
				get { return _fininquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fininnum
			{
				set { _fininnum = value; }
				get { return _fininnum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string dValidateDate
			{
				set { _dvalidatedate = value; }
				get { return _dvalidatedate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? inspecexchrate
			{
				set { _inspecexchrate = value; }
				get { return _inspecexchrate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? irejectautoid
			{
				set { _irejectautoid = value; }
				get { return _irejectautoid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? iexpiratdatecalcu
			{
				set { _iexpiratdatecalcu = value; }
				get { return _iexpiratdatecalcu; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cexpirationdate
			{
				set { _cexpirationdate = value; }
				get { return _cexpirationdate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? dexpirationdate
			{
				set { _dexpirationdate = value; }
				get { return _dexpirationdate; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string carrivalcode
			{
				set { _carrivalcode = value; }
				get { return _carrivalcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cbatchproperty1
			{
				set { _cbatchproperty1 = value; }
				get { return _cbatchproperty1; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cbatchproperty2
			{
				set { _cbatchproperty2 = value; }
				get { return _cbatchproperty2; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cbatchproperty3
			{
				set { _cbatchproperty3 = value; }
				get { return _cbatchproperty3; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cbatchproperty4
			{
				set { _cbatchproperty4 = value; }
				get { return _cbatchproperty4; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? cbatchproperty5
			{
				set { _cbatchproperty5 = value; }
				get { return _cbatchproperty5; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbatchproperty6
			{
				set { _cbatchproperty6 = value; }
				get { return _cbatchproperty6; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbatchproperty7
			{
				set { _cbatchproperty7 = value; }
				get { return _cbatchproperty7; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbatchproperty8
			{
				set { _cbatchproperty8 = value; }
				get { return _cbatchproperty8; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cbatchproperty9
			{
				set { _cbatchproperty9 = value; }
				get { return _cbatchproperty9; }
			}
			/// <summary>
			/// 
			/// </summary>
			public DateTime? cbatchproperty10
			{
				set { _cbatchproperty10 = value; }
				get { return _cbatchproperty10; }
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
			public int? ivouchrowno
			{
				set { _ivouchrowno = value; }
				get { return _ivouchrowno; }
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
			public int iproducttype
			{
				set { _iproducttype = value; }
				get { return _iproducttype; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string cmaininvcode
			{
				set { _cmaininvcode = value; }
				get { return _cmaininvcode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? imainmodetailsid
			{
				set { _imainmodetailsid = value; }
				get { return _imainmodetailsid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public string isourcemocode
			{
				set { _isourcemocode = value; }
				get { return _isourcemocode; }
			}
			/// <summary>
			/// 
			/// </summary>
			public int? isourcemodetailsid
			{
				set { _isourcemodetailsid = value; }
				get { return _isourcemodetailsid; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? freworkquantity
			{
				set { _freworkquantity = value; }
				get { return _freworkquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? freworknum
			{
				set { _freworknum = value; }
				get { return _freworknum; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fsumreworkquantity
			{
				set { _fsumreworkquantity = value; }
				get { return _fsumreworkquantity; }
			}
			/// <summary>
			/// 
			/// </summary>
			public decimal? fsumreworknum
			{
				set { _fsumreworknum = value; }
				get { return _fsumreworknum; }
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
