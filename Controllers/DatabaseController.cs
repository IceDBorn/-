using Npgsql;

namespace filmhub.Controllers
{
    public static class DatabaseController
    {
        private static NpgsqlConnection _con;
        
        public static NpgsqlConnection GetConnection()
        {
            if (_con != null) return _con;

            const string cs = "Host=34.107.105.224;Username=postgres;Password=1234;Database=postgres";
            _con = new NpgsqlConnection(cs);
            _con.Open();
            return _con;
        }
    }
}