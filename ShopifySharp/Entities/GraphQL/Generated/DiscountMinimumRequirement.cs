#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type of minimum requirement that must be met for the discount to be applied.
/// For example, a customer must spend a minimum subtotal to be eligible for the
/// discount. Alternatively, a customer must purchase a minimum quantity of items to
/// be eligible for the discount.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DiscountMinimumRequirement>))]
public record DiscountMinimumRequirement : GraphQLObject<DiscountMinimumRequirement>, IGraphQLUnionType
{
    public DiscountMinimumQuantity? AsDiscountMinimumQuantity() => this is DiscountMinimumRequirementDiscountMinimumQuantity wrapper ? wrapper.Value : null;
    public DiscountMinimumSubtotal? AsDiscountMinimumSubtotal() => this is DiscountMinimumRequirementDiscountMinimumSubtotal wrapper ? wrapper.Value : null;
}