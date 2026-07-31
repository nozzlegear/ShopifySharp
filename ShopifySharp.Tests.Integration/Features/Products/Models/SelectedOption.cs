namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record SelectedOption(
    string Name,
    string Value
)
{
    public static SelectedOption FromGraph(GraphQL.SelectedOption? option)
    {
        ArgumentNullException.ThrowIfNull(option);

        return new SelectedOption(option.name ?? "", option.value ?? "");
    }
}
