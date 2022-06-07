using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DAL
{
    class StudentViewGradeDAL
    {
        QueryClass queryClass;

        public StudentViewGradeDAL()
        {
            queryClass = new QueryClass();
        }

        public DataTable loadResultTable(string userId)
        {
            string sql = "SELECT * FROM TESTRESULT WHERE STUDENTID = N'" + userId + "'";

            return queryClass.loadGridTable(sql);
        }
    }
}
