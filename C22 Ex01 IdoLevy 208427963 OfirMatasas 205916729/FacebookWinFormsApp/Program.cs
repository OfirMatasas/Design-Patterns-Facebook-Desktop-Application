using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FaceBookWinFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
