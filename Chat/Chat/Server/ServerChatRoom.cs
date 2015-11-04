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
    class ServerChatRoom : TCPServer, IChatter
    {
        // public String pseudo { get; set; } // utilité ?
        // surement add TextChatRoom en attribut
        public ServerChatRoom(IPAddress Ip, int port) : base(Ip,port)
        {
        }

        public override void gereClient(Socket comm)
        {
            throw new NotImplementedException();
        }

        public string getAlias()
        {
            throw new NotImplementedException();
        }

        public void receiveAMessage(string msg, IChatter c)
        {
            throw new NotImplementedException();
        }
    }
}
