using System.Windows.Forms;
using Npgsql;

namespace filmhub.Controllers
{
    public static class QueryController
    {
        private static readonly NpgsqlConnection con = DatabaseController.GetConnection();

        public static bool Activity(string tableName, int userId, int movieId)
        {
            var id = -1;
            var query = "SELECT id FROM " + tableName + " WHERE movie_id = @movie AND user_id = @user LIMIT 1";

            try
            {
                using var cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("movie", movieId);
                cmd.Parameters.AddWithValue("user", userId);
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
                MessageBox.Show(@"Something went wrong.");
            }

            return id != -1;
        }
    }
}