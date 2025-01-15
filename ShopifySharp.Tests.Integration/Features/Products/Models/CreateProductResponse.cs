namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record CreateProductResponse(CreatedProductContainer Result, GraphUserError[]? UserErrors = null)
    : MutationResponse<CreatedProductContainer>(Result, UserErrors);
