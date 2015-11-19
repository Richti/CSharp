using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public interface IChatter
    {
        void receiveAMessage(string msg, IChatter c);
        string getAlias();
    }
}
