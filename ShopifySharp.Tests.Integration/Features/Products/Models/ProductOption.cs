namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record ProductOption(
    string Name,
    string Id,
    string[] Values,
    ProductOptionValue[] OptionValues
);