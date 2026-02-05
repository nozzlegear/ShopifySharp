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
/// A discount offers promotional value and can be applied by entering a code or
/// automatically when conditions are met. Discounts can provide fixed amounts,
/// percentage reductions, free shipping, or Buy X Get Y (BXGY) benefits on specific
/// products or the entire order. For more complex scenarios, developers can use
/// Function-backed discounts to create custom discount configurations.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<Discount>))]
public record Discount : GraphQLObject<Discount>, IGraphQLUnionType
{
    public DiscountAutomaticApp? AsDiscountAutomaticApp() => this is DiscountDiscountAutomaticApp wrapper ? wrapper.Value : null;
    public DiscountAutomaticBasic? AsDiscountAutomaticBasic() => this is DiscountDiscountAutomaticBasic wrapper ? wrapper.Value : null;
    public DiscountAutomaticBxgy? AsDiscountAutomaticBxgy() => this is DiscountDiscountAutomaticBxgy wrapper ? wrapper.Value : null;
    public DiscountAutomaticFreeShipping? AsDiscountAutomaticFreeShipping() => this is DiscountDiscountAutomaticFreeShipping wrapper ? wrapper.Value : null;
    public DiscountCodeApp? AsDiscountCodeApp() => this is DiscountDiscountCodeApp wrapper ? wrapper.Value : null;
    public DiscountCodeBasic? AsDiscountCodeBasic() => this is DiscountDiscountCodeBasic wrapper ? wrapper.Value : null;
    public DiscountCodeBxgy? AsDiscountCodeBxgy() => this is DiscountDiscountCodeBxgy wrapper ? wrapper.Value : null;
    public DiscountCodeFreeShipping? AsDiscountCodeFreeShipping() => this is DiscountDiscountCodeFreeShipping wrapper ? wrapper.Value : null;
}