using System.Windows.Forms;

namespace filmhub
{
    public partial class FavoritesUserControl : UserControl
    {
        
        #region Fields

        private readonly Colors _colors = new Colors();

        #endregion
        
        public FavoritesUserControl()
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