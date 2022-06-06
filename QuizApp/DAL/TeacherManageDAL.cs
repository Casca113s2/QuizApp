using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DAL
{
    class TeacherManageDAL
    {
        QueryClass queryClass;

        public TeacherManageDAL()
        {
            queryClass = new QueryClass();
        }

        public DataTable loadTestSetData(string userId)
        {
            string sql = "SELECT * FROM TESTSET WHERE TESTSETCREATOR = N'" + userId + "'";

            return queryClass.loadGridTable(sql);
        }

        public DataTable loadQuestionsData(string code)
        {
            string sql = "SELECT * FROM QUESTIONS WHERE TESTSETCODE = N'" + code + "'";

            return queryClass.loadGridTable(sql);
        }

        public int checkExistTestSet(string testCode)
        {
            SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM TESTSET WHERE TESTSETCODE = @testCode");
            countCommand.Parameters.AddWithValue("@testCode", testCode);

            return queryClass.executeScalar(countCommand);
        }

        public bool updateTestSetSameKey(string code, string name, string time, string creator)
        {
            SqlCommand updateCommand = new SqlCommand("UPDATE TESTSET SET TESTSETNAME = @name, TESTSETCREATOR = @creator, TIME = @time WHERE TESTSETCODE = @code");
            updateCommand.Parameters.AddWithValue("@name", name);
            updateCommand.Parameters.AddWithValue("@creator", creator);
            updateCommand.Parameters.AddWithValue("@time", time);
            updateCommand.Parameters.AddWithValue("@code", code);

            string successMessage = "Update Test Set Successfully.";
            string failMessage = "Update Test Set Fail.";

            return queryClass.executeNonQuery(updateCommand, successMessage, failMessage);
        }

        public bool updateTestSetDifferentKey(string newcode, string oldcode, string name, string time, string creator)
        {
            //Insert new code to test set table
            bool insertRes = false;
            SqlCommand insertSqlCommand = new SqlCommand("INSERT INTO TESTSET VALUES(@code, @name, @creator, CONVERT(int, @time))");
            insertSqlCommand.Parameters.AddWithValue("@code", newcode);
            insertSqlCommand.Parameters.AddWithValue("@name", name);
            insertSqlCommand.Parameters.AddWithValue("@creator", creator);
            insertSqlCommand.Parameters.AddWithValue("@time", time);

            insertRes = queryClass.executeNonQuery(insertSqlCommand, "", "");
            if (!insertRes) return insertRes;

            //Update questions form old code to new code
            bool updateRes = false;
            SqlCommand updateSqlCommand = new SqlCommand("UPDATE QUESTIONS SET TESTSETCODE = @newcode WHERE TESTSETCODE = @oldcode");
            updateSqlCommand.Parameters.AddWithValue("@newcode", newcode);
            updateSqlCommand.Parameters.AddWithValue("@oldcode", oldcode);

            updateRes = queryClass.executeNonQuery(updateSqlCommand, null, null);
            if (!updateRes) //Incase of failure delete new code
            {
                SqlCommand delete = new SqlCommand("DELETE TESTSET WHERE TESTSETCODE = @newcode");
                delete.Parameters.AddWithValue("@newcode", newcode);

                queryClass.executeNonQuery(delete, null, null);
                return updateRes;
            } 

            //Delete old code
            bool deleteRes = false;
            SqlCommand deleteSqlCommand = new SqlCommand("DELETE TESTSET WHERE TESTSETCODE = @oldcode");
            deleteSqlCommand.Parameters.AddWithValue("@oldcode", oldcode);

            deleteRes = queryClass.executeNonQuery(deleteSqlCommand, null, null);

            return deleteRes;
        }

        public bool deleteTestSet(string code)
        {
            //Update questions form old code to new code
            SqlCommand deleteQuestionsQuestionRes = new SqlCommand("DELETE QUESTIONS WHERE TESTSETCODE = @code");
            deleteQuestionsQuestionRes.Parameters.AddWithValue("@code", code);

            queryClass.executeNonQuery(deleteQuestionsQuestionRes, null, null);

            //Delete code
            bool deleteCodeRes = false;
            SqlCommand deleteCodeSqlCommand = new SqlCommand("DELETE TESTSET WHERE TESTSETCODE = @code");
            deleteCodeSqlCommand.Parameters.AddWithValue("@code", code);

            deleteCodeRes = queryClass.executeNonQuery(deleteCodeSqlCommand, null, null);

            return deleteCodeRes;
        }

    }
}
