﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Linq;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.ActiveDirectory;
using Owin;

namespace GraphExplorer
{
    public partial class Startup
    {
        //// For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
				//Commented following lines of code to bypass authentication
        //    app.UseWindowsAzureActiveDirectoryBearerAuthentication(
        //        new WindowsAzureActiveDirectoryBearerAuthenticationOptions
        //        {
        //            Tenant = ConfigurationManager.AppSettings["ida:Tenant"],
        //            TokenValidationParameters = new TokenValidationParameters
        //            {
        //                ValidAudience = ConfigurationManager.AppSettings["ida:Audience"]
        //            },
        //        }
        //    );
        }
    }
}