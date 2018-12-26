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
    public partial class TransferListesineEkle : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LC8FAMI\\SQLEXPRESS; Initial Catalog= oyuncuVeriler; Integrated Security=True");
        DataTable tbl = new DataTable();

        public TransferListesineEkle()
        {
            InitializeComponent();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Transfer transfer= new Transfer();
            transfer.Closed += (s, args) => this.Close();
            this.Hide();
            transfer.Show();
        }

        private void TransferListesineEkle_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from oyuncuListesi ", conn);
            dataGridViewOyuncuListesi.DataSource = tbl;
            adptr.Fill(tbl);
            conn.Close();
            dataGridViewOyuncuListesi.ClearSelection();
        }

        private void dataGridViewOyuncuListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridViewOyuncuListesi.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewOyuncuListesi.Rows[selectedrowindex];
            SqlCommand cmd = new SqlCommand(@"INSERT INTO transferListesi (ad, soyad, yas, maas, mevki, piyasaDegeri, sporDali, Takim) VALUES('" + Convert.ToString(dataGridViewOyuncuListesi.Rows[selectedrowindex].Cells[1].Value)
                + "','" + Convert.ToString(dataGridViewOyuncuListesi.Rows[selectedrowindex].Cells[2].Value)
                + "','" + Convert.ToInt32(dataGridViewOyuncuListesi.Rows[selectedrowindex].Cells[3].Value)
                + "','" + Convert.ToInt32(dataGridViewOyuncuListesi.Rows[selectedrowindex].Cells[4].Value)
                + "','" + Convert.ToString(dataGridViewOyuncuListesi.Rows[selectedrowindex].Cells[5].Value)
                + "','" + Convert.ToString(dataGridViewOyuncuListesi.Rows[selectedrowindex].Cells[6].Value)
                + "','" + Convert.ToString(dataGridViewOyuncuListesi.Rows[selectedrowindex].Cells[7].Value)
                + "','" + "Galatasaray" + "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Transfer transfer = new Transfer();
            transfer.Closed += (s, args) => this.Close();
            this.Hide();
            transfer.Show();
        }
    }
}
