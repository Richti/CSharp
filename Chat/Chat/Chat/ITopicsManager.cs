using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    interface ITopicsManager
    {
        String listTopics();
        IChatroom joinTopic(string topic);
        void createTopic(string name);
    }
}
