using Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Client
{
    class ClientGestTopics : TCPClient
    {
        public ClientGestTopics(IPAddress Ip, int port) : base (Ip,port)
        {
        }
    }
}
