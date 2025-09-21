#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type of discount associated to the automatic discount. For example, the
/// automatic discount might offer a basic discount using a fixed percentage, or a
/// fixed amount, on specific products from the order. The automatic discount may
/// also be a BXGY discount, which offers customer discounts on select products if
/// they add a specific product to their order.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DiscountAutomatic>))]
public record DiscountAutomatic : GraphQLObject<DiscountAutomatic>, IGraphQLUnionType
{
    public DiscountAutomaticApp? AsDiscountAutomaticApp() => this is DiscountAutomaticDiscountAutomaticApp wrapper ? wrapper.Value : null;
    public DiscountAutomaticBasic? AsDiscountAutomaticBasic() => this is DiscountAutomaticDiscountAutomaticBasic wrapper ? wrapper.Value : null;
    public DiscountAutomaticBxgy? AsDiscountAutomaticBxgy() => this is DiscountAutomaticDiscountAutomaticBxgy wrapper ? wrapper.Value : null;
    public DiscountAutomaticFreeShipping? AsDiscountAutomaticFreeShipping() => this is DiscountAutomaticDiscountAutomaticFreeShipping wrapper ? wrapper.Value : null;
}