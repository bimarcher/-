using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Drawing;

namespace 中国数字书法
{
    class Toolimp
    {
        public const int zNumber = 12;        //一行为12个字100*100
        public const int zsNumber = 15;       //一行为15个字50*50
        public const int backgauge = 100;     //边距
        public const int rows = 1;            //行数
        
        //判断光盘是否存在
        public static bool IsThereAnyCDRom()
        {
            bool flgResult = false;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType.ToString() == "CDRom")
                {
                    if (d.IsReady)
                    {
                        flgResult = true;
                        break;
                    }
                }
            }
            return flgResult;
        }

        //获取所有的cdrom
        public static List<DriveInfo> AllCDRomNames()
        {
            List<DriveInfo> allCDRomNames = new List<DriveInfo>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType.ToString() == "CDRom")
                {
                    if (d.IsReady)
                    {
                        allCDRomNames.Add(d);
                    }
                }
            }

            return allCDRomNames;
        }

        //判断当前运行程序是否在光盘中运行
        public static bool IsAppInCDRom()
        {
            bool flgResult = false;
            String strDir = System.IO.Directory.GetCurrentDirectory();
            String rootDir = strDir.Substring(0, 1);
            List<DriveInfo> allCDRomNames = AllCDRomNames();
            foreach (DriveInfo cdRom in allCDRomNames)
            {
                if (cdRom.Name.ToString().Equals(rootDir))
                {
                    flgResult = true;
                    break;
                }
            }

            return flgResult;
        }

        //获得绝对路径
        public static String getSystemMainDir()
        {
            String strDir = System.IO.Directory.GetCurrentDirectory();
            int indexLastDir = strDir.LastIndexOf("中国数字书法");
            return strDir.Substring(0, indexLastDir + 6);
        }

        //创建图片文字
        public static Image CreateImage(string content, Color fontColor, Color groundbackColor)
        {

            //判断字符串不等于空和null

            if (content == null || content.Trim() == String.Empty)

                return null;

            //创建一个位图对象

            Bitmap image = new Bitmap(80, 80);

            //创建Graphics

            Graphics g = Graphics.FromImage(image);

            try
            {

                //清空图片背景颜色

                g.Clear(groundbackColor);

                Font font = new Font("宋体", 64, (FontStyle.Bold));

                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), fontColor, fontColor, 1.2f, true);

               // SolidBrush brush = new SolidBrush(fontColor);
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                g.DrawString(content, font, brush, 0, 0,sf);

                //画图片的边框线

                g.DrawRectangle(new Pen(Color.White), 0, 0, image.Width - 1, image.Height - 1);

                return Bitmap2Image(image);
            }

            finally
            {
                g.Dispose();
            }

        }

        //Bitmap转换成Image
        public static Image Bitmap2Image(Bitmap Bi)
        {
            Image img = Bi;
            return img;
        }

        //放大缩小
        public static Image PicAdjust(Image oldImage, double ratio)
        {
            double width = oldImage.Width * ratio;
            double height = oldImage.Height * ratio;
            int newWidth = (int)width;
            int newHeight = (int)height;
            Image newImage = oldImage.GetThumbnailImage(newWidth, newHeight, new Image.GetThumbnailImageAbort(IsTrue), IntPtr.Zero);
            return newImage;
        }

        public static Image PicAdjust(Image oldImage, int newWidth, int newHeight)
        {
            Image newImage = oldImage.GetThumbnailImage(newWidth, newHeight, new Image.GetThumbnailImageAbort(IsTrue), IntPtr.Zero);
            return newImage;
        }

        private static bool IsTrue()
        {
            return true;
        }

        //设置文字颜色
        public static Image SetPicColor(Image image,Color fontColor)
        {
            System.Drawing.Bitmap curBitmap = new Bitmap(image);
            if (curBitmap != null)
            {
                Color curBGColor = curBitmap.GetPixel(0, 0);
                Color curColor;
                for (int i = 0; i < curBitmap.Width; i++)
                {
                    for (int j = 0; j < curBitmap.Height; j++)
                    {
                        curColor = curBitmap.GetPixel(i, j);
                        if (curColor != curBGColor)
                        {
                            curBitmap.SetPixel(i, j, fontColor);
                        }
                    }
                }
                
            }
            return (Image)curBitmap;
        }

        //不带后缀的名称
        public static string GetNameNoSuffix(string name)
        {
            return name.Substring(0, name.IndexOf('.'));
        }

    }
}
