#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of minimum requirement that must be met for the discount to be applied.
/// For example, a customer must spend a minimum subtotal to be eligible for the
/// discount. Alternatively, a customer must purchase a minimum quantity of items to
/// be eligible for the discount.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DiscountMinimumQuantity), typeDiscriminator: "DiscountMinimumQuantity")]
[JsonDerivedType(typeof(DiscountMinimumSubtotal), typeDiscriminator: "DiscountMinimumSubtotal")]
public record DiscountMinimumRequirement : GraphQLObject<DiscountMinimumRequirement>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DiscountMinimumQuantity? AsDiscountMinimumQuantity() => this is DiscountMinimumRequirementDiscountMinimumQuantity wrapper ? wrapper.Value : null;
	public DiscountMinimumSubtotal? AsDiscountMinimumSubtotal() => this is DiscountMinimumRequirementDiscountMinimumSubtotal wrapper ? wrapper.Value : null;
#endif
}