﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    interface MessageConnection
    {
        Message getMessage();

        void sendMessage(Message m);
    }
}
