using System;
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
            string hour, min, second;
            if(date.Hour < 10)
            {
                hour = "0" + date.Hour.ToString();
            }
            else
            {
                hour = date.Hour.ToString();
            }
            if (date.Minute < 10)
            {
                min = "0" + date.Minute.ToString();
            }
            else
            {
                min = date.Minute.ToString();
            }
            if (date.Second < 10)
            {
                second = "0" + date.Second.ToString();
            }
            else
            {
                second = date.Second.ToString();
            }
            return "["+ hour + ":" + min + ":" + second + "] " + "<" + sender + "> ";
        }
    }
}
