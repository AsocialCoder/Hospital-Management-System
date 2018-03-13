using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source =.; Initial Catalog = hastaneDB; Integrated Security = True; Pooling = False");
        Kontrol kontrol = new Kontrol();
        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand bul = new SqlCommand("select * FROM poliklinik", baglanti);
                SqlDataReader dr = bul.ExecuteReader();

                while (dr.Read())
                {
                    poliklinikCmb.Items.Add(new ComboBoxItem(dr["poliklinik"].ToString(), dr["poliklinikID"].ToString()));
                }
                dr.Close();
                baglanti.Close();
            }
            catch (Exception exce)
            {
                MessageBox.Show("Something happend" + exce);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (kullaniciVarmi("doktor", "tc") == false)
            {
                if (adTxt.Text != "" && soyadTxt.Text != "" && poliklinikCmb.SelectedItem.ToString() != "")
                {
                    baglanti.Open();
                    int poliklinik_id = Convert.ToInt16((((ComboBoxItem)poliklinikCmb.SelectedItem).HiddenValue));
                    SqlCommand komut = new SqlCommand("INSERT INTO doktor(poliklinikID,tc,ad,soyad,sifre) VALUES('" + poliklinik_id + "','" + tcTxt.Text + "','" + adTxt.Text + "','" + soyadTxt.Text + "','" + tcTxt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Doktor Eklendi");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurun...");
                }

            }



        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (kullaniciVarmi("Sekreter", "sekreterTC") == false)
            {
                if (adTxt.Text != "" && soyadTxt.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO Sekreter(sekreterTC,sekreterSifre,sekreterAd,sekreterSoyad) VALUES('" + tcTxt.Text + "','" + tcTxt.Text + "','" + adTxt.Text + "','" + soyadTxt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Sekreter Eklendi");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurun...");
                }
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (kullaniciVarmi("laborant", "laborantTC") == false)
            {
                if (adTxt.Text != "" && soyadTxt.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO laborant(laborantTC,laborantSifre,laborantAd,laborantSoyad) VALUES('" + tcTxt.Text + "','" + tcTxt.Text + "','" + adTxt.Text + "','" + soyadTxt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Laborant Eklendi");
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurun...");
                }

            }


        }

        private void tcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.karakterEngelle(sender, e);
        }

        private void adTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.sayiEngelle(e);
        }

        private void soyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.sayiEngelle(e);
        }

        public Boolean kullaniciVarmi(string table, string kolon)
        {
            baglanti.Open();
            string kontrol = "SELECT * FROM " + table + " WHERE " + kolon + " ='" + tcTxt.Text + "'";
            SqlCommand kont = new SqlCommand(kontrol, baglanti);

            SqlDataReader okuyucu = kont.ExecuteReader();

            if (okuyucu.Read())
            {
                errorProvider1.SetError(tcTxt, "Böyle bir kullanıcı zaten var");
                okuyucu.Close();
                baglanti.Close();
                return true;
            }
            else
            {
                okuyucu.Close();
                baglanti.Close();
                return false;
            }

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            GirisForm girisform = new GirisForm();
            this.Hide();
            girisform.ShowDialog();
            this.Close();
            this.Dispose();
        }

    }
}
