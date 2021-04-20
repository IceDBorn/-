using System;
using System.Windows.Forms;
using filmhub.Models;
using Npgsql;
using NpgsqlTypes;

namespace filmhub.Controllers
{
    public static class LoginController
    {
        public static void Login(string email, string password)
        {
            var id = -1;
            string name = null, picture = null;
            bool admin = false, darkTheme = true;
            var createdOn = NpgsqlDateTime.Infinity;

            try
            {
                var con = DatabaseController.GetConnection();
                con.Open();

                var validateUser =
                    "SELECT id, name, admin, dark_theme, picture, created_at " +
                    "FROM account " +
                    "WHERE email = '" + email + "' AND password = '" + password + "' " +
                    "LIMIT 1";

                using var cmd = new NpgsqlCommand(validateUser, con);

                using var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                    // name = rdr.GetString(1); TODO: Fix
                    admin = rdr.GetBoolean(2);
                    darkTheme = rdr.GetBoolean(3);
                    picture = rdr.IsDBNull(4) ? null : rdr.GetString(4);
                    createdOn = rdr.GetTimeStamp(5);
                }

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if (id != -1)
            {
                if (admin)
                {
                    // TODO: Admin account
                }
                else
                {
                    new Account(id, name, email, admin, darkTheme, picture, createdOn).Login();
                }
            }
            else
            {
                MessageBox.Show(@"Wrong username or password.");
            }
        }

        public static void Signup(string email, string password)
        {
            try
            {
                var con = DatabaseController.GetConnection();
                con.Open();

                const string validateUser =
                    "INSERT INTO account (email, password, admin, dark_theme) VALUES (@v1,@v2,@v3,@v4)";

                using var cmd = new NpgsqlCommand(validateUser, con);
                var v1 = cmd.Parameters.Add("v1", NpgsqlDbType.Text);
                var v2 = cmd.Parameters.Add("v2", NpgsqlDbType.Text);
                var v3 = cmd.Parameters.Add("v3", NpgsqlDbType.Boolean);
                var v4 = cmd.Parameters.Add("v4", NpgsqlDbType.Boolean);

                cmd.Prepare();

                v1.Value = email;
                v2.Value = password;
                v3.Value = false;
                v4.Value = true;

                cmd.ExecuteNonQuery();

                con.Close();

                Login(email, password);
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.SqlState.Equals("23505")
                    ? @"Email already exists."
                    : @"Something went wrong with the database, please try again.");
            }
            catch (Exception)
            {
                MessageBox.Show(@"Something went wrong, please try again.");
            }
        }
    }
}