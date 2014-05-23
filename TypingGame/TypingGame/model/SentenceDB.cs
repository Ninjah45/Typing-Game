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

        public Sentence GetSentence(int difficulty)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Lines WHERE difficulty = @difficulty");
            command.Parameters.AddWithValue("@difficulty", difficulty);
            Sentence sentence = new Sentence();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                sentence.SentenceString = reader.GetString(reader.GetOrdinal("sentence_string"));
                sentence.SentenceLength = reader.GetInt32(reader.GetOrdinal("sentence_length"));
            }

            connection.Close();

            sentence.Difficulty = difficulty;
            return sentence;
        }
    }
}