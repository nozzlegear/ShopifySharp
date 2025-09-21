#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The object that the participant references.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DeliveryPromiseParticipantOwner>))]
public record DeliveryPromiseParticipantOwner : GraphQLObject<DeliveryPromiseParticipantOwner>, IGraphQLUnionType
{
    public ProductVariant? AsProductVariant() => this is DeliveryPromiseParticipantOwnerProductVariant wrapper ? wrapper.Value : null;
}