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
        private string _alias;

        public ServerChatRoom(IPAddress Ip, int port) : base(Ip,port)
        {
        }

        public override void gereClient(TcpClient comm)
        {
            Console.WriteLine("WTF?");
        }

        public string alias
        {
            get { return getAlias(); }
            set { _alias = value; }
        }

        public string getAlias()
        {
            return _alias;
        }

        public void receiveAMessage(string msg, IChatter c) // à modifier plus tard !
        {
            Console.WriteLine("(At {0}) : {1} $> {2} ", alias, c.getAlias(), msg);
        }

        public override object Clone()
        {
            ServerChatRoom clone = new ServerChatRoom(ip,port);
            clone.commSock = commSock;
            return clone;
        }
    }
}
