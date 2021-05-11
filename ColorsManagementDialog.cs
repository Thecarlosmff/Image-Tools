using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Image_Tools
{
    public partial class ColorsManagementDialog : Form
    {
        static String CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        int count = 0;
        public ColorsManagementDialog()
        {
            InitializeComponent();
        }
        private void ColorsManagementDialog_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            TranslationTools.FillDropDownList("Select * From BackgroundColors Order by IDColor", deleteBox);
            TranslationTools.FillDropDownList("Select * From BackgroundColors Order by IDColor", UpdateBox);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            if (count < 3)
                return;
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "select * from BackgroundColors where IDColor=" + TranslationTools.GetId(UpdateBox);
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


        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.backgroundColorsTableAdapter.FillBy1(this.imageToolsDataSet.BackgroundColors);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void deleteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (deleteBox.Text == "1") return;
            //showItens();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete button
            int id = TranslationTools.GetId(deleteBox);
            if (id == 1)
            {
                MessageBox.Show(deleteBox.Text + " can't be deleted");
                return;
            }
            try
            {
                using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
                {
                    //string sql = "select * from BackgroundColors where IDColor=" + TranslationTools.GetId(UpdateBox);
                    string sql = "DELETE FROM BackgroundColors WHERE IDColor=" + id;
                    //MessageBox.Show(sql);
                    //return;
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        //DataTable dt = new DataTable();
                        //dt.Load(dr);

                        myConnection.Close();

                        //reloads the ComboBoxes
                        count = 0;
                        TranslationTools.FillDropDownList("Select * From BackgroundColors Order by IDColor", deleteBox);
                        TranslationTools.FillDropDownList("Select * From BackgroundColors Order by IDColor", UpdateBox);


                    }
                }
            }catch { return; }
            MessageBox.Show("Element sucessefully eliminated!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //update button
            int id = TranslationTools.GetId(UpdateBox);
            if (id == 1)
            {
                MessageBox.Show(UpdateBox.Text +" can't be edited");
                return;
            }
            decimal mHue = numericUpDown1.Value;
            decimal MHue = numericUpDown2.Value;
            decimal mSat = numericUpDown3.Value;
            decimal MSat = numericUpDown4.Value;
            decimal mVal = numericUpDown5.Value;
            decimal MVal = numericUpDown6.Value;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
                {
                    //string sql = "select * from BackgroundColors where IDColor=" + TranslationTools.GetId(UpdateBox);
                    string sql = "UPDATE BackgroundColors SET HueMin = " + mHue + ", HueMax = " + MHue + ", SatMin = " + mSat + ", SatMax = " + MSat + ", ValMin = " + mVal + ", ValMax = " + MVal + " WHERE IDColor=" + id;
                    //MessageBox.Show(sql);
                    //return;
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        myConnection.Close();

                    }
                }
            } catch { return; }
            MessageBox.Show("Element sucessefully updated!");
        }
        private bool NameExists(string name)
        {
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                //string sql = "select * from BackgroundColors where IDColor=" + TranslationTools.GetId(UpdateBox);
                string sql = "SELECT Name FROM BackgroundColors";
                //MessageBox.Show(sql);
                //return;
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    try
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        //MessageBox.Show(dt.Rows.Count.ToString());
                        //dt.Rows[0].ItemArray[2].ToString();
                        int rows = Int32.Parse(dt.Rows.Count.ToString());
                        for (int i = 0;i<rows;i++)
                        {
                            if (name.Equals(dt.Rows[i].ItemArray[0].ToString(), StringComparison.CurrentCultureIgnoreCase)) //case insensitive
                            {  myConnection.Close(); return true;  }
                        }
                        myConnection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                        return true;
                    }


                }
            }
            return false;

        }
        private void new_btn_save_Click(object sender, EventArgs e)
        {
            if (new_nameTextBox.Text == "") { MessageBox.Show("Choose a name"); return; }
            if (NameExists(new_nameTextBox.Text)) {MessageBox.Show("Choose different name"); return; }
            if (new_nameTextBox.Text.Length > 14) { MessageBox.Show("Use a smaller name"); return; }
            //INSERT INTO table_name(column1, column2, column3, ...)
            //VALUES(value1, value2, value3, ...);

            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "INSERT INTO BackgroundColors (Name,HueMin,HueMax,SatMin,SatMax,ValMin,ValMax) VALUES ('" + new_nameTextBox.Text + "'," + new_hueMinNumericUpDown.Value + "," + new_hueMaxNumericUpDown.Value + "," + new_satMinNumericUpDown.Value + "," + new_satMaxNumericUpDown.Value + "," + new_valMinNumericUpDown.Value + "," + new_valMaxNumericUpDown.Value + ");";
                //MessageBox.Show(sql);
                //return;
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    try {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        myConnection.Close();

                    //reloads the ComboBoxes and resets values
                    count = 0;
                    new_nameTextBox.Text = "";
                    new_hueMinNumericUpDown.Value = 0;
                    new_hueMaxNumericUpDown.Value = 0;
                    new_satMinNumericUpDown.Value = 0;
                    new_satMaxNumericUpDown.Value = 0;
                    new_valMinNumericUpDown.Value = 0;
                    new_valMaxNumericUpDown.Value = 0;
                    //MessageBox.Show(sql);
                    TranslationTools.FillDropDownList("Select * From BackgroundColors Order by IDColor", deleteBox);
                    TranslationTools.FillDropDownList("Select * From BackgroundColors Order by IDColor", UpdateBox);
                    MessageBox.Show("Sucess!");
                    }  catch  { MessageBox.Show("Error");   }
                    


                }
            }

        }
    }
}
