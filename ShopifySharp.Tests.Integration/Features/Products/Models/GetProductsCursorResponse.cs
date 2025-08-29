using ShopifySharp.GraphQL;

namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record GetProductsCursorResponse(ProductConnection Products)
    : QueryResponse<string>(Products.pageInfo!.startCursor!);
