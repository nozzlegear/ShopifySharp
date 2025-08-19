#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A rate provided by a merchant-defined rate or a participant.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DeliveryParticipant), typeDiscriminator: "DeliveryParticipant")]
[JsonDerivedType(typeof(DeliveryRateDefinition), typeDiscriminator: "DeliveryRateDefinition")]
public record DeliveryRateProvider : GraphQLObject<DeliveryRateProvider>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DeliveryParticipant? AsDeliveryParticipant() => this is DeliveryRateProviderDeliveryParticipant wrapper ? wrapper.Value : null;
	public DeliveryRateDefinition? AsDeliveryRateDefinition() => this is DeliveryRateProviderDeliveryRateDefinition wrapper ? wrapper.Value : null;
#endif
}