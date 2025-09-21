#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type of discount that will be applied. Currently, only a percentage discount is supported.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DiscountEffect>))]
public record DiscountEffect : GraphQLObject<DiscountEffect>, IGraphQLUnionType
{
    public DiscountAmount? AsDiscountAmount() => this is DiscountEffectDiscountAmount wrapper ? wrapper.Value : null;
    public DiscountPercentage? AsDiscountPercentage() => this is DiscountEffectDiscountPercentage wrapper ? wrapper.Value : null;
}