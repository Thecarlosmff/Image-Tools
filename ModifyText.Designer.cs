
namespace Image_Tools
{
    partial class ModifyText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyText));
            this.rich_Translated = new System.Windows.Forms.RichTextBox();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_load_session = new System.Windows.Forms.Button();
            this.btn_save_session = new System.Windows.Forms.Button();
            this.btn_save_current = new System.Windows.Forms.Button();
            this.btn_load_current = new System.Windows.Forms.Button();
            this.btn_discard = new System.Windows.Forms.Button();
            this.num_goto = new System.Windows.Forms.NumericUpDown();
            this.btn_go_to = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_path = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSession = new System.Windows.Forms.ComboBox();
            this.btn_new_session = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_SessionName = new System.Windows.Forms.TextBox();
            this.btn_delete_session = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btnLMinus = new System.Windows.Forms.Button();
            this.btnLPlus = new System.Windows.Forms.Button();
            this.btnRPlus = new System.Windows.Forms.Button();
            this.btnRMinus = new System.Windows.Forms.Button();
            this.comboTranslation = new System.Windows.Forms.ComboBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnLiveTranslation = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rich_Original = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_goto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rich_Translated
            // 
            this.rich_Translated.BackColor = System.Drawing.Color.White;
            this.rich_Translated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_Translated.Location = new System.Drawing.Point(497, 69);
            this.rich_Translated.Name = "rich_Translated";
            this.rich_Translated.Size = new System.Drawing.Size(460, 493);
            this.rich_Translated.TabIndex = 2;
            this.rich_Translated.Text = "";
            this.rich_Translated.FontChanged += new System.EventHandler(this.rich_translated_FontChanged);
            this.rich_Translated.TextChanged += new System.EventHandler(this.rich_translated_TextChanged);
            // 
            // btn_previous
            // 
            this.btn_previous.Enabled = false;
            this.btn_previous.Location = new System.Drawing.Point(270, 584);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(146, 51);
            this.btn_previous.TabIndex = 3;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(574, 584);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(146, 51);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_load_session
            // 
            this.btn_load_session.Location = new System.Drawing.Point(963, 99);
            this.btn_load_session.Name = "btn_load_session";
            this.btn_load_session.Size = new System.Drawing.Size(113, 39);
            this.btn_load_session.TabIndex = 5;
            this.btn_load_session.Text = "Load Session";
            this.btn_load_session.UseVisualStyleBackColor = true;
            this.btn_load_session.Click += new System.EventHandler(this.btn_load_session_Click);
            // 
            // btn_save_session
            // 
            this.btn_save_session.Location = new System.Drawing.Point(1082, 99);
            this.btn_save_session.Name = "btn_save_session";
            this.btn_save_session.Size = new System.Drawing.Size(113, 39);
            this.btn_save_session.TabIndex = 6;
            this.btn_save_session.Text = "Save Session";
            this.btn_save_session.UseVisualStyleBackColor = true;
            this.btn_save_session.Click += new System.EventHandler(this.btn_save_session_Click);
            // 
            // btn_save_current
            // 
            this.btn_save_current.Location = new System.Drawing.Point(1009, 416);
            this.btn_save_current.Name = "btn_save_current";
            this.btn_save_current.Size = new System.Drawing.Size(146, 39);
            this.btn_save_current.TabIndex = 7;
            this.btn_save_current.Text = "Save current*";
            this.btn_save_current.UseVisualStyleBackColor = true;
            this.btn_save_current.Click += new System.EventHandler(this.btn_save_current_Click);
            // 
            // btn_load_current
            // 
            this.btn_load_current.Location = new System.Drawing.Point(1009, 371);
            this.btn_load_current.Name = "btn_load_current";
            this.btn_load_current.Size = new System.Drawing.Size(146, 39);
            this.btn_load_current.TabIndex = 8;
            this.btn_load_current.Text = "Use Current Data";
            this.btn_load_current.UseVisualStyleBackColor = true;
            this.btn_load_current.Click += new System.EventHandler(this.btn_load_current_Click);
            // 
            // btn_discard
            // 
            this.btn_discard.Enabled = false;
            this.btn_discard.Location = new System.Drawing.Point(422, 584);
            this.btn_discard.Name = "btn_discard";
            this.btn_discard.Size = new System.Drawing.Size(146, 51);
            this.btn_discard.TabIndex = 9;
            this.btn_discard.Text = "Discard changes in the current text";
            this.btn_discard.UseVisualStyleBackColor = true;
            this.btn_discard.Click += new System.EventHandler(this.btn_discard_Click);
            // 
            // num_goto
            // 
            this.num_goto.Location = new System.Drawing.Point(794, 599);
            this.num_goto.Name = "num_goto";
            this.num_goto.Size = new System.Drawing.Size(105, 22);
            this.num_goto.TabIndex = 10;
            // 
            // btn_go_to
            // 
            this.btn_go_to.Enabled = false;
            this.btn_go_to.Location = new System.Drawing.Point(905, 596);
            this.btn_go_to.Name = "btn_go_to";
            this.btn_go_to.Size = new System.Drawing.Size(68, 26);
            this.btn_go_to.TabIndex = 11;
            this.btn_go_to.Text = "Go To";
            this.btn_go_to.UseVisualStyleBackColor = true;
            this.btn_go_to.Click += new System.EventHandler(this.btn_go_to_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(31, 584);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(146, 51);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Textbox);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(794, 576);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(15, 17);
            this.lbl_count.TabIndex = 13;
            this.lbl_count.Text = "s";
            this.lbl_count.Visible = false;
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path.ForeColor = System.Drawing.Color.Blue;
            this.lbl_path.Location = new System.Drawing.Point(28, 639);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(0, 17);
            this.lbl_path.TabIndex = 14;
            this.lbl_path.Click += new System.EventHandler(this.lbl_path_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(960, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Needed to for exemple save to a file*";
            // 
            // comboSession
            // 
            this.comboSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSession.FormattingEnabled = true;
            this.comboSession.Location = new System.Drawing.Point(963, 69);
            this.comboSession.Name = "comboSession";
            this.comboSession.Size = new System.Drawing.Size(192, 24);
            this.comboSession.TabIndex = 16;
            // 
            // btn_new_session
            // 
            this.btn_new_session.Location = new System.Drawing.Point(1026, 144);
            this.btn_new_session.Name = "btn_new_session";
            this.btn_new_session.Size = new System.Drawing.Size(113, 39);
            this.btn_new_session.TabIndex = 17;
            this.btn_new_session.Text = "New Session*";
            this.btn_new_session.UseVisualStyleBackColor = true;
            this.btn_new_session.Click += new System.EventHandler(this.btn_new_session_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1014, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "* Uses current data,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1007, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "either a loaded session";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1007, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "or a data created by files";
            // 
            // TextBox_SessionName
            // 
            this.TextBox_SessionName.Location = new System.Drawing.Point(1010, 189);
            this.TextBox_SessionName.Name = "TextBox_SessionName";
            this.TextBox_SessionName.Size = new System.Drawing.Size(146, 22);
            this.TextBox_SessionName.TabIndex = 21;
            // 
            // btn_delete_session
            // 
            this.btn_delete_session.Location = new System.Drawing.Point(1017, 24);
            this.btn_delete_session.Name = "btn_delete_session";
            this.btn_delete_session.Size = new System.Drawing.Size(113, 39);
            this.btn_delete_session.TabIndex = 22;
            this.btn_delete_session.Text = "Erase Session";
            this.btn_delete_session.UseVisualStyleBackColor = true;
            this.btn_delete_session.Click += new System.EventHandler(this.btn_delete_session_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.MarginChanged += new System.EventHandler(this.button1_MarginChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(1016, 546);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(146, 47);
            this.btn_2.TabIndex = 24;
            this.btn_2.Text = "Insert new BEFORE current";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(1016, 599);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(146, 47);
            this.btn_3.TabIndex = 25;
            this.btn_3.Text = "Insert new AFTER current";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(1016, 575);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(146, 47);
            this.btn_1.TabIndex = 26;
            this.btn_1.Text = "Insert new";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btnLMinus
            // 
            this.btnLMinus.Location = new System.Drawing.Point(1, 299);
            this.btnLMinus.Name = "btnLMinus";
            this.btnLMinus.Size = new System.Drawing.Size(29, 25);
            this.btnLMinus.TabIndex = 27;
            this.btnLMinus.Text = "-";
            this.btnLMinus.UseVisualStyleBackColor = true;
            this.btnLMinus.Click += new System.EventHandler(this.LeftMinus);
            // 
            // btnLPlus
            // 
            this.btnLPlus.Location = new System.Drawing.Point(1, 268);
            this.btnLPlus.Name = "btnLPlus";
            this.btnLPlus.Size = new System.Drawing.Size(29, 25);
            this.btnLPlus.TabIndex = 30;
            this.btnLPlus.Text = "+";
            this.btnLPlus.UseVisualStyleBackColor = true;
            this.btnLPlus.Click += new System.EventHandler(this.LeftPlus);
            // 
            // btnRPlus
            // 
            this.btnRPlus.Location = new System.Drawing.Point(960, 268);
            this.btnRPlus.Name = "btnRPlus";
            this.btnRPlus.Size = new System.Drawing.Size(29, 25);
            this.btnRPlus.TabIndex = 32;
            this.btnRPlus.Text = "+";
            this.btnRPlus.UseVisualStyleBackColor = true;
            this.btnRPlus.Click += new System.EventHandler(this.RightPlus);
            // 
            // btnRMinus
            // 
            this.btnRMinus.Location = new System.Drawing.Point(960, 299);
            this.btnRMinus.Name = "btnRMinus";
            this.btnRMinus.Size = new System.Drawing.Size(29, 25);
            this.btnRMinus.TabIndex = 31;
            this.btnRMinus.Text = "-";
            this.btnRMinus.UseVisualStyleBackColor = true;
            this.btnRMinus.Click += new System.EventHandler(this.RightMinus);
            // 
            // comboTranslation
            // 
            this.comboTranslation.FormattingEnabled = true;
            this.comboTranslation.Items.AddRange(new object[] {
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
            this.comboTranslation.Location = new System.Drawing.Point(107, 24);
            this.comboTranslation.Name = "comboTranslation";
            this.comboTranslation.Size = new System.Drawing.Size(121, 24);
            this.comboTranslation.TabIndex = 33;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(234, 19);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(88, 32);
            this.btnTranslate.TabIndex = 34;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnLiveTranslation
            // 
            this.btnLiveTranslation.Location = new System.Drawing.Point(385, 16);
            this.btnLiveTranslation.Name = "btnLiveTranslation";
            this.btnLiveTranslation.Size = new System.Drawing.Size(129, 32);
            this.btnLiveTranslation.TabIndex = 35;
            this.btnLiveTranslation.Text = "Live Translation";
            this.btnLiveTranslation.UseVisualStyleBackColor = true;
            this.btnLiveTranslation.Click += new System.EventHandler(this.btnLiveTranslation_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(574, 643);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(191, 21);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Keep Live Translation On";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rich_Original
            // 
            this.rich_Original.BackColor = System.Drawing.Color.White;
            this.rich_Original.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_Original.Location = new System.Drawing.Point(31, 69);
            this.rich_Original.Name = "rich_Original";
            this.rich_Original.Size = new System.Drawing.Size(460, 493);
            this.rich_Original.TabIndex = 1;
            this.rich_Original.Text = "";
            this.rich_Original.FontChanged += new System.EventHandler(this.rich_Original_FontChanged);
            this.rich_Original.TextChanged += new System.EventHandler(this.rich_Original_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(939, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "*Live Translation will not allow discard changes (revert to the original using th" +
    "e undo icon below, after clicking \"Save current\" that is the new original)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 39;
            this.textBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(815, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 40;
            this.button2.Text = "Find Word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(786, 643);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(187, 21);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Auto-Save (up to 9 slots)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Image_Tools.Properties.Resources.refresh_icon;
            this.pictureBox3.Location = new System.Drawing.Point(1161, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Image_Tools.Properties.Resources.undo_arrow2;
            this.pictureBox2.Location = new System.Drawing.Point(520, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Image_Tools.Properties.Resources.circle_16;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ModifyText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 668);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLiveTranslation);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.comboTranslation);
            this.Controls.Add(this.btnRPlus);
            this.Controls.Add(this.btnRMinus);
            this.Controls.Add(this.btnLPlus);
            this.Controls.Add(this.btnLMinus);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_delete_session);
            this.Controls.Add(this.TextBox_SessionName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_new_session);
            this.Controls.Add(this.comboSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_go_to);
            this.Controls.Add(this.num_goto);
            this.Controls.Add(this.btn_discard);
            this.Controls.Add(this.btn_load_current);
            this.Controls.Add(this.btn_save_current);
            this.Controls.Add(this.btn_save_session);
            this.Controls.Add(this.btn_load_session);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.rich_Translated);
            this.Controls.Add(this.rich_Original);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyText";
            this.Text = "ModifyText";
            this.Load += new System.EventHandler(this.ModifyText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_goto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rich_Translated;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_load_session;
        private System.Windows.Forms.Button btn_save_session;
        private System.Windows.Forms.Button btn_save_current;
        private System.Windows.Forms.Button btn_load_current;
        private System.Windows.Forms.Button btn_discard;
        private System.Windows.Forms.NumericUpDown num_goto;
        private System.Windows.Forms.Button btn_go_to;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSession;
        private System.Windows.Forms.Button btn_new_session;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_SessionName;
        private System.Windows.Forms.Button btn_delete_session;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btnLMinus;
        private System.Windows.Forms.Button btnLPlus;
        private System.Windows.Forms.Button btnRPlus;
        private System.Windows.Forms.Button btnRMinus;
        private System.Windows.Forms.ComboBox comboTranslation;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnLiveTranslation;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox rich_Original;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}