using SyncDesk.SyncDesk.Forms;
using System;
using System.Windows.Forms;

namespace SyncDesk
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Aqui chamamos a tela de login
        }
    }
}
