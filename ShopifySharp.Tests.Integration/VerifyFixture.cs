namespace ShopifySharp.Tests.Integration;

public class VerifyFixture
{
    public readonly VerifySettings Settings = new();

    public VerifyFixture()
    {
        Settings.ScrubMembers(info => info.Name is "LegacyResourceId" or "legacyResourceId");
        Settings.ScrubMembers(info => info.Name is "Id" or "id");
        Settings.ScrubMembers(info => info.Name is "RequestId" or "requestId");
        Settings.ScrubMembers(info => info.DeclaringType?.Name is "PageInfo" or "pageInfo");
        Settings.UseDirectory("Snapshots");
    }
}
