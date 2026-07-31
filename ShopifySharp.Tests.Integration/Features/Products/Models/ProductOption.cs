namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record ProductOption(
    string Name,
    string Id,
    string[] Values,
    ProductOptionValue[] OptionValues
)
{
    public static ProductOption FromGraph(GraphQL.ProductOption option) => new(
        option.name ?? "",
        option.id ?? "",
        option.values?.ToArray() ?? [],
        option.optionValues?.Select(ProductOptionValue.FromGraph).ToArray() ?? []
    );
}
