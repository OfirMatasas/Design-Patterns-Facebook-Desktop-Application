using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FaceBookWinFormsApp
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
