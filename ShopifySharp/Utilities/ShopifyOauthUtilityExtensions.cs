#nullable enable
using System;
using System.Threading.Tasks;

namespace ShopifySharp.Utilities;

public static class ShopifyOauthUtilityExtensions
{
    extension(IShopifyOauthUtility shopifyOauthUtility)
    {
        /// <summary>
        /// Authorizes an application installation, optionally requesting Shopify's expiring offline token flow.
        /// </summary>
        public Task<AuthorizationResult> AuthorizeAsync(string code,
            string shopDomain,
            string clientId,
            string clientSecret,
            bool expiring
        )
        {
            if (shopifyOauthUtility == null)
                throw new ArgumentNullException(nameof(shopifyOauthUtility));

            return shopifyOauthUtility.AuthorizeAsync(new AuthorizeOptions
            {
                Code = code,
                ShopDomain = shopDomain,
                ClientId = clientId,
                ClientSecret = clientSecret,
                Expiring = expiring
            });
        }

        /// <summary>
        /// Refreshes an expiring offline access token only when it is expired or about to expire.
        /// Returns the current authorization result unchanged when a refresh is not needed.
        /// </summary>
        public Task<AuthorizationResult> RefreshAccessTokenIfNeededAsync(RefreshAccessTokenIfNeededOptions options)
        {
            if (shopifyOauthUtility == null)
                throw new ArgumentNullException(nameof(shopifyOauthUtility));
            if (options == null)
                throw new ArgumentNullException(nameof(options));
            if (options.AuthorizationResult == null)
                throw new ArgumentNullException(nameof(options.AuthorizationResult));

            var authorizationResult = options.AuthorizationResult;

            if (!authorizationResult.ShouldRefreshAccessToken(options.RefreshBeforeExpiry))
                return Task.FromResult(authorizationResult);

            if (!authorizationResult.HasRefreshToken)
                throw new InvalidOperationException("The authorization result does not contain a refresh token. Only Shopify expiring offline access tokens can be refreshed automatically.");

            if (authorizationResult.RefreshTokenHasExpired())
                throw new InvalidOperationException("The authorization result's refresh token has expired and can no longer be used to refresh the access token.");

            return shopifyOauthUtility.RefreshAccessTokenAsync(new RefreshAccessTokenOptions
            {
                ShopDomain = options.ShopDomain,
                ClientId = options.ClientId,
                ClientSecret = options.ClientSecret,
                RefreshToken = authorizationResult.RefreshToken!,
                ExistingStoreAccessToken = authorizationResult.AccessToken
            });
        }
    }
}

