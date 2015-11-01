using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;
using System.IO;
using System.Threading;

namespace Net
{
    abstract class TCPServer : MessageConnection, ICloneable
    {
        public Socket waitSocket { get; set; }
        public Socket commSocket { get; set; }
        public int port { get; set; }
        public IPAddress ip { get; set; }
        public bool doRun { get; set; }

        public TCPServer(IPAddress ip, int port)
        {
            this.port = port;
            this.ip = ip;
            waitSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            doRun = true;
        }

        public void startServer(int port)
        {
            waitSocket.Bind(new IPEndPoint(ip, port));
            waitSocket.Listen(10);
            run();
        }

        public void stopServer()
        {
            waitSocket.Close();
            doRun = false;
        }

        public void run()
        {
            Console.WriteLine("Lancement Serveur");
            NetworkStream output = null;
            while (doRun)
            {
                try
                {
                    Console.WriteLine("Waiting for a connection...");
                    commSocket = waitSocket.Accept();
                    Console.WriteLine("Connexion établit");
                    output = new NetworkStream(commSocket);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
           
            
        }

        abstract public void gereClient(Socket comm);
   

        public Message getMessage()
        {
            throw new NotImplementedException();
        }

        public void sendMessage(Message m)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}

