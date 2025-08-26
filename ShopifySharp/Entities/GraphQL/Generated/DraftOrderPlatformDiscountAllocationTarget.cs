#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The element of the draft being discounted.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DraftOrderPlatformDiscountAllocationTargetCalculatedDraftOrderLineItem), typeDiscriminator: "CalculatedDraftOrderLineItem")]
[JsonDerivedType(typeof(DraftOrderPlatformDiscountAllocationTargetDraftOrderLineItem), typeDiscriminator: "DraftOrderLineItem")]
[JsonDerivedType(typeof(DraftOrderPlatformDiscountAllocationTargetShippingLine), typeDiscriminator: "ShippingLine")]
public record DraftOrderPlatformDiscountAllocationTarget : GraphQLObject<DraftOrderPlatformDiscountAllocationTarget>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public CalculatedDraftOrderLineItem? AsCalculatedDraftOrderLineItem() => this is DraftOrderPlatformDiscountAllocationTargetCalculatedDraftOrderLineItem wrapper ? wrapper.Value : null;
	public DraftOrderLineItem? AsDraftOrderLineItem() => this is DraftOrderPlatformDiscountAllocationTargetDraftOrderLineItem wrapper ? wrapper.Value : null;
	public ShippingLine? AsShippingLine() => this is DraftOrderPlatformDiscountAllocationTargetShippingLine wrapper ? wrapper.Value : null;
#endif
}