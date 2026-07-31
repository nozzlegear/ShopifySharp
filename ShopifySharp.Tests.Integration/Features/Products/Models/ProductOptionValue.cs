namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record ProductOptionValue(
    string Id,
    string Name,
    bool? HasVariants
)
{
    public static ProductOptionValue FromGraph(GraphQL.ProductOptionValue value) => new(
        value.id ?? "",
        value.name ?? "",
        value.hasVariants ?? false
    );
}
