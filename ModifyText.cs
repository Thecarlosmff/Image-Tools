using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Image_Tools
{
    public partial class ModifyText : Form
    {
        static String CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        public ModifyText()
        {
            InitializeComponent();
            TranslationTools.FillDropDownSessions("SELECT DISTINCT NameSession from Session;",comboSession);
        }

        List<Text> myList = new List<Text>();
        List<Text> tempList = new List<Text>();
        int number = 0; // Used to see what should be in the text boxes;

        public void passList(List<Text> List)
        {
            this.myList = List;
            tempList.AddRange(List);
        }

        private void btn_load_current_Click(object sender, System.EventArgs e)
        {
            number = 0;
            updateTextBox();
        }

        private void updateTextBox()
        {
            rich_Original.Text = "";
            rich_translated.Text = "";
            if (tempList.Count <= 0)
            {
                btn_delete.Enabled = false;
                btn_go_to.Enabled = false;
                btn_discard.Enabled = false;
                lbl_count.Text = "";
                lbl_count.Visible = false;
                lbl_path.Visible = false;
                lbl_path.Text = "";
                return;
            }
            else
            {
                btn_delete.Enabled = true;
                btn_go_to.Enabled = true;
                btn_discard.Enabled = true;
                lbl_count.Text = number + 1 + " of " + tempList.Count;
                lbl_count.Visible = true;
            }

            if (number > tempList.Count - 1 | number < 0) number = 0;

            lbl_path.Text = tempList[number].img_path;
            lbl_path.Visible = true;
            int i;
            int j;
            for (i = 0; i < tempList[number].content.Count - 1; i++) //-1 to add the text bellow
            {
                rich_Original.Text += tempList[number].content[i];
                rich_Original.Text += ((char)13);
            }
            if (tempList[number].content.Count > 0)
                rich_Original.Text += tempList[number].content[i];

            for (j = 0; j < tempList[number].content_trans.Count - 1; j++) //-1 to add the text bellow
            {
                rich_translated.Text += tempList[number].content_trans[j];
                rich_translated.Text += ((char)13);
            }
            if (tempList[number].content_trans.Count > 0)
                rich_translated.Text += tempList[number].content_trans[j];

            if (number == 0)
                btn_previous.Enabled = false;
            else
                btn_previous.Enabled = true;

            if (number >= tempList.Count - 1)
                btn_next.Enabled = false;
            else
                btn_next.Enabled = true;
            num_goto.Maximum = tempList.Count;
            num_goto.Minimum = 1;
            num_goto.Value = number+1;


        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            SaveThis();
            number = number - 1;
            updateTextBox();
        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            SaveThis();
            number = number + 1;
            updateTextBox();
        }

        private void btn_go_to_Click(object sender, System.EventArgs e)
        {
            SaveThis();
            number = (int)num_goto.Value - 1;
            updateTextBox();
        }
        private void SaveThis()
        {
            tempList[number].content.Clear();
            tempList[number].content_trans.Clear();
            for (int i = 0;i< rich_Original.Lines.Length; i++)
            {
                tempList[number].content.Add(rich_Original.Lines[i]);
            }
            for (int i = 0; i < rich_translated.Lines.Length; i++)
            {
                tempList[number].content_trans.Add(rich_translated.Lines[i]);
            }

        }

        private void btn_delete_Textbox(object sender, System.EventArgs e)
        {
            if (number < 0 | tempList.Count <= 0) { return; }
                tempList.RemoveAt(number);
                number -= 1;
                updateTextBox();
        }

        private void btn_discard_Click(object sender, EventArgs e)
        {
            updateTextBox();
        }

        private void btn_save_current_Click(object sender, EventArgs e)
        {
            SaveThis();
            myList.Clear();
            myList.AddRange(tempList);
        }

        private void btn_save_session_Click(object sender, EventArgs e)
        {
            if (comboSession.SelectedItem == null)
            {
                MessageBox.Show("Select a session");
                return;
            }
            if (rich_Original.TextLength > 0 | rich_translated.TextLength > 0)
                SaveThis();
            myList.Clear();
            myList.AddRange(tempList);
            //TranslationTools.DeleteDataFromTables();
            string name = comboSession.Text;

            //1º apagar todos os dados da sessão que se vai salvar
            TranslationTools.DeleteSession(name);

            //2º invocar a função new session, é provavelmente melhor copiar porque se o
            //primeiro passo foi bem sucessido, o nome não existe
            int Id;
            for (int i = 0; i < myList.Count; i++)
            {
                TranslationTools.InsertImagePath(myList[i]);
                Id = TranslationTools.GetLastId(); //gets the inserted ID of InsertImagePath
                TranslationTools.InsertSession(name, Id); //creates a session
                TranslationTools.InsertScript(myList[i], Id); //associates the Id of the images table to the text
            }
            //REFRESH THE SESSION LIST (comboSession)
        }


        private void btn_load_session_Click(object sender, EventArgs e)
        {
            if (comboSession.SelectedItem == null)
            { 
                MessageBox.Show("Select a session");
                return;
            }
            string name = comboSession.Text;
            tempList.Clear();
            tempList = TranslationTools.LoadFromDB(name);
            number = 0;
            updateTextBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ModifyText_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_session_Click(object sender, EventArgs e)
        {
            
            if(rich_Original.TextLength > 0 | rich_translated.TextLength > 0)
                SaveThis();
            List<string> Sessions = TranslationTools.GetSessionNames();
            string name = TextBox_SessionName.Text;
            if(name.Length < 3 | name.Length > 15)
            {
                MessageBox.Show("Write a name with:\nmore than 2 letters and less than 16");
                return;
            }
            for (int i = 0;i<Sessions.Count;i++)
            {
                if (Sessions[i].Equals(name,StringComparison.CurrentCultureIgnoreCase))
                {
                    MessageBox.Show(Name + " already exists choose another");
                    return;
                }

            }
            myList.Clear();
            myList.AddRange(tempList);
            int Id;
            for (int i = 0; i < myList.Count; i++)
            {
                TranslationTools.InsertImagePath(myList[i]);
                Id = TranslationTools.GetLastId(); //gets the inserted ID of InsertImagePath
                TranslationTools.InsertSession(name, Id); //creates a session
                TranslationTools.InsertScript(myList[i], Id); //associates the Id of the images table to the text
            }
            TranslationTools.FillDropDownSessions("SELECT DISTINCT NameSession from Session;", comboSession);
        }       //debuged

        private void btn_delete_session_Click(object sender, EventArgs e)
        {
            if (comboSession.SelectedItem == null)
            {
                MessageBox.Show("Select a session");
                return;
            }
            TranslationTools.DeleteSession(comboSession.Text);
            TranslationTools.FillDropDownSessions("SELECT DISTINCT NameSession from Session;", comboSession);
        }
        private void Degub(string query)
        {
            MessageBox.Show("____________"+ query + "_______________");
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = query;

                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    //lastID = Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
                    string temp;
                    for (int j = 0; j < dt.Rows.Count; j++)
                    { temp = "";
                        for (int k = 0; k < dt.Rows[j].ItemArray.Length; k++)
                            temp += dt.Rows[j].ItemArray[k].ToString() + "\n";
                        MessageBox.Show(temp);
                    }
                    myConnection.Close();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Degub("SELECT * From images;");
            Degub("SELECT * From Session;");
            Degub("SELECT * From TextOriginal;");
            Degub("SELECT * From TextTranslated;");
        }

        private void lbl_path_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(lbl_path.Text))
                Process.Start(lbl_path.Text);
        }
    }
}
