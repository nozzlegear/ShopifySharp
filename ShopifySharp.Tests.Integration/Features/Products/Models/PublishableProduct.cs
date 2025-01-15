using ShopifySharp.GraphQL;

namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record PublishableProduct(
    string Id,
    string Title,
    ProductStatus Status,
    bool PublishedOnPublication
) : ProductWithStatus(Id, Title, Status);