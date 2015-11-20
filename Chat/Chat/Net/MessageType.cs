using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    public enum MessageType
    {
        POST, JOINCR, QUITCR, RECV_MSG,
        LISTE_TOPICS, LISTE_TOPICS_REPLY, CREATE_TOPIC, JOIN_TOPIC, JOIN_REPLY,
        ADD_USER, RM_USER, AUTH_USER,
        ERROR, CONFIRM
    }

    public enum ErrorType
    {
        TOPIC_EXISTING, USER_EXISTING, WRONG_PWD, USER_UNKNOWN, UNKNOWN_EX
    }

    /*  Application protocol : Value of the type attribut 

        Chatroom action :
        POST (0) : send a message to a chatroom (data : message)
        JOINCR (1) : join a chatroom (no data)
        QUITCR (2) : quit a chatroom  (no data)
        RECV_MSG (3) : receive a message (data : message)

        Topic action :
        LISTE_TOPICS (4) : ask for the list of the topics (no data)
        LISTE_TOPICS_REPLY (5) : reply the list of the topics (data :list of the topic's name : "topic1,topic2,topic3")
        CREATE_TOPIC (6) : create a topic (data : name of the topic)
        JOIN_TOPIC (7) : join a topic (data : name of the topic)
        JOIN_REPLY (8) : reply the port of the ServerChatRoom after JOIN_TOPIC (data : port)

        Authentification action :
        ADD_USER (9) : add a user (data : "login;password")
        RM_USER (10) : remove a user (data : login)
        AUTH_USER (11) : authentify a user (data : "login;password")

        Exceptions Management :
        ERROR (12) : send an error to the client (data : ErrorType;message)
        CONFIRM (13) : send a confirmation to the client when there is no other reply (no data)
    */

}
