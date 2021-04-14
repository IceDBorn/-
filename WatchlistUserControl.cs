using System.Windows.Forms;

namespace filmhub
{
    public partial class WatchlistUserControl : UserControl
    {
        #region Fields

        private readonly Colors _colors = new Colors();

        #endregion
        
        public WatchlistUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }
        
        private void InitializeColors()
        {
            BackColor = _colors.BackgroundColor;
        }
    }
}