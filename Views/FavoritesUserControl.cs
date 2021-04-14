using System.Windows.Forms;

namespace filmhub.Views
{
    public partial class FavoritesUserControl : UserControl
    {
        
        public FavoritesUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }
        
        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
        }
    }
}