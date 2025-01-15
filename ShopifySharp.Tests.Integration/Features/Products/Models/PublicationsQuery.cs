namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record PublicationsQuery(NodeCollection<ShopifySharpPublication> Result)
    : QueryResponse<NodeCollection<ShopifySharpPublication>>(Result);