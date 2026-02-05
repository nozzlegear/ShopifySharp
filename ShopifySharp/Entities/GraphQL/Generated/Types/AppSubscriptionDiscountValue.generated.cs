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
/// The value of the discount.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<AppSubscriptionDiscountValue>))]
public record AppSubscriptionDiscountValue : GraphQLObject<AppSubscriptionDiscountValue>, IGraphQLUnionType
{
    public AppSubscriptionDiscountAmount? AsAppSubscriptionDiscountAmount() => this is AppSubscriptionDiscountValueAppSubscriptionDiscountAmount wrapper ? wrapper.Value : null;
    public AppSubscriptionDiscountPercentage? AsAppSubscriptionDiscountPercentage() => this is AppSubscriptionDiscountValueAppSubscriptionDiscountPercentage wrapper ? wrapper.Value : null;
}