using System.Collections.Generic;

namespace Image_Tools
{
    public class Text
    {
        public List<string> content = new List<string>();
        public string lang_con = "auto";
        public List<string> content_trans = new List<string>();
        public string lang_trans = "";
        public string img_path = "";

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
