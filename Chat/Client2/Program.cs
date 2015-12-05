using System;
using System.Net;
using Chat;
using System.Windows.Forms;
using FormN;
using System.Threading;

namespace Client2
{
    static class Program
    {
        
        private static int port = 55555;
        private static IPAddress Ip = IPAddress.Parse("127.0.0.1");
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connexion(Ip, port));
        }
        
    }
}
