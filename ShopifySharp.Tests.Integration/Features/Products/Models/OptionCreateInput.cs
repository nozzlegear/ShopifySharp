namespace ShopifySharp.Tests.Integration.Features.Products.Models;

public record OptionCreateInput(
    string Name,
    OptionValueCreateInput[]? Values
);