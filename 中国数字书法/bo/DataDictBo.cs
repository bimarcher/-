using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中国数字书法.bo
{
    class DataDictBo
    {
        enum DataDictBoAttr
        {
            category,
            key,
            label,
            value,
            description
        }
        public DataDictBo(){ }

        private String category;
        public String Category
        {
            get { return category; }
            set { category = value; }
        }

        private String key;
        public String Key
        {
            get { return key; }
            set { key = value; }
        }

        private String label;
        public String Label
        {
            get { return label; }
            set { label = value; }
        }

        private String value;
        public String Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        private String description;
        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String showBoInfo() {

            return "BoInfo：" + description;
        }
    }
}
