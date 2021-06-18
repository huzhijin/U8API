using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.JSON
{
    public class JsonHelper
    {
        /// <summary>
        /// 把Json字符串转换为DataTable
        /// </summary>
        /// <param name="strJson">Json字符串</param>
        /// <returns></returns>
        public static DataTable JsonToDataTable(string strJson, string JsonKey)
        {
            JObject joA = (JObject)JsonConvert.DeserializeObject(strJson);
            if (joA == null)
            {
                return null;
            }

            Newtonsoft.Json.Linq.JToken TokenA = joA[JsonKey];

            DataTable tb_data = new DataTable();
            tb_data.TableName = JsonKey;

            var objJson = TokenA.ToList();
            for (int i = 0; i < objJson.Count; i++)
            {
                DataRow row = tb_data.NewRow();
                foreach (JProperty jp in objJson[i])
                {
                    string strColumnName = jp.Name;
                    //转义字符
                    string zy = jp.Value.ToString().Replace("\"", "");
                    string strValue = zy;
                    if (tb_data.Columns.Contains(strColumnName) == false)
                    {
                        tb_data.Columns.Add(strColumnName);
                    }
                    row[strColumnName] = strValue;
                }

                tb_data.Rows.Add(row);
            }



            //string strXML = JsonConvert.SerializeObject(tb_data);

            return tb_data;
        }
    }
}
