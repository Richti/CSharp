using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    interface IChatroom
    {
        void post(string msg, IChatter c);
        void quit(IChatter c);
        void join(IChatter c);
        string getTopic();
    }
}
