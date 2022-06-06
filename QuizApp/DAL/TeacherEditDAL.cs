using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DAL
{
    class TeacherEditDAL
    {
        QueryClass queryClass;

        public TeacherEditDAL()
        {
            queryClass = new QueryClass();
        }

        public DataTable loadQuestionData(string testCode)
        {
            string sql = "SELECT * FROM QUESTIONS WHERE TESTSETCODE = N'" + testCode + "'";

            return queryClass.loadGridTable(sql);
        }

        public int checkExistTestSet(string testCode)
        {
            SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM TESTSET WHERE TESTSETCODE = @testCode");
            countCommand.Parameters.AddWithValue("@testCode", testCode);

            return queryClass.executeScalar(countCommand);
        }

        public int checkMatchUserTestSet(string testCode, string userId)
        {
            SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM TESTSET WHERE TESTSETCODE = @testCode AND TESTSETCREATOR = @userId");
            countCommand.Parameters.AddWithValue("@testCode", testCode);
            countCommand.Parameters.AddWithValue("@userId", userId);

            return queryClass.executeScalar(countCommand);
        }

        public bool addQuesiton(string question, string answerA, string answerB, string answerC, string answerD, string rightAnswer, string testSetCode)
        {
            SqlCommand insertCommand = new SqlCommand("INSERT INTO QUESTIONS VALUES(@question, @answerA, @answerB, @answerC, @answerD, @rightAnswer, @testSetCode)");
            insertCommand.Parameters.AddWithValue("@question", question);
            insertCommand.Parameters.AddWithValue("@answerA", answerA);
            insertCommand.Parameters.AddWithValue("@answerB", answerB);
            insertCommand.Parameters.AddWithValue("@answerC", answerC);
            insertCommand.Parameters.AddWithValue("@answerD", answerD);
            insertCommand.Parameters.AddWithValue("@rightAnswer", rightAnswer);
            insertCommand.Parameters.AddWithValue("@testSetCode", testSetCode);

            string successMessage = "Add Question Successfully.";
            string failMessage = "Add Question Fail.";

            return queryClass.executeNonQuery(insertCommand, successMessage, failMessage);
        }

        public bool deleteQuestion(string questionId)
        {
            SqlCommand deleteCommand = new SqlCommand("DELETE QUESTIONS WHERE ID = CONVERT(int, @questionId)");
            deleteCommand.Parameters.AddWithValue("@questionId", questionId);

            string successMessage = "Delete Question Successfully.";
            string failMessage = "Delete Question Fail.";

            return queryClass.executeNonQuery(deleteCommand, successMessage, failMessage);
        }

        public bool updateQuestion(string questionId, string question, string answerA, string answerB, string answerC, string answerD, string rightAnswer, string testSetCode)
        {
            SqlCommand updateCommand = new SqlCommand("UPDATE QUESTIONS SET QUESTION = @question, ANSWERA = @answerA, ANSWERB = @answerB, ANSWERC = @answerC, ANSWERD = @answerD, RIGHTANSWER = @rightAnswer, TESTSETCODE = @testSetCode WHERE ID = @questionId");
            updateCommand.Parameters.AddWithValue("@question", question);
            updateCommand.Parameters.AddWithValue("@answerA", answerA);
            updateCommand.Parameters.AddWithValue("@answerB", answerB);
            updateCommand.Parameters.AddWithValue("@answerC", answerC);
            updateCommand.Parameters.AddWithValue("@answerD", answerD);
            updateCommand.Parameters.AddWithValue("@rightAnswer", rightAnswer);
            updateCommand.Parameters.AddWithValue("@testSetCode", testSetCode);
            updateCommand.Parameters.AddWithValue("@questionId", questionId);

            string successMessage = "Update Question Successfully.";
            string failMessage = "Update Question Fail.";

            return queryClass.executeNonQuery(updateCommand, successMessage, failMessage);
        }
    }
}
