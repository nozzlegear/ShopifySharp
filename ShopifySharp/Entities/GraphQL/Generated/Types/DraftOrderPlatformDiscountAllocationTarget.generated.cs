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
/// The element of the draft being discounted.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DraftOrderPlatformDiscountAllocationTarget>))]
public record DraftOrderPlatformDiscountAllocationTarget : GraphQLObject<DraftOrderPlatformDiscountAllocationTarget>, IGraphQLUnionType
{
    public CalculatedDraftOrderLineItem? AsCalculatedDraftOrderLineItem() => this is DraftOrderPlatformDiscountAllocationTargetCalculatedDraftOrderLineItem wrapper ? wrapper.Value : null;
    public DraftOrderLineItem? AsDraftOrderLineItem() => this is DraftOrderPlatformDiscountAllocationTargetDraftOrderLineItem wrapper ? wrapper.Value : null;
    public ShippingLine? AsShippingLine() => this is DraftOrderPlatformDiscountAllocationTargetShippingLine wrapper ? wrapper.Value : null;
}