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
    class ServerGestTopics : TCPServer
    {
        public TCPGestTopics concretGT { get; set; }
        
        public ServerGestTopics(IPAddress ip, int port) : base(ip,port)
        {
            concretGT = new TCPGestTopics();
        }

        public override void gereClient(TcpClient comm)
        {
            ns = commSock.GetStream();
            // while(commSock.Connected)
            {
               
                Message message = getMessage();
                // à retravailler (vérifier le type etc)
                
                if(message.head.type == MessageType.LISTE_TOPICS)
                {
                    Message reply = new Message(new Header("Server", MessageType.LISTE_TOPICS_REPLY), concretGT.listTopics());
                    sendMessage(reply);
                }
                
                
                
            }
            
            
        }

        public override object Clone()
        {
            ServerGestTopics clone = new ServerGestTopics(ip, port);
            clone.commSock = commSock;
            return clone;
        }
    }
}
