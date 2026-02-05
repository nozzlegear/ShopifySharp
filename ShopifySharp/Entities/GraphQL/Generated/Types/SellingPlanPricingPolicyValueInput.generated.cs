#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update a pricing policy adjustment value.
/// </summary>
public record SellingPlanPricingPolicyValueInput : GraphQLInputObject<SellingPlanPricingPolicyValueInput>
{
    /// <summary>
    /// The fixed value for an fixed amount off or a new policy price.
    /// </summary>
    [JsonPropertyName("fixedValue")]
    public decimal? fixedValue { get; set; } = null;

    /// <summary>
    /// The percentage value.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}