using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace 中国数字书法.bo
{
    class MusicBo:BaseBo
    {
        public MusicBo() { }

        /* 属性定义区域 */
        public const String TableName = "MUSIC";

        public enum TableAttr
        {
            ID,
            TITLE,
            MUSIC_PATH
        }

        /*查询方法区域*/
        public DataSet listAll()
        {
            String sql = "select * from " + TableName;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);
        }

        public DataSet listByTitle(String title)
        {
            String sql = "select * from " + TableName
                + " where "
                + TableAttr.TITLE.ToString() + "=" + title;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);
        }
        
        
    }
}
