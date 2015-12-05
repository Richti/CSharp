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
            ns = comm.GetStream();
            while (comm.Connected)
            {
                Message message = getMessage();
                if(message==null) { return; }
                switch(message.head.type)
                {
                    case MessageType.JOINCR:
                        this.alias = message.head.sender;
                        join(this);
                        break;
                    case MessageType.POST:
                        post(message.data,this);
                        break;
                    case MessageType.QUITCR:
                        quit(this);
                        break;
                    default: break;
                }

            }
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

        public void receiveAMessage(string msg, IChatter c) 
        {
            Message message = new Message(new Header(c.getAlias(),MessageType.RECV_MSG),msg);
            sendMessage(message);
        }

        public override object Clone() 
        {
            ServerChatRoom clone = new ServerChatRoom(ip,concretCR.topic);
            clone.concretCR = concretCR;
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
            post(" s'est déconnecté(e).", c);
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
