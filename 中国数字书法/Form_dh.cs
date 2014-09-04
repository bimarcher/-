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
    public partial class Form_dh : Form
    {
        public Form_dh()
        {
            InitializeComponent();
            this.timer_ys.Start();
        }

        private void Form_dh_Load(object sender, EventArgs e)
        {
            String strSub = Toolimp.getSystemMainDir();
            axShockwaveFlash1.FlashVars = @"vcastr_file=" + strSub + "\\cartoon\\dl\\pt.flv" +
            @"&IsAutoPlay=1&IsContinue=0";
            axShockwaveFlash1.LoadMovie(0, strSub + @"\\cartoon\\Flvplayer.swf");
            axShockwaveFlash1.Play();

            
        }

        private void timer_ys_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form_dl form_dl = new Form_dl();
            form_dl.Show();
            this.timer_ys.Stop();
        }
    }
}
