#nullable enable

namespace ShopifySharp.Tests.TestClasses;

public class TestShopifyException : ShopifyException
{
    public override string ToString()
    {
        return "Test Shopify Exception";
    }
}
