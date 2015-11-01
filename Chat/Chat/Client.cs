using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Net
{
    class TCPClient : MessageConnection
    {
        public Socket sock { get; set; }
        public TCPServer serveur { get; set; }

        public void setServer(IPAddress IP, int port)
        {
            
        }

        public void connect()
        {

        }

        public TCPServer getServer()
        {
            return serveur;
        }

        public Message getMessage()
        {
            throw new NotImplementedException();
        }

        public void sendMessage(Message m)
        {
            throw new NotImplementedException();
        }
    }
}
