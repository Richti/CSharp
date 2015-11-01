﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class TextChatRoom : IChatroom
    {
        public List<IChatter> textChatters { get; set; }
        public String topic { get; set; }

        public TextChatRoom(string topic)
        {
            textChatters = new List<IChatter>();
            this.topic = topic;
        } 

        public string getTopic()
        {
            return topic;
        }

        public void join(IChatter c)
        {
            Console.WriteLine("(Message from Chatroom : {0}) {1}  has join the room.", topic,c.getAlias());
            textChatters.Add(c);
        }

        public void post(string msg, IChatter c)
        {
            foreach(TextChatter chatter in textChatters)
            {
                chatter.receiveAMessage(msg, c);
            }
        }

        public void quit(IChatter c)
        {
            textChatters.Remove(c);
        }
    }
}
