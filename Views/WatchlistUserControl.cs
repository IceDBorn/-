using System.Windows.Forms;

namespace filmhub.Views
{
    public partial class WatchlistUserControl : UserControl
    {
        
        public WatchlistUserControl()
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