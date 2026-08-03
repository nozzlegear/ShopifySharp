using ShopifySharp.GraphQL;

namespace ShopifySharp.Tests.Integration;

public class VerifyFixture
{
    public readonly VerifySettings Settings = new();

    public VerifyFixture()
    {
        Settings.UseStrictJson();
        Settings.ScrubEmptyLines();
        Settings.ScrubMembers(info => info.Name is "LegacyResourceId" or "legacyResourceId");
        Settings.ScrubMembers(info => info.Name is "Id" or "id");
        Settings.ScrubMembers(info => info.Name is "AdminGraphQLAPIId" or "adminGraphQLAPIId");
        Settings.ScrubMembers(info => info.Name.EndsWith("Id"));
        Settings.ScrubMembers(info => info.Name is "RequestId" or "requestId");
        Settings.ScrubMembers(info => info.Name is "ShippingAddress" or "shippingAddress");
        Settings.ScrubMembers(info => info.Name is "BillingAddress" or "billingAddress");
        Settings.ScrubMembers(info => info.DeclaringType?.Name is "PageInfo" or "pageInfo");
        Settings.ScrubMembers(info => info.DeclaringType?.Name is "PageInfo" or "pageInfo");
        Settings.ScrubMember(typeof(Image), nameof(Image.url));
        // Settings.ScrubMember<Metafield>(nameof(Metafield.@namespace));
        // Settings.ScrubMember<Metafield>(nameof(Metafield.key));
        // Settings.ScrubMember<Metafield>(nameof(Metafield.value));
        Settings.UseDirectory("Snapshots");
    }
}
