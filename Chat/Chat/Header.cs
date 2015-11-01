using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    public class Header
    {
        public String sender { get; set; }
        public DateTime date { get; set; }

        public Header(String sender, DateTime date)
        {
            this.sender = sender;
            this.date = date;
        }

        public override string ToString()
        {
            return "Sender : " + sender + " at " + date;
        }
    }
}
