
using System;

namespace Image_Tools
{
    partial class ColorsManagementDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorsManagementDialog));
            this.new_nameLabel = new System.Windows.Forms.Label();
            this.new_hueMinLabel = new System.Windows.Forms.Label();
            this.new_hueMaxLabel = new System.Windows.Forms.Label();
            this.new_satMinLabel = new System.Windows.Forms.Label();
            this.new_satMaxLabel = new System.Windows.Forms.Label();
            this.new_valMinLabel = new System.Windows.Forms.Label();
            this.new_valMaxLabel = new System.Windows.Forms.Label();
            this.imageToolsDataSet = new Image_Tools.ImageToolsDataSet();
            this.backgroundColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundColorsTableAdapter = new Image_Tools.ImageToolsDataSetTableAdapters.BackgroundColorsTableAdapter();
            this.tableAdapterManager = new Image_Tools.ImageToolsDataSetTableAdapters.TableAdapterManager();
            this.new_nameTextBox = new System.Windows.Forms.TextBox();
            this.new_hueMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_hueMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_satMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_satMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_valMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_valMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageToolsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_hueMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_hueMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_satMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_satMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_valMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_valMaxNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_nameLabel
            // 
            this.new_nameLabel.AutoSize = true;
            this.new_nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.new_nameLabel.Location = new System.Drawing.Point(133, 9);
            this.new_nameLabel.Name = "new_nameLabel";
            this.new_nameLabel.Size = new System.Drawing.Size(49, 17);
            this.new_nameLabel.TabIndex = 4;
            this.new_nameLabel.Text = "Name:";
            // 
            // new_hueMinLabel
            // 
            this.new_hueMinLabel.AutoSize = true;
            this.new_hueMinLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.new_hueMinLabel.Location = new System.Drawing.Point(56, 96);
            this.new_hueMinLabel.Name = "new_hueMinLabel";
            this.new_hueMinLabel.Size = new System.Drawing.Size(64, 17);
            this.new_hueMinLabel.TabIndex = 6;
            this.new_hueMinLabel.Text = "Hue Min:";
            // 
            // new_hueMaxLabel
            // 
            this.new_hueMaxLabel.AutoSize = true;
            this.new_hueMaxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.new_hueMaxLabel.Location = new System.Drawing.Point(56, 133);
            this.new_hueMaxLabel.Name = "new_hueMaxLabel";
            this.new_hueMaxLabel.Size = new System.Drawing.Size(67, 17);
            this.new_hueMaxLabel.TabIndex = 8;
            this.new_hueMaxLabel.Text = "Hue Max:";
            // 
            // new_satMinLabel
            // 
            this.new_satMinLabel.AutoSize = true;
            this.new_satMinLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.new_satMinLabel.Location = new System.Drawing.Point(61, 176);
            this.new_satMinLabel.Name = "new_satMinLabel";
            this.new_satMinLabel.Size = new System.Drawing.Size(59, 17);
            this.new_satMinLabel.TabIndex = 10;
            this.new_satMinLabel.Text = "Sat Min:";
            // 
            // new_satMaxLabel
            // 
            this.new_satMaxLabel.AutoSize = true;
            this.new_satMaxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.new_satMaxLabel.Location = new System.Drawing.Point(58, 215);
            this.new_satMaxLabel.Name = "new_satMaxLabel";
            this.new_satMaxLabel.Size = new System.Drawing.Size(62, 17);
            this.new_satMaxLabel.TabIndex = 12;
            this.new_satMaxLabel.Text = "Sat Max:";
            // 
            // new_valMinLabel
            // 
            this.new_valMinLabel.AutoSize = true;
            this.new_valMinLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.new_valMinLabel.Location = new System.Drawing.Point(61, 254);
            this.new_valMinLabel.Name = "new_valMinLabel";
            this.new_valMinLabel.Size = new System.Drawing.Size(58, 17);
            this.new_valMinLabel.TabIndex = 14;
            this.new_valMinLabel.Text = "Val Min:";
            // 
            // new_valMaxLabel
            // 
            this.new_valMaxLabel.AutoSize = true;
            this.new_valMaxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.new_valMaxLabel.Location = new System.Drawing.Point(58, 294);
            this.new_valMaxLabel.Name = "new_valMaxLabel";
            this.new_valMaxLabel.Size = new System.Drawing.Size(61, 17);
            this.new_valMaxLabel.TabIndex = 16;
            this.new_valMaxLabel.Text = "Val Max:";
            // 
            // imageToolsDataSet
            // 
            this.imageToolsDataSet.DataSetName = "ImageToolsDataSet";
            this.imageToolsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundColorsBindingSource
            // 
            this.backgroundColorsBindingSource.DataMember = "BackgroundColors";
            this.backgroundColorsBindingSource.DataSource = this.imageToolsDataSet;
            // 
            // backgroundColorsTableAdapter
            // 
            this.backgroundColorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackgroundColorsTableAdapter = this.backgroundColorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Image_Tools.ImageToolsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // new_nameTextBox
            // 
            this.new_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backgroundColorsBindingSource, "Name", true));
            this.new_nameTextBox.Location = new System.Drawing.Point(59, 41);
            this.new_nameTextBox.Name = "new_nameTextBox";
            this.new_nameTextBox.Size = new System.Drawing.Size(197, 22);
            this.new_nameTextBox.TabIndex = 5;
            // 
            // new_hueMinNumericUpDown
            // 
            this.new_hueMinNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "HueMin", true));
            this.new_hueMinNumericUpDown.Location = new System.Drawing.Point(136, 94);
            this.new_hueMinNumericUpDown.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.new_hueMinNumericUpDown.Name = "new_hueMinNumericUpDown";
            this.new_hueMinNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_hueMinNumericUpDown.TabIndex = 7;
            // 
            // new_hueMaxNumericUpDown
            // 
            this.new_hueMaxNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "HueMax", true));
            this.new_hueMaxNumericUpDown.Location = new System.Drawing.Point(136, 131);
            this.new_hueMaxNumericUpDown.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.new_hueMaxNumericUpDown.Name = "new_hueMaxNumericUpDown";
            this.new_hueMaxNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_hueMaxNumericUpDown.TabIndex = 9;
            // 
            // new_satMinNumericUpDown
            // 
            this.new_satMinNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "SatMin", true));
            this.new_satMinNumericUpDown.Location = new System.Drawing.Point(136, 174);
            this.new_satMinNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.new_satMinNumericUpDown.Name = "new_satMinNumericUpDown";
            this.new_satMinNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_satMinNumericUpDown.TabIndex = 11;
            // 
            // new_satMaxNumericUpDown
            // 
            this.new_satMaxNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "SatMax", true));
            this.new_satMaxNumericUpDown.Location = new System.Drawing.Point(136, 210);
            this.new_satMaxNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.new_satMaxNumericUpDown.Name = "new_satMaxNumericUpDown";
            this.new_satMaxNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_satMaxNumericUpDown.TabIndex = 13;
            // 
            // new_valMinNumericUpDown
            // 
            this.new_valMinNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "ValMin", true));
            this.new_valMinNumericUpDown.Location = new System.Drawing.Point(136, 249);
            this.new_valMinNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.new_valMinNumericUpDown.Name = "new_valMinNumericUpDown";
            this.new_valMinNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_valMinNumericUpDown.TabIndex = 15;
            // 
            // new_valMaxNumericUpDown
            // 
            this.new_valMaxNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "ValMax", true));
            this.new_valMaxNumericUpDown.Location = new System.Drawing.Point(136, 289);
            this.new_valMaxNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.new_valMaxNumericUpDown.Name = "new_valMaxNumericUpDown";
            this.new_valMaxNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_valMaxNumericUpDown.TabIndex = 17;
            // 
            // new_btn_save
            // 
            this.new_btn_save.BackColor = System.Drawing.Color.Transparent;
            this.new_btn_save.Location = new System.Drawing.Point(83, 337);
            this.new_btn_save.Name = "new_btn_save";
            this.new_btn_save.Size = new System.Drawing.Size(150, 70);
            this.new_btn_save.TabIndex = 18;
            this.new_btn_save.Text = "Save";
            this.new_btn_save.UseVisualStyleBackColor = false;
            this.new_btn_save.Click += new System.EventHandler(this.new_btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.new_btn_save);
            this.groupBox1.Controls.Add(this.new_valMaxNumericUpDown);
            this.groupBox1.Controls.Add(this.new_nameLabel);
            this.groupBox1.Controls.Add(this.new_satMaxNumericUpDown);
            this.groupBox1.Controls.Add(this.new_valMinNumericUpDown);
            this.groupBox1.Controls.Add(this.new_valMaxLabel);
            this.groupBox1.Controls.Add(this.new_nameTextBox);
            this.groupBox1.Controls.Add(this.new_valMinLabel);
            this.groupBox1.Controls.Add(this.new_hueMinLabel);
            this.groupBox1.Controls.Add(this.new_hueMinNumericUpDown);
            this.groupBox1.Controls.Add(this.new_satMaxLabel);
            this.groupBox1.Controls.Add(this.new_hueMaxLabel);
            this.groupBox1.Controls.Add(this.new_hueMaxNumericUpDown);
            this.groupBox1.Controls.Add(this.new_satMinLabel);
            this.groupBox1.Controls.Add(this.new_satMinNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.UpdateBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.numericUpDown6);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(341, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 435);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // UpdateBox
            // 
            this.UpdateBox.DataSource = this.backgroundColorsBindingSource;
            this.UpdateBox.DisplayMember = "Name";
            this.UpdateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateBox.FormattingEnabled = true;
            this.UpdateBox.Location = new System.Drawing.Point(104, 41);
            this.UpdateBox.Name = "UpdateBox";
            this.UpdateBox.Size = new System.Drawing.Size(150, 24);
            this.UpdateBox.TabIndex = 33;
            this.UpdateBox.ValueMember = "IDColor";
            this.UpdateBox.SelectedIndexChanged += new System.EventHandler(this.UpdateBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(104, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 31;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "HueMin", true));
            this.numericUpDown4.Location = new System.Drawing.Point(153, 210);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown4.TabIndex = 20;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "ValMax", true));
            this.numericUpDown1.Location = new System.Drawing.Point(153, 98);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 30;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "SatMin", true));
            this.numericUpDown6.Location = new System.Drawing.Point(153, 289);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown6.TabIndex = 24;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "SatMax", true));
            this.numericUpDown2.Location = new System.Drawing.Point(153, 135);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(78, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sat Min:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "ValMin", true));
            this.numericUpDown3.Location = new System.Drawing.Point(153, 176);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 28;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.backgroundColorsBindingSource, "HueMax", true));
            this.numericUpDown5.Location = new System.Drawing.Point(153, 249);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown5.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(75, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Val Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(73, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hue Max:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(78, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Val Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(75, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sat Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(73, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hue Min:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.deleteBox);
            this.groupBox3.Location = new System.Drawing.Point(680, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 435);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(94, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 70);
            this.button2.TabIndex = 32;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.DataSource = this.backgroundColorsBindingSource;
            this.deleteBox.DisplayMember = "Name";
            this.deleteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteBox.FormattingEnabled = true;
            this.deleteBox.Location = new System.Drawing.Point(94, 155);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(150, 24);
            this.deleteBox.TabIndex = 0;
            this.deleteBox.ValueMember = "IDColor";
            this.deleteBox.SelectedIndexChanged += new System.EventHandler(this.deleteBox_SelectedIndexChanged);
            // 
            // ColorsManagementDialog
            // 
            this.ClientSize = new System.Drawing.Size(1015, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorsManagementDialog";
            this.Load += new System.EventHandler(this.ColorsManagementDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageToolsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_hueMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_hueMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_satMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_satMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_valMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_valMaxNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageToolsDataSet imageToolsDataSet;
        private System.Windows.Forms.BindingSource backgroundColorsBindingSource;
        private ImageToolsDataSetTableAdapters.BackgroundColorsTableAdapter backgroundColorsTableAdapter;
        private ImageToolsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox new_nameTextBox;
        private System.Windows.Forms.NumericUpDown new_hueMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown new_hueMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown new_satMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown new_satMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown new_valMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown new_valMaxNumericUpDown;
        private System.Windows.Forms.Button new_btn_save;
        private System.Windows.Forms.Label new_nameLabel;
        private System.Windows.Forms.Label new_hueMinLabel;
        private System.Windows.Forms.Label new_hueMaxLabel;
        private System.Windows.Forms.Label new_satMinLabel;
        private System.Windows.Forms.Label new_satMaxLabel;
        private System.Windows.Forms.Label new_valMinLabel;
        private System.Windows.Forms.Label new_valMaxLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox deleteBox;
        private System.Windows.Forms.ComboBox UpdateBox;
    }
}