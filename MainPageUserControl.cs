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
            panel2.BackColor = _colors.BackgroundColor;
            categoryTitle.ForeColor = _colors.AccentColor;

            panel2.Visible = false;
        }


        private void menu_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void MainPageUserControl_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}