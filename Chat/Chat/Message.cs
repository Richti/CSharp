using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    public class Message
    {
        public Header head { get; set; }
        public String data { get; set; }

        public Message()
        {
            Console.WriteLine("Bonjour !");
            Console.WriteLine("Ok c'est bon!");
            Console.WriteLine("Ca devrait le faire pour après !");
            Console.WriteLine("Alors c'est bien ça marche !");
        }
        public Message(Header head, String data)
        {
            this.head = head;
            this.data = data;
        }

        public String toString()
        {
            return head.ToString() + "\n" + data + "\n";
        }
    }
}