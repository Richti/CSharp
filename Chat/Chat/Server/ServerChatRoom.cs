using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Net;
using System.Net;
using Chat;

namespace Server
{
    class ServerChatRoom : TCPServer, IChatter
    {
        public TextChatRoom concretCR { get; set; }
        public ServerChatRoom(IPAddress Ip, int port) : base(Ip,port)
        {
        }

        public override void gereClient(TcpClient comm)
        {
            throw new NotImplementedException();
        }

        public string getAlias()
        {
            throw new NotImplementedException();
        }

        public void receiveAMessage(string msg, IChatter c)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            ServerChatRoom clone = new ServerChatRoom(ip,port);
            clone.commSock = commSock;
            return clone;
        }
    }
}
