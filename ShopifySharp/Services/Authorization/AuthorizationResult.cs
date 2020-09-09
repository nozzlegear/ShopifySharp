namespace ShopifySharp
{
    public class AuthorizationResult
    {
        public string AccessToken { get; }
        public string[] GrantedScopes { get; }

        public AuthorizationResult(string accessToken, string[] grantedScopes)
        {
            this.AccessToken = accessToken;
            this.GrantedScopes = grantedScopes;
        }
    }
}
