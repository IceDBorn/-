using NpgsqlTypes;

namespace filmhub.Models
{
    public class Account
    {
        private string name;
        private string email;
        private bool admin;
        private bool darkTheme;
        private NpgsqlDateTime createdOn;

        private static Account _accountInstance;

        public Account(int id, string name, string email, bool admin, bool darkTheme, string picture,
            NpgsqlDateTime createdOn)
        {
            Id = id;
            this.name = name;
            this.email = email;
            this.admin = admin;
            this.darkTheme = darkTheme;
            this.Picture = picture;
            this.createdOn = createdOn;
        }

        public int Id { get; }

        public string Picture { get; }

        public void Login()
        {
            _accountInstance = this;
        }
        
        public static void Logout()
        {
            _accountInstance = null;
        }

        public static Account GetAccountInstance()
        {
            return _accountInstance;
        }
    }
}