using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace 中国数字书法.bo
{
    class VideoBo : BaseBo
    {
        public VideoBo() { }

        /* 属性定义区域 */
        public const String TableName = "VIDEO";

        public enum TableAttr
        {
            ID,
            TITLE,
            AUTHOR,
            ABSTRACT,
            CONTENT,
            VIDEO_PATH,
            FONT
        }

        /*查询方法区域*/
        public DataSet listAll()
        {
            String sql = "select * from " + TableName;
            return query(sql);
        }

        public DataSet listByAuthor(String author)
        {
            String sql = "select * from " + TableName 
                + " where " 
                + TableAttr.AUTHOR.ToString() + "="+author;
            return query(sql);
        }

    }
}
