using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Net;
using Chat;

namespace Server
{
    class ServerGestTopics : TCPServer, ITopicsManager
    {
        public TCPGestTopics concretGT { get; set; }
        
        public ServerGestTopics(IPAddress ip) : base(ip)
        {
            concretGT = new TCPGestTopics(ip);
        }

        public override void gereClient(TcpClient comm) 
        {
            ns = comm.GetStream();
             while(comm.Connected)
            {               
                Message message = getMessage();
                Message reply;
                switch (message.head.type)
                {
                    case MessageType.LISTE_TOPICS : 
                        reply = new Message(new Header("Server", MessageType.LISTE_TOPICS_REPLY), listTopics());
                        sendMessage(reply);
                        break;
                    case MessageType.CREATE_TOPIC:
                        createTopic(message.data);
                        break;
                    case MessageType.JOIN_TOPIC:
                        IChatroom scr = joinTopic(message.data);
                        int port = ((ServerChatRoom)scr).port;
                        reply = new Message(new Header("Server", MessageType.JOIN_REPLY), port.ToString());
                        sendMessage(reply);
                        break;
                    default: break; 
                }    
            }
        }

        public override object Clone()
        {
            ServerGestTopics clone = new ServerGestTopics(ip);
            clone.concretGT = concretGT;
            clone.commSock = commSock;
            return clone;
        }

        public string listTopics()
        {
            return concretGT.listTopics();
        }

        public IChatroom joinTopic(string topic)
        {
            return concretGT.joinTopic(topic);
        }

        public void createTopic(string name)
        {
            concretGT.createTopic(name);
        }
    }
}
