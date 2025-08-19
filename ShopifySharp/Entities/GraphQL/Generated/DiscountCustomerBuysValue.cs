#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The prerequisite for the discount to be applicable. For example, the discount
/// might require a customer to buy a minimum quantity of select items.
/// Alternatively, the discount might require a customer to spend a minimum amount
/// on select items.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DiscountPurchaseAmount), typeDiscriminator: "DiscountPurchaseAmount")]
[JsonDerivedType(typeof(DiscountQuantity), typeDiscriminator: "DiscountQuantity")]
public record DiscountCustomerBuysValue : GraphQLObject<DiscountCustomerBuysValue>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DiscountPurchaseAmount? AsDiscountPurchaseAmount() => this is DiscountCustomerBuysValueDiscountPurchaseAmount wrapper ? wrapper.Value : null;
	public DiscountQuantity? AsDiscountQuantity() => this is DiscountCustomerBuysValueDiscountQuantity wrapper ? wrapper.Value : null;
#endif
}