using MetroFramework.Forms;
using MetroFramework;
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

namespace HastaneOtomasyonu
{
    public partial class UyeOl : MetroFramework.Forms.MetroForm
    {
        public UyeOl()
        {

            InitializeComponent();
        }

        private void UyeOl_Load(object sender, EventArgs e)
        {
            cinsiyetCmb.Items.Add("Kadın");
            cinsiyetCmb.Items.Add("Erkek");
            cinsiyetCmb.SelectedIndex = 0;
        }

        SqlConnection baglanti = new SqlConnection("Data Source =.; Initial Catalog = hastaneDB; Integrated Security = True; Pooling = False");

        Kontrol kontrol = new Kontrol();


        private void metroTile1_Click(object sender, EventArgs e)
        {

            string tc = tcNoTxt.Text;
            string sifre = sifreTxt.Text;
            string ad = adTxt.Text;
            string soyad = soyadTxt.Text;
            string cinsiyet = cinsiyetCmb.SelectedItem.ToString();
            string anne = anaTxt.Text;
            string baba = babaTxt.Text;
            string tel = telefonTxt.Text;
            string mail = mailTxt.Text;


            baglanti.Open();
            string kontrol = "SELECT * FROM hastaKayit WHERE tc ='" + tc + "'";
            SqlCommand kont = new SqlCommand(kontrol, baglanti);

            SqlDataReader okuyucu = kont.ExecuteReader();

            if (okuyucu.Read())
            {
                MessageBox.Show("Böyle bir kullanıcı zaten var");
            }
            else if (ad != "" && soyad != "" && cinsiyet != null && anne != "" && baba != "" && tel != "" && mail != "" && tcNoTxt.Text.Length == 11)
            {
                okuyucu.Close();
                string komut = "INSERT INTO hastaKayit(tc,sifre,ad,soyad,cinsiyet,anne,baba,telefon,email) " +
          "VALUES('" + tc + "','" + sifre + "','" + ad + "','" + soyad + "','" + cinsiyet + "','" + anne + "','" + baba + "','" + tel + "','" + mail + "')";
                SqlCommand cmd = new SqlCommand(komut, baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eklendi");
                okuyucu.Close();

            }
            else
            {
                MessageBox.Show("Alanları Doğru Doldurduğunuzdan Emin Olun!");
            }


            tcNoTxt.Text = "";
            adTxt.Text = "";
            soyadTxt.Text = "";
            anaTxt.Text = "";
            babaTxt.Text = "";
            telefonTxt.Text = "";
            mailTxt.Text = "";
        }

        private void tcNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            kontrol.karakterEngelle(sender, e);


        }



        private void AdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.sayiEngelle(e);
        }



        private void soyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.sayiEngelle(e);
        }

        private void anaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.sayiEngelle(e);
        }

        private void babaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            kontrol.sayiEngelle(e);
        }

        private void telefonTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            kontrol.karakterEngelle(sender, e);


        }






        private void mailTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
