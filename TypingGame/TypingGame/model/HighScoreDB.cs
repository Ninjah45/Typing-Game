using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TypingGame.model
{
    public class HighScoreDB
    {
        public string Name { get; set; }
        public int Score { get; set; }
        SqlConnection connection = new SqlConnection(@"Server=.\sqlexpress;Database=TypingGame;Trusted_Connection=True;");

        public HighScoreDB(string name, int score)
        {
            Name = Name;
            Score = score;
        }

        public Dictionary<string, int> GetScores()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM HighScore");
            string name;
            int score;

            Dictionary<string, int> listOfScores = new Dictionary<string, int>();

            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    name = reader.GetString(reader.GetOrdinal("name"));
                    score = reader.GetInt32(reader.GetOrdinal("score"));
                    listOfScores.Add(name, score);
                }
            }

            connection.Close();

            return listOfScores;
        }
    }
}
