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

        public Header(String sender)
        {
            this.sender = sender;
            this.date = DateTime.Now;
        }

        public override string ToString()
        {
            return "Sender : " + sender + " at " + date;
        }
    }
}
