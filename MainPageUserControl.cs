using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            listBox1.BackColor = _colors.BackgroundColor;
            panel2.BackColor = _colors.BackgroundColor;
            categoriesTitle.ForeColor = _colors.AccentColor;
        }


        private void menu_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void MainPageUserControl_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        
        
        private void listBox1_Click(object sender, EventArgs e)
        {
            var lbox = listBox1.SelectedIndex;
            for (var i = 0; i <= 12; i++)
            {
                if (lbox == i)
                {
                    panel2.Visible = false;
                }
            }
        }
    }
}