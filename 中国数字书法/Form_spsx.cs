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
using System.Net;

namespace 中国数字书法
{
    public partial class Form_spsx : Form
    {
        int voice;//声音
        string strSub = "";
        int pageCount = 1;
        List<string> btspList;
        Button[] buttons;
        public Form_spsx()
        {
            InitializeComponent();
            this.strSub = Toolimp.getSystemMainDir();
            //加载登录背景
            this.BackgroundImage = Image.FromFile(@strSub + "\\image\\bj\\gbj.png");
            //加载登录音乐
            this.axWindowsMediaPlayer1.URL = @strSub + "\\music\\bjyy\\sound.mp3";
            this.axWindowsMediaPlayer1.Visible = false;
            //初始化碑帖视频的list
            btspList = new List<string>();
            this.pageCount = 1;
            buttons = new Button[5];
            buttons[0] = this.btn_lk1;
            buttons[1] = this.btn_lk2;
            buttons[2] = this.btn_lk3;
            buttons[3] = this.btn_lk4;
            buttons[4] = this.btn_lk5;
        }

        //设置声音大小
        public void setVoice(int voice)
        {
            this.axWindowsMediaPlayer1.settings.volume = voice;
        }

        private void btn_rjjs_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            Form_rjjs form_rjjs = new Form_rjjs();
            form_rjjs.Show();
            this.Close();
        }

        private void btn_btsx_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            Form_btsx form_btsx = new Form_btsx();
            form_btsx.Show();
            this.Close();
        }

        private void btn_spsx_Click(object sender, EventArgs e)
        {

        }

        private void btn_dzjs_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            Form_dzjs form_dzjs = new Form_dzjs();
            form_dzjs.Show();
            this.Close();
        }

        private void btn_zxjz_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            Form_zxjz form_zxjz = new Form_zxjz();
            form_zxjz.Show();
            this.Close();
        }

        private void btn_lmdb_Click(object sender, EventArgs e)
        {

        }

        private void btn_fh_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = null;

            Form_main form_main = new Form_main();
            form_main.Show();
            this.Close();
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

        private void Form_spsx_Load(object sender, EventArgs e)
        {
            btspList.Clear();
            //音频数据导入
            DirectoryInfo di = new DirectoryInfo(@strSub + "\\cartoon\\btsx\\");
            foreach (FileInfo f in di.GetFiles())
            {
                btspList.Add(this.strSub + "\\cartoon\\btsx\\" + f.Name);
                
            }

            if (setPageSpShow(pageCount) == false)
            {
                MessageBox.Show("暂时没有数据!", "ERROR");
            }

            axShockwaveFlash1.FlashVars = @"vcastr_file=" + btspList[0] +
           @"&IsAutoPlay=1&IsContinue=0";
            axShockwaveFlash1.LoadMovie(0, this.strSub + @"\\cartoon\\Flvplayer.swf");
            axShockwaveFlash1.Play();
        }

        private bool setPageSpShow(int pageCount)
        {
            bool flag = false;

            //开始索引，结束索引
            int endIndex = pageCount * 5 - 1;
            int startIndex = (pageCount - 1) * 5;

            if (btspList.Count > startIndex)
            {
                if (btspList.Count > endIndex)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        buttons[i - startIndex].Visible = true;
                        buttons[i - startIndex].Text = "●  相 关 视 频 " + (i+1);
                    }
                }
                else
                {
                    for (int i = startIndex; i <= btspList.Count - 1; i++)
                    {
                        buttons[i - startIndex].Visible = true;
                        buttons[i - startIndex].Text = "●  相 关 视 频 " + (i+1);
                    }

                    for (int i = btspList.Count; i <= endIndex; i++)
                    {
                        buttons[i - startIndex].Visible = false;
                    }

                }
                flag = true;
            }

            return flag;
        }

        private void btn_lk1_Click(object sender, EventArgs e)
        {
            Button sendButton = (Button)sender;
            string btnText = sendButton.Text;
            string laststr = btnText[btnText.Length - 1].ToString();
            int indexList = int.Parse(laststr);

            axShockwaveFlash1.Movie = "http://";
            axShockwaveFlash1.FlashVars = @"vcastr_file=" + btspList[indexList - 1] +
           @"&IsAutoPlay=1&IsContinue=0";
            axShockwaveFlash1.LoadMovie(0, this.strSub + @"\\cartoon\\Flvplayer.swf");
            axShockwaveFlash1.Play();
        }

        private void btn_lk2_Click(object sender, EventArgs e)
        {
            Button sendButton = (Button)sender;
            string btnText = sendButton.Text;
            string laststr = btnText[btnText.Length - 1].ToString();
            int indexList = int.Parse(laststr);

            axShockwaveFlash1.Movie = "http://";
            axShockwaveFlash1.FlashVars = @"vcastr_file=" + btspList[indexList - 1] +
           @"&IsAutoPlay=1&IsContinue=0";
            axShockwaveFlash1.LoadMovie(0, this.strSub + @"\\cartoon\\Flvplayer.swf");
            axShockwaveFlash1.Play();
        }

        private void btn_lk3_Click(object sender, EventArgs e)
        {
            Button sendButton = (Button)sender;
            string btnText = sendButton.Text;
            string laststr = btnText[btnText.Length - 1].ToString();
            int indexList = int.Parse(laststr);

            axShockwaveFlash1.Movie = "http://";
            axShockwaveFlash1.FlashVars = @"vcastr_file=" + btspList[indexList - 1] +
           @"&IsAutoPlay=1&IsContinue=0";
            axShockwaveFlash1.LoadMovie(0, this.strSub + @"\\cartoon\\Flvplayer.swf");
            axShockwaveFlash1.Play();
        }

        private void btn_lk4_Click(object sender, EventArgs e)
        {
            Button sendButton = (Button)sender;
            string btnText = sendButton.Text;
            string laststr = btnText[btnText.Length - 1].ToString();
            int indexList = int.Parse(laststr);

            axShockwaveFlash1.Movie = "http://";
            axShockwaveFlash1.FlashVars = @"vcastr_file=" + btspList[indexList - 1] +
           @"&IsAutoPlay=1&IsContinue=0";
            axShockwaveFlash1.LoadMovie(0, this.strSub + @"\\cartoon\\Flvplayer.swf");
            axShockwaveFlash1.Play();
        }

        private void btn_lk5_Click(object sender, EventArgs e)
        {
            Button sendButton = (Button)sender;
            string btnText = sendButton.Text;
            string laststr = btnText[btnText.Length - 1].ToString();
            int indexList = int.Parse(laststr);

            axShockwaveFlash1.Movie = "http://";
            axShockwaveFlash1.FlashVars = @"vcastr_file=" + btspList[indexList - 1] +
           @"&IsAutoPlay=1&IsContinue=0";
            axShockwaveFlash1.LoadMovie(0, this.strSub + @"\\cartoon\\Flvplayer.swf");
            axShockwaveFlash1.Play();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (this.pageCount <= 1)
            {
                MessageBox.Show("起始页数据!", "ERROR");
            }
            else
            {
                this.pageCount--;
                if (setPageSpShow(pageCount) == false)
                {
                    MessageBox.Show("暂时没有数据!", "ERROR");
                    this.btn_prev.Visible = false;
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.pageCount++;
            if (setPageSpShow(pageCount) == false)
            {
                MessageBox.Show("暂时没有数据!", "ERROR");
                this.btn_next.Visible = false;
                this.pageCount--;
            }
        }
    }
}
