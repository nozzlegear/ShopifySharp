namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record PublishedProductResponse(
    ProductStatusUpdateContainer ProductStatusUpdateResult,
    PublishableContainer PublicationResult
);