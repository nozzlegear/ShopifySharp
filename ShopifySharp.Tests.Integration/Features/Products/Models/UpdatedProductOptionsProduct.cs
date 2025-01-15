namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record UpdatedProductOptionsProduct(
    string Id,
    string Title,
    ProductOption[] Options,
    VariantsCount VariantsCount,
    bool HasOnlyDefaultVariant,
    NodeCollection<UpdatedProductOptionsVariant> Variants
);