
using System;
using System.Windows.Forms;

namespace Image_Tools
{
    partial class RemoveBackground
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
            this.RemBgSelectImages = new System.Windows.Forms.OpenFileDialog();
            this.btn_RemBgSelectImages = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_RemBg = new System.Windows.Forms.ListView();
            this.AbsolutePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_RemoveBackground = new System.Windows.Forms.Button();
            this.numHueMin1 = new System.Windows.Forms.NumericUpDown();
            this.numHueMax1 = new System.Windows.Forms.NumericUpDown();
            this.numSatMin1 = new System.Windows.Forms.NumericUpDown();
            this.numSatMax1 = new System.Windows.Forms.NumericUpDown();
            this.numValMin1 = new System.Windows.Forms.NumericUpDown();
            this.numValMax1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numValMax2 = new System.Windows.Forms.NumericUpDown();
            this.numValMin2 = new System.Windows.Forms.NumericUpDown();
            this.numSatMax2 = new System.Windows.Forms.NumericUpDown();
            this.numSatMin2 = new System.Windows.Forms.NumericUpDown();
            this.numHueMax2 = new System.Windows.Forms.NumericUpDown();
            this.numHueMin2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HSVBox1 = new System.Windows.Forms.CheckBox();
            this.HSVBox2 = new System.Windows.Forms.CheckBox();
            this.numValMax3 = new System.Windows.Forms.NumericUpDown();
            this.numValMin3 = new System.Windows.Forms.NumericUpDown();
            this.numSatMax3 = new System.Windows.Forms.NumericUpDown();
            this.numSatMin3 = new System.Windows.Forms.NumericUpDown();
            this.numHueMax3 = new System.Windows.Forms.NumericUpDown();
            this.numHueMin3 = new System.Windows.Forms.NumericUpDown();
            this.HSVBox3 = new System.Windows.Forms.CheckBox();
            this.numValMax4 = new System.Windows.Forms.NumericUpDown();
            this.numValMin4 = new System.Windows.Forms.NumericUpDown();
            this.numSatMax4 = new System.Windows.Forms.NumericUpDown();
            this.numSatMin4 = new System.Windows.Forms.NumericUpDown();
            this.numHueMax4 = new System.Windows.Forms.NumericUpDown();
            this.numHueMin4 = new System.Windows.Forms.NumericUpDown();
            this.btn_cleanListViewRemBg = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_RemBgSelectFolder = new System.Windows.Forms.Button();
            this.output_local = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboColors = new System.Windows.Forms.ComboBox();
            this.backgroundColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageToolsDataSet = new Image_Tools.ImageToolsDataSet();
            this.backgroundColorsTableAdapter = new Image_Tools.ImageToolsDataSetTableAdapters.BackgroundColorsTableAdapter();
            this.btn_addBgColor = new System.Windows.Forms.Button();
            this.btn_remBg_preview = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageToolsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RemBgSelectImages
            // 
            this.RemBgSelectImages.FileName = "RemBgSelectImages";
            this.RemBgSelectImages.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // btn_RemBgSelectImages
            // 
            this.btn_RemBgSelectImages.AutoSize = true;
            this.btn_RemBgSelectImages.Location = new System.Drawing.Point(377, 26);
            this.btn_RemBgSelectImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemBgSelectImages.Name = "btn_RemBgSelectImages";
            this.btn_RemBgSelectImages.Size = new System.Drawing.Size(160, 27);
            this.btn_RemBgSelectImages.TabIndex = 7;
            this.btn_RemBgSelectImages.Text = "Select Images";
            this.btn_RemBgSelectImages.UseVisualStyleBackColor = true;
            this.btn_RemBgSelectImages.Click += new System.EventHandler(this.Btn_SelectImages_Click);
            // 
            // list_RemBg
            // 
            this.list_RemBg.AllowDrop = true;
            this.list_RemBg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_RemBg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AbsolutePath});
            this.list_RemBg.FullRowSelect = true;
            this.list_RemBg.GridLines = true;
            this.list_RemBg.HideSelection = false;
            this.list_RemBg.Location = new System.Drawing.Point(12, 82);
            this.list_RemBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_RemBg.Name = "list_RemBg";
            this.list_RemBg.ShowItemToolTips = true;
            this.list_RemBg.Size = new System.Drawing.Size(471, 240);
            this.list_RemBg.TabIndex = 1;
            this.list_RemBg.TileSize = new System.Drawing.Size(5, 70);
            this.list_RemBg.UseCompatibleStateImageBehavior = false;
            this.list_RemBg.View = System.Windows.Forms.View.Details;
            this.list_RemBg.SelectedIndexChanged += new System.EventHandler(this.list_RemBg_SelectedIndexChanged);
            this.list_RemBg.DoubleClick += new System.EventHandler(this.ListRemoveBackground_DoubleClick);
            // 
            // AbsolutePath
            // 
            this.AbsolutePath.Text = "Path (Double Click to Remove)";
            // 
            // btn_RemoveBackground
            // 
            this.btn_RemoveBackground.Location = new System.Drawing.Point(562, 26);
            this.btn_RemoveBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveBackground.Name = "btn_RemoveBackground";
            this.btn_RemoveBackground.Size = new System.Drawing.Size(160, 24);
            this.btn_RemoveBackground.TabIndex = 9;
            this.btn_RemoveBackground.Text = "Remove Background";
            this.btn_RemoveBackground.UseVisualStyleBackColor = true;
            this.btn_RemoveBackground.Click += new System.EventHandler(this.Btn_RemoveBackground_Click);
            // 
            // numHueMin1
            // 
            this.numHueMin1.Location = new System.Drawing.Point(61, 26);
            this.numHueMin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHueMin1.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numHueMin1.Name = "numHueMin1";
            this.numHueMin1.Size = new System.Drawing.Size(75, 22);
            this.numHueMin1.TabIndex = 1;
            // 
            // numHueMax1
            // 
            this.numHueMax1.Location = new System.Drawing.Point(61, 53);
            this.numHueMax1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHueMax1.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numHueMax1.Name = "numHueMax1";
            this.numHueMax1.Size = new System.Drawing.Size(75, 22);
            this.numHueMax1.TabIndex = 2;
            // 
            // numSatMin1
            // 
            this.numSatMin1.Location = new System.Drawing.Point(160, 26);
            this.numSatMin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSatMin1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMin1.Name = "numSatMin1";
            this.numSatMin1.Size = new System.Drawing.Size(75, 22);
            this.numSatMin1.TabIndex = 3;
            // 
            // numSatMax1
            // 
            this.numSatMax1.Location = new System.Drawing.Point(160, 53);
            this.numSatMax1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSatMax1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMax1.Name = "numSatMax1";
            this.numSatMax1.Size = new System.Drawing.Size(75, 22);
            this.numSatMax1.TabIndex = 4;
            // 
            // numValMin1
            // 
            this.numValMin1.Location = new System.Drawing.Point(260, 26);
            this.numValMin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValMin1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMin1.Name = "numValMin1";
            this.numValMin1.Size = new System.Drawing.Size(75, 22);
            this.numValMin1.TabIndex = 5;
            // 
            // numValMax1
            // 
            this.numValMax1.Location = new System.Drawing.Point(260, 55);
            this.numValMax1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValMax1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMax1.Name = "numValMax1";
            this.numValMax1.Size = new System.Drawing.Size(75, 22);
            this.numValMax1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Min Val";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Min Sat";
            // 
            // label10
            // 
            this.label10.AccessibleDescription = "Hello";
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(500, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Min Hue";
            // 
            // numValMax2
            // 
            this.numValMax2.Location = new System.Drawing.Point(574, 265);
            this.numValMax2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValMax2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMax2.Name = "numValMax2";
            this.numValMax2.Size = new System.Drawing.Size(75, 22);
            this.numValMax2.TabIndex = 18;
            this.numValMax2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numValMin2
            // 
            this.numValMin2.Location = new System.Drawing.Point(574, 238);
            this.numValMin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValMin2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMin2.Name = "numValMin2";
            this.numValMin2.Size = new System.Drawing.Size(75, 22);
            this.numValMin2.TabIndex = 17;
            this.numValMin2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numSatMax2
            // 
            this.numSatMax2.Location = new System.Drawing.Point(574, 212);
            this.numSatMax2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSatMax2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMax2.Name = "numSatMax2";
            this.numSatMax2.Size = new System.Drawing.Size(75, 22);
            this.numSatMax2.TabIndex = 16;
            this.numSatMax2.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numSatMin2
            // 
            this.numSatMin2.Location = new System.Drawing.Point(574, 186);
            this.numSatMin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSatMin2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMin2.Name = "numSatMin2";
            this.numSatMin2.Size = new System.Drawing.Size(75, 22);
            this.numSatMin2.TabIndex = 15;
            this.numSatMin2.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numHueMax2
            // 
            this.numHueMax2.Location = new System.Drawing.Point(574, 159);
            this.numHueMax2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHueMax2.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numHueMax2.Name = "numHueMax2";
            this.numHueMax2.Size = new System.Drawing.Size(75, 22);
            this.numHueMax2.TabIndex = 14;
            this.numHueMax2.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numHueMin2
            // 
            this.numHueMin2.Location = new System.Drawing.Point(574, 133);
            this.numHueMin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHueMin2.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numHueMin2.Name = "numHueMin2";
            this.numHueMin2.Size = new System.Drawing.Size(75, 22);
            this.numHueMin2.TabIndex = 13;
            this.numHueMin2.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "Hello";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Max Hue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Max Sat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Max Val";
            // 
            // HSVBox1
            // 
            this.HSVBox1.AutoSize = true;
            this.HSVBox1.Location = new System.Drawing.Point(574, 109);
            this.HSVBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HSVBox1.Name = "HSVBox1";
            this.HSVBox1.Size = new System.Drawing.Size(63, 21);
            this.HSVBox1.TabIndex = 12;
            this.HSVBox1.Text = "Color";
            this.HSVBox1.UseVisualStyleBackColor = true;
            // 
            // HSVBox2
            // 
            this.HSVBox2.AutoSize = true;
            this.HSVBox2.Location = new System.Drawing.Point(672, 109);
            this.HSVBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HSVBox2.Name = "HSVBox2";
            this.HSVBox2.Size = new System.Drawing.Size(63, 21);
            this.HSVBox2.TabIndex = 19;
            this.HSVBox2.Text = "Color";
            this.HSVBox2.UseVisualStyleBackColor = true;
            // 
            // numValMax3
            // 
            this.numValMax3.Location = new System.Drawing.Point(672, 265);
            this.numValMax3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValMax3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMax3.Name = "numValMax3";
            this.numValMax3.Size = new System.Drawing.Size(75, 22);
            this.numValMax3.TabIndex = 25;
            // 
            // numValMin3
            // 
            this.numValMin3.Location = new System.Drawing.Point(672, 238);
            this.numValMin3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValMin3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMin3.Name = "numValMin3";
            this.numValMin3.Size = new System.Drawing.Size(75, 22);
            this.numValMin3.TabIndex = 24;
            // 
            // numSatMax3
            // 
            this.numSatMax3.Location = new System.Drawing.Point(672, 212);
            this.numSatMax3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSatMax3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMax3.Name = "numSatMax3";
            this.numSatMax3.Size = new System.Drawing.Size(75, 22);
            this.numSatMax3.TabIndex = 23;
            // 
            // numSatMin3
            // 
            this.numSatMin3.Location = new System.Drawing.Point(672, 186);
            this.numSatMin3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSatMin3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMin3.Name = "numSatMin3";
            this.numSatMin3.Size = new System.Drawing.Size(75, 22);
            this.numSatMin3.TabIndex = 22;
            // 
            // numHueMax3
            // 
            this.numHueMax3.Location = new System.Drawing.Point(672, 159);
            this.numHueMax3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHueMax3.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numHueMax3.Name = "numHueMax3";
            this.numHueMax3.Size = new System.Drawing.Size(75, 22);
            this.numHueMax3.TabIndex = 21;
            // 
            // numHueMin3
            // 
            this.numHueMin3.Location = new System.Drawing.Point(672, 133);
            this.numHueMin3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHueMin3.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numHueMin3.Name = "numHueMin3";
            this.numHueMin3.Size = new System.Drawing.Size(75, 22);
            this.numHueMin3.TabIndex = 20;
            // 
            // HSVBox3
            // 
            this.HSVBox3.AutoSize = true;
            this.HSVBox3.Location = new System.Drawing.Point(769, 109);
            this.HSVBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HSVBox3.Name = "HSVBox3";
            this.HSVBox3.Size = new System.Drawing.Size(63, 21);
            this.HSVBox3.TabIndex = 26;
            this.HSVBox3.Text = "Color";
            this.HSVBox3.UseVisualStyleBackColor = true;
            // 
            // numValMax4
            // 
            this.numValMax4.Location = new System.Drawing.Point(769, 265);
            this.numValMax4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValMax4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMax4.Name = "numValMax4";
            this.numValMax4.Size = new System.Drawing.Size(75, 22);
            this.numValMax4.TabIndex = 32;
            // 
            // numValMin4
            // 
            this.numValMin4.Location = new System.Drawing.Point(769, 238);
            this.numValMin4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValMin4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMin4.Name = "numValMin4";
            this.numValMin4.Size = new System.Drawing.Size(75, 22);
            this.numValMin4.TabIndex = 31;
            // 
            // numSatMax4
            // 
            this.numSatMax4.Location = new System.Drawing.Point(769, 212);
            this.numSatMax4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSatMax4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMax4.Name = "numSatMax4";
            this.numSatMax4.Size = new System.Drawing.Size(75, 22);
            this.numSatMax4.TabIndex = 30;
            // 
            // numSatMin4
            // 
            this.numSatMin4.Location = new System.Drawing.Point(769, 186);
            this.numSatMin4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSatMin4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMin4.Name = "numSatMin4";
            this.numSatMin4.Size = new System.Drawing.Size(75, 22);
            this.numSatMin4.TabIndex = 29;
            // 
            // numHueMax4
            // 
            this.numHueMax4.Location = new System.Drawing.Point(769, 159);
            this.numHueMax4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHueMax4.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numHueMax4.Name = "numHueMax4";
            this.numHueMax4.Size = new System.Drawing.Size(75, 22);
            this.numHueMax4.TabIndex = 28;
            // 
            // numHueMin4
            // 
            this.numHueMin4.Location = new System.Drawing.Point(769, 133);
            this.numHueMin4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHueMin4.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.numHueMin4.Name = "numHueMin4";
            this.numHueMin4.Size = new System.Drawing.Size(75, 22);
            this.numHueMin4.TabIndex = 27;
            // 
            // btn_cleanListViewRemBg
            // 
            this.btn_cleanListViewRemBg.Location = new System.Drawing.Point(531, 291);
            this.btn_cleanListViewRemBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cleanListViewRemBg.Name = "btn_cleanListViewRemBg";
            this.btn_cleanListViewRemBg.Size = new System.Drawing.Size(160, 24);
            this.btn_cleanListViewRemBg.TabIndex = 33;
            this.btn_cleanListViewRemBg.Text = "Clear";
            this.btn_cleanListViewRemBg.UseVisualStyleBackColor = true;
            // 
            // btn_RemBgSelectFolder
            // 
            this.btn_RemBgSelectFolder.Location = new System.Drawing.Point(776, 324);
            this.btn_RemBgSelectFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemBgSelectFolder.Name = "btn_RemBgSelectFolder";
            this.btn_RemBgSelectFolder.Size = new System.Drawing.Size(94, 23);
            this.btn_RemBgSelectFolder.TabIndex = 34;
            this.btn_RemBgSelectFolder.Text = "Destination";
            this.btn_RemBgSelectFolder.UseVisualStyleBackColor = true;
            this.btn_RemBgSelectFolder.Click += new System.EventHandler(this.Btn_RemBgSelectFolder_Click);
            // 
            // output_local
            // 
            this.output_local.AutoSize = true;
            this.output_local.Location = new System.Drawing.Point(96, 323);
            this.output_local.MaximumSize = new System.Drawing.Size(680, 40);
            this.output_local.Name = "output_local";
            this.output_local.Size = new System.Drawing.Size(0, 17);
            this.output_local.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Destination:";
            // 
            // comboColors
            // 
            this.comboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColors.Location = new System.Drawing.Point(377, 55);
            this.comboColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboColors.Name = "comboColors";
            this.comboColors.Size = new System.Drawing.Size(160, 24);
            this.comboColors.TabIndex = 8;
            this.comboColors.SelectedIndexChanged += new System.EventHandler(this.comboColors_SelectedIndexChanged);
            // 
            // backgroundColorsBindingSource
            // 
            this.backgroundColorsBindingSource.DataMember = "BackgroundColors";
            this.backgroundColorsBindingSource.DataSource = this.imageToolsDataSet;
            // 
            // imageToolsDataSet
            // 
            this.imageToolsDataSet.DataSetName = "ImageToolsDataSet";
            this.imageToolsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundColorsTableAdapter
            // 
            this.backgroundColorsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_addBgColor
            // 
            this.btn_addBgColor.Location = new System.Drawing.Point(562, 56);
            this.btn_addBgColor.Name = "btn_addBgColor";
            this.btn_addBgColor.Size = new System.Drawing.Size(160, 24);
            this.btn_addBgColor.TabIndex = 10;
            this.btn_addBgColor.Text = "Edit Presets";
            this.btn_addBgColor.UseVisualStyleBackColor = true;
            this.btn_addBgColor.Click += new System.EventHandler(this.Btn_addBgColor_Click);
            // 
            // btn_remBg_preview
            // 
            this.btn_remBg_preview.Location = new System.Drawing.Point(746, 27);
            this.btn_remBg_preview.Name = "btn_remBg_preview";
            this.btn_remBg_preview.Size = new System.Drawing.Size(124, 53);
            this.btn_remBg_preview.TabIndex = 11;
            this.btn_remBg_preview.Text = "Preview";
            this.btn_remBg_preview.UseVisualStyleBackColor = true;
            this.btn_remBg_preview.Click += new System.EventHandler(this.Btn_remBg_preview_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(736, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 21);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Transparent";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // RemoveBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 368);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_remBg_preview);
            this.Controls.Add(this.btn_addBgColor);
            this.Controls.Add(this.comboColors);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.output_local);
            this.Controls.Add(this.btn_RemBgSelectFolder);
            this.Controls.Add(this.btn_cleanListViewRemBg);
            this.Controls.Add(this.HSVBox3);
            this.Controls.Add(this.numValMax4);
            this.Controls.Add(this.numValMin4);
            this.Controls.Add(this.numSatMax4);
            this.Controls.Add(this.numSatMin4);
            this.Controls.Add(this.numHueMax4);
            this.Controls.Add(this.numHueMin4);
            this.Controls.Add(this.HSVBox2);
            this.Controls.Add(this.numValMax3);
            this.Controls.Add(this.numValMin3);
            this.Controls.Add(this.numSatMax3);
            this.Controls.Add(this.numSatMin3);
            this.Controls.Add(this.numHueMax3);
            this.Controls.Add(this.numHueMin3);
            this.Controls.Add(this.HSVBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numValMax2);
            this.Controls.Add(this.numValMin2);
            this.Controls.Add(this.numSatMax2);
            this.Controls.Add(this.numSatMin2);
            this.Controls.Add(this.numHueMax2);
            this.Controls.Add(this.numHueMin2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numValMax1);
            this.Controls.Add(this.numValMin1);
            this.Controls.Add(this.numSatMax1);
            this.Controls.Add(this.numSatMin1);
            this.Controls.Add(this.numHueMax1);
            this.Controls.Add(this.numHueMin1);
            this.Controls.Add(this.btn_RemoveBackground);
            this.Controls.Add(this.list_RemBg);
            this.Controls.Add(this.btn_RemBgSelectImages);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RemoveBackground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Background";
            this.Load += new System.EventHandler(this.RemoveBackground_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageToolsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void List_RemBg_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog RemBgSelectImages;
        private System.Windows.Forms.Button btn_RemBgSelectImages;
        private ColumnHeader columnHeader1;
        private ListView list_RemBg;
        private ColumnHeader AbsolutePath;
        private Button btn_RemoveBackground;
        private NumericUpDown numHueMin1;
        private NumericUpDown numHueMax1;
        private NumericUpDown numSatMin1;
        private NumericUpDown numSatMax1;
        private NumericUpDown numValMin1;
        private NumericUpDown numValMax1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown numValMax2;
        private NumericUpDown numValMin2;
        private NumericUpDown numSatMax2;
        private NumericUpDown numSatMin2;
        private NumericUpDown numHueMax2;
        private NumericUpDown numHueMin2;
        private Label label6;
        private Label label7;
        private Label label11;
        private CheckBox HSVBox1;
        private CheckBox HSVBox2;
        private NumericUpDown numValMax3;
        private NumericUpDown numValMin3;
        private NumericUpDown numSatMax3;
        private NumericUpDown numSatMin3;
        private NumericUpDown numHueMax3;
        private NumericUpDown numHueMin3;
        private CheckBox HSVBox3;
        private NumericUpDown numValMax4;
        private NumericUpDown numValMin4;
        private NumericUpDown numSatMax4;
        private NumericUpDown numSatMin4;
        private NumericUpDown numHueMax4;
        private NumericUpDown numHueMin4;
        private Button btn_cleanListViewRemBg;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btn_RemBgSelectFolder;
        private Label output_local;
        private Label label13;
        private ComboBox comboColors;
        private ImageToolsDataSet imageToolsDataSet;
        private BindingSource backgroundColorsBindingSource;
        private ImageToolsDataSetTableAdapters.BackgroundColorsTableAdapter backgroundColorsTableAdapter;
        private Button btn_addBgColor;
        private Button btn_remBg_preview;
        private CheckBox checkBox1;
    }
}