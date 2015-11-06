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
    class ClientChatRoom : TCPClient, IChatroom
    {
        public ClientChatRoom(IPAddress Ip, int port) : base (Ip,port)
        {
        }

        public string getTopic()
        {
            throw new NotImplementedException();
        }

        public void join(IChatter c)
        {
            throw new NotImplementedException();
        }

        public void post(string msg, IChatter c)
        {
            throw new NotImplementedException();
        }

        public void quit(IChatter c)
        {
            throw new NotImplementedException();
        }
    }
}
