using Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Chat;
using System.Collections;

namespace Client
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

        public String listTopics()
        {
            Message request = new Message(new Header("Client", MessageType.LISTE_TOPICS), "Empty");
            sendMessage(request);
            Message message = getMessage();
            return message.data;
        }

        public override void testEvent()
        {
            Console.WriteLine("Liste des topics : " + listTopics());
        }
    }
    
}
