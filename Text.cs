using System;
using System.Collections.Generic;

namespace Image_Tools
{
    public class Text : ICloneable
    {
        public List<string> content = new List<string>();
        public string lang_con = "auto";
        public List<string> content_trans = new List<string>();
        public string lang_trans = "";
        public string img_path = "";
        public int index = -1;

        public Text(Text t)
        {
            this.content = t.content;
            this.lang_con = t.lang_con;
            this.content_trans = t.content_trans;
            this.lang_trans = t.lang_trans;
            this.img_path = t.img_path;
            this.index = t.index;
        }
        public Text(){ }
        public object Clone()
        {
            return new Text(this);
        }

        //private string name; // field
        //public string Name   // property
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

    }
}
