using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 中国数字书法.demo
{
    public partial class TestSqlite : Form
    {
        public TestSqlite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开始");
            this.sqLiteConnection1.Open();
            this.sqLiteCommand1.CommandText = "INSERT INTO DATA_DICT(CATEGORY,KEY,LABEL,VALUE) VALUES ('11','22','33','44') ";
            int result = this.sqLiteCommand1.ExecuteNonQuery();
            this.sqLiteConnection1.Close();
            MessageBox.Show("结束，result = " + result);

        }
    }
}
