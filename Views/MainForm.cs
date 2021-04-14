using System;
using System.Drawing;
using System.Windows.Forms;

namespace filmhub.Views
{
    public partial class MainForm : Form
    {

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            InitializeColors();
            UserControlSelector(new WelcomeUserControl(), false);
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            navBar.BackColor = Program.Colors.BackgroundColor;
            searchBar.BackColor = Program.Colors.FieldColor;
            searchBar.ForeColor = Program.Colors.FieldDarkTextColor;
            mainPage.BackColor = Program.Colors.BackgroundColor;

            faves.BackColor = Program.Colors.BackgroundColor;
            watchlist.BackColor = Program.Colors.BackgroundColor;
            history.BackColor = Program.Colors.BackgroundColor;
            settings.BackColor = Program.Colors.BackgroundColor;
            logout.BackColor = Program.Colors.BackgroundColor;
            panel1.BackColor = Program.Colors.BackgroundColor;
        }

        public void UserControlSelector(Control userControl, bool flag)
        {
            mainPage.Controls.Clear();
            mainPage.Controls.Add(userControl);
            iconsPanel.Visible = flag;
        }

        #endregion

        #region Events
        
        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text.Equals(@" Enter your search"))
            {
                searchBar.Text = "";
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text.Equals(""))
            {
                searchBar.Text = @" Enter your search";
            }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void faves_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
            panel1.Visible = false;
        }

        private void faves_MouseHover(object sender, EventArgs e)
        {
            faves.ForeColor = Program.Colors.AccentColor;
        }

        private void faves_MouseLeave(object sender, EventArgs e)
        {
            faves.ForeColor = Color.White;
        }

        private void watchlist_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new WatchlistUserControl(), true);
            panel1.Visible = false;
        }

        private void watchlist_MouseHover(object sender, EventArgs e)
        {
            watchlist.ForeColor = Program.Colors.AccentColor;
        }

        private void watchlist_MouseLeave(object sender, EventArgs e)
        {
            watchlist.ForeColor = Color.White;
        }

        private void history_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new HistoryUserControl(), true);
            panel1.Visible = false;
        }

        private void history_MouseHover(object sender, EventArgs e)
        {
            history.ForeColor = Program.Colors.AccentColor;
        }

        private void history_MouseLeave(object sender, EventArgs e)
        {
            history.ForeColor = Color.White;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new SettingsUserControl(), true);
            panel1.Visible = false;
        }

        private void settings_MouseHover(object sender, EventArgs e)
        {
            settings.ForeColor = Program.Colors.AccentColor;
        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.ForeColor = Color.White;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new WelcomeUserControl(), false);
            panel1.Visible = false;
        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            logout.ForeColor = Program.Colors.AccentColor;
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;
        }
        
        #endregion
    }
}