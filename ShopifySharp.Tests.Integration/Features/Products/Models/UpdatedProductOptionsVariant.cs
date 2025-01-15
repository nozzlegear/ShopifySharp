namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record UpdatedProductOptionsVariant(
    string Id,
    string DisplayName,
    SelectedOption[] SelectedOptions
);