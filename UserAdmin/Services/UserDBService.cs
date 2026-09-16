using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using UserAdmin.Models;

namespace UserAdmin.Services
{
    class UserDBService
    {
        public string ConnectionString = "Server=localhost; Database=useradmin;User=root;Password=;";

        public void Add(User user)
        {
            var connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sql = "";

            connection.Close();
        }
    }
}
