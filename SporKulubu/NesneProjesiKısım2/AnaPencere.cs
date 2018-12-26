using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProjesiKısım2
{
    public partial class AnaPencere : Form
    {
        public AnaPencere()
        {
            InitializeComponent();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Closed += (s, args) => this.Close();
            this.Hide();
            transfer.Show();
        }

        private void buttonAntreman_Click(object sender, EventArgs e)
        {
            Antreman antreman = new Antreman();
            antreman.Closed += (s, args) => this.Close();
            this.Hide();
            antreman.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Closed += (s, args) => this.Close();
            this.Hide();
            giris.Show();
        }

        private void buttonOyuncuEkle_Click(object sender, EventArgs e)
        {
            OyuncuEkle oyuncuEkle = new OyuncuEkle();
            oyuncuEkle.Closed += (s, args) => this.Close();
            this.Hide();
            oyuncuEkle.Show();
        }

        private void AnaPencere_Load(object sender, EventArgs e)
        {
            CompositeGorevli Antrenor = new CompositeGorevli("Ahmet ", Gorevi.Antrenor);
        }

        private void kaynakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yardım yardım = new Yardım();
            yardım.Closed += (s, args) => this.Close();
            this.Hide();
            yardım.Show();
        }
    }
}
