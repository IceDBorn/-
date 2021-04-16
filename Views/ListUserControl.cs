using System;
using System.Windows.Forms;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class ListUserControl : UserControl
    {
        public ListUserControl(string title, bool flag)
        {
            InitializeComponent();
            InitializeColors();
            menu.Visible = flag;
            window.Text = title;
        }
        
        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            listView1.BackColor = Program.Colors.BackgroundColor;
        }
        
        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Image = Resources.menu;
            GC.Collect();
        }
        
        private void menu_MouseHover(object sender, EventArgs e)
        {
            menu.Image = Resources.menu_hover;
            GC.Collect();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            categoriesPanel.Controls.Clear();
            categoriesPanel.Controls.Add(new CategoriesUserControl());
            categoriesPanel.Visible = true;
        }
    }
}