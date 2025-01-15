namespace ShopifySharp.Tests.Integration;

[Collection("Verify Check")]
public class VerifyCheckTests
{
    [Fact]
    public void Run()
    {
        VerifyChecks.Run();
    }
}
