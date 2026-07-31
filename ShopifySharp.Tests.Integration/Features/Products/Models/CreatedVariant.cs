namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record CreatedVariant(
    string Id,
    string DisplayName,
    string Title,
    SelectedOption[] SelectedOptions
)
{
    public static CreatedVariant FromGraph(GraphQL.ProductVariant? variant)
    {
        ArgumentNullException.ThrowIfNull(variant);

        return new CreatedVariant(
            variant.id ?? "",
            variant.displayName ?? "",
            variant.title ?? "",
            variant.selectedOptions?.Select(SelectedOption.FromGraph).ToArray() ?? []
        );
    }
}
