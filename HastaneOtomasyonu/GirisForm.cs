using MetroFramework.Forms;
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
    public partial class GirisForm : MetroFramework.Forms.MetroForm
    {
        public GirisForm()
        {
            InitializeComponent();

        }
        SekreterForm sekreterform = new SekreterForm();
        Kontrol kontrol = new Kontrol();
        private void GirisForm_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            label1.Text = "ACİL ŞİFALAR DİLERİZ...   ACİL ŞİFALAR DİLERİZ...   ";
        }

        private void uyeOlBtn_Click(object sender, EventArgs e)
        {
            UyeOl uyeolform = new UyeOl();
            uyeolform.Show();
        }

        string tc;
        string sifre;

        SqlConnection baglanti = new SqlConnection("Data Source =.; Initial Catalog = hastaneDB; Integrated Security = True; Pooling = False");

        private void girisBtn_Click(object sender, EventArgs e)
        {

            //errorProvider1.SetError(tcTxt, "Tc 11");

            //sekreterform.Show();
            tc = tcTxt.Text;
            sifre = sifreTxt.Text;

            baglanti.Open();
            string hasta_komut = "SELECT * FROM hastaKayit WHERE TC = '" + tc + "'";
            SqlCommand kmt1 = new SqlCommand(hasta_komut, baglanti);
            SqlDataReader dr = kmt1.ExecuteReader();
            if (tc != "")
            {


                if (dr.Read())
                {
                    if (sifre != "")
                    {
                        if (dr["sifre"].ToString() == sifre)
                        {
                            HastaForm hastaform = new HastaForm(Convert.ToInt32(dr["kullaniciID"].ToString()));
                            this.Hide();
                            hastaform.ShowDialog();
                            this.Close();
                            this.Dispose();
                            
                        }
                        else
                        {
                            errorProvider1.SetError(sifreTxt, "Hatalı Şifre Girdiniz");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(sifreTxt, "Şifre Boş Bırakılamaz");
                    }

                    baglanti.Close();
                }
                else
                {
                    dr.Close();
                    string doktor_komut = "SELECT * FROM doktor WHERE TC = '" + tc + "'";
                    SqlCommand kmt2 = new SqlCommand(doktor_komut, baglanti);
                    SqlDataReader dr2 = kmt2.ExecuteReader();
                    if (dr2.Read())
                    {
                        if (sifre != "")
                        {
                            if (dr2["sifre"].ToString() == sifre)
                            {
                                DoktorForm doktorform = new DoktorForm(Convert.ToInt32(dr2["doktorID"].ToString()));
                                this.Hide();
                                doktorform.ShowDialog();
                                this.Close();
                                this.Dispose();

                            }
                            else
                            {
                                errorProvider1.SetError(sifreTxt, "Hatalı Şifre Girdiniz");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(sifreTxt, "Şifre Boş Bırakılamaz");
                        }


                    }
                    else
                    {
                        dr2.Close();
                        string sekreter_komut = "SELECT * FROM sekreter WHERE sekreterTC = '" + tc + "'";
                        SqlCommand kmt3 = new SqlCommand(sekreter_komut, baglanti);
                        SqlDataReader dr3 = kmt3.ExecuteReader();
                        if (dr3.Read())
                        {
                            if (sifre != "")
                            {
                                if (dr3["sekreterSifre"].ToString() == sifre)
                                {
                                    SekreterForm sekreterform = new SekreterForm();
                                    this.Hide();
                                    sekreterform.ShowDialog();
                                    this.Close();
                                    this.Dispose();
                                }
                                else
                                {
                                    errorProvider1.SetError(sifreTxt, "Hatalı Şifre Girdiniz");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(sifreTxt, "Şifre Boş Bırakılamaz");
                            }

                            baglanti.Close();
                        }
                        else
                        {

                            //laborant
                            dr3.Close();
                            string laborant_komut = "SELECT * FROM laborant WHERE laborantTC = '" + tc + "'";
                            SqlCommand kmt4 = new SqlCommand(laborant_komut, baglanti);
                            SqlDataReader dr4 = kmt4.ExecuteReader();
                            if (dr4.Read())
                            {
                                if (sifre != "")
                                {
                                    if (dr4["laborantSifre"].ToString() == sifre)
                                    {
                                        LabForm labform = new LabForm();
                                        this.Hide();
                                        labform.ShowDialog();
                                        this.Close();
                                        this.Dispose();
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(sifreTxt, "Hatalı Şifre Girdiniz");
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(sifreTxt, "Şifre Boş Bırakılamaz");
                                }

                                baglanti.Close();
                            }
                            else
                            {
                                string admin_tc = "11111111111";
                                string admin_sifre = "admin";
                                if (admin_sifre == sifre && tc == admin_tc)
                                {
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Böyle bir kullanıcı yoktur! ");
                                }
                            }
                        }
                    }
                }
                baglanti.Close();

            }
            else
            {
                errorProvider1.SetError(tcTxt, "TC Kimlik No Boş Bırakılamaz");
                baglanti.Close();
            }


        }

        private void tcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.karakterEngelle(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }
    }
}
