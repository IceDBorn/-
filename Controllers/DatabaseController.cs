using Npgsql;

namespace filmhub.Controllers
{
    public static class DatabaseController
    {
        private static NpgsqlConnection con;
        
        public static NpgsqlConnection GetConnection()
        {
            if (con != null) return con;

            const string cs = "Host=34.107.105.224;Username=postgres;Password=1234;Database=postgres";
            con = new NpgsqlConnection(cs);
            con.Open();
            return con;
        }
    }
}