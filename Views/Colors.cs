using System.Drawing;

namespace filmhub.Views
{
    public class Colors
    {
        #region Fields

        public Color WindowBarBackgroundColor { get; private set; }

        public Color NavBarBackgroundColor { get; private set; }

        public Color BackgroundColor { get; private set; }

        public Color PopOutBackgroundColor { get; private set; }

        public Color FieldColor { get; private set; }

        public Color FieldDarkTextColor { get; private set; }

        public Color AccentColor { get; private set; }

        public Color DarkTextColor { get; private set; }
        
        public Color ForeColor { get; private set; }
        
        public int Theme { get; private set; }

        #endregion

        #region Methods

        public void DarkTheme()
        {
            WindowBarBackgroundColor = Color.FromArgb(7, 7, 7);
            NavBarBackgroundColor = Color.FromArgb(20,20,20);
            BackgroundColor = Color.FromArgb(33,33,33);
            PopOutBackgroundColor = Color.FromArgb(50,50,50);
            FieldColor = Color.FromArgb(122,122,122);
            FieldDarkTextColor = Color.FromArgb(200,200,200);
            AccentColor = Color.FromArgb(113, 44, 218);
            DarkTextColor = Color.FromArgb(111, 111, 111);
            ForeColor = Color.White;
            Theme = 0;
        }

        public void LightTheme()
        {
            WindowBarBackgroundColor = Color.FromArgb(206, 206, 206);
            NavBarBackgroundColor = Color.FromArgb(234,234,234);
            BackgroundColor = Color.FromArgb(255,255,255);
            PopOutBackgroundColor = Color.FromArgb(247,247,247);
            FieldColor = Color.FromArgb(200,200,200);
            FieldDarkTextColor = Color.FromArgb(100,100,100);
            AccentColor = Color.FromArgb(113, 44, 218);
            DarkTextColor = Color.FromArgb(40, 40, 40);
            ForeColor = Color.Black;
            Theme = 1;
        }

        #endregion
    }
}