using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 中国数字书法.bo
{
    class BaseBo : IBusinessObject
    {
        public DataSet query(String sql)
        {
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);
        }

        public DataTable translateToDataTable(DataSet ds)
        {
            return ds.Tables[0];
        }
    }
}
