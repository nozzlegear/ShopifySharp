namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record UpdateProductResponse(ProductContainer Result, GraphUserError[]? UserErrors = null)
    : MutationResponse<ProductContainer>(Result, UserErrors);