using System;
using System.Drawing;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Models;
using Npgsql;

namespace filmhub.Views
{
    public class Colors
    {
        #region Fields
        
        private static readonly NpgsqlConnection con = DatabaseController.GetConnection();

        public Color WindowBarBackgroundColor { get; private set; }

        public Color NavBarBackgroundColor { get; private set; }

        public Color BackgroundColor { get; private set; }

        public Color PopOutBackgroundColor { get; private set; }

        public Color FieldColor { get; private set; }

        public Color FieldDarkTextColor { get; private set; }

        public Color AccentColor { get; private set; }

        public Color DarkTextColor { get; private set; }
        
        public Color ForeColor { get; private set; }

        #endregion

        #region Methods

        public void DarkTheme()
        {
            WindowBarBackgroundColor = Color.FromArgb(7, 7, 7);
            NavBarBackgroundColor = Color.FromArgb(20,20,20);
            BackgroundColor = Color.FromArgb(33,33,33);
            PopOutBackgroundColor = Color.FromArgb(50,50,50);
            FieldColor = Color.FromArgb(122,122,122);
            FieldDarkTextColor = Color.FromArgb(200,200,200);
            AccentColor = Color.FromArgb(113, 44, 218);
            DarkTextColor = Color.FromArgb(111, 111, 111);
            ForeColor = Color.White;
            SetDarkThemeInDB(true);
            Properties.Settings.Default["Theme"] = 0;
            Properties.Settings.Default.Save();
        }

        public void LightTheme()
        {
            WindowBarBackgroundColor = Color.FromArgb(206, 206, 206);
            NavBarBackgroundColor = Color.FromArgb(234,234,234);
            BackgroundColor = Color.FromArgb(255,255,255);
            PopOutBackgroundColor = Color.FromArgb(247,247,247);
            FieldColor = Color.FromArgb(200,200,200);
            FieldDarkTextColor = Color.FromArgb(100,100,100);
            AccentColor = Color.FromArgb(113, 44, 218);
            DarkTextColor = Color.FromArgb(40, 40, 40);
            ForeColor = Color.Black;
            SetDarkThemeInDB(false);
            Properties.Settings.Default["Theme"] = 1;
            Properties.Settings.Default.Save();
        }

        public void SetDarkTheme(bool darkTheme)
        {
            if (darkTheme) DarkTheme();
            else LightTheme();
            Program.MainForm.RefreshUi();
        }
        
        private static void SetDarkThemeInDB(bool darkTheme)
        {
            if (Account.GetAccountInstance() == null) return;
            
            const string query = "UPDATE account SET dark_theme = @theme WHERE id = @user_id";

            try
            {
                using var cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("theme", darkTheme);
                cmd.Parameters.AddWithValue("user_id", Account.GetAccountInstance().Id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion
    }
}