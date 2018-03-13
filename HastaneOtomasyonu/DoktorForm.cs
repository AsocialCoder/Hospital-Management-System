using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class DoktorForm : HastaDoktor
    {
        SqlQuery SqlSorgu = SqlQuery.sqlnesne();
        Thread hastacagirthread;
        int randevuID;
        int hastaID;
        int eklenen;
        bool teshisyapildi = false;
        bool hastacagrildi = false;
        bool ilaceklendi = false;
        int doktorID;
        public DoktorForm()
        {
            InitializeComponent();

            Rectangle rect = new Rectangle(

         tabPage1.Left,

         tabPage1.Top,

         tabPage1.Width,

         tabPage1.Height);

         tabControl1.Region = new Region(rect);
        }

        public DoktorForm(int doktorID)
        {
            InitializeComponent();

            Rectangle rect = new Rectangle(

         tabPage1.Left,

         tabPage1.Top,

         tabPage1.Width,

         tabPage1.Height);

            tabControl1.Region = new Region(rect);

           this.doktorID = doktorID;
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void hasta_gecmis_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            gecmis(gecmisDatagrid, hastaID);
        }

        private void gecmisArabtn_Click(object sender, EventArgs e)
        {
            gecmisAra(gecmisDatagrid, gecmisDatetime, hastaID);
        }

        private void Lab_sonuc_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            labsonuc(labDatagrid,1);
        }

        private void labAraBtn_Click(object sender, EventArgs e)
        {
            labsonucAra(labDatagrid, labDatetime, hastaID);
        }

        private void hasta_list_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            hastagetir();
        }

        private void muayene_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

       

        private void hasta_cagir_btn_Click(object sender, EventArgs e)
        {
            hastacagir("0");
        }



        public void hastagetir()
        {
            SqlSorgu.datagridvericek(hastalardatagrid, "Select randevu.randevuID as ID , poliklinik.poliklinik as Poliklinik , hastaKayit.ad as Ad , hastaKayit.soyad as Soyad , randevu.randevuTarih as Randevu_Tarihi , randevu.randevuSaat as Saat , randevu.muayenedurum Muayene_durumu from ((randevu INNER JOIN hastaKayit ON randevu.kullaniciID=hastaKayit.KullaniciID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) where randevu.randevuTarih='" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND randevu.doktorID="+doktorID+" AND onay=1 ORDER BY randevu.saat ASC");

            hastalardatagrid.Columns[0].Width = 50;
            hastalardatagrid.Columns[1].Width = 100;
            hastalardatagrid.Columns[3].Width = 100;
            hastalardatagrid.Columns[5].Width = 50;
        }

        public void hastacagir(String durum)
        {
            SqlSorgu.connection.Open();
            SqlCommand bul = new SqlCommand("Select randevu.randevuID as ID , hastaKayit.kullaniciID as kulID, poliklinik.poliklinik as Poliklinik , hastaKayit.tc as tc ,hastaKayit.ad as Ad , hastaKayit.soyad as Soyad , randevu.randevuTarih as Randevu_Tarihi , randevu.randevuSaat as Saat  from ((randevu INNER JOIN hastaKayit ON randevu.kullaniciID=hastaKayit.KullaniciID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) where randevu.randevuTarih=@prmtr1 AND randevu.doktorID=@prmtrID AND randevu.saat<=@prmtr2 AND randevu.muayenedurum=@prmtr3 ORDER BY randevu.saat ASC", SqlSorgu.connection);
            bul.Parameters.AddWithValue("@prmtrID", doktorID);
            bul.Parameters.AddWithValue("@prmtr1", DateTime.Now.Date.ToString("yyyy-MM-dd"));
            bul.Parameters.AddWithValue("@prmtr2", float.Parse(DateTime.Now.ToString("HH.mm")));
            bul.Parameters.AddWithValue("@prmtr3", durum);
            SqlDataReader dr = bul.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hasta çağrıldı : \n "+dr["Ad"].ToString() + " " + dr["Soyad"].ToString()+"\n"+"Randevu Saati :"+dr["Saat"]+"\n ACİL ŞİFALAR DİLERİZ.");
                hastatc_txt.Text = dr["tc"].ToString();
                hastaadsoyad_txt.Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                randevuID = Convert.ToInt32(dr["ID"].ToString());
                hastaID = Convert.ToInt32(dr["kulID"].ToString());
            }
            else
            {
                MessageBox.Show("Hasta bulunmamaktadır.");
            }
            dr.Close();
            SqlSorgu.connection.Close();
            hastacagrildi = true;
            hastagetir();
            //eklenendatagrid.Rows.Clear();
            eklenendatagrid.Refresh();
            tahlil_txt.Text = "";
            ilac_txt.Text = "";
            teshis_txt.Text = "";
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
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Lütfen bir alan seçin.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Control.CheckForIllegalCrossThreadCalls = false;
            hastacagirthread = new Thread(() => hastacagir("0"));
            hastacagirthread.IsBackground = true;
            hastacagirthread.Start();
        }

    

        private void tahliliste(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && hastacagrildi==true)
            {
                SqlSorgu.connection.Open();
                SqlCommand ekle = new SqlCommand("insert into lab (randevuID,tahlil,durum) values (@prmtr1,@prmtr2,0)", SqlSorgu.connection);
                ekle.Parameters.AddWithValue("@prmtr1", randevuID);
                ekle.Parameters.AddWithValue("@prmtr2", tahlil_txt.Text);
                ekle.ExecuteNonQuery();
                SqlSorgu.connection.Close();
                istenilentahlilcek();
                hastadurumdegis("tahlil_bekleniyor");
                tahlil_txt.Text = "";
            }
        }

        public void istenilentahlilcek()
        {
            SqlSorgu.datagridvericek(eklenendatagrid, "Select lab.labID as ID , poliklinik.poliklinik as Poliklinik , doktor.ad as Doktor_ad , doktor.soyad as Doktor_soyad , randevu.randevuTarih as Randevu_Tarihi , lab.tahlil as Tahlil,  lab.sonuc as Tahlil_Sonucu  from (((randevu INNER JOIN doktor ON randevu.doktorID=doktor.doktorID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) INNER JOIN lab ON randevu.randevuID=lab.randevuID) where lab.randevuID=" + randevuID + " AND lab.durum=0 ORDER BY lab.labID DESC ");
            eklenendatagrid.Columns[0].Width = 50;
            eklenendatagrid.Columns[1].Width = 100;
            eklenendatagrid.Columns[3].Width = 100;
            eklenendatagrid.Columns[4].Width = 100;
            eklenen = 0;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = SqlSorgu.alansec(eklenendatagrid);
            if(ID!=0)
            {
                if(eklenen==0)
                {
                    SqlSorgu.connection.Open();
                    SqlCommand tahlilsil = new SqlCommand("Delete from lab where labID=@prmtrID AND durum=0", SqlSorgu.connection);
                    tahlilsil.Parameters.AddWithValue("@prmtrID", ID);
                    tahlilsil.ExecuteNonQuery();
                    SqlSorgu.connection.Close();
                    istenilentahlilcek();
                }
                if(eklenen==1)
                {
                    SqlSorgu.connection.Open();
                    SqlCommand ilacsil = new SqlCommand("Delete from ilaclar where ilacID=@prmtrID", SqlSorgu.connection);
                    ilacsil.Parameters.AddWithValue("@prmtrID", ID);
                    ilacsil.ExecuteNonQuery();
                    SqlSorgu.connection.Close();
                    ilacgetir();
                }
                if(eklenen==2)
                {
                    SqlSorgu.connection.Open();
                    SqlCommand ilacsil = new SqlCommand("Delete from muayene where muayeneID=@prmtrID", SqlSorgu.connection);
                    ilacsil.Parameters.AddWithValue("@prmtrID", ID);
                    ilacsil.ExecuteNonQuery();
                    SqlSorgu.connection.Close();
                    teshisyapildi=false;
                    teshisgetir();
                }
            }
        }

        private void ilacekle(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && hastacagrildi==true)
            {
                SqlSorgu.connection.Open();
                SqlCommand teshisekle = new SqlCommand("insert into ilaclar (randevuID,ilac,adet) values (@prmtrID,@prmtr1,1)", SqlSorgu.connection);
                teshisekle.Parameters.AddWithValue("@prmtrID", randevuID);
                teshisekle.Parameters.AddWithValue("@prmtr1", ilac_txt.Text);
                teshisekle.ExecuteNonQuery();
                SqlSorgu.connection.Close();
                ilaceklendi = true;
                ilacgetir();
                hastadurumdegis("muayene_edildi");
                ilac_txt.Text = "";
            }
        }

        public void ilacgetir()
        {
            SqlSorgu.datagridvericek(eklenendatagrid, "Select ilacID as ID , ilac as İlaç , adet as Adet from ilaclar where randevuID=" + randevuID + "");
            eklenendatagrid.Columns[0].Width = 50;
            eklenendatagrid.Columns[1].Width = 400;
            eklenendatagrid.Columns[2].Width = 100;
            eklenen = 1;
        }

        private void teshisekle(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter && hastacagrildi==true)
           {
               if (teshisyapildi == false)
               {
                   SqlSorgu.connection.Open();
                   SqlCommand teshisekle = new SqlCommand("insert into muayene (randevuID,teshis) values (@prmtrID,@prmtr1)", SqlSorgu.connection);
                   teshisekle.Parameters.AddWithValue("@prmtrID", randevuID);
                   teshisekle.Parameters.AddWithValue("@prmtr1", teshis_txt.Text);
                   teshisekle.ExecuteNonQuery();
                   SqlSorgu.connection.Close();
                   teshisyapildi = true;
                   teshisgetir();
                   hastadurumdegis("muayene_edildi");
                   teshis_txt.Text = "";
               }
               else
               {
                   MessageBox.Show("Zaten bir teşhis yapıldı.");
                   teshisgetir();
               }
           }
           
        }

        public void teshisgetir()
        {
            SqlSorgu.datagridvericek(eklenendatagrid, "Select muayeneID as ID , teshis as Teşhis from muayene where randevuID="+randevuID+"");
            eklenendatagrid.Columns[0].Width = 50;
            eklenendatagrid.Columns[1].Width = 500;
            eklenen = 2;
        }

        Font font = new Font("Verdana", 16, FontStyle.Bold);
        Font font2 = new Font("Verdana", 14);
        SolidBrush brush = new SolidBrush(Color.Black);

        Image image = Image.FromFile("özkardeşlerlogo.png");
        Pen pen = new Pen(Color.Black);
        private void recetePrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (ilaceklendi == true && teshisyapildi == true && hastacagrildi == true)
            {
                SqlSorgu.connection.Open();

                SqlCommand bilgi_cek = new SqlCommand("select hastaKayit.tc as tc , hastaKayit.ad as ad , hastaKayit.soyad as soyad, poliklinik.poliklinik as poliklinik , doktor.ad as dad , doktor.soyad as dsoyad , randevu.randevuTarih as tarih  from ((( randevu INNER JOIN hastaKayit ON randevu.kullaniciID=hastaKayit.kullaniciID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) INNER JOIN doktor ON randevu.doktorID=doktor.doktorID) where randevuID=@prmtrID ", SqlSorgu.connection);
                bilgi_cek.Parameters.AddWithValue("@prmtrID", randevuID);
                SqlDataReader bilgi_oku = bilgi_cek.ExecuteReader();

                StringFormat sFormat = new StringFormat();
                sFormat.Alignment = StringAlignment.Near;
                int satir = 460;
                if (bilgi_oku.Read())
                {
                    e.Graphics.DrawImage(image, 0, 0, 300, 350);
                    e.Graphics.DrawString("REÇETE", font, brush, 400, 60);
                    e.Graphics.DrawString("TC Kimlik No : " + bilgi_oku["tc"], font, brush, 300, 130);
                    e.Graphics.DrawString("Hastanın Adı Soyadı : " + bilgi_oku["ad"] + " " + bilgi_oku["soyad"], font, brush, 300, 180);
                    e.Graphics.DrawString("Poliklinik : " + bilgi_oku["poliklinik"], font, brush, 300, 230);
                    e.Graphics.DrawString("Doktor Adı Soyadı : " + bilgi_oku["dad"] + " " + bilgi_oku["dsoyad"], font, brush, 300, 280);
                    e.Graphics.DrawString("Randevu Tarihi : " + bilgi_oku["tarih"], font, brush, 300, 330);
                    e.Graphics.DrawString("     İlaç                                                                Adet    ", font, brush, 70, 400);
                    e.Graphics.DrawLine(pen, 90, 440, 800, 440);
                    bilgi_oku.Close();

                    SqlCommand ilac_cek = new SqlCommand("select * from ilaclar where randevuID=@prmtrID ", SqlSorgu.connection);
                    ilac_cek.Parameters.AddWithValue("@prmtrID", randevuID);
                    SqlDataReader ilac_oku = ilac_cek.ExecuteReader();
                    while (ilac_oku.Read())
                    {
                        e.Graphics.DrawString(ilac_oku["ilac"] + "                                                             " + ilac_oku["adet"], font2, brush, 100, satir);
                        satir += 40;
                    }
                    ilac_oku.Close();
                    SqlSorgu.connection.Close();
                }

            }

        }

        private void receteyazdir_btn_Click(object sender, EventArgs e)
        {
            if (ilaceklendi == true && teshisyapildi == true && hastacagrildi == true)
            {
                recetePreview.ShowDialog();
            }
        }


        public void hastadurumdegis(String durum)
        {
            SqlSorgu.connection.Open();
            SqlCommand muayenedurum = new SqlCommand("update randevu set muayenedurum=@prmtr1 where randevuID=@prmtrID",SqlSorgu.connection);
            muayenedurum.Parameters.AddWithValue("@prmtr1",durum);
            muayenedurum.Parameters.AddWithValue("@prmtrID", randevuID);
            muayenedurum.ExecuteNonQuery();
            SqlSorgu.connection.Close();
        }

        private void tahlilcagir_btn_Click(object sender, EventArgs e)
        {
            hastacagir("tahlil_bekleniyor");
            hastagetir();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            GirisForm girisform = new GirisForm();
            this.Hide();
            girisform.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void hastatc_txt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
