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
/// The type used to define which buyers can use the discount.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DiscountContext>))]
public record DiscountContext : GraphQLObject<DiscountContext>, IGraphQLUnionType
{
    public DiscountBuyerSelectionAll? AsDiscountBuyerSelectionAll() => this is DiscountContextDiscountBuyerSelectionAll wrapper ? wrapper.Value : null;
    public DiscountCustomerSegments? AsDiscountCustomerSegments() => this is DiscountContextDiscountCustomerSegments wrapper ? wrapper.Value : null;
    public DiscountCustomers? AsDiscountCustomers() => this is DiscountContextDiscountCustomers wrapper ? wrapper.Value : null;
}