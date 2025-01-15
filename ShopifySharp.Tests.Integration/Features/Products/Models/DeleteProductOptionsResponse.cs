namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record DeleteProductOptionsResponse(DeletedProductOptionsContainer Result, GraphUserError[]? UserErrors = null)
    : MutationResponse<DeletedProductOptionsContainer>(Result, UserErrors);
