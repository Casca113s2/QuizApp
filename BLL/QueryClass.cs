using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    class QueryClass
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Casca\Desktop\.NETProject\QuizApp\BLL\QUIZ.mdf;Integrated Security=True";
        SqlConnection connection;

        public QueryClass()
        {
            connection = new SqlConnection(connectionString);
        }

        public System.Data.DataTable LoadGridTable(string sql)
        {
            SqlDataAdapter dat_Grid_TB = new SqlDataAdapter(sql, conn);
            DataTable dt_Grid_TB = new DataTable();
            dat_Grid_TB.Fill(dt_Grid_TB);
            return dt_Grid_TB;
        }

        public void THEM_SUA_XOA_SV(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                int ket_qua = comm.ExecuteNonQuery();
                if (ket_qua >= 1)
                {
                    MessageBox.Show("Thanh cong");
                }
                else MessageBox.Show("Loi try.Chua nhap ma.That bai");
            }
            catch (Exception)
            {
                MessageBox.Show("Loi catch.Cau lenh sql bi sai");
            }
            finally
            {
                conn.Close();
            }
            conn.Close();
        }

        public int DEM(string sql)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }

    }
}
