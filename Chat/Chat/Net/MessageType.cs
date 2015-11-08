using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    public enum MessageType { POST, JOINCR, QUITCR, RECV_MSG, LISTE_TOPICS, LISTE_TOPICS_REPLY, CREATE_TOPIC, JOIN_TOPIC, JOIN_REPLY }
    /*  Application protocol : Value of the type attribut 

            Chatroom action :
            0 : send a message to a chatroom(POST) (data : message)
            1 : join a chatroom (JOINCR) (no data)
            2 : quit a chatroom (QUITCR) (no data)
            3 : receive a message (RECV_MSG) (data : message)

            Topic action:
            4 : ask for the list of the topics (LISTE_TOPICS) (no data)
            5 : reply the list of the topics (LISTE_TOPICS_REPLY) (data :list of the topic's name : "topic1,topic2,topic3")
            6 : create a topic (CREATE_TOPIC) (data : name of the topic)
            7 : join a topic (JOIN_TOPIC) (data : name of the topic)
            8 : reply the port of the ServerChatRoom after JOIN_TOPIC(JOIN_REPLY) (data : port)
        */

}
