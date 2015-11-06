using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat;
using System.Collections;

namespace Server
{
    class TCPGestTopics : ITopicsManager
    {
        static int nextPort { get; set; }
        public Hashtable topicsChatRoom { get; set; }


        public void createTopic(string name)
        {
            if (topicsChatRoom.Contains(name))
            {
                Console.WriteLine("The topic is already existing");
            }
            else
            {
                topicsChatRoom.Add(name, new List<IChatroom>());
            }

        }

        public IChatroom joinTopic(string topic)
        {
            if (topicsChatRoom.Contains(topic))
            {
                TextChatRoom cr = new TextChatRoom(topic);
                if ((topicsChatRoom[topic] != null) && (topicsChatRoom[topic] is List<IChatroom>))
                {
                    List<IChatroom> l = (List<IChatroom>)topicsChatRoom[topic];
                    l.Add(cr);
                }
                return cr;
            }
            else
            {
                Console.WriteLine("Topic non existant");
                return null;
            }
        }

        public void listTopics()
        {
            ICollection topics = topicsChatRoom.Keys;
            if (topics.Count == 0)
            {
                Console.WriteLine("There is no topics.");
            }
            else
            {
                Console.WriteLine("The openned topics are : ");
                foreach (string topic in topics)
                {
                    Console.WriteLine(topic);
                }
            }

        }
    }
}
