using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NesneProjesiKısım2
{
    public partial class Transfer : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LC8FAMI\\SQLEXPRESS; Initial Catalog= oyuncuVeriler; Integrated Security=True");
        DataTable tbl = new DataTable();
        public Transfer()
        {
            InitializeComponent();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AnaPencere anapencere = new AnaPencere();
            anapencere.Closed += (s, args) => this.Close();
            this.Hide();
            anapencere.Show();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from transferListesi ", conn);
            dataGridViewTransferTablo.DataSource = tbl;
            adptr.Fill(tbl);
            conn.Close(); 
            buttonEkle.Visible = true;
            buttonKaldır.Visible = true;

            dataGridViewTransferTablo.ClearSelection();
        }

        private void buttonKaldır_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransferTablo.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewTransferTablo.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewTransferTablo.Rows[selectedrowindex];
                string takim = Convert.ToString(selectedRow.Cells["Takim"].Value);

                if (takim == "Galatasaray")
                {
                    int selectedIndex = dataGridViewTransferTablo.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE from transferListesi where id=@ID", conn);
                        cmd.Parameters.AddWithValue("@ID", dataGridViewTransferTablo.CurrentRow.Cells[0].Value);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        dataGridViewTransferTablo.Rows.RemoveAt(selectedIndex);
                        dataGridViewTransferTablo.Refresh();
                    }
                }
            }
            else
            {           
                MessageBox.Show("Lütfen bir sporcu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewTransferTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonTransferEt_Click(object sender, EventArgs e)
        {
            TransferGorusme t1 = new FutbolcuA();
            t1.TemplateMethodu();
            TransferGorusme t2 = new BasketbolcuA();
            t2.TemplateMethodu();

            int selectedrowindex = dataGridViewTransferTablo.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewTransferTablo.Rows[selectedrowindex];
            SqlCommand cmd = new SqlCommand(@"INSERT INTO oyuncuListesi (ad, soyad, yas, maas, mevki, piyasaDegeri, sporDali, Takim) VALUES('" + Convert.ToString(dataGridViewTransferTablo.Rows[selectedrowindex].Cells[1].Value)
                + "','" + Convert.ToString(dataGridViewTransferTablo.Rows[selectedrowindex].Cells[2].Value)
                + "','" + Convert.ToInt32(dataGridViewTransferTablo.Rows[selectedrowindex].Cells[3].Value)
                + "','" + Convert.ToInt32(dataGridViewTransferTablo.Rows[selectedrowindex].Cells[4].Value)
                + "','" + Convert.ToString(dataGridViewTransferTablo.Rows[selectedrowindex].Cells[5].Value)
                + "','" + Convert.ToString(dataGridViewTransferTablo.Rows[selectedrowindex].Cells[6].Value)
                + "','" + Convert.ToString(dataGridViewTransferTablo.Rows[selectedrowindex].Cells[7].Value)
                + "','" + "Galatasaray" + "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            if (dataGridViewTransferTablo.SelectedCells.Count > 0)
            {
                string takim = Convert.ToString(selectedRow.Cells["Takim"].Value);

                if (takim != "Galatasaray")
                {
                    int selectedIndex = dataGridViewTransferTablo.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand("DELETE FROM transferListesi where id=@ID", conn);
                        cmd2.Parameters.AddWithValue("@ID", dataGridViewTransferTablo.CurrentRow.Cells[0].Value);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        dataGridViewTransferTablo.Rows.RemoveAt(selectedIndex);
                        dataGridViewTransferTablo.Refresh();
                    }
                }
            }
            MessageBox.Show("Oyuncu ile transfer görüşmeleri başlamıştır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            TransferListesineEkle transferListesineEkle = new TransferListesineEkle();
            transferListesineEkle.Closed += (s, args) => this.Close();
            this.Hide();
            transferListesineEkle.Show();
        }
    }
}
