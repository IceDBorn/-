using System;
using System.Windows.Forms;

namespace filmhub
{
    public partial class MainPageUserControl : UserControl
    {
        #region Fields

        private readonly Colors _colors = new Colors();

        #endregion
        public MainPageUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

        private void InitializeColors()
        {
            BackColor = _colors.BackgroundColor;
            menu.BackColor = _colors.BackgroundColor;
            categoriesBox.BackColor = _colors.BackgroundColor;
            categoryTitle.ForeColor = _colors.AccentColor;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            categoriesBox.Visible = true;
            
            categoryTitle.Visible = true;
            categoryTitle.BringToFront();
            
            thriller.Visible = true;
            thriller.BringToFront();
            
            comedy.Visible = true;
            comedy.BringToFront();
            
            romance.Visible = true;
            romance.BringToFront();
            
            crime.Visible = true;
            crime.BringToFront();
            
            action.Visible = true;
            action.BringToFront();
            
            documentary.Visible = true;
            documentary.BringToFront();
            
            horror.Visible = true;
            horror.BringToFront();
            
            fantasy.Visible = true;
            fantasy.BringToFront();
            
            drama.Visible = true;
            drama.BringToFront();
            
            mystery.Visible = true;
            mystery.BringToFront();
            
            western.Visible = true;
            western.BringToFront();
            
            scifi.Visible = true;
            scifi.BringToFront();
            //throw new System.NotImplementedException();

        }

        private void categoriesBox_Click(object sender, EventArgs e)
        {
            categoriesBox.Visible = false;
            categoryTitle.Visible = false;
            thriller.Visible = false;
            comedy.Visible = false;
            romance.Visible = false;
            crime.Visible = false;
            action.Visible = false;
            documentary.Visible = false;
            horror.Visible = false;
            fantasy.Visible = false;
            drama.Visible = false;
            mystery.Visible = false;
            western.Visible = false;
            scifi.Visible = false;
            //throw new System.NotImplementedException();
        }
    }
}