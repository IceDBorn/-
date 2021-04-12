using Npgsql;

namespace filmhub
{
    public static class DatabaseController
    {
        public static NpgsqlConnection getConnection()
        {
            const string cs = "Host=localhost;Username=postgres;Password=1234;Database=postgres";
            return new NpgsqlConnection(cs);
        }
    }
}