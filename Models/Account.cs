using NpgsqlTypes;

namespace filmhub.Models
{
    public class Account
    {
        private int id;
        private string name;
        private string surnname;
        private string email;
        private NpgsqlDate birthdate;
        private bool admin;
        private bool darkTheme;
        private string picture;
        private NpgsqlDateTime createdOn;
        
        private static Account accountInstance = null;

        public Account(int id, string name, string surnname, string email, NpgsqlDate birthdate, bool admin, bool darkTheme, string picture, NpgsqlDateTime createdOn)
        {
            this.id = id;
            this.name = name;
            this.surnname = surnname;
            this.email = email;
            this.birthdate = birthdate;
            this.admin = admin;
            this.darkTheme = darkTheme;
            this.picture = picture;
            this.createdOn = createdOn;
        }
        
        public void login() {
            accountInstance = this;
        }
        
        public static Account getAccountInstance() {
            return accountInstance;
        }
    }
}