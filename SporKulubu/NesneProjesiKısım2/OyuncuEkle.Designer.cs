namespace NesneProjesiKısım2
{
    partial class OyuncuEkle
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
            this.labelSpoDali = new System.Windows.Forms.Label();
            this.comboBoxSporDali = new System.Windows.Forms.ComboBox();
            this.labelAdi = new System.Windows.Forms.Label();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.labelYas = new System.Windows.Forms.Label();
            this.labelMevki = new System.Windows.Forms.Label();
            this.labelMaas = new System.Windows.Forms.Label();
            this.labelPiyasaDegeri = new System.Windows.Forms.Label();
            this.labelTransferListesindeMi = new System.Windows.Forms.Label();
            this.radioButtonEvet = new System.Windows.Forms.RadioButton();
            this.radioButtonHayır = new System.Windows.Forms.RadioButton();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.textBoxPiyasaDegeri = new System.Windows.Forms.TextBox();
            this.textBoxMaas = new System.Windows.Forms.TextBox();
            this.textBoxYas = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.comboBoxMevki = new System.Windows.Forms.ComboBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.errorProviderSporDali = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAdi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSoyadi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderYasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMevki = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMaas = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPiyasaDegeri = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRadioButtıon = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSporDali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSoyadi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMevki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPiyasaDegeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRadioButtıon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpoDali
            // 
            this.labelSpoDali.AutoSize = true;
            this.labelSpoDali.Location = new System.Drawing.Point(23, 41);
            this.labelSpoDali.Name = "labelSpoDali";
            this.labelSpoDali.Size = new System.Drawing.Size(50, 13);
            this.labelSpoDali.TabIndex = 0;
            this.labelSpoDali.Text = "Spor Dalı";
            // 
            // comboBoxSporDali
            // 
            this.comboBoxSporDali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSporDali.FormattingEnabled = true;
            this.comboBoxSporDali.Location = new System.Drawing.Point(79, 38);
            this.comboBoxSporDali.Name = "comboBoxSporDali";
            this.comboBoxSporDali.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSporDali.TabIndex = 1;
            this.comboBoxSporDali.SelectedIndexChanged += new System.EventHandler(this.comboBoxSporDali_SelectedIndexChanged);
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Location = new System.Drawing.Point(23, 89);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(22, 13);
            this.labelAdi.TabIndex = 2;
            this.labelAdi.Text = "Adı";
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.Location = new System.Drawing.Point(237, 89);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(39, 13);
            this.labelSoyadi.TabIndex = 3;
            this.labelSoyadi.Text = "Soyadı";
            // 
            // labelYas
            // 
            this.labelYas.AutoSize = true;
            this.labelYas.Location = new System.Drawing.Point(23, 123);
            this.labelYas.Name = "labelYas";
            this.labelYas.Size = new System.Drawing.Size(25, 13);
            this.labelYas.TabIndex = 4;
            this.labelYas.Text = "Yaş";
            // 
            // labelMevki
            // 
            this.labelMevki.AutoSize = true;
            this.labelMevki.Location = new System.Drawing.Point(237, 123);
            this.labelMevki.Name = "labelMevki";
            this.labelMevki.Size = new System.Drawing.Size(36, 13);
            this.labelMevki.TabIndex = 5;
            this.labelMevki.Text = "Mevki";
            // 
            // labelMaas
            // 
            this.labelMaas.AutoSize = true;
            this.labelMaas.Location = new System.Drawing.Point(23, 158);
            this.labelMaas.Name = "labelMaas";
            this.labelMaas.Size = new System.Drawing.Size(45, 13);
            this.labelMaas.TabIndex = 6;
            this.labelMaas.Text = "Maaş($)";
            // 
            // labelPiyasaDegeri
            // 
            this.labelPiyasaDegeri.AutoSize = true;
            this.labelPiyasaDegeri.Location = new System.Drawing.Point(237, 158);
            this.labelPiyasaDegeri.Name = "labelPiyasaDegeri";
            this.labelPiyasaDegeri.Size = new System.Drawing.Size(84, 13);
            this.labelPiyasaDegeri.TabIndex = 7;
            this.labelPiyasaDegeri.Text = "Piyasa Değeri($)";
            // 
            // labelTransferListesindeMi
            // 
            this.labelTransferListesindeMi.AutoSize = true;
            this.labelTransferListesindeMi.Location = new System.Drawing.Point(23, 199);
            this.labelTransferListesindeMi.Name = "labelTransferListesindeMi";
            this.labelTransferListesindeMi.Size = new System.Drawing.Size(115, 13);
            this.labelTransferListesindeMi.TabIndex = 8;
            this.labelTransferListesindeMi.Text = "Transfer Listesinde mi?";
            // 
            // radioButtonEvet
            // 
            this.radioButtonEvet.AutoSize = true;
            this.radioButtonEvet.Location = new System.Drawing.Point(26, 224);
            this.radioButtonEvet.Name = "radioButtonEvet";
            this.radioButtonEvet.Size = new System.Drawing.Size(47, 17);
            this.radioButtonEvet.TabIndex = 8;
            this.radioButtonEvet.TabStop = true;
            this.radioButtonEvet.Text = "Evet";
            this.radioButtonEvet.UseVisualStyleBackColor = true;
            // 
            // radioButtonHayır
            // 
            this.radioButtonHayır.AutoSize = true;
            this.radioButtonHayır.Location = new System.Drawing.Point(89, 224);
            this.radioButtonHayır.Name = "radioButtonHayır";
            this.radioButtonHayır.Size = new System.Drawing.Size(49, 17);
            this.radioButtonHayır.TabIndex = 9;
            this.radioButtonHayır.TabStop = true;
            this.radioButtonHayır.Text = "Hayır";
            this.radioButtonHayır.UseVisualStyleBackColor = true;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(79, 86);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdi.TabIndex = 2;
            this.textBoxAdi.TextChanged += new System.EventHandler(this.textBoxAdi_TextChanged);
            this.textBoxAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdi_KeyPress);
            // 
            // textBoxPiyasaDegeri
            // 
            this.textBoxPiyasaDegeri.Location = new System.Drawing.Point(327, 155);
            this.textBoxPiyasaDegeri.Name = "textBoxPiyasaDegeri";
            this.textBoxPiyasaDegeri.Size = new System.Drawing.Size(100, 20);
            this.textBoxPiyasaDegeri.TabIndex = 7;
            this.textBoxPiyasaDegeri.TextChanged += new System.EventHandler(this.textBoxPiyasaDegeri_TextChanged);
            this.textBoxPiyasaDegeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPiyasaDegeri_KeyPress);
            // 
            // textBoxMaas
            // 
            this.textBoxMaas.Location = new System.Drawing.Point(79, 155);
            this.textBoxMaas.Name = "textBoxMaas";
            this.textBoxMaas.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaas.TabIndex = 6;
            this.textBoxMaas.TextChanged += new System.EventHandler(this.textBoxMaas_TextChanged);
            this.textBoxMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaas_KeyPress);
            // 
            // textBoxYas
            // 
            this.textBoxYas.Location = new System.Drawing.Point(79, 120);
            this.textBoxYas.Name = "textBoxYas";
            this.textBoxYas.Size = new System.Drawing.Size(100, 20);
            this.textBoxYas.TabIndex = 4;
            this.textBoxYas.TextChanged += new System.EventHandler(this.textBoxYas_TextChanged);
            this.textBoxYas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYas_KeyPress);
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(327, 86);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoyadi.TabIndex = 3;
            this.textBoxSoyadi.TextChanged += new System.EventHandler(this.textBoxSoyadi_TextChanged);
            this.textBoxSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoyadi_KeyPress);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(298, 267);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(129, 43);
            this.buttonEkle.TabIndex = 10;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // comboBoxMevki
            // 
            this.comboBoxMevki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMevki.FormattingEnabled = true;
            this.comboBoxMevki.Location = new System.Drawing.Point(327, 120);
            this.comboBoxMevki.Name = "comboBoxMevki";
            this.comboBoxMevki.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMevki.TabIndex = 5;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(26, 267);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(129, 43);
            this.buttonGeri.TabIndex = 11;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // errorProviderSporDali
            // 
            this.errorProviderSporDali.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSporDali.ContainerControl = this;
            // 
            // errorProviderAdi
            // 
            this.errorProviderAdi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAdi.ContainerControl = this;
            // 
            // errorProviderSoyadi
            // 
            this.errorProviderSoyadi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSoyadi.ContainerControl = this;
            // 
            // errorProviderYasi
            // 
            this.errorProviderYasi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderYasi.ContainerControl = this;
            // 
            // errorProviderMevki
            // 
            this.errorProviderMevki.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMevki.ContainerControl = this;
            // 
            // errorProviderMaas
            // 
            this.errorProviderMaas.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMaas.ContainerControl = this;
            // 
            // errorProviderPiyasaDegeri
            // 
            this.errorProviderPiyasaDegeri.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPiyasaDegeri.ContainerControl = this;
            // 
            // errorProviderRadioButtıon
            // 
            this.errorProviderRadioButtıon.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderRadioButtıon.ContainerControl = this;
            // 
            // OyuncuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 322);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.comboBoxMevki);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.textBoxYas);
            this.Controls.Add(this.textBoxMaas);
            this.Controls.Add(this.textBoxPiyasaDegeri);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.radioButtonHayır);
            this.Controls.Add(this.radioButtonEvet);
            this.Controls.Add(this.labelTransferListesindeMi);
            this.Controls.Add(this.labelPiyasaDegeri);
            this.Controls.Add(this.labelMaas);
            this.Controls.Add(this.labelMevki);
            this.Controls.Add(this.labelYas);
            this.Controls.Add(this.labelSoyadi);
            this.Controls.Add(this.labelAdi);
            this.Controls.Add(this.comboBoxSporDali);
            this.Controls.Add(this.labelSpoDali);
            this.Name = "OyuncuEkle";
            this.Text = "OyuncuEkle";
            this.Load += new System.EventHandler(this.OyuncuEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSporDali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSoyadi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMevki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPiyasaDegeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRadioButtıon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpoDali;
        private System.Windows.Forms.ComboBox comboBoxSporDali;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.Label labelYas;
        private System.Windows.Forms.Label labelMevki;
        private System.Windows.Forms.Label labelMaas;
        private System.Windows.Forms.Label labelPiyasaDegeri;
        private System.Windows.Forms.Label labelTransferListesindeMi;
        private System.Windows.Forms.RadioButton radioButtonEvet;
        private System.Windows.Forms.RadioButton radioButtonHayır;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.TextBox textBoxPiyasaDegeri;
        private System.Windows.Forms.TextBox textBoxMaas;
        private System.Windows.Forms.TextBox textBoxYas;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.ComboBox comboBoxMevki;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.ErrorProvider errorProviderSporDali;
        private System.Windows.Forms.ErrorProvider errorProviderAdi;
        private System.Windows.Forms.ErrorProvider errorProviderSoyadi;
        private System.Windows.Forms.ErrorProvider errorProviderYasi;
        private System.Windows.Forms.ErrorProvider errorProviderMevki;
        private System.Windows.Forms.ErrorProvider errorProviderMaas;
        private System.Windows.Forms.ErrorProvider errorProviderPiyasaDegeri;
        private System.Windows.Forms.ErrorProvider errorProviderRadioButtıon;
    }
}