#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of the discount value and how it will be applied. For example, it might
/// be a percentage discount on a fixed number of items. Alternatively, it might be
/// a fixed amount evenly distributed across all items or on each individual item. A
/// third example is a percentage discount on all items.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DiscountAmount), typeDiscriminator: "DiscountAmount")]
[JsonDerivedType(typeof(DiscountOnQuantity), typeDiscriminator: "DiscountOnQuantity")]
[JsonDerivedType(typeof(DiscountPercentage), typeDiscriminator: "DiscountPercentage")]
public record DiscountCustomerGetsValue : GraphQLObject<DiscountCustomerGetsValue>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DiscountAmount? AsDiscountAmount() => this is DiscountCustomerGetsValueDiscountAmount wrapper ? wrapper.Value : null;
	public DiscountOnQuantity? AsDiscountOnQuantity() => this is DiscountCustomerGetsValueDiscountOnQuantity wrapper ? wrapper.Value : null;
	public DiscountPercentage? AsDiscountPercentage() => this is DiscountCustomerGetsValueDiscountPercentage wrapper ? wrapper.Value : null;
#endif
}