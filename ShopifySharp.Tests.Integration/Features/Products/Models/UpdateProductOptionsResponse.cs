namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record UpdateProductOptionsResponse(UpdatedProductOptionsContainer Result, GraphUserError[]? UserErrors = null)
    : MutationResponse<UpdatedProductOptionsContainer>(Result, UserErrors);