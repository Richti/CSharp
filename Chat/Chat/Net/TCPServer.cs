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
        public TcpListener waitSocket { get; set; }
        public TcpClient commSock { get; set; }
        public int port { get; set; }
        public IPAddress ip { get; set; }
       
        public bool doRun { get; set; }
        public bool treatClient { get; set; }

        public TCPServer(IPAddress ip, int port)
        {
            this.port = port;
            this.ip = ip;
            this.treatClient = false;
            waitSocket = new TcpListener(ip,port);
            doRun = true;
        }

        public void startServer()
        {
            waitSocket.Start();
            run();
        }

        public void stopServer()
        {
            waitSocket.Stop();
            doRun = false;
        }

        public void run()
        {
            Console.WriteLine("Lancement Serveur");
            if(treatClient)
            {
                // gereClient(commSock);

                // juste pour le test
                Message message = new Message(new Header("Paulo"), "Salut Toi!");
                sendMessage(message);
            }
            else
            {
                while (doRun)
                {
                    try
                    {
                        Console.WriteLine("Waiting for a connection...");
                        commSock = waitSocket.AcceptTcpClient();
                        Console.WriteLine("Connexion établit");

                        TCPServer myClone = (TCPServer)Clone();
                        myClone.treatClient = true;
                        Thread newClient = new Thread(new ThreadStart(myClone.run));
                        newClient.Start(); 
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }
                }
            }   
        }

        abstract public void gereClient(TcpClient comm);


        public Message getMessage() 
        {
            NetworkStream output = commSock.GetStream();
            Message message = Message.Receive(output);
            output.Close();
            return message;
        }

        public void sendMessage(Message m) 
        {
            NetworkStream input = commSock.GetStream();
            Message.send(m, input);
            input.Close();
        }

        public virtual object Clone()
        {
            return null; 
        }
    }
}

