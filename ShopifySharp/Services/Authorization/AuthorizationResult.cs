#nullable enable

namespace ShopifySharp;

public class AuthorizationResult(string accessToken, string[]? grantedScopes)
{
    public string AccessToken { get; } = accessToken;
    public string[]? GrantedScopes { get; } = grantedScopes;
}