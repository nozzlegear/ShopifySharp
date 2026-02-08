namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record ProductOptionValue(
    string Id,
    string Name,
    bool? HasVariants
);
