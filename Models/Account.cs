using filmhub.Properties;

namespace filmhub.Models
{
    public class Account
    {
        private static Account _accountInstance;

        public Account(int id, string username, bool admin, string picture)
        {
            Id = id;
            Username = username;
            Admin = admin;
            Picture = picture;
        }

        public int Id { get; }
        public string Username { get; }
        public string Picture { get; set; }

        public bool Admin { get; }

        public void Login()
        {
            _accountInstance = this;
        }

        public static void Logout()
        {
            _accountInstance = null;
            if (!Settings.Default.RememberMe) return;
            Settings.Default.RememberMe = false;
            Settings.Default.Username = "";
            Settings.Default.Password = "";
            Settings.Default.Save();
        }

        public static Account GetAccountInstance()
        {
            return _accountInstance;
        }
    }
}