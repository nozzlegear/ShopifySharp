using System;

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
        ArgumentNullException.ThrowIfNull(variant, nameof(variant));

        var v = variant!;
        return new CreatedVariant(
            v.id ?? "",
            v.displayName ?? "",
            v.title ?? "",
            v.selectedOptions?.Select(SelectedOption.FromGraph).ToArray() ?? []
        );
    }
}
