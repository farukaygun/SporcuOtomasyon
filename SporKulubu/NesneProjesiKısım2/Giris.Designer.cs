namespace NesneProjesiKısım2
{
    partial class Giris
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
            this.labelLisansNo = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.textBoxLisansNo = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.checkBoxParolaGoster = new System.Windows.Forms.CheckBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.labelUyarı = new System.Windows.Forms.Label();
            this.pictureBoxUyarı = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUyarı)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLisansNo
            // 
            this.labelLisansNo.AutoSize = true;
            this.labelLisansNo.Location = new System.Drawing.Point(56, 54);
            this.labelLisansNo.Name = "labelLisansNo";
            this.labelLisansNo.Size = new System.Drawing.Size(54, 13);
            this.labelLisansNo.TabIndex = 0;
            this.labelLisansNo.Text = "Lisans No";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(59, 92);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(37, 13);
            this.labelParola.TabIndex = 1;
            this.labelParola.Text = "Parola";
            // 
            // textBoxLisansNo
            // 
            this.textBoxLisansNo.Location = new System.Drawing.Point(120, 51);
            this.textBoxLisansNo.Name = "textBoxLisansNo";
            this.textBoxLisansNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLisansNo.TabIndex = 2;
            this.textBoxLisansNo.TextChanged += new System.EventHandler(this.textBoxLisansNo_TextChanged);
            this.textBoxLisansNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLisansNo_KeyPress);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(120, 89);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(100, 20);
            this.textBoxParola.TabIndex = 3;
            this.textBoxParola.TextChanged += new System.EventHandler(this.textBoxParola_TextChanged);
            // 
            // checkBoxParolaGoster
            // 
            this.checkBoxParolaGoster.AutoSize = true;
            this.checkBoxParolaGoster.Location = new System.Drawing.Point(118, 129);
            this.checkBoxParolaGoster.Name = "checkBoxParolaGoster";
            this.checkBoxParolaGoster.Size = new System.Drawing.Size(97, 17);
            this.checkBoxParolaGoster.TabIndex = 4;
            this.checkBoxParolaGoster.Text = "Parolayı Göster";
            this.checkBoxParolaGoster.UseVisualStyleBackColor = true;
            this.checkBoxParolaGoster.CheckedChanged += new System.EventHandler(this.checkBoxParolaGoster_CheckedChanged);
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(153, 161);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(67, 28);
            this.buttonGiris.TabIndex = 5;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // labelUyarı
            // 
            this.labelUyarı.AutoSize = true;
            this.labelUyarı.ForeColor = System.Drawing.Color.Red;
            this.labelUyarı.Location = new System.Drawing.Point(117, 25);
            this.labelUyarı.Name = "labelUyarı";
            this.labelUyarı.Size = new System.Drawing.Size(148, 13);
            this.labelUyarı.TabIndex = 6;
            this.labelUyarı.Text = "Lisans No ya da Parola yanlış!";
            this.labelUyarı.Visible = false;
            // 
            // pictureBoxUyarı
            // 
            this.pictureBoxUyarı.Image = global::NesneProjesiKısım2.Properties.Resources.warning;
            this.pictureBoxUyarı.Location = new System.Drawing.Point(98, 22);
            this.pictureBoxUyarı.Name = "pictureBoxUyarı";
            this.pictureBoxUyarı.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxUyarı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUyarı.TabIndex = 7;
            this.pictureBoxUyarı.TabStop = false;
            this.pictureBoxUyarı.Visible = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 216);
            this.Controls.Add(this.pictureBoxUyarı);
            this.Controls.Add(this.labelUyarı);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.checkBoxParolaGoster);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxLisansNo);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelLisansNo);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUyarı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLisansNo;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox textBoxLisansNo;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.CheckBox checkBoxParolaGoster;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Label labelUyarı;
        private System.Windows.Forms.PictureBox pictureBoxUyarı;
    }
}