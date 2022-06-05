using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
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
            string sqlInsert = "INSERT INTO USERINFO VALUES('" + username + "', '" + password + "', N'" + name + "', CONVERT(date,'" + birthDay.ToString("dd/MM/yyyy") + "', 103), '" + address + "'), '" + phone + "', '" + userType + "')";

            queryClass.executeNonQuery(sqlInsert);
        }
    }
}
