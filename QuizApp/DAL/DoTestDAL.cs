using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DAL
{
    class DoTestDAL
    {
        QueryClass queryClass;

        public DoTestDAL()
        {
            queryClass = new QueryClass();
        }

        public int checkExistTestSet(string testCode)
        {
            SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM TESTSET WHERE TESTSETCODE = @testCode");
            countCommand.Parameters.AddWithValue("@testCode", testCode);

            return queryClass.executeScalar(countCommand);
        }

        public DataTable loadQuestionData(string testCode)
        {
            string sql = "SELECT * FROM QUESTIONS WHERE TESTSETCODE = N'" + testCode + "'";

            return queryClass.loadGridTable(sql);
        }

        public string getTestTime(string testCode)
        {
            SqlCommand selectSqlCommand = new SqlCommand("SELECT * FROM TESTSET WHERE TESTSETCODE = @testCode");
            selectSqlCommand.Parameters.AddWithValue("@testCode", testCode);

            return queryClass.selectValueQuery(selectSqlCommand, "TIME", "", "");
        }
    }
}
