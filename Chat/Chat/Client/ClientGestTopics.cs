using Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Chat;
namespace Chat.Client
{
    class ClientGestTopics : TCPClient, ITopicsManager
    {
        public ClientGestTopics(IPAddress Ip, int port) : base (Ip,port)
        {
        }

        public void createTopic(string name)
        {
            throw new NotImplementedException();
        }

        public IChatroom joinTopic(string topic)
        {
            throw new NotImplementedException();
        }

        public void listTopics()
        {
            throw new NotImplementedException();
        }
    }
}
