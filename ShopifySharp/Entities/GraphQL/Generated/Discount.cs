#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A discount offers promotional value and can be applied by entering a code or
/// automatically when conditions are met. Discounts can provide fixed amounts,
/// percentage reductions, free shipping, or Buy X Get Y (BXGY) benefits on specific
/// products or the entire order. For more complex scenarios, developers can use
/// Function-backed discounts to create custom discount configurations.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DiscountAutomaticApp), typeDiscriminator: "DiscountAutomaticApp")]
[JsonDerivedType(typeof(DiscountAutomaticBasic), typeDiscriminator: "DiscountAutomaticBasic")]
[JsonDerivedType(typeof(DiscountAutomaticBxgy), typeDiscriminator: "DiscountAutomaticBxgy")]
[JsonDerivedType(typeof(DiscountAutomaticFreeShipping), typeDiscriminator: "DiscountAutomaticFreeShipping")]
[JsonDerivedType(typeof(DiscountCodeApp), typeDiscriminator: "DiscountCodeApp")]
[JsonDerivedType(typeof(DiscountCodeBasic), typeDiscriminator: "DiscountCodeBasic")]
[JsonDerivedType(typeof(DiscountCodeBxgy), typeDiscriminator: "DiscountCodeBxgy")]
[JsonDerivedType(typeof(DiscountCodeFreeShipping), typeDiscriminator: "DiscountCodeFreeShipping")]
public record Discount : GraphQLObject<Discount>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DiscountAutomaticApp? AsDiscountAutomaticApp() => this is DiscountDiscountAutomaticApp wrapper ? wrapper.Value : null;
	public DiscountAutomaticBasic? AsDiscountAutomaticBasic() => this is DiscountDiscountAutomaticBasic wrapper ? wrapper.Value : null;
	public DiscountAutomaticBxgy? AsDiscountAutomaticBxgy() => this is DiscountDiscountAutomaticBxgy wrapper ? wrapper.Value : null;
	public DiscountAutomaticFreeShipping? AsDiscountAutomaticFreeShipping() => this is DiscountDiscountAutomaticFreeShipping wrapper ? wrapper.Value : null;
	public DiscountCodeApp? AsDiscountCodeApp() => this is DiscountDiscountCodeApp wrapper ? wrapper.Value : null;
	public DiscountCodeBasic? AsDiscountCodeBasic() => this is DiscountDiscountCodeBasic wrapper ? wrapper.Value : null;
	public DiscountCodeBxgy? AsDiscountCodeBxgy() => this is DiscountDiscountCodeBxgy wrapper ? wrapper.Value : null;
	public DiscountCodeFreeShipping? AsDiscountCodeFreeShipping() => this is DiscountDiscountCodeFreeShipping wrapper ? wrapper.Value : null;
#endif
}