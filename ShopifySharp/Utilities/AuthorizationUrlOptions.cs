#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.Enums;

namespace ShopifySharp.Utilities;

public record AuthorizationUrlOptions
{
    /// An array of Shopify permission strings, e.g. 'read_orders' or 'write_script_tags'. These are the permissions that your app needs to run.
    public
#if NET6_0_OR_GREATER
        required
#endif
        IEnumerable<string> Scopes { get; set; } = [];

    /// The shop's *.myshopify.com URL.
    public
#if NET6_0_OR_GREATER
        required
#endif
        string ShopDomain { get; set; } = null!;

    /// Your app's public Client ID, also known as its public API key.
    public
#if NET6_0_OR_GREATER
        required
#endif
        string ClientId { get; set; } = null!;

    /// URL to redirect the user to after integration.
    public
#if NET6_0_OR_GREATER
        required
#endif
        string RedirectUrl { get; set; } = null!;

    /// An optional, random string value provided by your application which is unique for each authorization request. During the OAuth callback phase, your application should check that this value matches the one you provided to this method.
    public string? State { get; set; }

    /// Requested grant types, which will change the type of access token granted upon OAuth completion.
    [Obsolete("Deprecated, please use " + nameof(Enums.AuthorizationAccessMode) + " instead.")]
    public IEnumerable<string>? Grants { get; set; }

    /// Sets the access mode for the access token grant. For an "online access token" (alternately referred to as "per user"
    /// in Shopify's documentation), set to <see cref="AuthorizationAccessMode.Online"/>.
    public AuthorizationAccessMode AuthorizationAccessMode { get; set; } = AuthorizationAccessMode.Offline;
}
