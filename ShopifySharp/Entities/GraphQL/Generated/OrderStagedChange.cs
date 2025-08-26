#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A change that has been applied to an order.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(OrderStagedChangeOrderStagedChangeAddCustomItem), typeDiscriminator: "OrderStagedChangeAddCustomItem")]
[JsonDerivedType(typeof(OrderStagedChangeOrderStagedChangeAddLineItemDiscount), typeDiscriminator: "OrderStagedChangeAddLineItemDiscount")]
[JsonDerivedType(typeof(OrderStagedChangeOrderStagedChangeAddShippingLine), typeDiscriminator: "OrderStagedChangeAddShippingLine")]
[JsonDerivedType(typeof(OrderStagedChangeOrderStagedChangeAddVariant), typeDiscriminator: "OrderStagedChangeAddVariant")]
[JsonDerivedType(typeof(OrderStagedChangeOrderStagedChangeDecrementItem), typeDiscriminator: "OrderStagedChangeDecrementItem")]
[JsonDerivedType(typeof(OrderStagedChangeOrderStagedChangeIncrementItem), typeDiscriminator: "OrderStagedChangeIncrementItem")]
[JsonDerivedType(typeof(OrderStagedChangeOrderStagedChangeRemoveShippingLine), typeDiscriminator: "OrderStagedChangeRemoveShippingLine")]
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