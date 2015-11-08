using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat;
using System.Collections;
using System.Net;

namespace Server
{
    class TCPGestTopics : ITopicsManager
    {
        static int nextPort { get; set; }
        public IPAddress ip { get; set; }
        public Hashtable topicsChatRoom { get; set; }

        public TCPGestTopics(IPAddress ip)
        {
            topicsChatRoom = new Hashtable();
            this.ip = ip;
        }

        public void createTopic(string name) 
        {
            if (topicsChatRoom.Contains(name))
            {
                throw new Exception("The topic exists already"); // à modifier
            }
            else
            {
                Console.WriteLine(nextPort);
                ServerChatRoom scr = new ServerChatRoom(ip, name);
                topicsChatRoom.Add(name, scr );
                scr.treatClient = true;
                scr.startServer(nextPort++);
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

        public String listTopics()
        { 
            ICollection topics = topicsChatRoom.Keys;
            String topicsList = "";
            foreach (string topic in topics)
            {
                topicsList += topic + ",";
            }
            return topicsList.Substring(0, topicsList.Length - 1); ; // to remove the last comma
        }


    }
}
