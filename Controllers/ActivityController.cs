using System.Collections.Generic;
using System.Windows.Forms;
using filmhub.Controls;
using filmhub.Models;
using Npgsql;

namespace filmhub.Controllers
{
    public static class ActivityController
    {
        private static readonly NpgsqlConnection con = DatabaseController.GetConnection();

        public static bool IsActivityType(string tableName, int movieId)
        {
            var id = -1;
            var query = "SELECT id FROM " + tableName + " WHERE movie_id = @movie AND user_id = @user LIMIT 1";

            try
            {
                using var cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("movie", movieId);
                cmd.Parameters.AddWithValue("user", Account.GetAccountInstance().Id);
                cmd.Prepare();
                using var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                }
                rdr.Close();
            }
            catch
            {
                CustomMessageBox.Show(@"Something went wrong.");
            }

            return id != -1;
        }
        
        public static IEnumerable<int> Query(string tableName)
        {
            var query = "SELECT movie_id FROM " + tableName + " WHERE user_id = @user_id";
            var list = new List<int>();

            try
            {
                using var cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("user_id", Account.GetAccountInstance().Id);
                cmd.Prepare();
                using var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(rdr.GetInt32(0));
                }
                rdr.Close();
            }
            catch
            {
                CustomMessageBox.Show(@"Something went wrong.");
            }

            return list;
        }
    }
}