using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class AuthorizationResult
    {
        public string AccessToken { get; }
        public string[] GrantedScopes { get; }

        internal AuthorizationResult(string accessToken, string[] grantedScopes)
        {
            this.AccessToken = accessToken;
            this.GrantedScopes = grantedScopes;
        }
    }
}
