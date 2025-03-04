#nullable enable
using System;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Tests.TestClasses;

/// <summary>
/// A test ShopifyService that overrides the <see cref="ShopifyService.BuildRequestUri(string)"/> method for testing.
/// </summary>
/// <param name="requestUri">The uri you want the overriden <see cref="ShopifyService.BuildRequestUri(string)"/> to return for testing.</param>
public class TestBuildRequestUriShopifyService(Uri requestUri) : ShopifyService("some-shop-domain", "some-access-token")
{
    protected override RequestUri BuildRequestUri(string _)
    {
        return new RequestUri(requestUri);
    }

    public RequestUri BuildRequestUriProxy() => BuildRequestUri("some-path");
}
