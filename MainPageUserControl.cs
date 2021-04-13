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
        }
    }
}