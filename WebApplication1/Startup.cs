﻿using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
[assembly: Microsoft.Owin.OwinStartup(typeof(WebApplication1.Startup))]

namespace WebApplication1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}