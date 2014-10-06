using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace 中国数字书法
{
    public partial class Form_btsx : Form
    {
        Label[] labels;
        PictureBox[] pictureboxs;
        GroupBox[] groupboxs;

        int pageCount = 1;
        int voice;//声音

        string strSub;
        
        public Form_btsx()
        {
            InitializeComponent();

            this.strSub = Toolimp.getSystemMainDir();
            //加载登录背景
            this.BackgroundImage = Image.FromFile(@strSub + "\\image\\bj\\gbj.png");

            //加载登录音乐
            this.axWindowsMediaPlayer1.URL = @strSub + "\\music\\bjyy\\sound.mp3";
            this.axWindowsMediaPlayer1.Visible = false;

            this.pageCount = 1;
            labels = new Label[10];
            labels[0] = lb1;
            labels[1] = lb2;
            labels[2] = lb3;
            labels[3] = lb4;
            labels[4] = lb5;
            labels[5] = lb6;
            labels[6] = lb7;
            labels[7] = lb8;
            labels[8] = lb9;
            labels[9] = lb10;
            pictureboxs = new PictureBox[10];
            pictureboxs[0] = pbox1;
            pictureboxs[1] = pbox2;
            pictureboxs[2] = pbox3;
            pictureboxs[3] = pbox4;
            pictureboxs[4] = pbox5;
            pictureboxs[5] = pbox6;
            pictureboxs[6] = pbox7;
            pictureboxs[7] = pbox8;
            pictureboxs[8] = pbox9;
            pictureboxs[9] = pbox10;
            groupboxs = new GroupBox[10];
            groupboxs[0] = gbox1;
            groupboxs[1] = gbox2;
            groupboxs[2] = gbox3;
            groupboxs[3] = gbox4;
            groupboxs[4] = gbox5;
            groupboxs[5] = gbox6;
            groupboxs[6] = gbox7;
            groupboxs[7] = gbox8;
            groupboxs[8] = gbox9;
            groupboxs[9] = gbox10;
        }

        //设置声音大小
        public void setVoice(int voice)
        {
            this.axWindowsMediaPlayer1.settings.volume = voice;
        }

        private bool setPagePicShow(int pageCount)
        {
            bool flag = false;

            //开始索引，结束索引
            int endIndex = pageCount * 10 - 1;
            int startIndex = (pageCount - 1) * 10;

            if (imageList1.Images.Count > startIndex)
            {
                if (imageList1.Images.Count > endIndex)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        groupboxs[i - startIndex].Visible = true;
                        labels[i - startIndex].Text = Toolimp.GetNameNoSuffix(imageList1.Images.Keys[i]);
                        pictureboxs[i - startIndex].Image = imageList1.Images[i];
                    }
                }
                else
                {
                    for (int i = startIndex; i <= imageList1.Images.Count-1; i++)
                    {
                        groupboxs[i - startIndex].Visible = true;
                        labels[i - startIndex].Text = Toolimp.GetNameNoSuffix(imageList1.Images.Keys[i]);
                        pictureboxs[i - startIndex].Image = imageList1.Images[i];
                        
                    }

                    for (int i = imageList1.Images.Count; i <= endIndex; i++ )
                    {
                        labels[i - startIndex].Text = null;
                        pictureboxs[i - startIndex].Image = null;
                        groupboxs[i - startIndex].Visible = false;
                    }

                }
                flag = true;
            }

            return flag;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            voice = e.Location.X;
            setVoice(voice);
            panel2.Size = new Size(e.Location.X, 6);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            voice = e.Location.X;
            panel2.Size = new Size(e.Location.X, 6);
            setVoice(voice);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void btn_btsx_Click(object sender, EventArgs e)
        {

        }

        private void btn_rjjs_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_rjjs form_rjjs = new Form_rjjs();
            form_rjjs.Show();
        }

        private void btn_spsx_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_spsx form_spsx = new Form_spsx();
            form_spsx.Show();
        }

        private void btn_dzjs_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_dzjs form_dzjs = new Form_dzjs();
            form_dzjs.Show();
        }

        private void btn_zxjz_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_zxjz form_zxjz = new Form_zxjz();
            form_zxjz.Show();
        }

        private void btn_lmdb_Click(object sender, EventArgs e)
        {

        }

        private void btn_fh_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            //返回主菜单
            this.Close();
            Form_main form_main = new Form_main();
            form_main.Show();
        }

        private void Form_btsx_Load(object sender, EventArgs e)
        {
            imageList1.Images.Clear();
            imageList1.ImageSize = new Size(160,120);

            String strSub = Toolimp.getSystemMainDir();
            DirectoryInfo di = new DirectoryInfo(@strSub + "\\image\\bt\\slt");
            foreach (FileInfo f in di.GetFiles())
            {
                if(!imageList1.Images.Keys.Contains(f.Name))
                {
                    imageList1.Images.Add(f.Name, Image.FromFile(@strSub + "\\image\\bt\\slt\\"+f.Name));
                }
            }

            if (setPagePicShow(pageCount) == false)
            {
                MessageBox.Show("暂时没有数据!", "ERROR");
            }

        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            this.pageCount++;
            if (setPagePicShow(pageCount) == false)
            {
                MessageBox.Show("暂时没有数据!", "ERROR");
                this.btn_down.Visible = false;
                this.pageCount--;
            }

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (this.pageCount <= 1)
            {
                MessageBox.Show("起始页数据!", "ERROR");
            }
            else
            {
                this.pageCount--;
                if (setPagePicShow(pageCount) == false)
                {
                    MessageBox.Show("暂时没有数据!", "ERROR");
                    this.btn_up.Visible = false;
                }
            }
        }

        private void pbox1_MouseHover(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BorderStyle = BorderStyle.None;
        }

        private void pbox1_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb1.Text,this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox2_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb2.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox3_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb3.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox4_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb4.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox5_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb5.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox6_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb6.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox7_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb7.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox8_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb8.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox9_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
           
            Form_btjs form_btjs = new Form_btjs(lb9.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

        private void pbox10_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;
            
            Form_btjs form_btjs = new Form_btjs(lb10.Text, this.imageList1);
            form_btjs.Show();
            this.Hide();
        }

    }
}
