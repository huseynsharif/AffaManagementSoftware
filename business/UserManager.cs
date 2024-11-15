using AffaManagementSoftware.entities;
using AffaManagementSoftware.utils;
using System.Collections.Generic;

namespace AffaManagementSoftware.business
{
    internal class UserManager
    {
        private readonly DbHelper dbHelper;

        public UserManager(DbHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public bool Login(User user)
        {
            string query = "SELECT COUNT(username) FROM [dbo].[users] WHERE username = @username AND password = @password";

            var parameters = new Dictionary<string, object>
            {
                { "@username", user.username },
                { "@password", user.password }
            };

            int userExists = dbHelper.ExecuteScalar(query, parameters);

            if (userExists > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
