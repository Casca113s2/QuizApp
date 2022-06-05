using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    class QueryClass
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Casca\Desktop\.NETProject\QuizApp\DAL\QUIZ.mdf;Integrated Security=True";
        SqlConnection connection;

        public QueryClass()
        {
            connection = new SqlConnection(connectionString);
        }

        public System.Data.DataTable loadGridTable(string sql)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            DataTable dataGridTable = new DataTable();
            dataAdapter.Fill(dataGridTable);
            return dataGridTable;
        }

        public void executeNonQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            try
            {
                int result = command.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Success!");
                }
                else MessageBox.Show("Try Error! Failure!");
            }
            catch (Exception)
            {
                MessageBox.Show("Catch Error! SQL Query Problem!");
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        public int countData(string sql)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            int result = (int)command.ExecuteScalar();
            connection.Close();
            return result;
        }


    }
}
