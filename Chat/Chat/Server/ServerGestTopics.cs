using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Net;
using Chat;
using AuthentificationN;
namespace Server
{
    class ServerGestTopics : TCPServer, ITopicsManager, AuthentificationManager
    {
        public TCPGestTopics concretGT { get; set; }
        public Authentification concretAM { get; set; }

        public ServerGestTopics(IPAddress ip) : base(ip)
        {
            concretGT = new TCPGestTopics(ip); // pattern singleton à faire??
            concretAM = new Authentification(); // idem?
            load("./../../../Users.txt"); // à modifier
        }

        public new void stopServer()
        {
            save("users.txt");
            base.stopServer();           
        }

        public override void gereClient(TcpClient comm) 
        {
            ns = comm.GetStream();
             while(comm.Connected)
            {               
                Message message = getMessage();  
                          
                    switch (message.head.type)
                    {
                        case MessageType.LISTE_TOPICS : 
                            Message reply = new Message(new Header("Server", MessageType.LISTE_TOPICS_REPLY), listTopics());
                            sendMessage(reply);
                            break;
                        case MessageType.CREATE_TOPIC:
                            createTopic(message.data);
                            break;
                        case MessageType.JOIN_TOPIC:
                            IChatroom scr = joinTopic(message.data);
                            int port = ((ServerChatRoom)scr).port;
                            reply = new Message(new Header("Server", MessageType.JOIN_REPLY), port.ToString());
                            sendMessage(reply);
                            break;
                        case MessageType.ADD_USER:
                            String[] userInfo = message.data.Split(';');
                                addUser(userInfo[0], userInfo[1]);
                            break;
                        case MessageType.RM_USER:
                              removeUser(message.data);
                            break;
                        case MessageType.AUTH_USER:
                            userInfo = message.data.Split(';');
                            authentify(userInfo[0], userInfo[1]);
                            break;
                        default:
                            break; 
                    }
            }
        }

        public override object Clone()
        {
            ServerGestTopics clone = new ServerGestTopics(ip);
            clone.concretGT = concretGT;
            clone.concretAM = concretAM;
            clone.commSock = commSock;
            return clone;
        }

        public string listTopics()
        {
            return concretGT.listTopics();
        }
        public IChatroom joinTopic(string topic)
        {
            return concretGT.joinTopic(topic);
        }
        public void createTopic(string name)
        {
            concretGT.createTopic(name);
        }

        public void addUser(string login, string password)
        {
                concretAM.addUser(login, password);                       
        }
        public void removeUser(string login)
        {
                concretAM.removeUser(login);
        }
        public void authentify(string login, string password)
        {
            concretAM.authentify(login, password);
        }
        public void load(string path)
        {
            concretAM.load(path);
        }
        public void save(string path)
        {
            concretAM.save(path);
        }
    }
}
