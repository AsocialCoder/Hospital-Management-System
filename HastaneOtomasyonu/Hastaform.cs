using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{

    public partial class HastaForm : HastaDoktor
    {
       
        SqlQuery SqlSorgu = SqlQuery.sqlnesne();
        int hastaID;
        
        public HastaForm()
        {
            InitializeComponent();

           Rectangle rect = new Rectangle (

           tabPage1.Left,

           tabPage1.Top,

           tabPage1.Width,

           tabPage1.Height);

        tabControl1.Region = new Region(rect);
        }
        public HastaForm(int hastaID)
        {
            this.hastaID = hastaID;
            InitializeComponent();

            Rectangle rect = new Rectangle(

          tabPage1.Left,

          tabPage1.Top,

          tabPage1.Width,

          tabPage1.Height);

            tabControl1.Region = new Region(rect);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            acilsifalartimer.Start();
            acilsifalarlabel.Text = "ACİL ŞİFALAR DİLERİZ...     ";
            try
            {
                SqlSorgu.connection.Open();
                SqlCommand bul = new SqlCommand("select * FROM poliklinik", SqlSorgu.connection);
                SqlDataReader dr = bul.ExecuteReader();

                while (dr.Read())
                {
                    poliklinikCombo.Items.Add(new ComboBoxItem(dr["poliklinik"].ToString(), dr["poliklinikID"].ToString()));
                }
                dr.Close();
                SqlSorgu.connection.Close();
            }
            catch(Exception exce)
            {
                MessageBox.Show("Something happend" + exce);
            }
            
        }              

        private void randevuBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void gecmisBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            gecmis(gecmisDatagrid, hastaID);               
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gecmis(gecmisDatagrid, hastaID);
        }


        private void gecmisArabtn_Click(object sender, EventArgs e)
        {
            gecmisAra(gecmisDatagrid, gecmisDatetime, hastaID);
        }
       

        private void LabBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            labsonuc(labDatagrid, hastaID);
           
        }

        private void yenileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labsonuc(labDatagrid, hastaID);
        }

        private void labAraBtn_Click(object sender, EventArgs e)
        {
            labsonucAra(labDatagrid, labDatetime, hastaID);
        }

        

        private void poliklinikCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorCombo.Items.Clear();
            doktorCombo.Text = "";
            try
            {
                SqlSorgu.connection.Open();
                SqlCommand bul = new SqlCommand("select * FROM doktor WHERE poliklinikID=@prmtrID", SqlSorgu.connection);
                bul.Parameters.AddWithValue("@prmtrID", Convert.ToInt32(((ComboBoxItem)poliklinikCombo.SelectedItem).HiddenValue));
                SqlDataReader dr = bul.ExecuteReader();
                while (dr.Read())
                {
                    doktorCombo.Items.Add(new ComboBoxItem(dr["ad"] + " " + dr["soyad"], dr["doktorID"].ToString()));
                    
                }
                dr.Close();
                SqlSorgu.connection.Close();
            }
            catch (Exception exce)
            {
                MessageBox.Show("Something happend" + exce);
            }
        }

        

        private void doktorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            saatduzenle();
        }


        public void saatduzenle()
        {
            saatCombo.Items.Clear();
            int dakika = 15, saat = 9;
            saatCombo.Items.Add(saat + ".00");
            while (saat != 17)
            {
                if (dakika == 60)
                {
                    dakika = 00;
                    saat++;
                    if (saat != 12)
                        saatCombo.Items.Add(saat + "." + dakika + "0");
                }
                else
                {
                    if (saat != 12)
                        saatCombo.Items.Add(saat + "." + dakika);
                }

                dakika += 15;
            }

            SqlSorgu.connection.Open();
            SqlCommand bul = new SqlCommand("select * FROM randevu WHERE randevuTarih=@prmtr1 AND doktorID=@prmtrID", SqlSorgu.connection);
            bul.Parameters.AddWithValue("@prmtrID", Convert.ToInt32(((ComboBoxItem)doktorCombo.SelectedItem).HiddenValue));
            bul.Parameters.AddWithValue("@prmtr1", tarihDatepicker.Value.ToString("yyyy-MM-dd"));
            SqlDataReader dr = bul.ExecuteReader();
            while (dr.Read())
            {
                saatCombo.Items.Remove(dr["randevuSaat"]);

            }
            dr.Close();
            SqlSorgu.connection.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
            if (poliklinikCombo.Text != "" && doktorCombo.Text != "" && tarihDatepicker.Text != "" && saatCombo.Text != "")
            {
                SqlSorgu.connection.Open();
                SqlCommand ekle = new SqlCommand("insert into randevu (kullaniciID,poliklinikID,doktorID,randevuTarih,randevuSaat,onay,muayenedurum,saat) values (@prmtr1,@prmtr2,@prmtr3,@prmtr4,@prmtr5,@prmtr6,0,@prmtr5)", SqlSorgu.connection);
                ekle.Parameters.AddWithValue("@prmtr1", hastaID);
                ekle.Parameters.AddWithValue("@prmtr2", Convert.ToInt32(((ComboBoxItem)poliklinikCombo.SelectedItem).HiddenValue));
                ekle.Parameters.AddWithValue("@prmtr3", Convert.ToInt32(((ComboBoxItem)doktorCombo.SelectedItem).HiddenValue));
                ekle.Parameters.AddWithValue("@prmtr4", tarihDatepicker.Value.ToString("yyyy-MM-dd"));
                ekle.Parameters.AddWithValue("@prmtr5", saatCombo.Text);
                ekle.Parameters.AddWithValue("@prmtr6", "0");
                ekle.ExecuteNonQuery();
                SqlSorgu.connection.Close();
                MessageBox.Show("Randevu başarılı bir şekilde alındı");
                doktorCombo.Items.Clear();
                saatCombo.Items.Clear();
                doktorCombo.Text = "";
                saatCombo.Text = "";

            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
            
           
        }       
        

        private void detaylıBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID=SqlSorgu.alansec(gecmisDatagrid);
            if(ID!=0)
            {
                GecmisDetayForm gecmis = new GecmisDetayForm(ID);
                gecmis.Show();
            }                
           
        }

        private void tahliliGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String uzanti = "0";
            try
            {
                uzanti = labDatagrid.SelectedRows[0].Cells[5].Value.ToString();
                if (uzanti == "0")
                {
                    MessageBox.Show("Lütfen alan seçin.");
                }
                else
                {
                    Process.Start(uzanti);
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Beklenmedik bir hata! Resim açılamıyor!");
            }  
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Lütfen bir alan seçin.");
            }
          
        }

        private void acilsifalartick(object sender, EventArgs e)
        {
            acilsifalarlabel.Text = acilsifalarlabel.Text.Substring(1) + acilsifalarlabel.Text.Substring(0, 1);
        }

        private void tarih_valuechanged(object sender, EventArgs e)
        {
            saatduzenle();
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
