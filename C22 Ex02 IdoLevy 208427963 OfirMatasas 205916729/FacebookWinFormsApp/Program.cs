using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
