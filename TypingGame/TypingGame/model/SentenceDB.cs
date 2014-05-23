using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TypingGame
{
    public class SentenceDB
    {
        SqlConnection connection = new SqlConnection(@"Server=.\sqlexpress;Database=TypingGame;Trusted_Connection=True;");

        public List<Sentence> GetSentence(int difficulty)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Lines WHERE difficulty=@difficulty", connection);
            command.Parameters.AddWithValue("@difficulty", difficulty);
            List<Sentence> listofSent = new List<Sentence>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Sentence sentence = new Sentence();

                    sentence.SentenceString = reader.GetString(reader.GetOrdinal("sentence_string"));
                    sentence.SentenceLength = reader.GetInt32(reader.GetOrdinal("sentence_length"));
                    sentence.Difficulty = difficulty;
                    listofSent.Add(sentence);
                }
            }

            connection.Close();

            
            return listofSent;
        }
    }
}