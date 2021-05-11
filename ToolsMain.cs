using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void Btn_MainTxtToExcel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MainTranslate_Click(object sender, EventArgs e)
        {

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
    }
}
