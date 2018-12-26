namespace NesneProjesiKısım2
{
    partial class TransferListesineEkle
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
            this.dataGridViewOyuncuListesi = new System.Windows.Forms.DataGridView();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOyuncuListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOyuncuListesi
            // 
            this.dataGridViewOyuncuListesi.AllowUserToAddRows = false;
            this.dataGridViewOyuncuListesi.AllowUserToDeleteRows = false;
            this.dataGridViewOyuncuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOyuncuListesi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOyuncuListesi.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewOyuncuListesi.Name = "dataGridViewOyuncuListesi";
            this.dataGridViewOyuncuListesi.ReadOnly = true;
            this.dataGridViewOyuncuListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOyuncuListesi.Size = new System.Drawing.Size(943, 345);
            this.dataGridViewOyuncuListesi.TabIndex = 0;
            this.dataGridViewOyuncuListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOyuncuListesi_CellContentClick);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(827, 381);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(129, 43);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(692, 381);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(129, 43);
            this.buttonGeri.TabIndex = 2;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // TransferListesineEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 432);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridViewOyuncuListesi);
            this.Name = "TransferListesineEkle";
            this.Text = "TransferListesineEkle";
            this.Load += new System.EventHandler(this.TransferListesineEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOyuncuListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOyuncuListesi;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonGeri;
    }
}