using System;    
using System.Collections.Generic;    
using System.Data;    
using System.Data.SqlClient;   

namespace QuizApplication.Models {
    public class QuizDataAccessLayer {
        string connectionString = @"Data Source=DESK00083\SQLEXPRESS2014;integrated security=SSPI;database=Quiz;MultipleActiveResultSets=True" ;

        public IEnumerable<Quiz> GetAllQuestions(int id) {
            List<Quiz> QuestionList = new List<Quiz>();

            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("SELECT * FROM QUESTIONS WHERE QuestionID = " + id, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read()) {
                    Quiz question = new Quiz();

                    question.QuestionID = Convert.ToInt32(reader["QuestionID"]);
                    question.Question = reader["Question"].ToString();
                    for ( int i = 0; i < 4; i++) {
                        question.Options[i] = reader["OP" + (i+1)].ToString(); 
                    }
                    question.correctOption = reader["CorrectOP"].ToString(); 

                    QuestionList.Add(question);
                }
                con.Close();
            }
            return QuestionList;
        } 
    }
}