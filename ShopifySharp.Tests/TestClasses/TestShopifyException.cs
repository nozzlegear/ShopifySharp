#nullable enable

namespace ShopifySharp.Tests.TestClasses;

public class TestShopifyException() : ShopifyException("A test exception")
{
    public override string ToString()
    {
        return "Test Shopify Exception";
    }
}
