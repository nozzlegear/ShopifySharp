using ShopifySharp.GraphQL;

namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record CreatedProduct(
    string Description,
    string Id,
    bool HasOnlyDefaultVariant,
    string Title,
    ProductStatus Status,
    ProductOption[] Options,
    VariantsCount VariantsCount,
    NodeCollection<CreatedVariant> Variants,
    string Vendor
);