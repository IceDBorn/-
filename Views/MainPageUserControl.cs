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
            categoriesPanel.Controls.Clear();
            categoriesPanel.Controls.Add(new CategoriesUserControl());
        }
        
        #endregion

        #region Methods
        
        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            menu.BackColor = Program.Colors.BackgroundColor;
            categoriesPanel.BackColor = Program.Colors.PopOutBackgroundColor;
        }
        
        #endregion

        #region Events

        private void menu_Click(object sender, EventArgs e)
        {
            categoriesPanel.Visible = true;
            Program.MainForm.HideDropDown();
        }

        private void MainPageUserControl_Click(object sender, EventArgs e)
        {
            categoriesPanel.Visible = false;
            Program.MainForm.HideDropDown();
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