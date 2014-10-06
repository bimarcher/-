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
    public partial class Form_btfd : Form
    {
        string imageListkey = "";
        string strSub = "";
        int width_yt = 0;
        int height_yt = 0;
        public Form_btfd()
        {
            InitializeComponent();
        }

        public Form_btfd(string imageListkey,ImageList imagelist)
        {
            InitializeComponent();
            this.strSub = Toolimp.getSystemMainDir();
            this.imageList1 = imagelist;
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                if (Toolimp.GetNameNoSuffix(imageList1.Images.Keys[i].ToString()).Equals(imageListkey))
                {
                    this.imageListkey = imageList1.Images.Keys[i].ToString();
                }
            }
            //加载登录背景
            this.BackgroundImage = Image.FromFile(@strSub + "\\image\\bj\\gbj.png");
        }

        private void Form_btfd_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@strSub + "\\image\\bt\\fd\\" + imageListkey);
            pboxfdshow.Image = image;
            this.width_yt = image.Width;
            this.height_yt = image.Height;
        }

        private void btn_fd_Click(object sender, EventArgs e)
        {
            Image oldimage = pboxfdshow.Image;
            int width = oldimage.Width;
            int height = oldimage.Height;

            if (width / this.width_yt < 4)
            {
                int newWidth = width * 2;
                int newHeight = height * 2;
                pboxfdshow.Image = oldimage.GetThumbnailImage(newWidth, newHeight, new Image.GetThumbnailImageAbort(IsTrue), IntPtr.Zero);
            } 
        }

        private bool IsTrue() 
        {  
           return true;       
        }

        private void btn_hy_Click(object sender, EventArgs e)
        {
            pboxfdshow.Image = Image.FromFile(@strSub + "\\image\\bt\\fd\\" + this.imageListkey);
        }

        private void btn_fh_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_btjs form_btjs = new Form_btjs(Toolimp.GetNameNoSuffix(this.imageListkey), this.imageList1);
            form_btjs.Show();
        }

    }
}
