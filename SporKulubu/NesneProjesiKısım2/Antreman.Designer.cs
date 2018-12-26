namespace NesneProjesiKısım2
{
    partial class Antreman
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
            this.checkedListBoxAntremanListesi = new System.Windows.Forms.CheckedListBox();
            this.labelAntremanSüresi = new System.Windows.Forms.Label();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.dataGridViewAntreman = new System.Windows.Forms.DataGridView();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.comboBoxAntremanSuresi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntreman)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxAntremanListesi
            // 
            this.checkedListBoxAntremanListesi.FormattingEnabled = true;
            this.checkedListBoxAntremanListesi.Location = new System.Drawing.Point(13, 169);
            this.checkedListBoxAntremanListesi.Name = "checkedListBoxAntremanListesi";
            this.checkedListBoxAntremanListesi.Size = new System.Drawing.Size(942, 154);
            this.checkedListBoxAntremanListesi.TabIndex = 0;
            // 
            // labelAntremanSüresi
            // 
            this.labelAntremanSüresi.AutoSize = true;
            this.labelAntremanSüresi.Location = new System.Drawing.Point(12, 346);
            this.labelAntremanSüresi.Name = "labelAntremanSüresi";
            this.labelAntremanSüresi.Size = new System.Drawing.Size(102, 13);
            this.labelAntremanSüresi.TabIndex = 2;
            this.labelAntremanSüresi.Text = "Antreman Süresi(dk)";
            // 
            // buttonBasla
            // 
            this.buttonBasla.Location = new System.Drawing.Point(826, 336);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(129, 43);
            this.buttonBasla.TabIndex = 3;
            this.buttonBasla.Text = "Başla";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // dataGridViewAntreman
            // 
            this.dataGridViewAntreman.AllowUserToAddRows = false;
            this.dataGridViewAntreman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAntreman.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAntreman.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewAntreman.Name = "dataGridViewAntreman";
            this.dataGridViewAntreman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAntreman.Size = new System.Drawing.Size(943, 150);
            this.dataGridViewAntreman.TabIndex = 4;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(691, 336);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(129, 43);
            this.buttonGeri.TabIndex = 5;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // comboBoxAntremanSuresi
            // 
            this.comboBoxAntremanSuresi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAntremanSuresi.FormattingEnabled = true;
            this.comboBoxAntremanSuresi.Location = new System.Drawing.Point(120, 343);
            this.comboBoxAntremanSuresi.Name = "comboBoxAntremanSuresi";
            this.comboBoxAntremanSuresi.Size = new System.Drawing.Size(78, 21);
            this.comboBoxAntremanSuresi.TabIndex = 6;
            this.comboBoxAntremanSuresi.SelectedIndexChanged += new System.EventHandler(this.comboBoxAntremanSuresi_SelectedIndexChanged);
            // 
            // Antreman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 391);
            this.Controls.Add(this.comboBoxAntremanSuresi);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.dataGridViewAntreman);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.labelAntremanSüresi);
            this.Controls.Add(this.checkedListBoxAntremanListesi);
            this.Name = "Antreman";
            this.Text = "Antreman";
            this.Load += new System.EventHandler(this.Antreman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntreman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxAntremanListesi;
        private System.Windows.Forms.Label labelAntremanSüresi;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.DataGridView dataGridViewAntreman;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.ComboBox comboBoxAntremanSuresi;
    }
}