using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Image_Tools
{
    public partial class TranslationTools : Form
    {
        public TranslationTools()
        {
            InitializeComponent();
        }

        readonly static String CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

        private void BtnMainBackground_Click(object sender, EventArgs e)
        {
            RemoveBackground RemBg = new RemoveBackground();
            //this.Hide();
            RemBg.Show();
            //RemBg.ShowDialog();
            //this.Show();

        }
        private void Btn_MainImageToText_Click(object sender, EventArgs e)
        {
            ImageToText toText = new ImageToText();
            //this.Hide();
            toText.Show();
            //toText.ShowDialog();
            //this.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static int GetId(ComboBox box)
        {
            //MessageBox.Show(box.Text);
            //return box.Text;
            string result = "";
            //com.Parameters.Add(New ObjectParameter("ln", "Adams"));
            //com.Parameters.AddWithValue("@field", "eirghoerihgoh");
            string sql = "select IDColor,Name from BackgroundColors where Name='" + box.Text + "' Order by IDColor";
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    //MessageBox.Show(sql);
                    try
                    {

                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    result = dt.Rows[0].ItemArray[0].ToString();
                    myConnection.Close();

                    }
                    catch
                    {
                        result = "1";
                    }

                }
            }
            //MessageBox.Show(result);
            return Int32.Parse(result);
        }
        public static void FillDropDownList(string Query, System.Windows.Forms.ComboBox DropDownName)
        {
            DropDownName.DataSource = null;
            DropDownName.Items.Clear();
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(Query, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    DropDownName.DataSource = dt;
                    DropDownName.ValueMember = "IDColor";
                    DropDownName.DisplayMember = "Name";
                    myConnection.Close();
                }
            }
        }
        public static void FillDropDownSessions(string Query, System.Windows.Forms.ComboBox DropDownName)
        {
            DropDownName.DataSource = null;
            DropDownName.Items.Clear();
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(Query, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    DropDownName.DataSource = dt;
                    DropDownName.DisplayMember = "NameSession";
                    DropDownName.SelectedIndex = -1;
                    myConnection.Close();
                }
            }
        }
        public static void clearPictureBox(PictureBox pic)
        {
            if (pic.Image != null)
            {
                pic.Image.Dispose();
                pic.Image = null;
            }
        }

        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
        //Bitmap image1;
        public static Bitmap TransformToHSV(String path)
        {
            try
            {
                // Retrieve the image.
                Bitmap image1 = new Bitmap(path, true);

                int x, y;
                double hue, saturation, value;

                // Loop through the images pixels to reset color.
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y); //gets the color of each pixel
                        ColorToHSV(pixelColor, out hue, out saturation, out value);
                        pixelColor = ColorFromHSV(hue, saturation, value);
                    }
                }
                return image1;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
                return null;
            }

        }
        public static bool CheckBound(List<int> IntList, int Hue, int Sat, int Val)
        {
            //IntList[0] = Min Hue
            //IntList[1] = Max Hue
            //IntList[2] = Min Saturation
            //IntList[3] = Max Saturation
            //IntList[4] = Min Value
            //IntList[5] = Max Value
            //MessageBox.Show(IntList[0].ToString());
            if (Hue >= IntList[0] & Hue <= IntList[1] & Sat >= IntList[2] & Sat <= IntList[3] & Val >= IntList[4] & Val <= IntList[5])
                return true;
            return false;
        }

        public static int FindSituation(int a, int b, int c, int d, int e, int f)
        {
            if (a <= b & c <= d & e <= f) //fine
                return 1;
            if (a > b & c <= d & e <= f) //hue
                return 2;
            if (a <= b & c > d & e <= f) //saturation
                return 3;
            if (a <= b & c <= d & e > f) //value
                return 4;
            if (a > b & c > d & e <= f) //hue saturation
                return 5;
            if (a > b & c <= d & e > f) //hue value
                return 6;
            if (a <= b & c > d & e > f) //saturation value
                return 7;
            if (a > b & c > d & e > f) //hue saturation value
                return 8;
            return -1; //this should never return;

        }

        public static List<List<int>> GetListOfInts(int a, int b, int c, int d, int e, int f)
        {
            int op = FindSituation(a, b, c, d, e, f);
            List<List<int>> ListArrays = new List<List<int>>();
            if (op == 1)
            {
                ListArrays.Add(new List<int> { a, b, c, d, e, f });
                return ListArrays;
            }
            if (op == 2)
            {
                ListArrays.Add(new List<int> { 0, b, c, d, e, f });
                ListArrays.Add(new List<int> { a, 179, c, d, e, f });
                return ListArrays;
            }
            if (op == 3)
            {
                ListArrays.Add(new List<int> { a, b, 0, d, e, f });
                ListArrays.Add(new List<int> { a, b, c, 255, e, f });
                return ListArrays;
            }
            if (op == 4)
            {
                ListArrays.Add(new List<int> { a, b, c, d, 0, f });
                ListArrays.Add(new List<int> { a, b, c, d, e, 255 });
                return ListArrays;
            }
            if (op == 5)
            {
                ListArrays.Add(new List<int> { 0, b, 0, d, e, f });
                ListArrays.Add(new List<int> { 0, b, c, 255, e, f });
                ListArrays.Add(new List<int> { a, 179, 0, d, e, f });
                ListArrays.Add(new List<int> { a, 179, c, 255, e, f });
                return ListArrays;
            }
            if (op == 6)
            {
                ListArrays.Add(new List<int> { 0, b, c, d, 0, f });
                ListArrays.Add(new List<int> { 0, b, c, d, e, 255 });
                ListArrays.Add(new List<int> { a, 179, c, d, 0, f });
                ListArrays.Add(new List<int> { a, 179, c, d, e, 255 });
                return ListArrays;
            }
            if (op == 7)
            {
                ListArrays.Add(new List<int> { a, b, 0, d, 0, f });
                ListArrays.Add(new List<int> { a, b, 0, d, e, 255 });
                ListArrays.Add(new List<int> { a, b, c, 255, 0, f });
                ListArrays.Add(new List<int> { a, b, c, 255, e, 255 });
                return ListArrays;
            }
            if (op == 8)
            {
                ListArrays.Add(new List<int> { 0, b, 0, d, 0, f });
                ListArrays.Add(new List<int> { 0, b, 0, d, e, 255 });
                ListArrays.Add(new List<int> { 0, b, c, 255, 0, f });
                ListArrays.Add(new List<int> { a, 179, 0, d, 0, f });

                ListArrays.Add(new List<int> { a, 179, c, 255, 0, f });
                ListArrays.Add(new List<int> { a, 179, 0, d, e, 255 });
                ListArrays.Add(new List<int> { 0, b, c, 255, e, 255 });
                ListArrays.Add(new List<int> { a, 179, c, 255, e, 255 });
                return ListArrays;
            }
            return null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
        public static void FillList(ListView list, OpenFileDialog fileDialog)
        {
            fileDialog.Filter =
                "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*";

            fileDialog.Multiselect = true;
            fileDialog.Title = "Select Images";

            DialogResult dr = fileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in fileDialog.FileNames) //percorre todos os ficheiros
                {
                    try
                    {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = file;
                        //lvi.SubItems.Add(RemBgSelectImages.SafeFileName);
                        //lvi.SubItems.Add(RemBgSelectImages.);

                        if (!existChecker(file,list))
                            list.Items.Add(lvi);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public static bool existChecker(string id,ListView lvi)
        {
            bool exist = false;

            for (int i = 0; i < lvi.Items.Count && exist != true; i++)
            {
                if (lvi.Items[i].SubItems[0].Text == id)
                    exist = true;
            }
            return exist;
        }
        public static string getTranslationStr(string lang)
        {
            //if (lang == true) ;
            switch (lang)
            {
                case "Afrikaans": return "af";
                case "Albanian": return "sq";
                case "Amharic": return "am";
                case "Arabic": return "ar";
                case "Armenian": return "hy";
                case "Azerbaijani": return "az";
                case "Basque": return "eu";
                case "Belarusian": return "be";
                case "Bengali": return "bn";
                case "Bosnian": return "bs";
                case "Bulgarian": return "bg";
                case "Catalan": return "ca";
                case "Cebuano": return "ceb";
                case "Chinese (Simplified)": return "zh-CN";
                case "Chinese (Traditional)": return "zh-TW";
                case "Corsican": return "co";
                case "Croatian": return "hr";
                case "Czech": return "cs";
                case "Danish": return "da";
                case "Dutch": return "nl";
                case "English": return "en";
                case "Esperanto": return "eo";
                case "Estonian": return "et";
                case "Finnish": return "fi";
                case "French": return "fr";
                case "Frisian": return "fy";
                case "Galician": return "gl";
                case "Georgian": return "ka";
                case "German": return "de";
                case "Greek": return "el";
                case "Gujarati": return "gu";
                case "Haitian Creole": return "ht";
                case "Hausa": return "ha";
                case "Hawaiian": return "haw";
                case "Hebrew": return "he";
                case "Hindi": return "hi";
                case "Hmong": return "hmn";
                case "Hungarian": return "hu";
                case "Icelandic": return "is";
                case "Igbo": return "ig";
                case "Indonesian": return "id";
                case "Irish": return "ga";
                case "Italian": return "it";
                case "Japanese": return "ja";
                case "Javanese": return "jv";
                case "Kannada": return "kn";
                case "Kazakh": return "kk";
                case "Khmer": return "km";
                case "Kinyarwanda": return "rw";
                case "Korean": return "ko";
                case "Kurdish": return "ku";
                case "Kyrgyz": return "ky";
                case "Lao": return "lo";
                case "Latin": return "la";
                case "Latvian": return "lv";
                case "Lithuanian": return "lt";
                case "Luxembourgish": return "lb";
                case "Macedonian": return "mk";
                case "Malagasy": return "mg";
                case "Malay": return "ms";
                case "Malayalam": return "ml";
                case "Maltese": return "mt";
                case "Maori": return "mi";
                case "Marathi": return "mr";
                case "Mongolian": return "mn";
                case "Myanmar": return "my";
                case "Nepali": return "ne";
                case "Norwegian": return "no";
                case "Nyanja": return "ny";
                case "Odia": return "or";
                case "Pashto": return "ps";
                case "Persian": return "fa";
                case "Polish": return "pl";
                case "Portuguese": return "pt";
                case "Punjabi": return "pa";
                case "Romanian": return "ro";
                case "Russian": return "ru";
                case "Samoan": return "sm";
                case "Scots Gaelic": return "gd";
                case "Serbian": return "sr";
                case "Sesotho": return "st";
                case "Shona": return "sn";
                case "Sindhi": return "sd";
                case "Sinhala": return "si";
                case "Slovak": return "sk";
                case "Slovenian": return "sl";
                case "Somali": return "so";
                case "Spanish": return "es";
                case "Sundanese": return "su";
                case "Swahili": return "sw";
                case "Swedish": return "sv";
                case "Tagalog (Filipino)": return "tl";
                case "Tajik": return "tg";
                case "Tamil": return "ta";
                case "Tatar": return "tt";
                case "Telugu": return "te";
                case "Thai": return "th";
                case "Turkish": return "tr";
                case "Turkmen": return "tk";
                case "Ukrainian": return "uk";
                case "Urdu": return "ur";
                case "Uyghur": return "ug";
                case "Uzbek": return "uz";
                case "Vietnamese": return "vi";
                case "Welsh": return "cy";
                case "Xhosa": return "xh";
                case "Yiddish": return "yi";
                case "Yoruba": return "yo";
                case "Zulu": return "zu";
            }

            return "en";
        }
        public static string getOCRLang(string lang)
        {
            switch (lang)
            {
                case "Chinese(Simplified)":
                    return "chi_sim";
                case "Chinese(Traditional)":
                    return "chi_tra";
                case "Dutch":
                    return "nld";
                case "English":
                    return "eng";
                case "French":
                    return "fra";
                case "German":
                    return "deu";
                case "Greek":
                    return "ell";
                case "Hindi":
                    return "hin";
                case "Italian":
                    return "ita";
                case "Japanese":
                    return "jpn";
                case "Math / equation":
                    return "equ";
                case "Polish":
                    return "pol";
                case "Portuguese":
                    return "por";
                case "Russian":
                    return "rus";
                case "Spanish":
                    return "spa";

            }
            return "eng";
        }
        public static string ReplaceASCII(string s)
        {
            for (int i = 32;i<48;i++)
                s = s.Replace("&#"+i+";", ((char)i).ToString());
            for (int i = 91; i < 97; i++)
                s = s.Replace("&#" + i + ";", ((char)i).ToString());

            return s;
        }

        public static void CleanListView(ListView l)
        {
            l.Items.Clear();
            l.Refresh();
        }
        public static void show_MSG(Label l,string msg, Color color, int d)
        {
            l.Visible = true;
            l.Text = msg;
            l.ForeColor = color;
            l.BackColor = System.Drawing.Color.Transparent;
            l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Timer timer = new Timer();
            timer.Interval = d;
            timer.Tick += (object sender, EventArgs e) =>
            {
                l.Visible = false;
            }; timer.Start();
            l.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public static int GetLastId()
        {
            int lastID = 0;
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                //string sql = "SELECT IDENT_CURRENT FROM images";
                string sql = "SELECT TOP(1) Id FROM images ORDER BY 1 DESC";
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    cmd.Parameters.AddWithValue("@LASTID", lastID);
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    lastID = Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
                    dt.Dispose();
                    myConnection.Close();

                }
            }
            return lastID;
        }
        public static void InsertImagePath(Text text)
        {
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string temp = (text.img_path).Replace("'", "''");
                string sql = "INSERT INTO dbo.images (image_path) VALUES (N'" + temp + "');";
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    myConnection.Close();

                }
            }
        }
        public static void InsertScript(Text text, int Id) 
        {
            string temp = "";
            for (int i = 0; i < text.content.Count; i++)
            {
                using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
                {
                    temp = text.content[i].Replace("'", "''");
                    string sql = "INSERT INTO dbo.TextOriginal (OText,FK_Original_ID) VALUES (N'" + temp + "'," + Id + ");";
                    //MessageBox.Show(sql);
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        myConnection.Close();

                    }
                }
            }
            for (int i = 0; i < text.content_trans.Count; i++)
            {
                using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
                {
                    temp = text.content_trans[i].Replace("'","''");
                    string sql = "INSERT INTO dbo.TextTranslated (TText,FK_Translated_ID) VALUES (N'" + temp + "'," + Id + ");";
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        myConnection.Close();

                    }
                }
            }
        }
        public static void InsertSession(string name, int LastId)
        {
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "INSERT INTO dbo.Session (NameSession,IdImage) VALUES (N'" + name + "'," + LastId + ");";
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    _= cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    myConnection.Close();

                }
            }
        }
        public static List<string> GetSessionNames()
        {
            List<string> l = new List<string>();
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "SELECT DISTINCT NameSession from Session;";
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    for (int i = 0; i < dt.Rows.Count; i++)
                            l.Add(dt.Rows[i].ItemArray[0].ToString());

                    dt.Dispose();
                    myConnection.Close();
                    return l;
                }
            }
        }
        public static List<int> GetListOfIds(string SessionName)
        {
            List<int> l = new List<int>();
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                SessionName = SessionName.Replace("'", "''");
                string sql = "SELECT Id from images Inner JOIN Session ON images.Id=Session.IdImage WHERE Session.NameSession ='"+ SessionName + "';";
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    for (int i = 0; i < dt.Rows.Count; i++)
                        l.Add(Int32.Parse(dt.Rows[i].ItemArray[0].ToString()));

                    dt.Dispose();
                    myConnection.Close();

                }
            }
            return l;

        }
        public static List<Text> LoadFromDB(string SessionName)
        {
            List<Text> T = new List<Text>();
            List<int> ListOfItens = GetListOfIds(SessionName);

            for(int i = 0; i < ListOfItens.Count; i++)
            {
                Text text = new Text();
                using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
                {
                    string sql = "SELECT TextOriginal.OText From images Inner JOIN TextOriginal ON images.Id = TextOriginal.FK_Original_ID WHERE Id = " + ListOfItens[i] + ";";

                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        //lastID = Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
                        for(int j = 0;j<dt.Rows.Count;j++)
                        {
                            text.content.Add(dt.Rows[j].ItemArray[0].ToString());
                        }
                        myConnection.Close();

                    }
                }

                using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
                {
                    string sql = "SELECT TextTranslated.TText From images Inner JOIN TextTranslated ON images.Id = TextTranslated.FK_Translated_ID WHERE Id = " + ListOfItens[i] + ";";

                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        //lastID = Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            text.content_trans.Add(dt.Rows[j].ItemArray[0].ToString());
                        }
                        dt.Dispose();
                        myConnection.Close();

                    }
                }

                using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
                {
                    string sql = "SELECT image_path From images Where Id = " + ListOfItens[i] + "; ";

                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        //lastID = Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            text.img_path =dt.Rows[j].ItemArray[0].ToString();
                        }
                        dt.Dispose();
                        myConnection.Close();

                    }
                }
                T.Add(text);
            }
            //1º SELECT para ir buscar lista de ids e guardalos
            //2ª algoritmo para percurrer a lista em que 
            // a cada novo id acrescentar um novo elemento e dentro desse is encher a lista on os SELECTS em baixo

            //SELECT TextOriginal.OText
            //From images
            //Inner JOIN TextOriginal ON images.Id = TextOriginal.FK_Original_ID
            //WHERE Id = 1;

            //SELECT TextTranslated.TText
            //From images
            //Inner JOIN TextTranslated ON images.Id = TextTranslated.FK_Translated_ID
            //WHERE Id = 1;

            //SELECT image_path
            //From images
            //Where Id = 1;

            return T;
        }
        public static void DeleteDataFromTables()
        {
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "DELETE FROM images; DELETE FROM TextOriginal; DELETE FROM TextTranslated; DELETE FROM Session;";
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    myConnection.Close();
                }
            }
        }
        public static void DeleteTranslated(int Fk_ID)
        {
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "DELETE FROM TextOriginal WHERE FK_Original_ID = " + Fk_ID+";";
                //MessageBox.Show(sql);
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    myConnection.Close();
                }
            }
        }
        public static void DeleteOriginal(int Fk_ID)
        {
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "DELETE FROM TextTranslated WHERE FK_Translated_ID = " + Fk_ID + ";";
                //MessageBox.Show(sql);
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    myConnection.Close();
                }
            }
        }
        public static void DeleteImages(string sql_query)
        {
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                //MessageBox.Show(sql_query);
                using (SqlCommand cmd = new SqlCommand(sql_query, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    myConnection.Close();
                }
            }
        }
        public static void DeleteSession(string SessionName)
        {
            List<int> Id = GetListOfIds(SessionName);

            for(int i = 0; i < Id.Count; i++)
            {
                DeleteOriginal(Id[i]);
                DeleteTranslated(Id[i]);
            }
            if (Id.Count > 0)
            {
                string sql = "DELETE FROM images WHERE Id IN (";
                //DELETE FROM your_table
                //WHERE id IN(value1, value2, ...);
                for (int i = 0; i < Id.Count; i++)
                {
                    if (i + 1 == Id.Count)
                        sql += Id[i];
                    else
                        sql += Id[i] + ",";
                }
                sql += ");";
                DeleteImages(sql);
            }

            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "DELETE FROM Session WHERE NameSession = '"+SessionName+"';";
                //MessageBox.Show(sql);
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    myConnection.Close();
                }
            }
        }
        public static Bitmap ToGrey(Bitmap image1)
        {
            int x, y, temp;
            double red, blue, green, soma;

            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y); //gets the color of each pixel
                    red = Int32.Parse(pixelColor.R.ToString());
                    green = Int32.Parse(pixelColor.R.ToString());
                    blue = Int32.Parse(pixelColor.R.ToString());
                    soma = red * 0.3 + green * 0.59 + 0.11 * blue;
                    temp = Convert.ToInt32(soma);
                    pixelColor = Color.FromArgb(255, temp, temp, temp);
                    image1.SetPixel(x, y, pixelColor);
                }}
            return image1;
        }
        public static Bitmap NegativeColors(Bitmap image1)
        {
            int x, y;
            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y); //gets the color of each pixel
                    pixelColor = Color.FromArgb(pixelColor.ToArgb() ^ 0xffffff);
                    image1.SetPixel(x, y, pixelColor);
                }
            }
            return image1;
        }
        public static Bitmap ToBlackAndWhite(Bitmap image,int opacity,int value)
        {
            int x, y, red;
            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y); //gets the color of each pixel
                    red = Int32.Parse(pixelColor.R.ToString());
                    if (red >= value)
                    {
                        pixelColor = Color.FromArgb(opacity, 255, 255, 255);
                        image.SetPixel(x, y, pixelColor);
                    }
                    else
                    {
                        pixelColor = Color.FromArgb(255, 0,0,0);
                        image.SetPixel(x, y, pixelColor);
                    }
                }
            }
            return image;
        }
    }
}
