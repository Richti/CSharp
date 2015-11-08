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
            ns = commSock.GetStream();
             while(commSock.Connected)
            {
               
                Message message = getMessage();
                // à retravailler (vérifier le type etc)
                
                if(message.head.type == MessageType.LISTE_TOPICS)
                {
                    Message reply = new Message(new Header("Server", MessageType.LISTE_TOPICS_REPLY), listTopics());
                    sendMessage(reply);
                }
                if (message.head.type == MessageType.CREATE_TOPIC)
                {
                    createTopic(message.data);
                }
                if (message.head.type == MessageType.JOIN_TOPIC)
                {
                    IChatroom scr = joinTopic(message.data);
                    int port = ((ServerChatRoom)scr).port;
                    Message reply = new Message(new Header("Server", MessageType.JOIN_REPLY), port.ToString());
                    sendMessage(reply);
                }




            }


        }

        public override object Clone()
        {
            ServerGestTopics clone = new ServerGestTopics(ip);
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
