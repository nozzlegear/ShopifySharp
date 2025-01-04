namespace ShopifySharp.Tests.Integration;

public class VerifyFixture
{
    public readonly VerifySettings Settings = new VerifySettings();

    public VerifyFixture()
    {
        Settings.UseDirectory("Snapshots");
    }
}
