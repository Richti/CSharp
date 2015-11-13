using Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Chat;
using System.Threading;

namespace Client
{
    class ClientChatRoom : TCPClient, IChatroom
    {
        public IChatter chatter { get; set; }
        public String topic { get; set; }
        public bool doRun { get; set; }

        public ClientChatRoom(IPAddress Ip, int port,String topic) : base (Ip,port)
        {
            this.topic = topic;
            doRun = true;
        }

        public string getTopic()
        {
            return topic;
        }

        public void join(IChatter chatter)
        {
            this.chatter = chatter;
            Message request = new Message(new Header(chatter.getAlias(), MessageType.JOINCR), "");
            sendMessage(request);
            Thread t = new Thread(new ThreadStart(runReceiveMsg));
            t.Start();
        }

        public void post(string msg, IChatter c)
        {
            Message request = new Message(new Header(c.getAlias(), MessageType.POST), msg);
            sendMessage(request);
        }

        public void quit(IChatter c)
        {
            Message request = new Message(new Header(c.getAlias(), MessageType.QUITCR), "");
            sendMessage(request);
            doRun = false;
        }

        public void runReceiveMsg() 
        {
            while(doRun)
            {
                Message message = getMessage();
                Console.WriteLine(message); // à modifier plus tard
            }
        }   
    }
}
