
namespace Image_Tools
{
    partial class ImageToText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageToText));
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckReplace1 = new System.Windows.Forms.CheckBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.TransCombo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OCRCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(627, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Images to text";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Text File (.txt) - Original",
            "Text File (.txt) - Translation",
            "Text File (.txt) - Both",
            "Word (.docx)",
            "Excel (.xlxs)"});
            this.comboBox4.Location = new System.Drawing.Point(627, 475);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(155, 24);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.SaveToFileCombo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CheckReplace1);
            this.panel1.Controls.Add(this.btnSaveToFile);
            this.panel1.Controls.Add(this.TransCombo);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OCRCombo);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 624);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(627, 573);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(155, 39);
            this.btn_edit.TabIndex = 19;
            this.btn_edit.Text = "Edit/Preview";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckReplace1
            // 
            this.CheckReplace1.AutoSize = true;
            this.CheckReplace1.Location = new System.Drawing.Point(631, 210);
            this.CheckReplace1.Name = "CheckReplace1";
            this.CheckReplace1.Size = new System.Drawing.Size(134, 21);
            this.CheckReplace1.TabIndex = 17;
            this.CheckReplace1.Text = "Replace | for I (i)";
            this.CheckReplace1.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveToFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveToFile.Location = new System.Drawing.Point(627, 505);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(155, 35);
            this.btnSaveToFile.TabIndex = 16;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = false;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // TransCombo
            // 
            this.TransCombo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TransCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransCombo.FormattingEnabled = true;
            this.TransCombo.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Amharic",
            "Arabic",
            "Armenian",
            "Azerbaijani",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bosnian",
            "Bulgarian",
            "Catalan",
            "Cebuano",
            "Chinese (Simplified)",
            "Chinese (Traditional)",
            "Corsican",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Esperanto",
            "Estonian",
            "Finnish",
            "French",
            "Frisian",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Gujarati",
            "Haitian Creole",
            "Hausa",
            "Hawaiian",
            "Hebrew",
            "Hindi",
            "Hmong",
            "Hungarian",
            "Icelandic",
            "Igbo",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Javanese",
            "Kannada",
            "Kazakh",
            "Khmer",
            "Kinyarwanda",
            "Korean",
            "Kurdish",
            "Kyrgyz",
            "Lao",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Luxembourgish",
            "Macedonian",
            "Malagasy",
            "Malay",
            "Malayalam",
            "Maltese",
            "Maori",
            "Marathi",
            "Mongolian",
            "Myanmar",
            "Nepali",
            "Norwegian",
            "Nyanja",
            "Odia",
            "Pashto",
            "Persian",
            "Polish",
            "Portuguese",
            "Punjabi",
            "Romanian",
            "Russian",
            "Samoan",
            "Scots Gaelic",
            "Serbian",
            "Sesotho",
            "Shona",
            "Sindhi",
            "Sinhala",
            "Slovak",
            "Slovenian",
            "Somali",
            "Spanish",
            "Sundanese",
            "Swahili",
            "Swedish",
            "Tagalog (Filipino)",
            "Tajik",
            "Tamil",
            "Tatar",
            "Telugu",
            "Thai",
            "Turkish",
            "Turkmen",
            "Ukrainian",
            "Urdu",
            "Uyghur",
            "Uzbek",
            "Vietnamese",
            "Welsh",
            "Xhosa",
            "Yiddish",
            "Yoruba",
            "Zulu"});
            this.TransCombo.Location = new System.Drawing.Point(627, 360);
            this.TransCombo.Name = "TransCombo";
            this.TransCombo.Size = new System.Drawing.Size(155, 24);
            this.TransCombo.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(627, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 33);
            this.button5.TabIndex = 14;
            this.button5.Text = "Delete list of images";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "text in loaded images";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select the language of the";
            // 
            // OCRCombo
            // 
            this.OCRCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OCRCombo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.OCRCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OCRCombo.FormattingEnabled = true;
            this.OCRCombo.Items.AddRange(new object[] {
            "Chinese (Simplified)",
            "Chinese (Traditional)",
            "Dutch",
            "English",
            "French",
            "German",
            "Greek",
            "Hindi",
            "Italian",
            "Japanese",
            "Math/equation",
            "Polish",
            "Portuguese",
            "Russian",
            "Spanish"});
            this.OCRCombo.Location = new System.Drawing.Point(627, 139);
            this.OCRCombo.Name = "OCRCombo";
            this.OCRCombo.Size = new System.Drawing.Size(155, 24);
            this.OCRCombo.TabIndex = 11;
            this.OCRCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(627, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "Clean text in memory";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "     Translate Text       (in memory)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(571, 624);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Images";
            this.columnHeader1.Width = 400;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(627, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Images";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Btn_SelectImages);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImageToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 624);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageToText";
            this.Text = "Image To Text";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OCRCombo;
        private System.Windows.Forms.ComboBox TransCombo;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.CheckBox CheckReplace1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
    }
}