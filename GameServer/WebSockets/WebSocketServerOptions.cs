﻿using System;

namespace GameServer
{
    /// <summary>
    /// Server WebSocket init options
    /// </summary>
    public class WebSocketServerOptions
    {
        /// <summary>
        /// How often to send ping requests to the Client
        /// The default is 60 seconds
        /// This is done to prevent proxy servers from closing your connection
        /// A timespan of zero will disable the automatic ping pong mechanism
        /// You can manually control ping pong messages using the PingPongManager class.
        /// If you do that it is advisible to set this KeepAliveInterval to zero in the WebSocketServerFactory
        /// </summary>
        public TimeSpan KeepAliveInterval { get; set; }

        /// <summary>
        /// Include the full exception (with stack trace) in the close response 
        /// when an exception is encountered and the WebSocket connection is closed
        /// The default is false
        /// </summary>
        public bool IncludeExceptionInCloseResponse { get; set; }

        /// <summary>
        /// Initialises a new instance of the WebSocketServerOptions class
        /// </summary>
        public WebSocketServerOptions()
        {
            KeepAliveInterval = TimeSpan.FromSeconds(60);
            IncludeExceptionInCloseResponse = false;
        }
    }
}
