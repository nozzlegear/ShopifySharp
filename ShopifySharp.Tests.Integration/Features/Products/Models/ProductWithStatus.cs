using ShopifySharp.GraphQL;

namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record ProductWithStatus(
    string Id,
    string Title,
    ProductStatus Status
);