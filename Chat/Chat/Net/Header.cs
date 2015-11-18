﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Net
{

    [Serializable]
    public class Header
    {
        public String sender { get; set; }
        public DateTime date { get; set; }    
        public MessageType type { get; set; } 


        public Header(String sender,MessageType type)
        {
            this.sender = sender;
            this.date = DateTime.Now;
            this.type = type;
        }

        public override string ToString()
        {
            return "["+ date.Hour + ":" + date.Minute + ":" + date.Second + "] " + "<" + sender + "> ";
        }
    }
}
