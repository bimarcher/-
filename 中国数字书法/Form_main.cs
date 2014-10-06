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
    public partial class Form_main : Form
    {

        int voice;//声音
        public Form_main()
        {
            InitializeComponent();

            String strSub = Toolimp.getSystemMainDir();
            //加载登录背景
            this.BackgroundImage = Image.FromFile(strSub + "\\image\\bj\\zbj.jpg");

            //加载登录音乐
            this.axWindowsMediaPlayer1.URL = @strSub + "\\music\\bjyy\\sound.mp3";
            this.axWindowsMediaPlayer1.Visible = false;

            this.btn_rjjj.BackgroundImage = Image.FromFile(strSub + "\\image\\bj\\ans.png");
            this.btn_btsx.BackgroundImage = Image.FromFile(strSub + "\\image\\bj\\ans.png");
            this.btn_spsx.BackgroundImage = Image.FromFile(strSub + "\\image\\bj\\ans.png");
            this.btn_dzjs.BackgroundImage = Image.FromFile(strSub + "\\image\\bj\\ans.png");
            this.btn_zxjz.BackgroundImage = Image.FromFile(strSub + "\\image\\bj\\ans.png");
            this.btn_lmdb.BackgroundImage = Image.FromFile(strSub + "\\image\\bj\\ans.png");
        }

        //设置声音大小
        public void setVoice(int voice)
        {
            this.axWindowsMediaPlayer1.settings.volume = voice;
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

        private void btn_rjjj_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            this.Close();
            Form_rjjs form_rjjs = new Form_rjjs();
            form_rjjs.Show();
        }
    }
}
