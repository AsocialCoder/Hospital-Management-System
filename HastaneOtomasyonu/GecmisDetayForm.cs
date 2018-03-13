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
    public partial class GecmisDetayForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection("server=.;Database=hastaneDB;Integrated Security=true");
        private int ID;
        public GecmisDetayForm(int ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        public GecmisDetayForm()
        {
            InitializeComponent();
        }

        private void GecmisDetayForm_Load(object sender, EventArgs e)
        {
            
              connection.Open();
              SqlCommand bul = new SqlCommand("Select poliklinik.poliklinik as Poliklinik , doktor.ad as Doktor_ad , doktor.soyad as Doktor_soyad , randevu.randevuTarih as Randevu_Tarihi , randevu.randevuSaat as Randevu_Saat ,  muayene.teshis as Teşhis from (((randevu INNER JOIN muayene ON randevu.randevuID=muayene.randevuID) INNER JOIN doktor ON randevu.doktorID=doktor.doktorID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) where randevu.randevuID=@prmtrID", connection);
              bul.Parameters.AddWithValue("@prmtrID", ID);
              SqlDataReader dr = bul.ExecuteReader();

              if(dr.Read())
                {
                  polikliniklabel.Text=dr["Poliklinik"].ToString();
                  doktorlabel.Text=dr["Doktor_ad"].ToString()+dr["Doktor_soyad"].ToString();
                  tarihlabel.Text=dr["Randevu_Tarihi"].ToString();
                  saatlabel.Text=dr["Randevu_Saat"].ToString();
                  teshislabel.Text=dr["Teşhis"].ToString();
                  dr.Close();
                  SqlCommand ilacgetir = new SqlCommand("Select * from ilaclar where randevuID=@prmtrID", connection);
                  ilacgetir.Parameters.AddWithValue("@prmtrID", ID);
                  SqlDataReader dr2 = ilacgetir.ExecuteReader();

                  while(dr2.Read())
                  {
                      ilaclarlabel.Text += dr2["ilac"]+", ";
                  }


                  dr2.Close();
                }
              else
              {
                  MessageBox.Show("Randevuya gidilmemiştir");
              }


              dr.Close();       

            connection.Close();            
            
        }
    }
}
