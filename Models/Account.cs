using NpgsqlTypes;

namespace filmhub.Models
{
    public class Account
    {
        private int id;
        private string name;
        private string email;
        private bool admin;
        private bool darkTheme;
        private string picture;
        private NpgsqlDateTime createdOn;

        private static Account accountInstance;

        public Account(int id, string name, string email, bool admin, bool darkTheme, string picture,
            NpgsqlDateTime createdOn)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.admin = admin;
            this.darkTheme = darkTheme;
            this.picture = picture;
            this.createdOn = createdOn;
        }

        public void login()
        {
            accountInstance = this;
        }
        
        public static void logout()
        {
            accountInstance = null;
        }

        public static Account getAccountInstance()
        {
            return accountInstance;
        }
    }
}