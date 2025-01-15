namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record MutationResponse<T>(
    T Result,
    GraphUserError[]? UserErrors = null
);