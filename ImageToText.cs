using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text;

namespace Image_Tools
{
    public partial class ImageToText : Form
    {
        //string TESSERACT_EXE = "D:\\Programas\\Tesseract-OCR\\tesseract.exe";
        string TESSERACT_EXE = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Tesseract-OCR\\tesseract.exe";
        List<Text> listText = new List<Text>();
        string special = ((char)12).ToString();
        public ImageToText()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string path = "C:\\Screenshots\\4.png";
            string middle = "stdout";
            if (OCRCombo.SelectedItem != null)
                middle += " -l " + TranslationTools.getOCRLang(OCRCombo.Text);
            else
                middle += " -l eng";
            TranslationTools.show_MSG(label1, "Please wait...", Color.FromArgb(150, 255, 10, 10), 1);
            foreach (ListViewItem item in listView1.Items) //percorre todos os ficheiros
            {
                try
                {
                    //var Result = new IronTesseract().Read(item.SubItems[0].Text).Text;
                    //return;
                    OCR(TESSERACT_EXE, item.SubItems[0].Text, middle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            listView1.Clear();

        }
        void OCR(string program, string cmdargs, string cmdargs2)
        {

           var proc = new Process()
            {
               //"[Console]::OutputEncoding = New - Object System.Text.UTF8Encoding $false;"
               //StartInfo = new ProcessStartInfo("cmd.exe", "/k " + cmdargs)
               StartInfo = new ProcessStartInfo(program, cmdargs + " " + cmdargs2)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    //RedirectStandardInput = true,
                    UseShellExecute = false
                    
                },
                EnableRaisingEvents = true
            };

            proc.Start();
            //string output = proc.StandardOutput.ReadToEnd(); //reads all the text
            //proc.StandardInput.WriteLine("chcp 65001");
            //proc.StandardInput.Flush();
            //proc.StandardInput.Close();
            //Console.OutputEncoding = Encoding.UTF8;
            string output;
            Text txt = new Text();
            //int count = 0;
            while ((output = proc.StandardOutput.ReadLine()) != null)
            {
                if (output == "" | output == " ")
                {
                    //count++;
                    continue;
                }
                // else
                //{
                // if (!(count % 2 == 0))
                //     txt.content.Add("");
                // count = 0;

                // }
                //}
                if (output == ((char)12).ToString()) break;
                if (CheckReplace1.Checked) output = output.Replace("|", "I");
                txt.content.Add(output);
                //previous = output;

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
        
        private void TranslateAll(List<Text> T)
        {
            for (int i = 0; i < T.Count; i++)
                //Translation(T[i].lang_con, TranslationTools.getTranslationStr(TransCombo.SelectedText), T[i]);
                if (TransCombo.SelectedItem != null)
                    TranslationTools.Translation("auto", TranslationTools.getTranslationStr(TransCombo.SelectedItem.ToString()), T[i]);
                else
                    TranslationTools.Translation("auto", "eng", T[i]);
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
        private void SaveToFileCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TranslationTools.show_MSG(label1, "Please wait...", Color.FromArgb(150, 255, 10, 10), 1);
            TranslateAll(listText);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            //SaveToTxt_Original(listText);
            //SaveToTxt_Translated(listText);
            //SaveToTxt_Both(listText);
            ////SaveToExcel_both(listText,1,1);
            //SaveExcel(listText,1,1);
            //SaveWord(listText);
            if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Select a type of file");
                return;
            }
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    Save("Text File|*.txt"); //txt original
                    break;
                case 1: //txt translation
                    Save("Text File|*.txt");
                    break;
                case 2: //txt both
                    Save("Text File|*.txt");
                    break;
                case 3: //word
                    Save("Word Document|*.docx");
                    break;
                case 4://excel
                    Save("Excel|*.xls");
                    break;

            }
        }
        private void Save(string extension)
        {
            // https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
            if (listText.Count > 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = extension;
                saveFileDialog1.Title = "Save the document";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    TranslationTools.show_MSG(label1, "Please wait...", Color.FromArgb(150, 255, 10, 10), 1);
                    switch (comboBox4.SelectedIndex)
                    {
                        case 0://txt original  
                            SaveToTxt_Original(listText, saveFileDialog1.FileName); break;
                        case 1: //txt translation
                            SaveToTxt_Translated(listText, saveFileDialog1.FileName); break;
                        case 2: //txt both
                            SaveToTxt_Both(listText, saveFileDialog1.FileName); break;
                        case 3: //word
                            SaveWord(listText, saveFileDialog1.FileName); break;
                        case 4://excel
                            SaveExcel(listText, 1, 1, saveFileDialog1.FileName); break;

                    }
                }
            }
            else
            {
                MessageBox.Show("No data available!");
            }
        }
        private void SaveWord(List<Text> list, string filename)
        {
            //https://stackoverflow.com/questions/38356903/how-to-write-text-into-a-word-file-using-c-net
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc;
            object oMissing = null;
            object missing = null;
            try
            {
                oMissing = System.Reflection.Missing.Value;
                missing = System.Reflection.Missing.Value;
                doc = app.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                doc.Content.Font.Size = 9;
                //doc.Content.Font.Bold = 1;

                for (int i = 0; i < list.Count; i++)
                {
                    //foreach (string line in sentence.content)
                    for (int j = 0; j < list[i].content.Count; j++)
                    {
                        //doc.Content.Text += list[i].content[j] + ((char)13);
                        doc.Content.Text += list[i].content[j];
                    }
                    doc.Content.Text += ((char)12);
                    for (int k = 0; k < list[i].content_trans.Count; k++)
                    {
                        //doc.Content.Text += list[i].content_trans[k] + ((char)13);
                        doc.Content.Text += list[i].content_trans[k];
                    }
                    if (!(i + 1 == list.Count))
                        doc.Content.Text += ((char)12);
                }

                doc.SaveAs2(filename);
                doc.Save();
                doc.Close();

                app.Visible = false;    //Optional
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Marshal.ReleaseComObject(app);
            }
        }
        private void SaveExcel(List<Text> list, int row, int column, string fileName)
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            string temp = "";
            for (int i = 0; i < list.Count; i++)
            {
                //foreach (string line in sentence.content)
                for (int j = 0; j < list[i].content.Count; j++)
                {
                    temp += list[i].content[j] + " " + ((char)10);
                }
                if (temp.Length > 0)
                    temp = temp.Remove(temp.Length - 1);
                xlWorkSheet.Cells[row, column] = temp;
                temp = "";

                for (int k = 0; k < list[i].content_trans.Count; k++)
                {
                    temp += list[i].content_trans[k] + " " + ((char)10);
                }
                if (temp.Length > 0)
                    temp = temp.Remove(temp.Length - 1);
                xlWorkSheet.Cells[row, column + 2] = list[i].img_path;
                xlWorkSheet.Cells[row, column + 1] = temp;
                temp = "";
                row++;
            }



            xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            //MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
        }
        private void SaveToTxt_Both(List<Text> list, string fileName)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
                {
                    //foreach (Text sentence in list)
                    for (int i = 0; i < list.Count; i++)
                    {
                        //foreach (string line in sentence.content)
                        for (int j = 0; j < list[i].content.Count; j++)
                        {
                            file.WriteLine(list[i].content[j]);
                            //file.WriteLine(line);
                        }
                        //file.WriteLine((char)12);
                        file.WriteLine();

                        for (int k = 0; k < list[i].content_trans.Count; k++)
                        {
                            if (i + 1 == list.Count & k + 1 == list[i].content_trans.Count) //ultima linha de tudo
                                file.Write(list[i].content_trans[k]);
                            else
                                file.WriteLine(list[i].content_trans[k]);
                            //file.WriteLine(line);
                        }
                        if (!(i + 1 == list.Count))
                            //file.WriteLine((char)12);
                            file.WriteLine((char)13);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void SaveToTxt_Translated(List<Text> list, string fileName)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
                {
                    //foreach (Text sentence in list)
                    for (int i = 0; i < list.Count; i++)
                    {
                        //foreach (string line in sentence.content)
                        for (int j = 0; j < list[i].content_trans.Count; j++)
                        {
                            if (i + 1 == list.Count & j + 1 == list[i].content_trans.Count) //ultima linha de tudo
                                file.Write(list[i].content_trans[j]);
                            else
                                file.WriteLine(list[i].content_trans[j]);
                            //file.WriteLine(line);
                        }
                        if (!(i + 1 == list.Count))
                            file.WriteLine((char)12);
                        //file.Write((char)12);
                        //file.WriteLine();
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void SaveToTxt_Original(List<Text> list, string fileName)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
                {
                    //foreach (Text sentence in list)
                    for (int i = 0; i < list.Count; i++)
                    {
                        //foreach (string line in sentence.content)
                        for (int j = 0; j < list[i].content.Count; j++)
                        {
                            if (i + 1 == list.Count & j + 1 == list[i].content.Count) //ultima linha de tudo
                                file.Write(list[i].content[j]);
                            else
                                file.WriteLine(list[i].content[j]);
                            //file.WriteLine(line);
                        }
                        if (!(i + 1 == list.Count))
                            file.WriteLine((char)12);
                        //file.Write((char)12);
                        //file.WriteLine();
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            TranslationTools.CleanListView(listView1);
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems != null)
            {
                //list_RemBg.Add(list_RemBg.SelectedItems);
                this.listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listText.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ModifyText form = new ModifyText();
            form.passList(this.listText);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}