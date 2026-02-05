#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type of discount associated with the discount code. For example, the
/// discount code might offer a basic discount of a fixed percentage, or a fixed
/// amount, on specific products or the order. Alternatively, the discount might
/// offer the customer free shipping on their order. A third option is a Buy X, Get
/// Y (BXGY) discount, which offers a customer discounts on select products if they
/// add a specific product to their order.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DiscountCode>))]
public record DiscountCode : GraphQLObject<DiscountCode>, IGraphQLUnionType
{
    public DiscountCodeApp? AsDiscountCodeApp() => this is DiscountCodeDiscountCodeApp wrapper ? wrapper.Value : null;
    public DiscountCodeBasic? AsDiscountCodeBasic() => this is DiscountCodeDiscountCodeBasic wrapper ? wrapper.Value : null;
    public DiscountCodeBxgy? AsDiscountCodeBxgy() => this is DiscountCodeDiscountCodeBxgy wrapper ? wrapper.Value : null;
    public DiscountCodeFreeShipping? AsDiscountCodeFreeShipping() => this is DiscountCodeDiscountCodeFreeShipping wrapper ? wrapper.Value : null;
}