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
    public partial class Antreman : Form
    {
        public Antreman()
        {
            InitializeComponent();
        }

        private void Antreman_Load(object sender, EventArgs e)
        {
            comboBoxAntremanSuresi.DisplayMember = "Text";
            comboBoxAntremanSuresi.ValueMember = "Value";

            comboBoxAntremanSuresi.Items.Add(new { Text = "15", Value = "0" });
            comboBoxAntremanSuresi.Items.Add(new { Text = "30", Value = "1" });
            comboBoxAntremanSuresi.Items.Add(new { Text = "45", Value = "2" });

            checkedListBoxAntremanListesi.CheckOnClick = true;

            checkedListBoxAntremanListesi.DisplayMember = "Text";
            checkedListBoxAntremanListesi.ValueMember = "Value";

            checkedListBoxAntremanListesi.Items.Insert(0, new { Text = "Kalecilik", Value = "Kalecilik" });
            checkedListBoxAntremanListesi.Items.Insert(1, new { Text = "Defans Antremanı", Value = "Defans Antremanı" });
            checkedListBoxAntremanListesi.Items.Insert(2, new { Text = "Orta Saha Antremanı", Value = "Orta Saha Antremanı" });
            checkedListBoxAntremanListesi.Items.Insert(3, new { Text = "Forvet Antremanı", Value = "Forvet Antremanı" });

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LC8FAMI\\SQLEXPRESS; Initial Catalog= oyuncuVeriler; Integrated Security=True");
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select * from oyuncuListesi ", conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridViewAntreman.DataSource = tbl;
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AnaPencere anapencere = new AnaPencere();
            anapencere.Closed += (s, args) => this.Close();
            this.Hide();
            anapencere.Show();
        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            if (dataGridViewAntreman.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir sporcu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxAntremanSuresi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen antreman süresini seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkedListBoxAntremanListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen antreman türünü seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FacadePattern.Takım takım = new FacadePattern.Takım();
                //Takıma iş yaptırdık.
                takım.Baslat();
                //Command Pattern
                //Duduk nesnesi oluşturduk
                Duduk duduk = new Duduk();
                //Duduk komutları oluşturuyoruz.
                DudukCalKomutu dudukCal = new DudukCalKomutu(duduk);
                DudukSusKomutu dudukSus = new DudukSusKomutu(duduk);
                //Duduk Ufleme nesnesi oluşturuyoruz.
                DudukUfle ufle = new DudukUfle(dudukCal, dudukSus);
                ufle.Ufle();
                ufle.Bırak();
                MessageBox.Show("Antreman tamamlandı! Oyuncu " + comboBoxAntremanSuresi.Text + "dk antreman yaptı ve seçilen özellikler oyuncuya eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void comboBoxAntremanSuresi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
