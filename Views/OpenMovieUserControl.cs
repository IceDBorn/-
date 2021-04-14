using System.Windows.Forms;

namespace filmhub.Views
{
    public partial class OpenMovie : UserControl
    {
        public OpenMovie()
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