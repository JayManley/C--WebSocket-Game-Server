﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer.WebSockets.Exceptions
{
    [Serializable]
    public class WebSocketVersionNotSupportedException : Exception
    {
        public WebSocketVersionNotSupportedException() : base()
        {            
        }

        public WebSocketVersionNotSupportedException(string message) : base(message)
        {            
        }

        public WebSocketVersionNotSupportedException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
