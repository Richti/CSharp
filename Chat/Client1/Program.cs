using AuthentificationN;
using Chat;
using FormN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client1
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
            Application.Run(new Connexion(Ip,port));
           // Application.Run(new InfoUser(new User("Vuitton", "Louis")));
        }
    }
}
