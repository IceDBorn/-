using System.Windows.Forms;

namespace filmhub
{
    public partial class HistoryUserControl : UserControl
    {
        #region Fields

        private readonly Colors _colors = new Colors();

        #endregion
        
        public HistoryUserControl()
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