using System;

namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record SelectedOption(
    string Name,
    string Value
)
{
    public static SelectedOption FromGraph(GraphQL.SelectedOption? option)
    {
        ArgumentNullException.ThrowIfNull(option, nameof(option));

        var o = option!;
        return new SelectedOption(o.name ?? "", o.value ?? "");
    }
}
