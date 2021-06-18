using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.DOM
{
    public class DomHelper
    {
        /// <summary>
        /// 根据SQL语句生成DOMDocumentClass对象
        /// </summary>
        /// <param name="Strsql">SQL语句</param>
        /// <param name="U8Login">U8Login对象</param>
        /// <returns></returns>
        public static MSXML2.DOMDocument getDom(string Strsql, string strConn)
        {
            MSXML2.DOMDocument dom = new MSXML2.DOMDocument();
            ADODB.Connection conn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();

            conn.Open(strConn);

            rs.Open(Strsql, conn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rs.Save(dom, ADODB.PersistFormatEnum.adPersistXML);

            return dom;
        }
        /// <summary>
        /// 給属性赋值
        /// </summary>
        /// <param name="nd">IXMLDOMElement节点</param>
        /// <param name="name">字段名</param>
        /// <param name="value">字段值</param>
        public static void setAttribute(MSXML2.IXMLDOMElement nd, string name, object value)
        {
            string strValue = "";
            if (value != null && value != DBNull.Value)
                strValue = value.ToString();
            nd.setAttribute(name, strValue);
        }
    }
}
