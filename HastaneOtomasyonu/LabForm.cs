using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class LabForm : MetroFramework.Forms.MetroForm
    {
        SqlQuery SqlSorgu = SqlQuery.sqlnesne();
        public LabForm()
        {
            InitializeComponent();
        }

         public void Labgetir()
        {
          
            SqlSorgu.datagridvericek(labDatagrid,"Select lab.labID as ID , poliklinik.poliklinik as Poliklinik , doktor.ad as Doktor_ad , doktor.soyad as Doktor_soyad , randevu.randevuTarih as Randevu_Tarihi ,  lab.tahlil as Tahlil , lab.durum as Durum , lab.sonuc as Tahlil_Sonucu  from (((lab INNER JOIN randevu ON lab.randevuID=randevu.randevuID) INNER JOIN doktor ON randevu.doktorID=doktor.doktorID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID)");
            labDatagrid.Columns[0].Width = 50;
            labDatagrid.Columns[1].Width = 120;
            labDatagrid.Columns[3].Width = 100;
            labDatagrid.Columns[4].Width = 110;
            labDatagrid.Columns[5].Width = 120;
            labDatagrid.Columns[6].Width = 60;
        }

        private void LabForm_Load(object sender, EventArgs e)
        {
            Labgetir();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Labgetir();
        }   

        private void sonuçYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = SqlSorgu.alansec(labDatagrid);
            string dosyayolu="";
            if (ID != 0)
            {
                try
                {
                    OpenFileDialog dosya = new OpenFileDialog();
                    dosya.Filter = "Resim Dosyası |*.jpg;*.png";
                    dosya.ShowDialog();
                    dosyayolu = dosya.FileName;
                    File.Copy(dosyayolu, @"tahlilsonuc\" + ID + ".jpg");

                    SqlSorgu.connection.Open();
                    SqlCommand ekle = new SqlCommand("UPDATE lab set sonuc=@prmtr1 , durum=1 where labID=@prmtrID ", SqlSorgu.connection);
                    ekle.Parameters.AddWithValue("@prmtrID", ID);
                    ekle.Parameters.AddWithValue("@prmtr1", @"tahlilsonuc\" + ID + ".jpg");
                    ekle.ExecuteNonQuery();
                    SqlSorgu.connection.Close();
                    MessageBox.Show("Tahlil başarıyla yüklendi!");
                    Labgetir();
                }

                catch (IOException)
                {
                    DialogResult dialogResult = MessageBox.Show("Bu isimde tahlil sonucu bulunmaktadır. Üzerine yazmak istermisiniz", "Kopyalama hatası", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(@"tahlilsonuc\" + ID + ".jpg");
                        File.Copy(dosyayolu, @"tahlilsonuc\" + ID + ".jpg");
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        
                    }
                }
                catch(SystemException err)
                {
                    
                }
                catch(Exception err)
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu"+err);
                }
                    
               
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
