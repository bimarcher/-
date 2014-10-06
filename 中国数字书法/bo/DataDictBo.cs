using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace 中国数字书法.bo
{
    class DataDictBo : BaseBo
    {
        public DataDictBo(){ }
       
        /* 属性定义区域 */
        public const String TableName = "DATA_DICT";

        public enum TableAttr
        {
            CATEGORY,
            KEY,
            LABEL,
            VALUE,
            DESCRIPTION

        }

        /*查询方法区域*/
        public DataSet listAll()
        {
            String sql = "select * from " + TableName;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);       
        }

        public DataSet listByCategoryAndKey(String category,String key)
        {
            String sql = "select * from " + TableName 
                + " where "
                + TableAttr.CATEGORY.ToString() + "=" + category
                + "and "
                + TableAttr.KEY.ToString() + "=" + key;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);
        }

    }
}
