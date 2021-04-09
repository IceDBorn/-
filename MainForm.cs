using System.Drawing;
using System.Windows.Forms;

namespace filmhub
{
    public partial class MainForm : Form
    {
        #region Colors

        private readonly Color _backgroundColor = Color.FromArgb(33,33,33);
        private readonly Color _fieldColor = Color.FromArgb(122,122,122);
        private readonly Color _darkTextColor = Color.FromArgb(200,200,200);
        
        #endregion
        public MainForm()
        {
            InitializeComponent();
            navBar.BackColor = _backgroundColor;
            searchBar.BackColor = _fieldColor;
            searchBar.ForeColor = _darkTextColor;
            mainPage.BackColor = _backgroundColor;
        }
    }
}