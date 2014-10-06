﻿using System;
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
    public partial class Form_dl : Form
    {
        int voice;//声音

        public Form_dl()
        {
            InitializeComponent();


            String strSub = Toolimp.getSystemMainDir();
            //加载登录背景
            this.BackgroundImage=Image.FromFile(@strSub + "\\image\\bj\\dlbj.jpg");

            //加载登录音乐
            this.axWindowsMediaPlayer1.URL = @strSub + "\\music\\bjyy\\sound.mp3";
            this.axWindowsMediaPlayer1.Visible = false;

            //加载登录按钮背景
            this.btn_jryz.BackgroundImage = Image.FromFile(@strSub + "\\image\\bj\\anh.png");
        }



        private void Form_dl_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_jryz_Click(object sender, EventArgs e)
        {
            //取消音乐背景
            this.axWindowsMediaPlayer1.URL = null;
            this.axWindowsMediaPlayer1.Visible = false;
            //登录验证页
            this.Hide();
            Form_yz form_yz = new Form_yz();
            form_yz.Show();
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

        private void btn_jryz_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void btn_jryz_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
        }
    }
}
