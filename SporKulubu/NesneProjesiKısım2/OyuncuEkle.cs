using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace NesneProjesiKısım2
{
    public partial class OyuncuEkle : Form
    {
        public OyuncuEkle()
        {
            InitializeComponent();
        }

        private void OyuncuEkle_Load(object sender, EventArgs e)
        {
            comboBoxSporDali.DisplayMember = "Text";
            comboBoxSporDali.ValueMember = "Value";

            comboBoxSporDali.Items.Add(new { Text = "Futbol", Value = "Futbol" });
            comboBoxSporDali.Items.Add(new { Text = "Basketbol", Value = "Basketbol" });
        }

        private void textBoxAdi_KeyPress(object sender, KeyPressEventArgs e)
        {    
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxAdi_TextChanged(object sender, EventArgs e)
        {
            textBoxAdi.MaxLength = 16;
        }

        private void textBoxSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                         && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxSoyadi_TextChanged(object sender, EventArgs e)
        {
            textBoxSoyadi.MaxLength = 16;
        }

        private void textBoxYas_TextChanged(object sender, EventArgs e)
        {
            textBoxYas.MaxLength = 2;
        }

        private void textBoxYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxMaas_TextChanged(object sender, EventArgs e)
        {
            textBoxMaas.MaxLength = 8;
        }

        private void textBoxPiyasaDegeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxPiyasaDegeri_TextChanged(object sender, EventArgs e)
        {
            textBoxPiyasaDegeri.MaxLength = 9;
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AnaPencere anapencere = new AnaPencere();
            anapencere.Closed += (s, args) => this.Close();
            this.Hide();
            anapencere.Show();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            errorProviderSporDali.Clear();
            errorProviderAdi.Clear();
            errorProviderSoyadi.Clear();
            errorProviderYasi.Clear();
            errorProviderMaas.Clear();
            errorProviderMevki.Clear();
            errorProviderPiyasaDegeri.Clear();
            errorProviderRadioButtıon.Clear();

            if (comboBoxSporDali.SelectedIndex == -1)
            {
                errorProviderSporDali.SetError(comboBoxSporDali, "Bu alan boş geçilemez!");               
            }
            if (textBoxAdi.Text == "")
            {
                errorProviderAdi.SetError(textBoxAdi, "Bu alan boş geçilemez!");
            }
            if(textBoxSoyadi.Text == "")
            {
                errorProviderSoyadi.SetError(textBoxSoyadi, "Bu alan boş geçilemez!");
            }
            if (textBoxYas.Text == "")
            {
                errorProviderYasi.SetError(textBoxYas, "Bu alan boş geçilemez!");
            }
            if (comboBoxMevki.SelectedIndex == -1)
            {
                errorProviderMevki.SetError(comboBoxMevki, "Bu alan boş geçilemez!");
            }
            if (textBoxMaas.Text == "")
            {
                errorProviderMaas.SetError(textBoxMaas, "Bu alan boş geçilemez!");
            }
            if (textBoxPiyasaDegeri.Text == "")
            {
                errorProviderPiyasaDegeri.SetError(textBoxPiyasaDegeri, "Bu alan boş geçilemez!");
            }
            if (radioButtonEvet.Checked != true && radioButtonHayır.Checked != true)
            {
                errorProviderRadioButtıon.SetError(labelTransferListesindeMi, "Bu alan boş geçilemez!");
            }
            if (comboBoxSporDali.SelectedIndex != -1 && textBoxAdi.Text != "" && textBoxSoyadi.Text != "" && textBoxYas.Text != ""
                && comboBoxMevki.SelectedIndex != -1 && textBoxMaas.Text != "" && textBoxPiyasaDegeri.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LC8FAMI\\SQLEXPRESS; Initial Catalog= oyuncuVeriler; Integrated Security=True");
                conn.Open();
                SqlCommand kmt = new SqlCommand("Insert into  oyuncuListesi VALUES  ('" + textBoxAdi.Text + "','" + textBoxSoyadi.Text + "','" 
                                                                                + textBoxYas.Text + "','" + textBoxMaas.Text + "','" + comboBoxMevki.Text
                                                                                + "','" + textBoxPiyasaDegeri.Text + "','" + comboBoxSporDali.Text + "','" + "Galatasaray" + "')", conn);
                kmt.ExecuteNonQuery();


                if (radioButtonEvet.Checked == true)
                {
                    AdapterTarget target = new Adapter();
                    target.SatılıkFutbolcu();

                    SqlCommand kmt2 = new SqlCommand("Insert into  transferListesi VALUES  ('" + textBoxAdi.Text + "','" + textBoxSoyadi.Text + "','"
                                                                                    + textBoxYas.Text + "','" + textBoxMaas.Text + "','" + comboBoxMevki.Text
                                                                                    + "','" + textBoxPiyasaDegeri.Text + "','" + comboBoxSporDali.Text + "','" + "Galatasaray" + "')", conn);
                    kmt2.ExecuteNonQuery();
                }
                conn.Close();;

                AnaPencere anapencere = new AnaPencere();
                anapencere.Closed += (s, args) => this.Close();
                this.Hide();
                anapencere.Show();
            }
        }

        private void comboBoxSporDali_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSporDali.SelectedIndex == 0)
            {
                comboBoxMevki.Items.Clear();
                comboBoxMevki.DisplayMember = "Text";
                comboBoxMevki.ValueMember = "Value";

                comboBoxMevki.Items.Add(new { Text = "Kaleci", Value = "Kaleci" });
                comboBoxMevki.Items.Add(new { Text = "Defans", Value = "Defans" });
                comboBoxMevki.Items.Add(new { Text = "Orta Saha", Value = "Orta Saha" });
                comboBoxMevki.Items.Add(new { Text = "Forvet", Value = "Forvet" });
            }
            else if (comboBoxSporDali.SelectedIndex == 1)
            {
                comboBoxMevki.Items.Clear();
                comboBoxMevki.DisplayMember = "Text";
                comboBoxMevki.ValueMember = "Value";

                comboBoxMevki.Items.Add(new { Text = "Oyun Kurucu", Value = "Oyun Kurucu" });
                comboBoxMevki.Items.Add(new { Text = "Şutör", Value = "Şutör" });
                comboBoxMevki.Items.Add(new { Text = "Guard", Value = "Guard" });
                comboBoxMevki.Items.Add(new { Text = "Kısa Forvet", Value = "Kısa Forvet" });
                comboBoxMevki.Items.Add(new { Text = "Yüksek Post", Value = "Yüksek Post" });
            }
        }
    }
}
