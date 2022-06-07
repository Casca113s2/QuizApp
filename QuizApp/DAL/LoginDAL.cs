using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DAL
{
    class LoginDAL
    {
        QueryClass queryClass;

        public LoginDAL()
        {
            queryClass = new QueryClass();
        }

        public int login(string username, string password, string userType)
        {
            SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM USERINFO WHERE USERNAME = @username AND PASSWORD = @password AND USERTYPE = @userType");
            countCommand.Parameters.AddWithValue("@username", username);
            countCommand.Parameters.AddWithValue("@password", password);
            countCommand.Parameters.AddWithValue("@userType", userType);

            return queryClass.executeScalar(countCommand);
        }


    }
}
