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
[JsonDerivedType(typeof(DiscountDiscountAutomaticApp), typeDiscriminator: "DiscountAutomaticApp")]
[JsonDerivedType(typeof(DiscountDiscountAutomaticBasic), typeDiscriminator: "DiscountAutomaticBasic")]
[JsonDerivedType(typeof(DiscountDiscountAutomaticBxgy), typeDiscriminator: "DiscountAutomaticBxgy")]
[JsonDerivedType(typeof(DiscountDiscountAutomaticFreeShipping), typeDiscriminator: "DiscountAutomaticFreeShipping")]
[JsonDerivedType(typeof(DiscountDiscountCodeApp), typeDiscriminator: "DiscountCodeApp")]
[JsonDerivedType(typeof(DiscountDiscountCodeBasic), typeDiscriminator: "DiscountCodeBasic")]
[JsonDerivedType(typeof(DiscountDiscountCodeBxgy), typeDiscriminator: "DiscountCodeBxgy")]
[JsonDerivedType(typeof(DiscountDiscountCodeFreeShipping), typeDiscriminator: "DiscountCodeFreeShipping")]
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