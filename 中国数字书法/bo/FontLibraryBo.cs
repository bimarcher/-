using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace 中国数字书法.bo
{
    class FontLibraryBo : BaseBo
    {
        public FontLibraryBo() { }

        /* 属性定义区域 */
        public const String TableName = "FONT_LIBRARY";

        public enum TableAttr
        {
            ID,
            FONT,
            SPELL,
            BUSHOU,
            PIANPANG,
            STRUCTURE,
            BIHUA_BUWAI,
            BIHUA_BUSHOU,
            BIHUA_TOTLE
        }

        /*查询方法区域*/
        public DataSet listAll()
        {
            String sql = "select * from " + TableName;
            return query(sql);
        }

        public DataSet listByFont(String font)
        {
            String sql = "select * from " + TableName
                + " where "
                + TableAttr.FONT.ToString() + "=" + font;
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
