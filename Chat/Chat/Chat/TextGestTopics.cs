using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class TextGestTopics : ITopicsManager
    {
        public Hashtable topicsChatRoom { get; set; }

        public TextGestTopics()
        {
            topicsChatRoom = new Hashtable();
        }

        public void createTopic(string name)
        {
            if (topicsChatRoom.Contains(name))
            {
                Console.WriteLine("The topic is already existing");
            }
            else
            {
                topicsChatRoom.Add(name, null);
            }
                
        }

        public IChatroom joinTopic(string topic)
        {
            if(topicsChatRoom.Contains(topic))
            { 
                if((topicsChatRoom[topic] != null) && (topicsChatRoom[topic] is TextChatRoom))
                {
                    return (TextChatRoom)topicsChatRoom[topic];
                }
                return new TextChatRoom(topic); ;
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
            if(topics.Count == 0)
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
