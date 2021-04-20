using Npgsql;

namespace filmhub.Controllers
{
    public static class DatabaseController
    {
        public static NpgsqlConnection GetConnection()
        {
            const string cs = "Host=34.107.105.224;Username=postgres;Password=1234;Database=postgres";
            return new NpgsqlConnection(cs);
        }
    }
}