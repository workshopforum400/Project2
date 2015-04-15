﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridges;
using Project2;

namespace AcceptanceTests
{   
    class Driver
    { 

        public static Bridge getBridge()
        {
            ProxyBridge proxy = new ProxyBridge();
            proxy.setRealBridge(new RealBridge());
            Bridge bridge = (Bridge)proxy;
            // comment out if domain layer not yet implemented
            return bridge;
        }

    }
}
