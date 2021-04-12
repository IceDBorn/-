using System;
using System.Windows.Forms;

namespace filmhub
{
    public partial class OpenMovie : UserControl
    {
        #region Fields

        private readonly Colors _colors = new Colors();

        #endregion
        
        public OpenMovie()
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