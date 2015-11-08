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
                topicsChatRoom.Add(name, new TextChatRoom(name));
            }      
        }

        public IChatroom joinTopic(string topic)
        {
            if(topicsChatRoom.Contains(topic))
            { 
                 return (TextChatRoom)topicsChatRoom[topic];                
            }
            else
            {
                Console.WriteLine("Topic non existant");
                return null;
            }
        }

        public String listTopics()
        {
            ICollection topics = topicsChatRoom.Keys;
            String topicsList = "";
            if(topics.Count == 0)
            {
                return "There is no topics.\n";
            }
            else
            {
                topicsList = "The openned topics are : \n";
                foreach (string topic in topics)
                {
                    topicsList += topic + ",";
                }
                return topicsList.Substring(0, topicsList.Length - 1); ; // to remove the last comma
            }
          
        }
    }
}
