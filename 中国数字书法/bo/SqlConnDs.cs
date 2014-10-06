using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;

//SqlConnDb类,适用于Sql数据库操作
public class SqlConnDs
{
    SQLiteConnection conn = null;  //连接数据库的对象
    private string M_ConnectionKey = "中国数字书法.Properties.Settings.DigitalCalligraphyConnect";

    // 获取数据库链接字符串
    private String getSqlConnStr() {
        return ConfigurationManager.ConnectionStrings[M_ConnectionKey].ToString();//连接数据库的字符串
    }

    // 构造函数,连接数据库，数据库连接字符在web.Config文件的AppSettings下的conStr
    public SqlConnDs()
    {
        if (conn == null)//判断连接是否为空
        {
            conn = new SQLiteConnection(this.getSqlConnStr());
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();//打开数据库连接
            }
        }
    }

    // 从数据库中查询数据的,返回为DataSet
    public DataSet query(string sql)
    {
        DataSet ds = new DataSet();//DataSet是表的集合

        SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);//从数据库中查询

        da.Fill(ds);//将数据填充到DataSet

        closeConn();//关闭连接

        return ds;//返回结果

    }

    // 更新数据库
    public int update(string sql)
    {
        SQLiteCommand oc = new SQLiteCommand();//表示要对数据源执行的SQL语句或存储过程

        oc.CommandText = sql;//设置命令的文本

        oc.CommandType = CommandType.Text;//设置命令的类型

        oc.Connection = conn;//设置命令的连接

        int x = oc.ExecuteNonQuery();//执行SQL语句

        closeConn();//关闭连接

        return x;   //返回一个影响行数

    }

    // 关闭数据库连接
    private void closeConn()
    {
        if (conn.State == ConnectionState.Open)
        {//判断数据库的连接状态，如果状态是打开的话就将它关闭

            conn.Close();
        }
    }

}