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
        public IPAddress ip { get; set; }
        public NetworkStream ns { get; set; }

        public bool doRun { get; set; }
        public bool treatClient { get; set; }

        public TCPServer(IPAddress ip)
        {
            this.ip = ip;
            this.treatClient = false; 
            doRun = true;
        }

        public void startServer(int port)
        {
            waitSocket = new TcpListener(ip, port);
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
                 gereClient(commSock);
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
            Message message = Message.Receive(ns);
            return message;
        }

        public void sendMessage(Message m)
        {
            NetworkStream input = commSock.GetStream();
            Message.send(m, input);
        }

        public virtual object Clone()
        {
            return null; 
        }
    }
}

