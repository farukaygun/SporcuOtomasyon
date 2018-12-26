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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            //Entera basınca Giriş butonuna basılıyor.
            this.AcceptButton = buttonGiris;
        }

        private void textBoxLisansNo_TextChanged(object sender, EventArgs e)
        {
            textBoxLisansNo.MaxLength = 11;            
        }

        private void textBoxLisansNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox içerisine sadece rakam girişi yapılabiliyor.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {
            textBoxParola.PasswordChar = '*';
            textBoxParola.MaxLength = 16;
        }

        private void checkBoxParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            //parola göster checkbox kontrolü
            textBoxParola.PasswordChar = checkBoxParolaGoster.Checked ? '\0' : '*';
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LC8FAMI\\SQLEXPRESS; Initial Catalog= oyuncuVeriler; Integrated Security=True");
            conn.Open();
            SqlCommand komut = new SqlCommand("select lisansNo from giris", conn);
            SqlCommand komut2 = new SqlCommand("select parola from giris", conn);
            string lisansNo = komut.ExecuteScalar().ToString();
            string parola = komut2.ExecuteScalar().ToString();

            if (textBoxLisansNo.Text != lisansNo || textBoxParola.Text != parola)
            {
                pictureBoxUyarı.Visible = true;
                labelUyarı.Visible = true;
            }            
            else
            {               
                AnaPencere anapencere = new AnaPencere();
                anapencere.Closed += (s, args) => this.Close();
                this.Hide();
                anapencere.Show();
                conn.Close();
            }
        }
    }
}