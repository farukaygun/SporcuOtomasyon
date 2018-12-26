namespace NesneProjesiKısım2
{
    partial class Yardım
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
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(13, 48);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(38, 13);
            this.linkLabelGithub.TabIndex = 0;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(122, 89);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(129, 43);
            this.buttonGeri.TabIndex = 2;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // Yardım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 144);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.linkLabelGithub);
            this.Name = "Yardım";
            this.Text = "Yardım";
            this.Load += new System.EventHandler(this.Yardım_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonGeri;
    }
}