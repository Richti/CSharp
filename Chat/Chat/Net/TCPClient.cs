using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Net
{
    class TCPClient : MessageConnection
    {
        public TcpClient commSock { get; set; }
        public TCPServer serveur { get; set; }
        public IPAddress Ip { get; set; }
        public int port { get; set; }

        public TCPClient(IPAddress Ip, int port)
        {
            this.Ip = Ip;
            this.port = port;
            commSock = new TcpClient();
            setServer(Ip, port);
        }

        public void setServer(IPAddress Ip, int port)
        {
            serveur = new ServerGestTopics(Ip,port); 
        }

        public void connect() // à modifier
        {
            try
            {
                commSock.Connect(Ip, port);
                Console.WriteLine("Connecté");
                Message message = getMessage();
                Console.WriteLine(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (commSock != null)
                {
                    commSock.Close();
                }
            }
       
        }

        public TCPServer getServer()
        {
            return serveur;
        }

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
    }
}
