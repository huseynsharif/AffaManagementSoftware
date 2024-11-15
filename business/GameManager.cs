using AffaManagementSoftware.entities;
using AffaManagementSoftware.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffaManagementSoftware.business
{
    internal class GameManager
    {
        private readonly DbHelper dbHelper;

        public GameManager(DbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }


        public DataTable GetAll()
        {
            return dbHelper.ExecuteReader("SELECT " +
                "g.id, " + 
                "c1.name AS club1, " +
                "g.Score1, " +
                "g.Score2, " +
                "c2.name AS club2, " +
                "g.DateTime " +
                "FROM  " +
                "games g " +
                "JOIN  " +
                "clubs c1 ON g.club1 = c1.Id " + 
                "JOIN  " +
                "clubs c2 ON g.club2 = c2.Id;");
        }

        public void AddGame(Game game)
        {

            string query = @"INSERT INTO games (club1, club2, score1, score2, dateTime)
                            VALUES (@club1, @club2, @score1, @score2, @dateTime);";

            var parameters = new Dictionary<string, object>
            {
                { "@club1", game.club1.id },
                { "@club2", game.club2.id },
                { "@score1", game.score1 },
                { "@score2", game.score2 },
                { "@dateTime", game.dateTime }
            };

            dbHelper.ExecuteNonQuery(query, parameters);

        }

        public void Update(Game game)
        {
            string query = @"UPDATE games SET score1=@score1, score2=@score2 WHERE id=@id";

            var parameters = new Dictionary<string, object>
            {
                { "@score1", game.score1 },
                { "@score2", game.score2 },
                { "@id", game.id }
            };

            dbHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
