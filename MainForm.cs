using System;
using System.Windows.Forms;

namespace filmhub
{
    public partial class MainForm : Form
    { 
        private FavoritesUserControl favesPage = new FavoritesUserControl();
        
        #region Fields
        
        private readonly Colors _colors = new Colors();
        
        #endregion

        #region Constructor
        
        public MainForm()
        {
            InitializeComponent();
            InitializeColors();
            UserControlSelector();
        }
        
        #endregion

        #region Methods

        private void InitializeColors()
        {
            navBar.BackColor = _colors.BackgroundColor;
            searchBar.BackColor = _colors.FieldColor;
            searchBar.ForeColor = _colors.FieldDarkTextColor;
            mainPage.BackColor = _colors.BackgroundColor;
            dropDown.BackColor = _colors.BackgroundColor;
            faves.BackColor = _colors.BackgroundColor;
            watchlist.BackColor = _colors.BackgroundColor;
            history.BackColor = _colors.BackgroundColor;
            settings.BackColor = _colors.BackgroundColor;
            logout.BackColor = _colors.BackgroundColor;
        }

        private void UserControlSelector()
        {
            mainPage.Controls.Clear();
            mainPage.Controls.Add(new MainPageUserControl());
        }
        
        

        #endregion

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

        private void dropDown_Click(object sender, EventArgs e)
        {
            dropDown.BringToFront();
            //throw new System.NotImplementedException();
        }
        
        int count = 0;
        private void accountButton_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                dropDown.Visible = true;

                faves.Visible = true;
                faves.BringToFront();

                watchlist.Visible = true;
                watchlist.BringToFront();

                history.Visible = true;
                history.BringToFront();

                settings.Visible = true;
                settings.BringToFront();

                logout.Visible = true;
                logout.BringToFront();
                //throw new System.NotImplementedException();
                count = count + 1;
            }else if (count == 1)
            {
                dropDown.Visible = false;
                faves.Visible = false;
                watchlist.Visible = false;
                history.Visible = false;
                settings.Visible = false;
                logout.Visible = false;
                //throw new System.NotImplementedException();
                count = 0;
            }
        }

        private void faves_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}