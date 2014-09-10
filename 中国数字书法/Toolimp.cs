using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace 中国数字书法
{
    class Toolimp
    {
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

        public static String getSystemMainDir()
        {
            String strDir = System.IO.Directory.GetCurrentDirectory();
            int indexLastDir = strDir.LastIndexOf("中国数字书法");
            return strDir.Substring(0, indexLastDir + 6);
        }

    }
}
