using System;
using System.Windows.Forms;
using filmhub.Models;
using Npgsql;

namespace filmhub
{
    public class LoginController
    {
        private void login(string email, string password)
        {
            var id = -1;
            string name = null, surname = null, birthdate = null, picture = null, createdOn = null;
            bool admin = false, darkTheme = true;
            
            try {
                var con = DatabaseController.getConnection();

                const string validateUser = 
                    "SELECT id, name, surname, birthdate, admin, dark_theme, picture, created_on " +
                    "FROM account " +
                    "WHERE email = @email AND password = @password" +
                    "LIMIT 1";
                
                using var cmd = new NpgsqlCommand(validateUser, con);
    
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Prepare();
                
                using var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                    name = rdr.GetString(1);
                    surname = rdr.GetString(2);
                    birthdate = rdr.GetString(3);
                    admin = rdr.GetBoolean(4);
                    darkTheme = rdr.GetBoolean(5);
                    picture = rdr.GetString(6);
                    createdOn = rdr.GetString(7);
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
    
            if (name != null && id != -1) {
                if (admin) {
                    // TODO: Admin account
                } else {
                    new Account(id, name, surname, email, birthdate, admin, darkTheme, picture, createdOn).login();
                }
            } else {
                MessageBox.Show("Wrong username or password.");
            }
        }
    }
}