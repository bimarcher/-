using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace 中国数字书法.bo
{
    class DataDictBo:IBusinessObject
    {
        public DataDictBo(){ }
       
        public const String m_table_name = "DATA_DICT";

        public enum DataDictAttr
        {
            CATEGORY,
            KEY,
            LABEL,
            VALUE,
            DESCRIPTION

        }

        public List<IBusinessObject> list = new List<IBusinessObject>();

        private Dictionary<DataDictAttr, String> attrDict = new Dictionary<DataDictAttr, String>();

         
        public List<IBusinessObject> List
        {
            get { return list; }
        }

        public void setAttr(DataDictAttr attrKey, String attrValue)
        {
            this.attrDict.Add(attrKey, attrValue);
        }

        public String getAttr(DataDictAttr attrKey)
        {
            return this.attrDict[attrKey];
        }

        private String category;
        public String Category
        {
            get { return category; }
            set { category = value; }
        }

        private String key;
        public String Key
        {
            get { return key; }
            set { key = value; }
        }

        private String label;
        public String Label
        {
            get { return label; }
            set { label = value; }
        }

        private String value;
        public String Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        private String description;
        public String Description
        {
            get { return description; }
            set { description = value; }
        }


        public string showBoInfo()
        {
            return "DataDictBoInfo："
                + "\n\t" + "category=" + category
                + "\n\t" + "key=" + key
                + "\n\t" + "label=" + label
                + "\n\t" + "value=" + value
                + "\n\t" + "description=" + description;
        }
        /**查询方法区**/
        public DataSet listAll()
        {
            String sql = "select * from " + m_table_name;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);       
        }

        public DataSet listByCategoryAndKey(String category,String key)
        {
            String sql = "select * from " + m_table_name + " where CATEGORY=" + category + "and key=" + key;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);
        }
        public void translateToBoList(DataSet ds)
        {
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        Console.WriteLine("{0}, {1}, {2} ", dt.TableName, dc.ColumnName, dr[dc]);
            }

        }


    }
}
