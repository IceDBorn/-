using System;
using System.Windows.Forms;

namespace filmhub
{
    public partial class MainForm : Form
    {
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
        }

        private void UserControlSelector()
        {
            mainPage.Controls.Clear();
            mainPage.Controls.Add(new SignInUserControl());
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
    }
}