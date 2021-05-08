using System;
using System.Windows.Forms;
using filmhub.Models;
using filmhub.Views;

namespace filmhub
{
    internal static class Program
    {
        #region Constructor
        
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Colors = new Colors();
            
            if (Properties.Settings.Default.Theme == 0)
            {
                Colors.DarkTheme();
            }
            else
            {
                Colors.LightTheme();
            }
            
            MainForm = new MainForm();
            Application.Run(MainForm);
        }
        
        #endregion
        
        public static MainForm MainForm{ get; private set; }
        
        public static Colors Colors { get; private set; }
    }
}