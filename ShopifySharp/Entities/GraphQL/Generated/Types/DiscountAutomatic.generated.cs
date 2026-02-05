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
/// The types of automatic discounts applied in the cart and at checkout when an order meets specific criteria.
/// Includes [`DiscountAutomaticApp`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountAutomaticApp) for custom logic using the [Discount Function
/// API](https://shopify.dev/docs/api/functions/latest/discount), [`DiscountAutomaticBasic`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountAutomaticBasic)
/// for percentage or fixed amount reductions, [`DiscountAutomaticBxgy`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountAutomaticBxgy)
/// for Buy X Get Y promotions, and [`DiscountAutomaticFreeShipping`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountAutomaticFreeShipping)
/// for delivery incentives.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DiscountAutomatic>))]
public record DiscountAutomatic : GraphQLObject<DiscountAutomatic>, IGraphQLUnionType
{
    public DiscountAutomaticApp? AsDiscountAutomaticApp() => this is DiscountAutomaticDiscountAutomaticApp wrapper ? wrapper.Value : null;
    public DiscountAutomaticBasic? AsDiscountAutomaticBasic() => this is DiscountAutomaticDiscountAutomaticBasic wrapper ? wrapper.Value : null;
    public DiscountAutomaticBxgy? AsDiscountAutomaticBxgy() => this is DiscountAutomaticDiscountAutomaticBxgy wrapper ? wrapper.Value : null;
    public DiscountAutomaticFreeShipping? AsDiscountAutomaticFreeShipping() => this is DiscountAutomaticDiscountAutomaticFreeShipping wrapper ? wrapper.Value : null;
}