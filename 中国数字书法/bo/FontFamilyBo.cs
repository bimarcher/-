using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace 中国数字书法.bo
{
    class FontFamilyBo : BaseBo
    {
        public FontFamilyBo() { }

        /* 属性定义区域 */
        public const String TableName = "FONT_FAMILY";

        public enum TableAttr
        {
            ID,
            FONT_FAMILY,
            FONT,
            FONT_FILE_PATH,
            ARTICLE,
            CALLIGRAPHER,
            FONT_VIDEO_PATH
        }

        /*查询方法区域*/
        public DataSet listAll()
        {
            String sql = "select * from " + TableName;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);
        }

        public DataSet listByFontFamily(String fontFamily)
        {
            String sql = "select * from " + TableName
                + " where "
                + TableAttr.FONT_FAMILY.ToString() + "=" + fontFamily;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);
        }

        public DataSet listByFont(String font)
        {
            String sql = "select * from " + TableName
                + " where "
                + TableAttr.FONT.ToString() + "=" + font;
            SqlConnDs sqlConn = new SqlConnDs();
            return sqlConn.query(sql);
        }
    }
}
