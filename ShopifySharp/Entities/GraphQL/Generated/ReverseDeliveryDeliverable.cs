#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The delivery method and artifacts associated with a reverse delivery.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(ReverseDeliveryShippingDeliverable), typeDiscriminator: "ReverseDeliveryShippingDeliverable")]
public record ReverseDeliveryDeliverable : GraphQLObject<ReverseDeliveryDeliverable>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public ReverseDeliveryShippingDeliverable? AsReverseDeliveryShippingDeliverable() => this is ReverseDeliveryDeliverableReverseDeliveryShippingDeliverable wrapper ? wrapper.Value : null;
#endif
}