using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffaManagementSoftware.entities
{
    internal class Club
    {
        public int id { get; set; }
        public string name { get; set; }

        public Club(string name)
        {
            this.name = name;
        }

        public Club(int id)
        {
            this.id = id;
        }
    }
}
