using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace 中国数字书法.bo
{
    interface IBusinessObject
    {
        DataSet query(String sql);
        DataTable translateToDataTable(DataSet ds);
    }
}
