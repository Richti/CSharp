﻿using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Net
{
    public class TCPClient : MessageConnection
    {
        public TcpClient commSock { get; set; }
        public IPAddress Ip { get; set; }
        public int port { get; set; }
        public NetworkStream ns { get; set; }

        public TCPClient(IPAddress Ip, int port)
        {
            this.Ip = Ip;
            this.port = port;
            commSock = new TcpClient();
        }

        public void setServer(IPAddress Ip, int port)
        {
            this.Ip = Ip;
            this.port = port;
        }

        public void connect() 
        {
            commSock.Connect(Ip, port);
            ns = commSock.GetStream(); 
        }

        public Message getMessage() 
        {
            Message message = Message.Receive(ns);
            return message;
        }
        public void sendMessage(Message m) 
        {
                Message.send(m, ns); 
        }

        ~TCPClient()
        {
            if(commSock != null)
            {
                commSock.Close();
            }
            if (ns != null)
            {
                ns.Close();
            }
        }
    }
}
