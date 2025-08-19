#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of discount associated with the discount code. For example, the
/// discount code might offer a basic discount of a fixed percentage, or a fixed
/// amount, on specific products or the order. Alternatively, the discount might
/// offer the customer free shipping on their order. A third option is a Buy X, Get
/// Y (BXGY) discount, which offers a customer discounts on select products if they
/// add a specific product to their order.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DiscountCodeApp), typeDiscriminator: "DiscountCodeApp")]
[JsonDerivedType(typeof(DiscountCodeBasic), typeDiscriminator: "DiscountCodeBasic")]
[JsonDerivedType(typeof(DiscountCodeBxgy), typeDiscriminator: "DiscountCodeBxgy")]
[JsonDerivedType(typeof(DiscountCodeFreeShipping), typeDiscriminator: "DiscountCodeFreeShipping")]
public record DiscountCode : GraphQLObject<DiscountCode>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DiscountCodeApp? AsDiscountCodeApp() => this is DiscountCodeDiscountCodeApp wrapper ? wrapper.Value : null;
	public DiscountCodeBasic? AsDiscountCodeBasic() => this is DiscountCodeDiscountCodeBasic wrapper ? wrapper.Value : null;
	public DiscountCodeBxgy? AsDiscountCodeBxgy() => this is DiscountCodeDiscountCodeBxgy wrapper ? wrapper.Value : null;
	public DiscountCodeFreeShipping? AsDiscountCodeFreeShipping() => this is DiscountCodeDiscountCodeFreeShipping wrapper ? wrapper.Value : null;
#endif
}