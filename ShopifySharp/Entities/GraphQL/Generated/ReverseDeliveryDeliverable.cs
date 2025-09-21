#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The delivery method and artifacts associated with a reverse delivery.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<ReverseDeliveryDeliverable>))]
public record ReverseDeliveryDeliverable : GraphQLObject<ReverseDeliveryDeliverable>, IGraphQLUnionType
{
    public ReverseDeliveryShippingDeliverable? AsReverseDeliveryShippingDeliverable() => this is ReverseDeliveryDeliverableReverseDeliveryShippingDeliverable wrapper ? wrapper.Value : null;
}