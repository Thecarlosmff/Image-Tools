using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Tools
{
    public partial class ModifyText : Form
    {
        static String CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        List<Text> myList = new List<Text>();
        List<Text> tempList = new List<Text>();
        List<Text> wordList = new List<Text>();
        int number = 0; // Used to see what should be in the text boxes;
        float fontsize1 = 10;
        float fontsize2 = 10;
        Byte live = 0;
        TypeAssistant assistant;

        private static System.Threading.Timer _timer;//https://www.c-sharpcorner.com/blogs/how-to-run-a-timer-on-specific-time-interval

        public ModifyText()
        {
            InitializeComponent();
                assistant = new TypeAssistant();
                assistant.Idled += assistant_Idled;
                TranslationTools.FillDropDownSessions("SELECT DISTINCT NameSession from Session;",comboSession);
           
            _timer = new System.Threading.Timer(x => { callTimerMethode(); }, null, Timeout.Infinite, Timeout.Infinite);
            Setup_Timer();
            updateTextBox();
        }

        private void callTimerMethode()
        {
            if(checkBox2.Checked)
            auto_save_new();
        }
        private static void Setup_Timer()
        {
            //DateTime currentTime = DateTime.Now;
            //DateTime timerRunningTime = new DateTime(currentTime.Year,currentTime.Month, currentTime.Day, 2, 0, 0);
            //timerRunningTime = timerRunningTime.AddDays(15);
            DateTime timerRunningTime = DateTime.Now.AddSeconds(300); 

            double tickTime = (double)(timerRunningTime - DateTime.Now).TotalSeconds;

            _timer.Change(TimeSpan.FromSeconds(tickTime), TimeSpan.FromSeconds(tickTime));
        }

        public void passList(List<Text> List)
        {
            int i = 0;
            this.myList = List;
            tempList.Clear();
            foreach (Text t in myList)
            {
                t.index = i;
                //tempList.Add((Text)t.Clone());
                i += 1;
            }
        }

        private void btn_load_current_Click(object sender, System.EventArgs e)
        {
            //SaveThis();
            tempList.Clear();
            foreach (Text t in myList)
            {
                tempList.Add((Text)t.Clone());
            }

            number = 0;
            updateTextBox();
        }

        private void updateTextBox()
        {
            rich_Original.Text = "";
            rich_Translated.Text = "";
            //btn_1.Enabled = true;
            if (checkBox1.Checked)
                live = 1;
            else
                live = 0;
            if(live == 1)
            {
                this.pictureBox1.Image = global::Image_Tools.Properties.Resources.circle_16_Green;
            }
            else
            {
                this.pictureBox1.Image = global::Image_Tools.Properties.Resources.circle_16;
            }
            if (tempList.Count <= 0)
            {
                btn_delete.Enabled = false;
                btn_go_to.Enabled = false;
                btn_discard.Enabled = false;
                lbl_count.Text = "";
                lbl_count.Visible = false;
                lbl_path.Visible = false;
                lbl_path.Text = "";
                btn_1.Visible = true;
                btn_2.Visible = false;
                btn_3.Visible = false;
                rich_Original.ReadOnly = true;
                rich_Translated.ReadOnly = true;
                rich_Original.BackColor = System.Drawing.Color.LightGray;
                rich_Translated.BackColor = System.Drawing.Color.LightGray;
                return;
            }
            else
            {
                btn_delete.Enabled = true;
                btn_go_to.Enabled = true;
                btn_discard.Enabled = true;
                lbl_count.Text = number + 1 + " of " + tempList.Count;
                lbl_count.Visible = true;
                btn_1.Visible = false;
                btn_2.Visible = true;
                btn_3.Visible = true;
                rich_Original.ReadOnly = false;
                rich_Translated.ReadOnly = false;
                rich_Original.BackColor = System.Drawing.Color.White;
                rich_Translated.BackColor = System.Drawing.Color.White;

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
                rich_Translated.Text += tempList[number].content_trans[j];
                rich_Translated.Text += ((char)13);
            }
            if (tempList[number].content_trans.Count > 0)
                rich_Translated.Text += tempList[number].content_trans[j];

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
            if (tempList.Count <= 0) return;
            int tempIndex = tempList[number].index;
            string tempPath = tempList[number].img_path;
            tempList.RemoveAt(number);

            Text T = new Text();
            T.img_path = tempPath;
            T.index = tempIndex;

            for (int i = 0;i< rich_Original.Lines.Length; i++)
            {
                T.content.Add(rich_Original.Lines[i]);
            }
            for (int i = 0; i < rich_Translated.Lines.Length; i++)
            {
                T.content_trans.Add(rich_Translated.Lines[i]);
            }
            tempList.Insert( number, T);

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
            int i = 0;
            foreach (Text t in tempList)
            {
                t.index = i;
                myList.Add((Text)t.Clone());
                i += 1;
            }            
        }

        private void btn_save_session_Click(object sender, EventArgs e)
        {
            if (comboSession.SelectedItem == null)
            {
                MessageBox.Show("Select a session");
                return;
            }
            string name = comboSession.Text;
            if (IsAutoSave(name)){ MessageBox.Show("You can't overwrite Auto Saves!"); return; }


            if (rich_Original.TextLength > 0 | rich_Translated.TextLength > 0)
                SaveThis();
            CloneList(myList, tempList);
            //TranslationTools.DeleteDataFromTables();
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
            CloneList(myList, tempList);
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
            
            if(rich_Original.TextLength > 0 | rich_Translated.TextLength > 0)
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
            CloneList(myList, tempList);
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

        public void auto_save_new()
        {
            DateTime thisDay = DateTime.Now;
            List<string> Sessions = TranslationTools.GetSessionNames();
            string name = "Auto Save " + thisDay.ToString();
            for (int i = 0; i < Sessions.Count; i++)
            {
                if (Sessions[i].Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return;
                }

            }
            int Id;
            for (int i = 0; i < tempList.Count; i++)
            {
                TranslationTools.InsertImagePath(tempList[i]);
                Id = TranslationTools.GetLastId(); //gets the inserted ID of InsertImagePath
                TranslationTools.InsertSessionWAuto(name, Id); //creates a session
                TranslationTools.InsertScript(tempList[i], Id); //associates the Id of the images table to the text
            }
            string a = GetAutoSaves();
            if (a != "")
                TranslationTools.DeleteSession(a);
            //TranslationTools.FillDropDownSessions("SELECT DISTINCT NameSession from Session;", comboSession);
        }

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

        private void button1_MarginChanged(object sender, EventArgs e)
        {

        }

        //private void btn_1_Click(object sender, EventArgs e)
        //{
        //    if (tempList.Count > 0) return;
        //    Text Item = new Text();
        //    for (int i = 0; i < rich_Original.Lines.Length; i++)
        //    {
        //        Item.content.Add(rich_Original.Lines[i]);
        //    }
        //    for (int i = 0; i < rich_translated.Lines.Length; i++)
        //    {
        //        Item.content_trans.Add(rich_translated.Lines[i]);
        //    }
        //    tempList.Add(Item);
        //    updateTextBox();
        //}

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (tempList.Count > 0) return;
            Text Item = new Text();
            tempList.Add(Item);
            number = 0;
            updateTextBox();
        }

        private void btn_2_Click(object sender, EventArgs e) //BEFORE
        {
            SaveThis();
            Text Item = new Text();
            tempList.Insert(number, Item);
            updateTextBox();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            SaveThis();
            Text Item = new Text();
            tempList.Insert(number+1, Item);
            number++;
            updateTextBox();
        }
        private void LeftPlus(object sender, EventArgs e)
        {
            fontsize1 = fontsize1 + 1F;
            this.rich_Original.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsize1, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void RightPlus(object sender, EventArgs e)
        {
            fontsize2 = fontsize2 + 1F;
            this.rich_Translated.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsize2, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void LeftMinus(object sender, EventArgs e)
        {
            if (fontsize1 >= 1)
                fontsize1 = fontsize1 - 1F;
            this.rich_Original.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsize1, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void RightMinus(object sender, EventArgs e)
        {
            if(fontsize2>=1)
                fontsize2 = fontsize2 - 1F;
            this.rich_Translated.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsize2, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void rich_Original_FontChanged(object sender, EventArgs e)
        {
            fontsize1 = rich_Original.Font.Size;
        }

        private void rich_translated_FontChanged(object sender, EventArgs e)
        {
            fontsize2 = rich_Translated.Font.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            SaveThis();
            try
            {
                if (comboTranslation.SelectedItem != null)
                    TranslationTools.Translation("auto", TranslationTools.getTranslationStr(comboTranslation.SelectedItem.ToString()), tempList[number]);
                else
                    TranslationTools.Translation("auto", "eng", tempList[number]);
            }
            catch
            {
                MessageBox.Show("Error translating");
            }
            updateTranslation();
            //updateTextBox();

        }

        private void btnLiveTranslation_Click(object sender, EventArgs e)
        {
            if (live == 0)
            {
                live = 1;
                this.pictureBox1.Image = global::Image_Tools.Properties.Resources.circle_16_Green;
            }
            else
            {
                live = 0;
                this.pictureBox1.Image = global::Image_Tools.Properties.Resources.circle_16;
            }
        }
        // #################################
        // https://stackoverflow.com/questions/33776387/dont-raise-textchanged-while-continuous-typing/33777265
        void assistant_Idled(object sender, EventArgs e)
        {
            if (number < 0 | number > tempList.Count - 1 | tempList.Count<1) return;
            this.Invoke(
            new MethodInvoker(() =>
            {
                    SaveThis();
                    try
                    {
                        if (comboTranslation.SelectedItem != null)
                            TranslationTools.Translation("auto", TranslationTools.getTranslationStr(comboTranslation.SelectedItem.ToString()), tempList[number]);
                        else
                            TranslationTools.Translation("auto", "eng", tempList[number]);
                    }
                    catch
                    {
                        MessageBox.Show("Error translating");
                    }
                    updateTranslation();
            }));
        }

        private void rich_Original_TextChanged(object sender, EventArgs e)
        {
            if(live == 1)
                assistant.TextChanged();
        }
        // ###############################################################
        //private async void rich_Original_TextChanged(object sender, KeyEventArgs e)
        //{

        //    await ((RichTextBox)sender).Text
        //    .DelayProcessing(x => label1.Text = x);
        //    if (live == 1)
        //    {
        //        //await Task.Delay(500);
        //        SaveThis();
        //        try
        //        {
        //            if (comboTranslation.SelectedItem != null)
        //                TranslationTools.Translation("auto", TranslationTools.getTranslationStr(comboTranslation.SelectedItem.ToString()), tempList[number]);
        //            else
        //                TranslationTools.Translation("auto", "eng", tempList[number]);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Error translating");
        //        }
        //        updateTranslation();
        //    }

        //}

        private void updateTranslation()
        {
            if (number < 0 | number > tempList.Count - 1 | tempList.Count < 1) return;
            rich_Translated.Text = "";
            int j;
            for (j = 0; j < tempList[number].content_trans.Count - 1; j++) //-1 to add the text bellow
            {
                rich_Translated.Text += tempList[number].content_trans[j];
                rich_Translated.Text += ((char)13);
            }
            if (tempList[number].content_trans.Count > 0)
                rich_Translated.Text += tempList[number].content_trans[j];
        }

        private void rich_translated_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hi");
            if (number < 0 | number > tempList.Count - 1 | tempList.Count < 1) return;
            if (tempList[number].index < 0) { MessageBox.Show("Data not available");return; };
            foreach (Text T in myList)
            {
                if (T.index == tempList[number].index)
                {
                    tempList.RemoveAt(number);
                    tempList.Insert(number, (Text)T.Clone());
                    updateTextBox();
                    return;
                }
            }

        }
        public void CloneList(List <Text> New,List<Text> Old)
        {
            New.Clear();
            int i = 0;
            foreach (Text t in Old)
            {
                t.index = i;
                New.Add((Text)t.Clone());
                i = i + 1;
            }
        }

        public static string GetAutoSaves()
        {
            string s = "";
            using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "SELECT DISTINCT NameSession from Session WHERE Auto = 1;";
                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    if(dt.Rows.Count>9) s = dt.Rows[0].ItemArray[0].ToString();

                    dt.Dispose();
                    myConnection.Close();
                    return s;
                }
            }
        }

        public static bool IsAutoSave(string name)
        {
           // try
            //{
                string s = "";
                using (SqlConnection myConnection = new SqlConnection(CONNECTION_STRING))
                {
                    string sql = "SELECT Auto from Session WHERE NameSession = '" + name + "';";
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        myConnection.Open();
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        s = dt.Rows[0].ItemArray[0].ToString();

                        dt.Dispose();
                        myConnection.Close();
                    if (s == "True") return true;
                        return false;
                    }
                }
            //}
            //catch
            //{
            //    MessageBox.Show("IsAutoSave");
            //}
            return true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TranslationTools.FillDropDownSessions("SELECT DISTINCT NameSession from Session;", comboSession);
        }
    }
}
