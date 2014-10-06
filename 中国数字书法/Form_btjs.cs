using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 中国数字书法
{
    public partial class Form_btjs : Form
    {
        string imageListkey = "";
        int position = 0;
        string strSub = "";
        string imageName = "";
        public Form_btjs()
        {
            InitializeComponent();
        }

        public Form_btjs(string str,ImageList imagelist)
        {
            InitializeComponent();
            this.imageList1 = imagelist;
            strSub = Toolimp.getSystemMainDir();
            imageListkey = str;

            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                if (Toolimp.GetNameNoSuffix(imageList1.Images.Keys[i].ToString()).Equals(imageListkey))
                {
                    position = i;
                    this.imageName = imageList1.Images.Keys[i].ToString();
                }
            }
            
        }

        private void Form_btjs_Load(object sender, EventArgs e)
        {
            pboxshow.Image = Image.FromFile(@strSub + "\\image\\bt\\yt\\" + this.imageName);
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (position >= 1)
            {
                position--;
                this.imageName = imageList1.Images.Keys[position];
                pboxshow.Image = Image.FromFile(@strSub + "\\image\\bt\\yt\\" + this.imageName);
            }
            else
            {
                MessageBox.Show("起始数据!", "ERROR");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (position > imageList1.Images.Count - 2)
            {
                MessageBox.Show("无相关数据!", "ERROR");
            }
            else
            {
                position++;
                this.imageName = imageList1.Images.Keys[position];
                pboxshow.Image = Image.FromFile(@strSub + "\\image\\bt\\yt\\" + this.imageName);
            }
        }

        private void btn_fd_Click(object sender, EventArgs e)
        {
           
            Form_btfd form_btfd = new Form_btfd(imageListkey,this.imageList1);
            form_btfd.Show();
            this.Hide();
        }

        private void btn_fh_Click(object sender, EventArgs e)
        {
            Form_main form_main = new Form_main();
            form_main.Show();
            this.Close();
        }


    }
}
