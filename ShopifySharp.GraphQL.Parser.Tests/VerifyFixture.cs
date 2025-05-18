namespace ShopifySharp.GraphQL.Parser.Tests;

public class VerifyFixture
{
    public readonly VerifySettings Settings = new();

    public VerifyFixture()
    {
        Settings.UseDirectory("Snapshots");
    }
}
