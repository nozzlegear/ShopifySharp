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
/// The input fields required to create or update a selling plan anchor.
/// </summary>
public record SellingPlanAnchorInput : GraphQLInputObject<SellingPlanAnchorInput>
{
    /// <summary>
    /// The cutoff day of the anchor.
    /// If `type` is WEEKDAY, then the value must be between 1-7. Shopify interprets
    /// the days of the week according to ISO 8601, where 1 is Monday.
    /// If `type` is MONTHDAY, then the value must be between 1-31.
    /// If `type` is YEARDAY, then the value must be `null`.
    /// This field should only be set if the cutoff field for the delivery policy is `null`.
    /// </summary>
    [JsonPropertyName("cutoffDay")]
    public int? cutoffDay { get; set; } = null;

    /// <summary>
    /// The day of the anchor.
    /// If `type` is WEEKDAY, then the value must be between 1-7. Shopify interprets
    /// the days of the week according to ISO 8601, where 1 is Monday.
    /// If `type` isn't WEEKDAY, then the value must be between 1-31.
    /// </summary>
    [JsonPropertyName("day")]
    public int? day { get; set; } = null;

    /// <summary>
    /// The month of the anchor. If type is different than YEARDAY, then the value must
    /// be `null` or between 1-12.
    /// </summary>
    [JsonPropertyName("month")]
    public int? month { get; set; } = null;

    /// <summary>
    /// Represents the anchor type, must be one of WEEKDAY, MONTHDAY, YEARDAY.
    /// </summary>
    [JsonPropertyName("type")]
    public SellingPlanAnchorType? type { get; set; } = null;
}