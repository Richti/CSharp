using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    class Server : TCPServer
    {
        public Server(IPAddress ip, int port) : base(ip,port)
        {
        }

        public override void gereClient(Socket comm)
        {
            throw new NotImplementedException();
        }
    }
}
