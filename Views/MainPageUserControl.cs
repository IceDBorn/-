using System;
using System.Drawing;
using System.Windows.Forms;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class MainPageUserControl : UserControl
    {

        #region Constructor
        
        public MainPageUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }
        
        #endregion

        #region Methods
        
        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            menu.BackColor = Program.Colors.BackgroundColor;
            categoriesPanel.BackColor = Program.Colors.PopOutBackgroundColor;
            categoriesLabel.BackColor = Program.Colors.PopOutBackgroundColor;
        }
        
        #endregion

        #region Events

        private void menu_Click(object sender, EventArgs e)
        {
            categoriesPanel.Visible = true;
            categoriesLabel.Visible = true;
            Program.MainForm.HideDropDown();
        }

        private void MainPageUserControl_Click(object sender, EventArgs e)
        {
            categoriesPanel.Visible = false;
            categoriesLabel.Visible = false;
            Program.MainForm.HideDropDown();
        }

        private void actionLabel_MouseHover(object sender, EventArgs e)
        {
            actionLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void actionLabel_MouseLeave(object sender, EventArgs e)
        {
            actionLabel.ForeColor = Color.White;
        }

        private void actionLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void comedyLabel_MouseHover(object sender, EventArgs e)
        {
            comedyLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void comedyLabel_MouseLeave(object sender, EventArgs e)
        {
            comedyLabel.ForeColor = Color.White;
        }

        private void comedyLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void crimeLabel_MouseHover(object sender, EventArgs e)
        {
            crimeLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void crimeLabel_MouseLeave(object sender, EventArgs e)
        {
            crimeLabel.ForeColor = Color.White;
        }

        private void crimeLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void documentaryLabel_MouseHover(object sender, EventArgs e)
        {
            documentaryLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void documentaryLabel_MouseLeave(object sender, EventArgs e)
        {
            documentaryLabel.ForeColor = Color.White;
        }

        private void documentaryLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void dramaLabel_MouseHover(object sender, EventArgs e)
        {
            dramaLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void dramaLabel_MouseLeave(object sender, EventArgs e)
        {
            dramaLabel.ForeColor = Color.White;
        }

        private void dramaLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void fantasyLabel_MouseHover(object sender, EventArgs e)
        {
            fantasyLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void fantasyLabel_MouseLeave(object sender, EventArgs e)
        {
            fantasyLabel.ForeColor = Color.White;
        }

        private void fantasyLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void horrorLabel_MouseHover(object sender, EventArgs e)
        {
            horrorLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void horrorLabel_MouseLeave(object sender, EventArgs e)
        {
            horrorLabel.ForeColor = Color.White;
        }

        private void horrorLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void mysteryLabel_MouseHover(object sender, EventArgs e)
        {
            mysteryLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void mysteryLabel_MouseLeave(object sender, EventArgs e)
        {
            mysteryLabel.ForeColor = Color.White;
        }

        private void mysteryLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void romanceLabel_MouseHover(object sender, EventArgs e)
        {
            romanceLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void romanceLabel_MouseLeave(object sender, EventArgs e)
        {
            romanceLabel.ForeColor = Color.White;
        }

        private void romanceLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void scifiLabel_MouseHover(object sender, EventArgs e)
        {
            scifiLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void scifiLabel_MouseLeave(object sender, EventArgs e)
        {
            scifiLabel.ForeColor = Color.White;
        }

        private void scifiLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void westernLabel_MouseHover(object sender, EventArgs e)
        {
            westernLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void westernLabel_MouseLeave(object sender, EventArgs e)
        {
            westernLabel.ForeColor = Color.White;
        }

        private void westernLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
        }
        
        private void menu_MouseHover(object sender, EventArgs e)
        {
            menu.Image = Resources.menu_hover;
            GC.Collect();
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Image = Resources.menu;
            GC.Collect();
        }
        
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new MovieViewer(), true);
        }
    }
}