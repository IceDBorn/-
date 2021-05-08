using System;
using System.Windows.Forms;
using filmhub.Controls;
using filmhub.Models;
using filmhub.Properties;
using Npgsql;

namespace filmhub.Controllers
{
    public static class AccountController
    {
        private static readonly NpgsqlConnection Con = DatabaseController.GetConnection();

        public static void Login(string username, string password)
        {
            var id = -1;
            string picture = null;
            bool admin = false, darkTheme = true;
            const string query = "SELECT id, username, admin, dark_theme, picture " +
                                 "FROM account " +
                                 "WHERE username = @username AND password = @password " +
                                 "LIMIT 1";

            try
            {
                using var cmd = new NpgsqlCommand(query, Con);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Prepare();
                using var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                    username = rdr.GetString(1);
                    admin = rdr.GetBoolean(2);
                    darkTheme = rdr.GetBoolean(3);
                    picture = rdr.IsDBNull(4) ? null : rdr.GetString(4);
                }

                rdr.Close();
            }
            catch
            {
                CustomMessageBox.Show(@"Something went wrong while contacting the database.");
            }

            if (id != -1)
            {
                new Account(id, username, admin, darkTheme, picture).Login();
                if (Settings.Default.Theme == 0 && darkTheme ||
                    Settings.Default.Theme == 1 && darkTheme == false) return;
                Program.Colors.SetDarkTheme(darkTheme);
            }
            else
            {
                CustomMessageBox.Show(@"Wrong username or password.");
            }
        }

        public static void Signup(string username, string password)
        {
            const string query = "INSERT INTO account (username, password, admin, dark_theme) " +
                                 "VALUES (@username, @password, @admin, @dark_theme)";
            try
            {
                using var cmd = new NpgsqlCommand(query, Con);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("admin", false);
                cmd.Parameters.AddWithValue("dark_theme", true);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                Login(username, password);
            }
            catch (PostgresException e)
            {
                CustomMessageBox.Show(e.SqlState.Equals("23505")
                    ? @"Username already exists."
                    : @"Something went wrong with the database, please try again.");
            }
            catch (Exception)
            {
                CustomMessageBox.Show(@"Something went wrong, please try again.");
            }
        }

        public static void ChangePassword(string password)
        {
            const string query = "UPDATE account SET password = @password WHERE id = @user_id";

            try
            {
                using var cmd = new NpgsqlCommand(query, Con);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("user_id", Account.GetAccountInstance().Id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                CustomMessageBox.Show(@"Something went wrong while contacting the database.");
            }
        }
    }
}