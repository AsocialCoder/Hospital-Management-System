using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public class HastaDoktor : MetroFramework.Forms.MetroForm
    {
         SqlQuery SqlSorgu = SqlQuery.sqlnesne();
      

        public void gecmis(DataGridView datagrid, int kullaniciID)
        {
            SqlSorgu.datagridvericek(datagrid, "Select randevu.randevuID as ID , poliklinik.poliklinik as Poliklinik , doktor.ad as Doktor_ad , doktor.soyad as Doktor_soyad , randevu.randevuTarih as Randevu_Tarihi , randevu.randevuSaat as Saat  from ((randevu INNER JOIN doktor ON randevu.doktorID=doktor.doktorID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) where randevu.kullaniciID="+kullaniciID+" ORDER BY randevu.randevuID DESC");

            datagrid.Columns[0].Width = 50;
            datagrid.Columns[1].Width = 100;
            datagrid.Columns[3].Width = 100;
        }

        public void gecmisAra(DataGridView datagrid, DateTimePicker date , int kullaniciID)
        {
            SqlSorgu.datagridvericek(datagrid, "Select randevu.randevuID as ID , poliklinik.poliklinik as Poliklinik , doktor.ad as Doktor_ad , doktor.soyad as Doktor_soyad , randevu.randevuTarih as Randevu_Tarihi , randevu.randevuSaat as Saat  from ((randevu INNER JOIN doktor ON randevu.doktorID=doktor.doktorID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) where randevu.kullaniciID="+kullaniciID+" AND randevu.randevuTarih='" + date.Value.ToString("yyyy-MM-dd") + "' ORDER BY randevu.randevuID DESC");

            datagrid.Columns[0].Width = 50;
            datagrid.Columns[1].Width = 100;
            datagrid.Columns[3].Width = 100;
        }

        public void labsonuc(DataGridView datagrid, int kullaniciID)
        {
            SqlSorgu.datagridvericek(datagrid, "Select lab.labID as ID , poliklinik.poliklinik as Poliklinik , doktor.ad as Doktor_ad , doktor.soyad as Doktor_soyad , randevu.randevuTarih as Randevu_Tarihi ,  lab.sonuc as Tahlil_Sonucu  from (((randevu INNER JOIN doktor ON randevu.doktorID=doktor.doktorID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) INNER JOIN lab ON randevu.randevuID=lab.randevuID) where randevu.kullaniciID="+kullaniciID+" AND lab.durum=1");
            datagrid.Columns[0].Width = 50;
            datagrid.Columns[1].Width = 100;
            datagrid.Columns[3].Width = 100;
            datagrid.Columns[4].Width = 100;
        }

        public void labsonucAra(DataGridView datagrid, DateTimePicker date, int kullaniciID)
        {
            SqlSorgu.datagridvericek(datagrid, "Select lab.labID as ID , poliklinik.poliklinik as Poliklinik , doktor.ad as Doktor_ad , doktor.soyad as Doktor_soyad , randevu.randevuTarih as Randevu_Tarihi ,  lab.sonuc as Tahlil_Sonucu  from (((randevu INNER JOIN doktor ON randevu.doktorID=doktor.doktorID) INNER JOIN poliklinik ON randevu.poliklinikID=poliklinik.poliklinikID) INNER JOIN lab ON randevu.randevuID=lab.randevuID) where randevu.kullaniciID="+kullaniciID+" AND lab.durum=1 AND randevu.randevuTarih='" + date.Value.ToString("yyyy-MM-dd") + "'");
            datagrid.Columns[0].Width = 50;
            datagrid.Columns[1].Width = 100;
            datagrid.Columns[3].Width = 100;
            datagrid.Columns[4].Width = 100;
        }


    }
}
