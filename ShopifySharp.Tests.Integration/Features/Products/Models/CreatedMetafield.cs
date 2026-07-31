namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record CreatedMetafield(string Id, string Key, string? Namespace, string Value)
{
    public static CreatedMetafield FromGraph(GraphQL.Metafield? metafield)
    {
        ArgumentNullException.ThrowIfNull(metafield);

        return new CreatedMetafield(
            metafield.id ?? "",
            metafield.key ?? "",
            metafield.@namespace,
            metafield.value ?? ""
        );
    }
}
