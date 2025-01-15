namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record CreatedVariant(
    string Id,
    string DisplayName,
    string Title,
    SelectedOption[] SelectedOptions
);