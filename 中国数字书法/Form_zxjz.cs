using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 中国数字书法
{
    public partial class Form_zxjz : Form
    {
        Form picfrm; //面板

        int voice;//声音

        string strSub; //子路径

        PictureBox[] picboxs;

        Dictionary<string, string> dic;   

        PictureBox picbox;     //当前点击的文字picturebox

        
        public Form_zxjz()
        {
            InitializeComponent();
            this.strSub = Toolimp.getSystemMainDir();
            dic = new Dictionary<string, string>();

            //加载登录背景
            this.BackgroundImage = Image.FromFile(@strSub + "\\image\\bj\\gbj.png");

            //加载登录音乐
            this.axWindowsMediaPlayer1.URL = @strSub + "\\music\\bjyy\\sound.mp3";
            this.axWindowsMediaPlayer1.Visible = false;
        }

        //设置声音大小
        public void setVoice(int voice)
        {
            this.axWindowsMediaPlayer1.settings.volume = voice;
        }

        private void tb_bjys_MouseDown(object sender, MouseEventArgs e)
        {
            tb_bjys.Clear();
            if (colorDialog_bjys.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_bjys.Text = colorDialog_bjys.Color.Name;
            }
        }

        private void Form_zxjz_Load(object sender, EventArgs e)
        {
            tb_content.Text = "丑初春癸和会稽集九蘭暮年群山少事岁亭会之";
            //PictureBox pic_show1 = new PictureBox();
            if (tb_bjys.Text == null || tb_bjys.Text == "")
            {
                colorDialog_bjys.Color = Color.White;
            }

            
            //计算picturebox的个数，每个字一个picturebox
            string strinput = tb_content.Text.ToString().Trim();

            generateCopybook(strinput,100);   
        }

        private void btn_scsf_Click(object sender, EventArgs e)
        {
            string strinput = tb_content.Text.ToString().Trim();
            generateCopybook(strinput,100);
        }

        //生成展示图片picturebox点击事件，在下方出现相关字体
        private void picboxs_Click(object sender, EventArgs e)
        {
            this.picbox = (PictureBox)sender;
            string dz = dic[picbox.Name];
            //读取包含单字的数据，查询数据库
            DirectoryInfo di = new DirectoryInfo(@strSub + "\\image\\ltx\\50x50");
            List<string> fNamelist = new List<string>();
            foreach (FileInfo f in di.GetFiles())
            {
                if (f.Name.Contains(dz))
                {
                    fNamelist.Add(f.Name);
                } 
            }

            PictureBox[] pic_shows = new PictureBox[fNamelist.Count];
           
            //添加图片
            this.pl_wjsr.Controls.Clear();
            //this.pl_wjsr.Size = new System.Drawing.Size(fNamelist.Count*50, 50);
            int divisor = 0;               //除数
            int remainder = 0;             //余数

            for (int i = 0; i < fNamelist.Count; i++)
            {
                pic_shows[i] = new PictureBox();
                //查询数据库
                pic_shows[i].Image = Toolimp.PicAdjust(Image.FromFile(strSub + "\\image\\ltx\\50x50\\" + fNamelist[i]), 50, 50);
                pic_shows[i].Name = fNamelist[i];
                pic_shows[i].Size = new System.Drawing.Size(50, 50);
                pic_shows[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                divisor = i / Toolimp.zsNumber;
                remainder = i % Toolimp.zsNumber;
                pic_shows[i].Location = new System.Drawing.Point(50 * remainder, 50 * divisor);
                pic_shows[i].Cursor = System.Windows.Forms.Cursors.Hand;
                pic_shows[i].Click += new System.EventHandler(this.pic_showboxs_Click);
                this.pl_wjsr.Controls.Add(pic_shows[i]);
            }
            
        }

        //生成展示图片pic_showsbox点击事件，点击下方的文字，上面面板出现相关字体
        private void pic_showboxs_Click(object sender, EventArgs e)
        {
            PictureBox pic_show = (PictureBox)sender;
            this.picbox.Image = Toolimp.PicAdjust(Image.FromFile(strSub + "\\image\\ltx\\300x300\\" + pic_show.Name), 100, 100);
        }


        //生成字帖
        private void generateCopybook(string strinput,int nwidth)
        {
            picboxs = new PictureBox[strinput.Length];
            int rows = 1;
            if (strinput.Length > Toolimp.zNumber)
            {
                rows = 2;
            }

            //生成form
            picfrm = new Form();
            picfrm.TopLevel = false;
            picfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            if (rows > 1)
            {
                picfrm.Size = new System.Drawing.Size(nwidth * Toolimp.zNumber, nwidth * rows);
            }
            else
            {
                picfrm.Size = new System.Drawing.Size(nwidth * strinput.Length, nwidth * rows);
            }

            picfrm.Location = new System.Drawing.Point(20, 20);
            //picfrm.BackgroundImageLayout = ImageLayout.Stretch;
            picfrm.BackColor = colorDialog_bjys.Color;
            picfrm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.dic.Clear();

            //生成picturebox
            if (rows > 1)
            {
                for (int i = 0; i < Toolimp.zNumber; i++)
                {
                    string dz = strinput.Substring(i, 1);
                    picboxs[i] = new PictureBox();
                    //单字数据库查询
                    picboxs[i].Image = Toolimp.PicAdjust(Image.FromFile(strSub + "\\image\\ltx\\300x300\\" + dz + ".png"), nwidth, nwidth);
                    picboxs[i].Name = "pic" + i;
                    dic.Add(picboxs[i].Name, dz);
                    picboxs[i].Size = new System.Drawing.Size(nwidth, nwidth);
                    picboxs[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    picboxs[i].Location = new System.Drawing.Point(nwidth * i, 0);
                    picboxs[i].Cursor = System.Windows.Forms.Cursors.Hand;
                   // picboxs[i].BackgroundImage = Toolimp.PicAdjust(Image.FromFile(strSub + "\\image\\bj\\tzg.jpg"), 100, 100);
                    picboxs[i].Click += new System.EventHandler(this.picboxs_Click);
                    picboxs[i].Parent = picfrm;
                }
                for (int i = Toolimp.zNumber; i < strinput.Length; i++)
                {
                    string dz = strinput.Substring(i, 1);
                    picboxs[i] = new PictureBox();
                    //单字数据库查询
                    picboxs[i].Image = Toolimp.PicAdjust(Image.FromFile(strSub + "\\image\\ltx\\300x300\\" + dz + ".png"), nwidth, nwidth);
                    picboxs[i].Name = "pic" + i;
                    dic.Add(picboxs[i].Name, dz);
                    picboxs[i].Size = new System.Drawing.Size(nwidth, nwidth);
                    picboxs[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    picboxs[i].Location = new System.Drawing.Point(nwidth * (i - Toolimp.zNumber), nwidth);
                    picboxs[i].Cursor = System.Windows.Forms.Cursors.Hand;
                   // picboxs[i].BackgroundImage = Toolimp.PicAdjust(Image.FromFile(strSub + "\\image\\bj\\tzg.jpg"), 100, 100);
                    picboxs[i].Click += new System.EventHandler(this.picboxs_Click);
                    picboxs[i].Parent = picfrm;
                }
            }
            else
            {
                for (int i = 0; i < strinput.Length; i++)
                {
                    string dz = strinput.Substring(i, 1);
                    picboxs[i] = new PictureBox();
                    //单字数据库查询
                    picboxs[i].Image = Toolimp.PicAdjust(Image.FromFile(strSub + "\\image\\ltx\\300x300\\" + dz + ".png"), nwidth, nwidth);
                    picboxs[i].Name = "pic" + i;
                    dic.Add(picboxs[i].Name, dz);
                    picboxs[i].Size = new System.Drawing.Size(nwidth, nwidth);
                    picboxs[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    picboxs[i].Location = new System.Drawing.Point(nwidth * i, 0);
                    picboxs[i].Cursor = System.Windows.Forms.Cursors.Hand;
                   // picboxs[i].BackgroundImage = Toolimp.PicAdjust(Image.FromFile(strSub + "\\image\\bj\\tzg.jpg"), 100, 100);
                    picboxs[i].Click += new System.EventHandler(this.picboxs_Click);
                    picboxs[i].Parent = picfrm;
                }
            }

            picfrm.Show();

            //添加容器panel
            this.pl_wjxs.Controls.Clear();
            this.pl_wjxs.Controls.Add(picfrm);

            this.pl_wjxs.Size = new System.Drawing.Size(picfrm.Width + 40, picfrm.Height + 40);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.voice = e.Location.X;
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
            this.voice = e.Location.X;
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

        private void btn_bctp_Click(object sender, EventArgs e)
        {
            //将panel控件导出图片
            int w, h;
            if (this.pl_wjxs.VerticalScroll.Visible)
                h = this.pl_wjxs.VerticalScroll.Maximum;
            else
                h = this.pl_wjxs.Height;

            if (this.pl_wjxs.HorizontalScroll.Visible)
                w = this.pl_wjxs.HorizontalScroll.Maximum;
            else
                w = this.pl_wjxs.Width;

            Image curBitmap = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(curBitmap);
            g.Clear(this.pl_wjxs.BackColor);
            foreach (Control c in this.pl_wjxs.Controls)
            {
                Bitmap b = new Bitmap(c.Width, c.Height);
                c.DrawToBitmap(b, new Rectangle(new Point(0, 0), c.Size));
                g.DrawImage(b, c.Location);
            }

            //保存图片
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Title = "保存为";
            saveDlg.OverwritePrompt = true;
            saveDlg.Filter =
                "BMP文件 (*.bmp) | *.bmp|" +
                "Gif文件 (*.gif) | *.gif|" +
                "JPEG文件 (*.jpg) | *.jpg|" +
                "PNG文件 (*.png) | *.png";
            saveDlg.ShowHelp = true;
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDlg.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_rjjs_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_rjjs form_rjjs = new Form_rjjs();
            form_rjjs.Show();
        }

        private void btn_btsx_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_btsx form_btsx = new Form_btsx();
            form_btsx.Show();
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

        private void btn_fh_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_main form_main = new Form_main();
            form_main.Close();
        }
    }
}
