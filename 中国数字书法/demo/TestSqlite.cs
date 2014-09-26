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

        private void TestSqlite_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bo.DataDictBo dataDictBo = new bo.DataDictBo();
            dataDictBo.Description = "Test";
            String boInfo = dataDictBo.showBoInfo();
            MessageBox.Show(boInfo);
        }

        private void sqLiteDataAdapter1_RowUpdated(object sender, System.Data.Common.RowUpdatedEventArgs e)
        {

        }
    }
}
