using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    class SqlQuery
    {
        
        private static SqlQuery sql;
        public SqlConnection connection = new SqlConnection("server=.;Database=hastaneDB;Integrated Security=true");
        private SqlQuery()
        {

        }

        public static SqlQuery sqlnesne()
        {
            if (sql == null)
                sql = new SqlQuery();
            return sql;

        }

        public void datagridvericek(DataGridView gridview, string sorgu)
        {
            
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(sorgu, connection);  

            DataSet can = new DataSet();

            adaptor.Fill(can, "xx");

            gridview.DataSource = can.Tables[0];
            connection.Close();
        }

        public int alansec(DataGridView datagrid )
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(datagrid.SelectedRows[0].Cells[0].Value.ToString());
                if (ID == 0)
                {
                    MessageBox.Show("Lütfen alan seçin.");
                    return ID=0;
                }
                else
                {
                    return ID;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Lütfen bir alan seçin.");
                return ID = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu.");
                return ID = 0;
            }            
        }
    }
}
