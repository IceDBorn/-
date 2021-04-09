using System;
using System.Windows.Forms;

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
            Application.Run(new MainForm());
        }
        
        #endregion
    }
}