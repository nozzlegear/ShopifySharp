#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of discount that will be applied. Currently, only a percentage discount is supported.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DiscountEffectDiscountAmount), typeDiscriminator: "DiscountAmount")]
[JsonDerivedType(typeof(DiscountEffectDiscountPercentage), typeDiscriminator: "DiscountPercentage")]
public record DiscountEffect : GraphQLObject<DiscountEffect>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DiscountAmount? AsDiscountAmount() => this is DiscountEffectDiscountAmount wrapper ? wrapper.Value : null;
	public DiscountPercentage? AsDiscountPercentage() => this is DiscountEffectDiscountPercentage wrapper ? wrapper.Value : null;
#endif
}