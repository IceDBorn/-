using System.Windows.Forms;

namespace filmhub
{
    public partial class WelcomeUserControl : UserControl
    {
        #region Fields

        private readonly Colors _colors = new Colors();

        #endregion
        public WelcomeUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

        private void InitializeColors()
        {
            joinButton.BackColor = _colors.AccentColor;
            joinButton.FlatAppearance.BorderColor = _colors.AccentColor;
            signInButton.BackColor = _colors.AccentColor;
            signInButton.FlatAppearance.BorderColor = _colors.AccentColor;
        }
    }
}