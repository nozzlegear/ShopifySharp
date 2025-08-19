#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A change that has been applied to an order.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(OrderStagedChangeAddCustomItem), typeDiscriminator: "OrderStagedChangeAddCustomItem")]
[JsonDerivedType(typeof(OrderStagedChangeAddLineItemDiscount), typeDiscriminator: "OrderStagedChangeAddLineItemDiscount")]
[JsonDerivedType(typeof(OrderStagedChangeAddShippingLine), typeDiscriminator: "OrderStagedChangeAddShippingLine")]
[JsonDerivedType(typeof(OrderStagedChangeAddVariant), typeDiscriminator: "OrderStagedChangeAddVariant")]
[JsonDerivedType(typeof(OrderStagedChangeDecrementItem), typeDiscriminator: "OrderStagedChangeDecrementItem")]
[JsonDerivedType(typeof(OrderStagedChangeIncrementItem), typeDiscriminator: "OrderStagedChangeIncrementItem")]
[JsonDerivedType(typeof(OrderStagedChangeRemoveShippingLine), typeDiscriminator: "OrderStagedChangeRemoveShippingLine")]
public record OrderStagedChange : GraphQLObject<OrderStagedChange>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public OrderStagedChangeAddCustomItem? AsOrderStagedChangeAddCustomItem() => this is OrderStagedChangeOrderStagedChangeAddCustomItem wrapper ? wrapper.Value : null;
	public OrderStagedChangeAddLineItemDiscount? AsOrderStagedChangeAddLineItemDiscount() => this is OrderStagedChangeOrderStagedChangeAddLineItemDiscount wrapper ? wrapper.Value : null;
	public OrderStagedChangeAddShippingLine? AsOrderStagedChangeAddShippingLine() => this is OrderStagedChangeOrderStagedChangeAddShippingLine wrapper ? wrapper.Value : null;
	public OrderStagedChangeAddVariant? AsOrderStagedChangeAddVariant() => this is OrderStagedChangeOrderStagedChangeAddVariant wrapper ? wrapper.Value : null;
	public OrderStagedChangeDecrementItem? AsOrderStagedChangeDecrementItem() => this is OrderStagedChangeOrderStagedChangeDecrementItem wrapper ? wrapper.Value : null;
	public OrderStagedChangeIncrementItem? AsOrderStagedChangeIncrementItem() => this is OrderStagedChangeOrderStagedChangeIncrementItem wrapper ? wrapper.Value : null;
	public OrderStagedChangeRemoveShippingLine? AsOrderStagedChangeRemoveShippingLine() => this is OrderStagedChangeOrderStagedChangeRemoveShippingLine wrapper ? wrapper.Value : null;
#endif
}