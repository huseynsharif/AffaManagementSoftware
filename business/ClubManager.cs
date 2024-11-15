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
    internal class ClubManager
    {

        private readonly DbHelper dbHelper;

        public ClubManager(DbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }


        public DataTable GetAll()
        {

            return dbHelper.ExecuteReader("SELECT id, name FROM clubs");
        }

        public void AddClub(Club club)
        {
            string query = @"INSERT INTO clubs (name) " +
                       "VALUES (@name)";

            var parameters = new Dictionary<string, object>
            {
                { "@name", club.name }
            };

            dbHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
