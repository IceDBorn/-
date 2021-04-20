namespace filmhub.Models
{
    public class Account
    {
        private string username;
        private string email;
        private bool admin;
        private bool darkTheme;

        private static Account _accountInstance;

        public Account(int id, string username, bool admin, bool darkTheme, string picture)
        {
            Id = id;
            Username = username;
            this.admin = admin;
            this.darkTheme = darkTheme;
            this.Picture = picture;
        }

        public int Id { get; }
        public string Username { get; }
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