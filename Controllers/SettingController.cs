using System.Threading.Tasks;
using System.Windows.Forms;
using filmhub.Models;
using Npgsql;

namespace filmhub.Controllers
{
    public static class SettingController
    {
        private static readonly NpgsqlConnection con = DatabaseController.GetConnection();

        public static async Task UpdateImageLink(string link)
        {
            const string query = "UPDATE account SET picture = @link WHERE id = @id";

            try
            {
                using var cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("link", link);
                cmd.Parameters.AddWithValue("id", Account.GetAccountInstance().Id);

                await cmd.PrepareAsync();
                await cmd.ExecuteNonQueryAsync();
                
                Account.GetAccountInstance().Picture = link;
            }
            catch
            {
                MessageBox.Show(@"Something went wrong while contacting the database.");
            }
        }
    }
}