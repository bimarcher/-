using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 中国数字书法.bo
{
    class BaseBo:IBusinessObject
    {
        public DataTable translateToDataTable(DataSet ds)
        {
            return ds.Tables[0];
        }
    }
}
