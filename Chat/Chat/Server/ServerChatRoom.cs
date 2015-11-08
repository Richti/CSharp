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
    class ServerChatRoom : TCPServer,IChatroom, IChatter 
    {
        public TextChatRoom concretCR { get; set; }
        private string _alias;

        public ServerChatRoom(IPAddress Ip, String topicName) : base(Ip)
        {
            concretCR = new TextChatRoom(topicName);
        }

        public override void gereClient(TcpClient comm)
        {
            Console.WriteLine("gere client du serverChatroom à faire !");
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
            ServerChatRoom clone = new ServerChatRoom(ip,concretCR.topic);
            clone.commSock = commSock;
            return clone;
        }

        public void post(string msg, IChatter c)
        {
            concretCR.post(msg, c);
        }

        public void quit(IChatter c)
        {
            concretCR.quit(c);
        }

        public void join(IChatter c)
        {
            concretCR.join(c);
        }

        public string getTopic()
        {
            return concretCR.getTopic();
        }
    }
}
