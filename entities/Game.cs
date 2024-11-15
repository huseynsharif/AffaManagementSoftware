using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffaManagementSoftware.entities
{
    internal class Game
    {
        public int id {  get; set; }
        public Club club1 { get; set; }
        public Club club2 { get; set; }
        public int score1 { get; set; }
        public int score2 { get; set; }
        public DateTime dateTime { get; set; }

        public Game(Club club1, Club club2, int score1, int score2, DateTime dateTime)
        {
            this.club1 = club1;
            this.club2 = club2;
            this.score1 = score1;
            this.score2 = score2;
            this.dateTime = dateTime;
        }
    }
}
