using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class TextChatter : IChatter
    {
        private string _alias;

        public TextChatter(string alias)
        {
            this.alias = alias;
        }

        public string alias
        {
            get { return getAlias(); }
            set { _alias = value; }
        }



        public string getAlias()
        {
            return _alias;
        }

        public void receiveAMessage(string msg, IChatter c)
        {
            Console.WriteLine("(At {0}) : {1} $> {2} ", alias, c.getAlias(), msg);
        }
    }
}
