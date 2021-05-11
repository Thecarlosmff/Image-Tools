
namespace Image_Tools
{
    partial class TranslationTools
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        { 
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslationTools));
            this.btn_MainBackground = new System.Windows.Forms.Button();
            this.btn_MainImageToText = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MainBackground
            // 
            this.btn_MainBackground.Location = new System.Drawing.Point(108, 136);
            this.btn_MainBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MainBackground.Name = "btn_MainBackground";
            this.btn_MainBackground.Size = new System.Drawing.Size(150, 40);
            this.btn_MainBackground.TabIndex = 0;
            this.btn_MainBackground.Text = "Remove Background";
            this.btn_MainBackground.UseVisualStyleBackColor = true;
            this.btn_MainBackground.Click += new System.EventHandler(this.BtnMainBackground_Click);
            // 
            // btn_MainImageToText
            // 
            this.btn_MainImageToText.Location = new System.Drawing.Point(458, 136);
            this.btn_MainImageToText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MainImageToText.Name = "btn_MainImageToText";
            this.btn_MainImageToText.Size = new System.Drawing.Size(150, 40);
            this.btn_MainImageToText.TabIndex = 1;
            this.btn_MainImageToText.Text = "Image to Text";
            this.btn_MainImageToText.UseVisualStyleBackColor = true;
            this.btn_MainImageToText.Click += new System.EventHandler(this.Btn_MainImageToText_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(216, 53);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(288, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Thecarlosmff/Image-Tools";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Devolped by Thecarlosmff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "This software uses Tesseract OCR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(235, 298);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(269, 17);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/tesseract-ocr/tesseract";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "See usage and how HSV colors work in the link above";
            // 
            // TranslationTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_MainImageToText);
            this.Controls.Add(this.btn_MainBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TranslationTools";
            this.Text = "Image Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MainBackground;
        private System.Windows.Forms.Button btn_MainImageToText;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
    }
}

