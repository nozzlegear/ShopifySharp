#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The object that the participant references.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
public record DeliveryPromiseParticipantOwner : GraphQLObject<DeliveryPromiseParticipantOwner>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public ProductVariant? AsProductVariant() => this is DeliveryPromiseParticipantOwnerProductVariant wrapper ? wrapper.Value : null;
#endif
}