#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DeliveryPromiseParticipantOwnerProductVariant(ProductVariant Value): DeliveryPromiseParticipantOwner;
#endif /// <summary>

/// The type of object that the participant is attached to.
/// </summary>
public enum DeliveryPromiseParticipantOwnerType
{
    PRODUCTVARIANT,
}