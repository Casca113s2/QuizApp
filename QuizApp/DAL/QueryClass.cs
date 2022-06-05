using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.DAL
{
    class QueryClass
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Casca\Desktop\.NETProject\QuizApp\QuizApp\QUIZ.mdf;Integrated Security=True";
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

        //public void executeNonQuery(string sql, string successMessage, string failMessage)
        //{
        //    SqlCommand command = new SqlCommand(sql, connection);
        //    connection.Open();

        //    try
        //    {
        //        int result = command.ExecuteNonQuery();

        //        if (result >= 1)
        //        {
        //            MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else MessageBox.Show(failMessage, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        MessageBox.Show("SQL Query Problem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    connection.Close();
        //}

        public void executeNonQuery(SqlCommand command, string successMessage, string failMessage)
        {
            command.Connection = connection;
            connection.Open();

            try
            {
                int result = command.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show(failMessage, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("SQL Query Problem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        public int executeScalar(SqlCommand command)
        {
            connection.Open();
            command.Connection = connection;
            int result = (int) command.ExecuteScalar();
            connection.Close();
            return result;
        }
    }
}
