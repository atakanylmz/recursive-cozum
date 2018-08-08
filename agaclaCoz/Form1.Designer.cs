namespace agaclaCoz
{
    partial class Form1
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
            this.hesaplaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.basamakTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hesaplaBtn
            // 
            this.hesaplaBtn.Location = new System.Drawing.Point(43, 124);
            this.hesaplaBtn.Name = "hesaplaBtn";
            this.hesaplaBtn.Size = new System.Drawing.Size(107, 23);
            this.hesaplaBtn.TabIndex = 0;
            this.hesaplaBtn.Text = "HESAPLA";
            this.hesaplaBtn.UseVisualStyleBackColor = true;
            this.hesaplaBtn.Click += new System.EventHandler(this.hesaplaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "basamak sayısı giriniz:";
            // 
            // basamakTxt
            // 
            this.basamakTxt.Location = new System.Drawing.Point(43, 75);
            this.basamakTxt.Name = "basamakTxt";
            this.basamakTxt.Size = new System.Drawing.Size(107, 20);
            this.basamakTxt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 304);
            this.Controls.Add(this.basamakTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesaplaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox basamakTxt;
    }
}

