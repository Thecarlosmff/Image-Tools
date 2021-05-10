using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Tools
{
    class Text
    {
        public List<string> content;
        public string lang_con;
        public List<string> content_trans;
        public string lang_trans;
        public string img_path;

        //private string name; // field
        //public string Name   // property
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public void clean()
        {
            content.Clear();
            content = null;
            lang_con = null;
            content_trans.Clear();
            content_trans = null;
            lang_trans = null;
            img_path = null;
        }

    }
}
