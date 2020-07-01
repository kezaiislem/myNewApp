using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm fLogin = new LoginForm();
            /*if (fLogin.ShowDialog() == DialogResult.OK)
            {*/
                Application.Run(new WelcomeFrom());
            /*}
            else
            {
                Application.Exit();
            }*/
            //Application.Run(new MainForm());
        }
    }
}
