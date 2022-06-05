using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DAL
{
    public class RegisterDAL
    {
        QueryClass queryClass;

        public RegisterDAL()
        {
            queryClass = new QueryClass();
        }

        public void registerUser(string username, string password, string name, DateTime birthDay, string address, string phone, string userType)
        {
            SqlCommand insertCommand = new SqlCommand("INSERT INTO USERINFO VALUES(@username, @password, @name, CONVERT(Date, @birthDay, 103), @address, @phone, @userType)");
            insertCommand.Parameters.AddWithValue("@username", username);
            insertCommand.Parameters.AddWithValue("@password", password);
            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@birthDay", birthDay.ToString());
            insertCommand.Parameters.AddWithValue("@address", address);
            insertCommand.Parameters.AddWithValue("@phone", phone);
            insertCommand.Parameters.AddWithValue("@userType", userType);

            string successMessage = "Register Successfully.";
            string failMessage = "Register Fail.";

            queryClass.executeNonQuery(insertCommand, successMessage, failMessage);
        }
    }
}
