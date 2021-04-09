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
        }
        
        #endregion

        #region Methods

        private void InitializeColors()
        {
            navBar.BackColor = _colors.BackgroundColor;
            searchBar.BackColor = _colors.FieldColor;
            searchBar.ForeColor = _colors.DarkTextColor;
            mainPage.BackColor = _colors.BackgroundColor;
        }

        #endregion
    }
}