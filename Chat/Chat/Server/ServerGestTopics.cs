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
        
        public ServerGestTopics(IPAddress ip, int port) : base(ip,port)
        {
            concretGT = new TCPGestTopics();
        }

        public override void gereClient(TcpClient comm)
        {
            throw new NotImplementedException();
        }

        public void listTopics()
        {
            throw new NotImplementedException();
        }

        public IChatroom joinTopic(string topic)
        {
            throw new NotImplementedException();
        }

        public void createTopic(string name)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            ServerChatRoom clone = new ServerChatRoom(ip, port);
            clone.commSock = commSock;
            return clone;
        }
    }
}
