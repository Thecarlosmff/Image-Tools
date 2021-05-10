using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml;

namespace Image_Tools
{
    public partial class ImageToText : Form
    {
        string TESSERACT_EXE = "D:\\Programas\\Tesseract-OCR\\tesseract.exe";
        List<Text> listText = new List<Text>();
        public ImageToText()
        {
            InitializeComponent();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string path = "C:\\Screenshots\\4.png";
            string middle = "stdout";
            foreach (ListViewItem item in listView1.Items) //percorre todos os ficheiros
            {
                try
                {
                    OCR(TESSERACT_EXE, item.SubItems[0].Text, middle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        void OCR(string program,string cmdargs,string cmdargs2)
        {
            var proc = new Process()
            {
                //StartInfo = new ProcessStartInfo("cmd.exe", "/k " + cmdargs)
                StartInfo = new ProcessStartInfo(program, cmdargs + " " + cmdargs2)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                },
                EnableRaisingEvents = true
            };

            proc.Start();
            //string output = proc.StandardOutput.ReadToEnd(); //reads all the text

            string output;
            Text txt = new Text();
            txt.content = new List<string>();
            txt.content_trans = new List<string>();
            while ((output = proc.StandardOutput.ReadLine()) != null)
            {
                if (output == "")                       continue;
                if (output == ((char)12).ToString())    break;
                txt.content.Add(output);
                    
            }
            
            proc.WaitForExit();
            txt.img_path = cmdargs;
            listText.Add(txt);
        }

        void RunWithRedirect(string program, string cmdargs, string cmdargs2)
        {
            var proc = new Process()
            {
                //StartInfo = new ProcessStartInfo("cmd.exe", "/k " + cmdargs)
                StartInfo = new ProcessStartInfo(program, cmdargs + " " + cmdargs2)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                },
                EnableRaisingEvents = true
            };

            // see below for output handler
            proc.ErrorDataReceived += proc_DataReceived;  //to use with "proc_DataReceived"
            proc.OutputDataReceived += proc_DataReceived; //to use with "proc_DataReceived"

            proc.Start();
          
            proc.BeginErrorReadLine(); //error messages;
            proc.BeginOutputReadLine();

            proc.WaitForExit();
        }

        void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            //MessageBox.Show("Hello");
            //passa aqui o nº de linhas que é para inserir;
            if (e.Data != null)
            {
                MessageBox.Show(e.Data);
                //MessageBox.Show(((char)12).ToString());
                //Dispatcher.BeginInvoke(new Action(() => txtOut.Text += (Environment.NewLine + e.Data)));
            }
        }
        void Translation(string inLang,string outLang,Text T)
        {
            string concat = "";
            for (int i = 0; i < T.content.Count; i++)
            {
                if (!(inLang == "ja")) //not japonese verify , probably chinese are other asiatic languages that dont use spaces (or are optional) (why????)
                    concat += T.content[i] + " ";
                else
                    concat += T.content[i];
            }
            if (!(inLang == "ja"))
                concat = concat.Remove(concat.Length - 1);
            //MessageBox.Show("\""+concat+"\"");

            //MessageBox.Show(handleTranslation("en", "ja", concat));
            string a = handleTranslation(inLang, outLang, concat);
            if(a != null)
            {
                T.content_trans.Add(a);
            }
        }
        private string handleTranslation(string InLang,string OutLang,string text)
        {
            string url = "https://translate.google.com/m?hl=?" + InLang + "&sl=" + InLang + "&tl=" + OutLang + "&ie=UTF-16&prev=_m&q=" + text;

            WebClient web = new WebClient();
            web.Encoding = System.Text.Encoding.UTF8;
            System.IO.Stream stream = web.OpenRead(url);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                String a = reader.ReadToEnd();
                web.Dispose();
                web = null;
                a = GetBetween(a, "class=\"result-container\">", "</div>");
                //MessageBox.Show(a);
                return a;
            }

        }

        public static string GetBetween(string source, string start, string end)
        {
            var startPos = source.IndexOf(start, StringComparison.Ordinal);
            if (startPos < 0) return null;
            startPos += start.Length;
            var endPos = source.IndexOf(end, startPos, StringComparison.Ordinal);
            return endPos < 0 ? null : source.Substring(startPos, endPos - startPos - 1);
        }

        private void TranslateAll(List<Text> T)
        {
            for (int i = 0; i < T.Count; i++)
                Translation("en", "pt", T[i]);
            //MessageBox.Show("Translation Done! Good Work!");
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_SelectImages(object sender, EventArgs e)
        {
            TranslationTools.FillList(listView1, openFileDialog1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==2)
            {
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                numericUpDown1.Visible = false;
                numericUpDown2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TranslateAll(listText);
            int a = 1;
        }
    }
}
