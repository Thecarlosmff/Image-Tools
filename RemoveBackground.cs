using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Image_Tools
{
    public partial class RemoveBackground : Form
    {
        int count = 0;
        readonly static String CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        public RemoveBackground()
        {
            InitializeComponent();
            TranslationTools.FillDropDownList("SELECT IDColor, Name FROM BackgroundColors Order by IDColor", comboColors);
        }

        private void Btn_SelectImages_Click(object sender, EventArgs e)
        {

            TranslationTools.FillList(list_RemBg,RemBgSelectImages);
        }

        private void RemoveBackground_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageToolsDataSet.BackgroundColors' table. You can move, or remove it, as needed.
            // this.backgroundColorsTableAdapter.Fill(this.imageToolsDataSet.BackgroundColors);
        }

        private void ListRemoveBackground_DoubleClick(object sender, EventArgs e)
        {
            if (this.list_RemBg.SelectedItems != null)
            {
                //list_RemBg.Add(list_RemBg.SelectedItems);
                this.list_RemBg.Items.Remove(list_RemBg.SelectedItems[0]);
            }
        }

        private void Btn_RemoveBackground_Click(object sender, EventArgs e)
        {
            if (output_local.Text == "")
            {
                MessageBox.Show("Select a output folder, images with the same name will be overwrited");
                return;
            }
            TranslationTools.show_MSG(label12, "Please wait...", Color.FromArgb(150, 255, 10, 10), 1);
            foreach (ListViewItem item in list_RemBg.Items) //percorre todos os ficheiros
            {
                try
                {
                    //MessageBox.Show(item.SubItems[0].Text + "\n" + item.SubItems[1].Text);

                    String result = Path.GetFileNameWithoutExtension(item.SubItems[0].Text);
                    RemoveImageBackground(item.SubItems[0].Text, this.output_local.Text, result + ".png");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void RemoveImageBackground(String path, String new_path, String filename)
        {
            //Verificações:
            if (new_path == "") return;

            Bitmap image1 = new Bitmap(path, true);

            int x, y, opacity;
            double hue, saturation, value;
            if (checkBox1.Checked)
                opacity = 0; //transparent
            else
                opacity = 255; //solid


            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y); //gets the color of each pixel
                    TranslationTools.ColorToHSV(pixelColor, out hue, out saturation, out value); //aqui temos os valores corretos do HSV
                                                                                                 //nas variaveis hue, saturation e value
                                                                                                 //MessageBox.Show("hue " + hue + "\nsaturation " + saturation + "\nvalue " + value);
                    if (!RightColor(hue, saturation, value))
                    {
                        //MessageBox.Show("hue " + hue + "\nsaturation " + saturation + "\nvalue " + value);
                        pixelColor = Color.FromArgb(opacity, 0, 0, 0);
                        image1.SetPixel(x, y, pixelColor);
                        //MessageBox.Show(pixelColor.R + "\n" + pixelColor.G+"\n"+pixelColor.B);
                    }

                }
            }



            //-------------
            if (path == new_path + "\\" + filename)
                filename = "_" + filename;
            if (System.IO.File.Exists(new_path + "\\" + filename))
                System.IO.File.Delete(new_path + "\\" + filename);
            image1.Save(new_path + "\\" + filename, ImageFormat.Png); //save the image
            image1.Dispose();

        }

        private bool RightColor(double hue, double sat, double val)
        {
            //Hue: 0-179
            //Saturation 0-255
            //Value 0-255
            if (hue == 360)
                hue = 360 - 2;
            hue = hue / 2;
            int IntHue = Convert.ToInt32(hue);
            int IntSat = Convert.ToInt32(sat * 255);
            int IntVal = Convert.ToInt32(val * 255);

            List<List<int>> ListArrays = new List<List<int>>();

            //ListArrays.Add(new List<int> { 1, 2, 3, 4, 5, 6 });

            ListArrays.AddRange(TranslationTools.GetListOfInts((int)numHueMin1.Value, (int)numHueMax1.Value, (int)numSatMin1.Value, (int)numSatMax1.Value, (int)numValMin1.Value, (int)numValMax1.Value));

            if (this.HSVBox1.Checked)
            {
                ListArrays.AddRange(TranslationTools.GetListOfInts((int)numHueMin2.Value, (int)numHueMax2.Value, (int)numSatMin2.Value, (int)numSatMax2.Value, (int)numValMin2.Value, (int)numValMax2.Value));
            }
            if (this.HSVBox2.Checked)
            {
                ListArrays.AddRange(TranslationTools.GetListOfInts((int)numHueMin3.Value, (int)numHueMax3.Value, (int)numSatMin3.Value, (int)numSatMax3.Value, (int)numValMin3.Value, (int)numValMax3.Value));
            }
            if (this.HSVBox3.Checked)
            {
                ListArrays.AddRange(TranslationTools.GetListOfInts((int)numHueMin4.Value, (int)numHueMax4.Value, (int)numSatMin4.Value, (int)numSatMax4.Value, (int)numValMin4.Value, (int)numValMax4.Value));
            }

            bool result = false;
            for (int x = 0; x < ListArrays.Count; x++)
            {
                result = TranslationTools.CheckBound(ListArrays[x], IntHue, IntSat, IntVal);
                if (result)
                    break;
            }
            return result;
        }

        private void Btn_RemBgSelectFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult dr = this.folderBrowserDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(folderBrowserDialog1.SelectedPath);
                this.output_local.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            if (count < 2)
                return;
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "select * from BackgroundColors where IDColor=" + TranslationTools.GetId(comboColors);
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    numHueMin1.Value = Int32.Parse(dt.Rows[0].ItemArray[2].ToString());
                    numHueMax1.Value = Int32.Parse(dt.Rows[0].ItemArray[3].ToString());
                    numSatMin1.Value = Int32.Parse(dt.Rows[0].ItemArray[4].ToString());
                    numSatMax1.Value = Int32.Parse(dt.Rows[0].ItemArray[5].ToString());
                    numValMin1.Value = Int32.Parse(dt.Rows[0].ItemArray[6].ToString());
                    numValMax1.Value = Int32.Parse(dt.Rows[0].ItemArray[7].ToString());

                    myConnection.Close();

                }
            }
        }

        private void Btn_addBgColor_Click(object sender, EventArgs e)
        {
            ColorsManagementDialog ColMan = new ColorsManagementDialog();
            this.Visible = false;
            ColMan.ShowDialog();
            this.Close();
            //RemBg.Show();
        }

        private void Btn_remBg_preview_Click(object sender, EventArgs e)
        {
            Form_PreviewBG Preview = new Form_PreviewBG();
            this.Visible = false;
            Preview.ShowDialog();
            this.Visible = true;
        }

        private void list_RemBg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cleanListViewRemBg_Click(object sender, EventArgs e)
        {
            TranslationTools.CleanListView(list_RemBg);
            numHueMin1.Value = 0;
            numHueMin2.Value = 0;
            numHueMin3.Value = 0;
            numHueMin4.Value = 0;

            numHueMax1.Value = 179;
            numHueMax2.Value = 179;
            numHueMax3.Value = 179;
            numHueMax4.Value = 179;

            numSatMin1.Value = 0;
            numSatMin2.Value = 0;
            numSatMin3.Value = 0;
            numSatMin4.Value = 0;

            numSatMax1.Value = 255;
            numSatMax2.Value = 255;
            numSatMax3.Value = 255;
            numSatMax4.Value = 255;

            numValMin1.Value = 0;
            numValMin2.Value = 0;
            numValMin3.Value = 0;
            numValMin4.Value = 0;

            numValMax1.Value = 255;
            numValMax2.Value = 255;
            numValMax3.Value = 255;
            numValMax4.Value = 255;

            checkBox1.Checked = false;
            HSVBox1.Checked = false;
            HSVBox2.Checked = false;
            HSVBox3.Checked = false;
            comboColors.SelectedIndex = 0;
        }
    }
}
