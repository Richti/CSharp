using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat;
using System.Collections;
using System.Net;
using System.Threading;

namespace Server
{
    class TCPGestTopics : ITopicsManager
    {
        static int nextPort { get; set; }
        public IPAddress ip { get; set; }
        public Hashtable topicsChatRoom { get; set; }

        static TCPGestTopics()
        {
            nextPort = 12000;
        }
        public TCPGestTopics(IPAddress ip)
        {
            topicsChatRoom = new Hashtable();
            this.ip = ip;
        }

        public void createTopic(string name)
        {
            lock(topicsChatRoom)
            {
                if (topicsChatRoom.Contains(name))
                {                    
                    throw new TopicExistsException("The topic exists already"); 
                }
                else
                {
                    Console.WriteLine(nextPort);
                    ServerChatRoom scr = new ServerChatRoom(ip, name);
                    topicsChatRoom.Add(name, scr);
                    ParameterizedThreadStart ts = new ParameterizedThreadStart(scr.startServer);
                    Thread t = new Thread(ts);
                    t.Start(nextPort++);
                }
            }
           

        }

        public IChatroom joinTopic(string topic)
        {
            lock (topicsChatRoom)
            {
                if (topicsChatRoom.Contains(topic))
                {
                    return (ServerChatRoom)topicsChatRoom[topic];
                }
                else
                {
                    return null;
                }
            }  
        }

        public String listTopics()
        {
            lock (topicsChatRoom)
            {
                ICollection topics = topicsChatRoom.Keys;
                String topicsList = "";
                if (topics.Count == 0) { return topicsList; }
                foreach (string topic in topics)
                {
                    topicsList += topic + ";";
                }
                return topicsList.Substring(0, topicsList.Length - 1); ; // to remove the last comma
            }      
        }


    }
}
