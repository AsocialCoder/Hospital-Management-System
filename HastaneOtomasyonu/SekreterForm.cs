
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
    public partial class SekreterForm : MetroFramework.Forms.MetroForm
    {
        public SekreterForm()
        {
            InitializeComponent();

            Rectangle rect = new Rectangle(
             tabPage1.Left,
             tabPage1.Top,
             tabPage1.Width,
             tabPage1.Height);

            tabControl1.Region = new Region(rect);
        }


        private void metroTile1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
        SqlConnection baglanti = new SqlConnection("Data Source =.; Initial Catalog = hastaneDB; Integrated Security = True; Pooling = False");
        private void SekreterForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kadın");
            comboBox1.Items.Add("Erkek");
            comboBox1.SelectedIndex = 0;


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

        private void tcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (tcTxt.Text.Length == 11)
            {
                e.Handled = true;
            }
        }

        private void adTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void soyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void anaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void babaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void telTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (telTxt.Text.Length == 11)
            {
                e.Handled = true;
            }
        }


        int hasta_id;

        private void metroTile3_Click(object sender, EventArgs e)
        {
            string tc = tcTxt.Text;
            string sifre = tcTxt.Text;
            string ad = adTxt.Text;
            string soyad = soyadTxt.Text;
            string cinsiyet = comboBox1.SelectedItem.ToString();
            string anne = anaTxt.Text;
            string baba = babaTxt.Text;
            string tel = telTxt.Text;
            string mail = mailTxt.Text;

            baglanti.Open();
            string kontrol = "SELECT * FROM hastaKayit WHERE tc ='" + tc + "'";
            SqlCommand kont = new SqlCommand(kontrol, baglanti);

            SqlDataReader okuyucu = kont.ExecuteReader();

            if (okuyucu.Read())
            {
                MessageBox.Show("Böyle bir kullanıcı zaten var");
            }
            else if (ad != "" && soyad != "" && cinsiyet != null && anne != "" && baba != "" && tel != "" && mail != "" && tcTxt.Text.Length == 11)
            {
                okuyucu.Close();
                string komut = "INSERT INTO hastaKayit(tc,sifre,ad,soyad,cinsiyet,anne,baba,telefon,email) " +
          "VALUES('" + tc + "','" + sifre + "','" + ad + "','" + soyad + "','" + cinsiyet + "','" + anne + "','" + baba + "','" + tel + "','" + mail + "')";
                SqlCommand cmd = new SqlCommand(komut, baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eklendi");

            }
            else
            {
                MessageBox.Show("Alanları Doğru Doldurduğunuzdan Emin Olun!");
            }

            string hasta_query = "SELECT * FROM hastaKayit WHERE tc = '" + tc + "'";
            SqlCommand hastaKmt = new SqlCommand(hasta_query, baglanti);
            SqlDataReader dr_hasta = hastaKmt.ExecuteReader();
            if (dr_hasta.Read())
            {
                hasta_id = Convert.ToInt16(dr_hasta["hastaID"]);
                dr_hasta.Close();
            }

            int poliklinik_id = Convert.ToInt16((((ComboBoxItem)poliklinikCmb.SelectedItem).HiddenValue));
            int doktor_id = Convert.ToInt16((((ComboBoxItem)doktorCmb.SelectedItem).HiddenValue));
            string tarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string saat = saatCmb.SelectedItem.ToString();
            string randevu_query = "INSERT INTO randevu(kullaniciID,doktorId,poliklinikID,randevuTarih,randevuSaat,onay) VALUES (@hastaid,'" + doktor_id + "','" + poliklinik_id + "','" + tarih + "','" + saat + "',1)";
            SqlCommand randevu_kayit = new SqlCommand(randevu_query, baglanti);
            randevu_kayit.Parameters.AddWithValue("@hastaid", hasta_id);
            randevu_kayit.ExecuteNonQuery();
            MessageBox.Show("Randevu Kayıt Edildi");

        }

        private void doktorCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            saatCmb.Items.Clear();
            int dakika = 15, saat = 9;
            saatCmb.Items.Add(saat + ":00");
            while (saat != 17)
            {
                if (dakika == 60)
                {
                    dakika = 00;
                    saat++;

                    saatCmb.Items.Add(saat + ":" + dakika + "0");
                }
                else
                {
                    saatCmb.Items.Add(saat + ":" + dakika);
                    dakika += 15;
                }
            }

        }

        private void poliklinikCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                doktorCmb.Items.Clear();
                baglanti.Open();
                SqlCommand bul = new SqlCommand("select * FROM doktor WHERE poliklinikID=@prmtrID", baglanti);
                bul.Parameters.AddWithValue("@prmtrID", Convert.ToInt32(((ComboBoxItem)poliklinikCmb.SelectedItem).HiddenValue));
                SqlDataReader dr = bul.ExecuteReader();
                while (dr.Read())
                {
                    doktorCmb.Items.Add(new ComboBoxItem(dr["ad"] + " " + dr["soyad"], dr["doktorID"].ToString()));

                }
                baglanti.Close();
            }
            catch (Exception exce)
            {
                MessageBox.Show("Something happend" + exce);
            }


        }



        SqlQuery sql = SqlQuery.sqlnesne();

        private void metroTile5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            string onay_query = "UPDATE randevu SET onay = 1 WHERE randevuID = @paramID";
            baglanti.Open();
            SqlCommand onay_cmd = new SqlCommand(onay_query, baglanti);
            onay_cmd.Parameters.AddWithValue("@paramID", id);
            onay_cmd.ExecuteNonQuery();

            MessageBox.Show("Randevu Onaylandı");
            onaylanmamisRandevu();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            onaylanmamisRandevu();
        }

        public void onaylanmamisRandevu()
        {
            sql.datagridvericek(dataGridView2, "SELECT randevu.randevuID as ID,doktor.ad as Doktor_Adı,doktor.soyad as Doktor_Soyadı,poliklinik.poliklinik as Poliklinik,hastaKayit.ad as Hasta_Adı,hastaKayit.soyad as Hasta_Soyad,randevu.randevuTarih as Randevu_Tarih,randevu.randevuSaat as Randevu_Saati " +
                "FROM randevu " +
                "INNER JOIN hastaKayit ON randevu.kullaniciID = hastaKayit.kullaniciID  " +
                "INNER JOIN poliklinik ON randevu.poliklinikID = poliklinik.poliklinikID " +
                "INNER JOIN doktor ON randevu.doktorID = doktor.doktorID WHERE hastaKayit.tc = '" + araTxt.Text + "' AND onay = 0");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            GirisForm girisform = new GirisForm();
            this.Hide();
            girisform.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }


}
