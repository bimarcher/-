using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中国数字书法
{
    class ImagePersonnel
    {
        public ImagePersonnel(string name, string imgs)
        {
                this.name = name;
                this.imgs = imgs;
        }
        private string name;

        public string Name
        {
                get { return name; }
                set { name = value; }
        }


        //图片路径
        private string imgs;
        public string Imgs
        {
                get
                {
                    return imgs;
                }
                set
                {
                    imgs = value;
                }
         }
        
    }
}
