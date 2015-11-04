using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Net;


namespace Server
{
    class ServerGestTopics : TCPServer
    {
        // surement add TCPGestTopics en attribut
        public ServerGestTopics(IPAddress ip, int port) : base(ip,port)
        {
        }

        public override void gereClient(Socket comm)
        {
            throw new NotImplementedException();
        }
    }
}
