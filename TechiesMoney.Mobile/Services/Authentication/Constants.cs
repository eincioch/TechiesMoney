using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesMoney.Mobile.Services.Authentication
{
    public static class Constants
    {
        public static readonly string ClientId = "xxxxxxxx-xxxx-xxxxx-xxxx-xxxxxxxx";
        public static readonly string[] Scopes = new string[] { "openid", "offline_access" };        

        public static readonly string TenantName = "xxxxxxxx";
        public static readonly string TenantId = $"{TenantName}.onmicrosoft.com";
        public static readonly string SignInPolicy = "B2C_1_SignupSignIn";
        public static readonly string AuthorityBase = $"https://{TenantName}.b2clogin.com/tfp/{TenantId}/";
        public static readonly string AuthoritySignIn = $"{AuthorityBase}{SignInPolicy}";
        public static readonly string AccountEnvironment = $"{TenantName}.b2clogin.com";        
    }
}
