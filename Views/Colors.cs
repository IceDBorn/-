using System.Drawing;

namespace filmhub.Views
{
    public class Colors
    {
        #region Fields
        
        // Create global colors
        public Color WindowBarBackgroundColor { get; } = Color.FromArgb(7, 7, 7);
        public Color NavBarBackgroundColor { get; } = Color.FromArgb(20,20,20);
        public Color BackgroundColor { get; } = Color.FromArgb(33,33,33);
        public Color PopOutBackgroundColor { get; } = Color.FromArgb(50,50,50);
        public Color FieldColor { get; } = Color.FromArgb(122,122,122);
        public Color FieldDarkTextColor { get; } = Color.FromArgb(200,200,200);
        public Color AccentColor { get; } = Color.FromArgb(113, 44, 218);
        public Color DarkTextColor { get; } = Color.FromArgb(111, 111, 111);
        
        #endregion
    }
}