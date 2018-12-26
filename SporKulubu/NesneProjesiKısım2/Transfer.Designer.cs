namespace NesneProjesiKısım2
{
    partial class Transfer
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
            this.dataGridViewTransferTablo = new System.Windows.Forms.DataGridView();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonKaldır = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonTransferEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransferTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransferTablo
            // 
            this.dataGridViewTransferTablo.AllowUserToAddRows = false;
            this.dataGridViewTransferTablo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTransferTablo.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTransferTablo.MultiSelect = false;
            this.dataGridViewTransferTablo.Name = "dataGridViewTransferTablo";
            this.dataGridViewTransferTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransferTablo.Size = new System.Drawing.Size(943, 368);
            this.dataGridViewTransferTablo.TabIndex = 0;
            this.dataGridViewTransferTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransferTablo_CellContentClick);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(826, 395);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(129, 43);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonKaldır
            // 
            this.buttonKaldır.Location = new System.Drawing.Point(691, 395);
            this.buttonKaldır.Name = "buttonKaldır";
            this.buttonKaldır.Size = new System.Drawing.Size(129, 43);
            this.buttonKaldır.TabIndex = 2;
            this.buttonKaldır.Text = "Kaldır";
            this.buttonKaldır.UseVisualStyleBackColor = true;
            this.buttonKaldır.Click += new System.EventHandler(this.buttonKaldır_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(12, 395);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(129, 43);
            this.buttonGeri.TabIndex = 3;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonTransferEt
            // 
            this.buttonTransferEt.Location = new System.Drawing.Point(556, 395);
            this.buttonTransferEt.Name = "buttonTransferEt";
            this.buttonTransferEt.Size = new System.Drawing.Size(129, 43);
            this.buttonTransferEt.TabIndex = 4;
            this.buttonTransferEt.Text = "Transfer Et";
            this.buttonTransferEt.UseVisualStyleBackColor = true;
            this.buttonTransferEt.Click += new System.EventHandler(this.buttonTransferEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTransferEt);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.buttonKaldır);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridViewTransferTablo);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransferTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransferTablo;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonKaldır;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonTransferEt;
        private System.Windows.Forms.Label label1;
    }
}