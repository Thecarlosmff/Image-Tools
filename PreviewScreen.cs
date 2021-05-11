using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Image_Tools
{
    public partial class Form_PreviewBG : Form
    {
        string OPath = "";
        readonly string NPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\temp.png";     //image that will be loaded and displayed in the PitureBox
        readonly string NPath1 = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\temp1.png";   //a copy of the original
        int count = 0;
        readonly static String CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        public Form_PreviewBG()
        {
            InitializeComponent();
            TranslationTools.FillDropDownList("SELECT IDColor, Name FROM BackgroundColors Order by IDColor", comboBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void selectImage(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter =
        "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
        "All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select a image";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames) //percorre todos os ficheiros
                {
                    try
                    {
                        OPath = file;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            UpdateImage(false);

        }
        private void CreateTempImage(string origin,string destin)
        {
            //To DO
            //make sure that the app isn't using the image(s)
            try
            {
                if (origin == destin) { return; }
            if (System.IO.File.Exists(destin))
                System.IO.File.Delete(destin);

            Bitmap image1 = new Bitmap(origin, true);
            image1.Save(destin, ImageFormat.Png); //save the image
            image1.Dispose();
            }
            catch
            {

            }
        }
        private void UpdateImage(bool option)
        {
            Cursor.Current = Cursors.WaitCursor;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            //Option = 0; new file DO not apply remover
            //Option = 1; update, apply remover
            //create a temp image to load, DO NOT WORK WITH THE ORIGINAL
            TranslationTools.clearPictureBox(pictureBox1);//so the app do not use the image while modifing it
                                                    //test with image open elsewhere, exception created , futher test are needed
            CreateTempImage(OPath, NPath);
            if (option == false)
            {// load temp 
                if (System.IO.File.Exists(NPath))
                    pictureBox1.Image = Image.FromFile(NPath);
            }
            else
            {//Creates a temp from original and apply mask to the temp (replacing it)
                TranslationTools.clearPictureBox(pictureBox1); //so the app do not use the image
                                                               //test with image open elsewhere
                RemoveImageBackground();
                pictureBox1.Image = Image.FromFile(NPath);

            }

            DefinePicBoxSize(pictureBox1, NPath);

            Cursor.Current = Cursors.Default;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        private void getImageRatio(Image img)
        {
            MessageBox.Show(img.Width.ToString());
            MessageBox.Show(img.Height.ToString());
        }
        private void DefinePicBoxSize(PictureBox box,string path)
        {
            //image size:

            if (!System.IO.File.Exists(path)) return;
            Bitmap image1 = new Bitmap(path, true);
            int w = image1.Width;
            int h = image1.Height;
            //int w = box.Image.Width;
            //int h = box.Image.Height;
            image1.Dispose();
            double a = w;
            double b = h;
            int boxMaxH = box.MaximumSize.Height;
            int boxMaxW = box.MaximumSize.Width;
            if(a<boxMaxW & b<boxMaxH)
            {
                box.Size = new System.Drawing.Size(box.MaximumSize.Width, box.MaximumSize.Height);
                return;
            }

                

            for (double z = 1; b > boxMaxH & a > boxMaxW; z = z - 0.02)
            {
                b = h * z;
                a = w * z;
                if (z <= 0)
                {
                    MessageBox.Show("Impossible to resize image");
                    box.Size = new System.Drawing.Size(box.MaximumSize.Width, box.MaximumSize.Height);
                    return;
          
                }
            }
            box.Size = new System.Drawing.Size(Convert.ToInt32(Math.Floor(a)), Convert.ToInt32(Math.Floor(b)));


        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (OPath == "") return;
            TranslationTools.show_MSG(label7, "Please wait...", Color.FromArgb(150, 255, 10, 10), 1);
            UpdateImage(true);
        }
        private void RemoveImageBackground()
        {
            CreateTempImage(NPath, NPath1);
            //copies the Temp image to another path
            //now use the new temp
            Bitmap image1 = new Bitmap(NPath1, true);

            int x, y, opacity,red,green,blue;
            bool removeWhite = false;
            bool removeBlack = false;
            double hue, saturation, value;
            if (checkBox1.Checked)
                opacity = 0; //transparent
            else
                opacity = 255; //solid
            if (checkBox2.Checked)
                removeWhite = true;
            if (checkBox3.Checked)
                removeBlack = true;
            if (checkBox4.Checked)
                red = 255;
            else
                red = 0;
            if (checkBox5.Checked)
                green = 255;
            else
                green = 0;
            if (checkBox6.Checked)
                blue = 255;
            else
                blue = 0;



            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y); //gets the color of each pixel
                    if (removeBlack)
                    {
                        if (pixelColor.R < 31 & pixelColor.G < 31 & pixelColor.B < 31)
                        {
                            pixelColor = Color.FromArgb(opacity, red, green, blue);
                            image1.SetPixel(x, y, pixelColor);
                            continue;
                        }

                    }
                    if (removeWhite)
                    {
                        if (pixelColor.A <=  20 | (pixelColor.R >= 235 & pixelColor.G >= 235 & pixelColor.B >= 235))
                        {
                            pixelColor = Color.FromArgb(opacity, red, green, blue);
                            image1.SetPixel(x, y, pixelColor);
                            continue;
                        }

                    }


                    TranslationTools.ColorToHSV(pixelColor, out hue, out saturation, out value); //aqui temos os valores corretos do HSV
                                                                                //nas variaveis hue, saturation e value
                                                                                //MessageBox.Show("hue " + hue + "\nsaturation " + saturation + "\nvalue " + value);
                    if (!RightColor(hue, saturation, value))
                    {
                        //MessageBox.Show("hue " + hue + "\nsaturation " + saturation + "\nvalue " + value);
                        pixelColor = Color.FromArgb(opacity, red, green, blue);
                        image1.SetPixel(x, y, pixelColor);
                        //MessageBox.Show(pixelColor.R + "\n" + pixelColor.G+"\n"+pixelColor.B);
                    }

                }
            }

            //-------------
            if (System.IO.File.Exists(NPath))
                System.IO.File.Delete(NPath);
            Bitmap image2 = new Bitmap(NPath1, true);
            image1.Save(NPath, ImageFormat.Png); //save the image
            image1.Dispose();
            image2.Dispose();

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

            ListArrays.AddRange(TranslationTools.GetListOfInts((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value));

            bool result = false;
            for (int x = 0; x < ListArrays.Count; x++)
            {
                result = TranslationTools.CheckBound(ListArrays[x], IntHue, IntSat, IntVal);
                if (result)
                    break;
            }
            return result;
        }
        private void Form_PreviewBG_FormClosing(object sender, FormClosingEventArgs e)
        {
            TranslationTools.clearPictureBox(pictureBox1);
            if (System.IO.File.Exists(NPath)) System.IO.File.Exists(NPath);
            if (System.IO.File.Exists(NPath1)) System.IO.File.Delete(NPath1);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Save_Image();
        }
        private void Save_Image()
        {
            // https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
            if (System.IO.File.Exists(NPath))
            {
                Bitmap image1 = new Bitmap(NPath, true);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Png Image|*.png";
                saveFileDialog1.Title = "Save an Image File DON'T ADD AN EXTENSION";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs =
                        (System.IO.FileStream)saveFileDialog1.OpenFile();
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            image1.Save(fs,
                              System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }

                    fs.Close();
                }
                image1.Dispose();
            }
            else
            {
                MessageBox.Show("No image selected");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            if (count < 2)
                return;
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "select * from BackgroundColors where IDColor=" + TranslationTools.GetId(comboBox1);
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    numericUpDown1.Value = Int32.Parse(dt.Rows[0].ItemArray[2].ToString());
                    numericUpDown2.Value = Int32.Parse(dt.Rows[0].ItemArray[3].ToString());
                    numericUpDown3.Value = Int32.Parse(dt.Rows[0].ItemArray[4].ToString());
                    numericUpDown4.Value = Int32.Parse(dt.Rows[0].ItemArray[5].ToString());
                    numericUpDown5.Value = Int32.Parse(dt.Rows[0].ItemArray[6].ToString());
                    numericUpDown6.Value = Int32.Parse(dt.Rows[0].ItemArray[7].ToString());

                    myConnection.Close();

                }
            }
        }

        private void Form_PreviewBG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageToolsDataSet.BackgroundColors' table. You can move, or remove it, as needed.
            //this.backgroundColorsTableAdapter.Fill(this.imageToolsDataSet.BackgroundColors);

        }
    }
}
