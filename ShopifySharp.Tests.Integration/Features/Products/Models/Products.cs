using ShopifySharp.GraphQL;

namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record Products(
    GraphQL.Product[] Nodes,
    PageInfo PageInfo
);