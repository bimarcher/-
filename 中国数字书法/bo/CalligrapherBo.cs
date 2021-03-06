﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace 中国数字书法.bo
{
    class CalligrapherBo : BaseBo
    {
        public CalligrapherBo() { }
        /* 属性定义区域 */
        public const String TableName = "CALLIGRAPHER";

        public enum TableAttr
        {
            ID,
            NAME,
            AGE,
            STYLE,
            ABSTRACT,
            GOOD_AT
        }

        /*查询方法区域*/
        public DataSet listAll()
        {
            String sql = "select * from " + TableName;
            return query(sql);
        }

        public DataSet findByName(String name)
        {
            String sql = "select * from " + TableName
                + " where "
                + TableAttr.NAME.ToString() + "=" + name;
            return query(sql);
        }

        public DataSet listByStyle(String style)
        {
            String sql = "select * from " + TableName
                + " where "
                + TableAttr.STYLE.ToString() + "=" + style;
            return query(sql);
        }
    }
}
