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
    public partial class Form_dzjs : Form
    {
        PictureBox[] pictureboxs;

        int voice;//声音

        string strSub;
        public Form_dzjs()
        {
            InitializeComponent();
            this.strSub = Toolimp.getSystemMainDir();
            //加载登录背景
            this.BackgroundImage = Image.FromFile(@strSub + "\\image\\bj\\gbj.png");

            //加载登录音乐
            this.axWindowsMediaPlayer1.URL = @strSub + "\\music\\bjyy\\sound.mp3";
            this.axWindowsMediaPlayer1.Visible = false;

            tb_input.Text = "东";
        }


        //设置声音大小
        public void setVoice(int voice)
        {
            this.axWindowsMediaPlayer1.settings.volume = voice;
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

        private void btn_js_Click(object sender, EventArgs e)
        {
            //有检索信息
            string input = tb_input.Text;
            if (input == null || input == "")
            {
                MessageBox.Show("请输入要检索的字");
                return;
            }
            input = input.Trim();

            //有检索
            DirectoryInfo di = new DirectoryInfo(@strSub + "\\cartoon\\dz");
            foreach (FileInfo f in di.GetFiles())
            {
                string dzm = f.Name.Substring(0, f.Name.IndexOf('.'));
                if (dzm.Equals(input))
                {
                    //放入田字格
                    pb_showwz.Image = Toolimp.PicAdjust(Image.FromFile(@strSub + "\\cartoon\\dz\\" + dzm + ".png"),300,300);
                    //放入flash动画
                    axShockwaveFlash1.Movie = @strSub + "\\cartoon\\dz\\" + dzm + ".swf";
                    axShockwaveFlash1.Loop = false;
                    axShockwaveFlash1.Stop(); 
                    return;
                }
            }
            //未检索
            pb_showwz.Image = null;
            MessageBox.Show("未检索到相关的字！");

        }

        private void btn_bszs_Click(object sender, EventArgs e)
        {
            if (axShockwaveFlash1.Playing)
            {
                axShockwaveFlash1.StopPlay();
            }
            else
            {
                axShockwaveFlash1.Play();
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
            Form_spsx form_sxsx = new Form_spsx();
            form_sxsx.Show();
        }

        private void btn_dzjs_Click(object sender, EventArgs e)
        {

        }

        private void btn_zxjz_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_zxjz form_zxjz = new Form_zxjz();
            form_zxjz.Show();
        }

        private void btn_fh_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_main form_main = new Form_main();
            form_main.Show();
        }
    }
}
