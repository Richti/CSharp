using Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Chat;
using System.Collections;
using AuthentificationN;

namespace Client
{
    public class ClientGestTopics : TCPClient, ITopicsManager
    {
        
        public ClientGestTopics(IPAddress Ip, int port) : base (Ip,port)
        {            
        }

        public void addUser(string login, string password)
        {
            Message request = new Message(new Header("Client", MessageType.ADD_USER), login + ";" + password);
            sendMessage(request);
            receiveReply();
        }
        public void removeUser(string login)
        {
            Message request = new Message(new Header("Client", MessageType.RM_USER), login);
            sendMessage(request);
            receiveReply();
        }
        public void authentify(string login, string password)
        {
            Message request = new Message(new Header("Client", MessageType.AUTH_USER), login + ";" + password);
            sendMessage(request);
            receiveReply();
        }

        public void createTopic(string name)
        {
            Message request = new Message(new Header("Client", MessageType.CREATE_TOPIC), name);
            sendMessage(request);
            receiveReply();
        }
        public IChatroom joinTopic(string topic)
        {
            Message request = new Message(new Header("Client", MessageType.JOIN_TOPIC), topic);
            sendMessage(request);
            Message reply = getMessage();
            int port =  int.Parse(reply.data);
            ClientChatRoom ccr = new ClientChatRoom(Ip,port,topic);
            ccr.connect();
            return ccr;
        }
        public String listTopics()
        {
            Message request = new Message(new Header("Client", MessageType.LISTE_TOPICS), "");
            sendMessage(request);
            Message reply = getMessage();
            return reply.data;
        }

        private void receiveReply()
        {
            Message reply = getMessage();
            if (reply.head.type == MessageType.ERROR)
            {
                String[] replyData = reply.data.Split(';');
                ErrorType errorType = (ErrorType) Enum.Parse(typeof(ErrorType), replyData[0], true); 

                switch (errorType)
                {
                    case ErrorType.USER_EXISTING:
                        throw new UserExistsException(replyData[1]);
                    case ErrorType.USER_UNKNOWN:
                        throw new UserUnknownException(replyData[1]);
                    case ErrorType.WRONG_PWD:
                        throw new WrongPasswordException(replyData[1]);
                    case ErrorType.TOPIC_EXISTING:
                        throw new TopicExistsException(replyData[1]);
                    default:
                        throw new Exception(replyData[1]);
                }
            }
        }

    }
    
}
