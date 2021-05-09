
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
            this.btn_MainBackground = new System.Windows.Forms.Button();
            this.btn_MainImageToText = new System.Windows.Forms.Button();
            this.btn_MainTxtToExcel = new System.Windows.Forms.Button();
            this.btn_MainTranslate = new System.Windows.Forms.Button();
            this.label_MainBackground = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MainBackground
            // 
            this.btn_MainBackground.Location = new System.Drawing.Point(80, 70);
            this.btn_MainBackground.Name = "btn_MainBackground";
            this.btn_MainBackground.Size = new System.Drawing.Size(150, 50);
            this.btn_MainBackground.TabIndex = 0;
            this.btn_MainBackground.Text = "Remove Background";
            this.btn_MainBackground.UseVisualStyleBackColor = true;
            this.btn_MainBackground.Click += new System.EventHandler(this.BtnMainBackground_Click);
            // 
            // btn_MainImageToText
            // 
            this.btn_MainImageToText.Location = new System.Drawing.Point(80, 135);
            this.btn_MainImageToText.Name = "btn_MainImageToText";
            this.btn_MainImageToText.Size = new System.Drawing.Size(150, 50);
            this.btn_MainImageToText.TabIndex = 1;
            this.btn_MainImageToText.Text = "Image to Text";
            this.btn_MainImageToText.UseVisualStyleBackColor = true;
            this.btn_MainImageToText.Click += new System.EventHandler(this.Btn_MainImageToText_Click);
            // 
            // btn_MainTxtToExcel
            // 
            this.btn_MainTxtToExcel.Location = new System.Drawing.Point(80, 200);
            this.btn_MainTxtToExcel.Name = "btn_MainTxtToExcel";
            this.btn_MainTxtToExcel.Size = new System.Drawing.Size(150, 50);
            this.btn_MainTxtToExcel.TabIndex = 3;
            this.btn_MainTxtToExcel.Text = "Text File to Excel";
            this.btn_MainTxtToExcel.UseVisualStyleBackColor = true;
            this.btn_MainTxtToExcel.Click += new System.EventHandler(this.Btn_MainTxtToExcel_Click);
            // 
            // btn_MainTranslate
            // 
            this.btn_MainTranslate.Location = new System.Drawing.Point(80, 265);
            this.btn_MainTranslate.Name = "btn_MainTranslate";
            this.btn_MainTranslate.Size = new System.Drawing.Size(150, 50);
            this.btn_MainTranslate.TabIndex = 4;
            this.btn_MainTranslate.Text = "Translate";
            this.btn_MainTranslate.UseVisualStyleBackColor = true;
            this.btn_MainTranslate.Click += new System.EventHandler(this.Btn_MainTranslate_Click);
            // 
            // label_MainBackground
            // 
            this.label_MainBackground.AutoSize = true;
            this.label_MainBackground.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_MainBackground.Location = new System.Drawing.Point(240, 75);
            this.label_MainBackground.Name = "label_MainBackground";
            this.label_MainBackground.Size = new System.Drawing.Size(250, 19);
            this.label_MainBackground.TabIndex = 5;
            this.label_MainBackground.Text = "Description of the background remover";
            this.label_MainBackground.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TranslationTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 405);
            this.Controls.Add(this.label_MainBackground);
            this.Controls.Add(this.btn_MainTranslate);
            this.Controls.Add(this.btn_MainTxtToExcel);
            this.Controls.Add(this.btn_MainImageToText);
            this.Controls.Add(this.btn_MainBackground);
            this.Name = "TranslationTools";
            this.Text = "Image Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MainBackground;
        private System.Windows.Forms.Button btn_MainImageToText;
        private System.Windows.Forms.Button btn_MainTxtToExcel;
        private System.Windows.Forms.Button btn_MainTranslate;
        private System.Windows.Forms.Label label_MainBackground;
    }
}

