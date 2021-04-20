using System;
using System.Windows.Forms;
using filmhub.Models;
using Npgsql;
using NpgsqlTypes;

namespace filmhub.Controllers
{
    public static class LoginController
    {
        public static void Login(string username, string password)
        {
            var id = -1;
            string picture = null;
            bool admin = false, darkTheme = true;

            try
            {
                var con = DatabaseController.GetConnection();
                con.Open();

                const string validateUser = "SELECT id, username, admin, dark_theme, picture " +
                                            "FROM account " +
                                            "WHERE username = @username AND password = @password " +
                                            "LIMIT 1";

                using var cmd = new NpgsqlCommand(validateUser, con);
                var usernameValue = cmd.Parameters.Add("username", NpgsqlDbType.Text);
                var passwordValue = cmd.Parameters.Add("password", NpgsqlDbType.Text);

                cmd.Prepare();

                usernameValue.Value = username;
                passwordValue.Value = password;

                using var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                    username = rdr.GetString(1);
                    admin = rdr.GetBoolean(2);
                    darkTheme = rdr.GetBoolean(3);
                    picture = rdr.IsDBNull(4) ? null : rdr.GetString(4);
                }

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if (id != -1)
            {
                new Account(id, username, admin, darkTheme, picture).Login();
            }
            else
            {
                MessageBox.Show(@"Wrong username or password.");
            }
        }

        public static void Signup(string username, string password)
        {
            try
            {
                var con = DatabaseController.GetConnection();
                con.Open();

                const string validateUser =
                    "INSERT INTO account (username, password, admin, dark_theme) VALUES (@v1,@v2,@v3,@v4)";

                using var cmd = new NpgsqlCommand(validateUser, con);
                var v1 = cmd.Parameters.Add("v1", NpgsqlDbType.Text);
                var v2 = cmd.Parameters.Add("v2", NpgsqlDbType.Text);
                var v3 = cmd.Parameters.Add("v3", NpgsqlDbType.Boolean);
                var v4 = cmd.Parameters.Add("v4", NpgsqlDbType.Boolean);

                cmd.Prepare();

                v1.Value = username;
                v2.Value = password;
                v3.Value = false;
                v4.Value = true;

                cmd.ExecuteNonQuery();

                con.Close();

                Login(username, password);
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.SqlState.Equals("23505")
                    ? @"Username already exists."
                    : @"Something went wrong with the database, please try again.");
            }
            catch (Exception)
            {
                MessageBox.Show(@"Something went wrong, please try again.");
            }
        }
    }
}