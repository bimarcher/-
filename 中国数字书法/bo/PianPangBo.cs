using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace 中国数字书法.bo
{
    class PianPangBo : BaseBo
    {
        public PianPangBo() { }

        /* 属性定义区域 */
        public const String TableName = "PIANPANG";

        public enum TableAttr
        {
            ID,
            PIANPANG,
            BIHUA_PIANPANG
        }

        /*查询方法区域*/
        public DataSet listAll()
        {
            String sql = "select * from " + TableName;
            return query(sql);
        }

        public DataSet listByPianpang(String pianpang)
        {
            String sql = "select * from " + TableName
                + " where "
                + TableAttr.PIANPANG.ToString() + "=" + pianpang;
            return query(sql);
        }

    }
}
