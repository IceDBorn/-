using System;
using System.Windows.Forms;
using filmhub.Models;
using Npgsql;
using NpgsqlTypes;

namespace filmhub
{
    public static class LoginController
    {
        public static void login(string email, string password)
        {
            var id = -1;
            string name = null, surname = null, picture = null;
            bool admin = false, darkTheme = true;
            var createdOn = NpgsqlDateTime.Infinity;

            try
            {
                var con = DatabaseController.getConnection();
                con.Open();

                var validateUser =
                    "SELECT id, name, surname, admin, dark_theme, picture, created_on " +
                    "FROM account " +
                    "WHERE email = '" + email + "' AND password = '" + password + "' " +
                    "LIMIT 1";

                using var cmd = new NpgsqlCommand(validateUser, con);

                using var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                    name = rdr.GetString(1);
                    surname = rdr.GetString(2);
                    admin = rdr.GetBoolean(3);
                    darkTheme = rdr.GetBoolean(4);
                    // picture = rdr.GetString(5); TODO: Fix
                    createdOn = rdr.GetTimeStamp(6);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if (name != null && id != -1)
            {
                if (admin)
                {
                    // TODO: Admin account
                }
                else
                {
                    new Account(id, name, surname, email, admin, darkTheme, picture, createdOn).login();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
        }
    }
}