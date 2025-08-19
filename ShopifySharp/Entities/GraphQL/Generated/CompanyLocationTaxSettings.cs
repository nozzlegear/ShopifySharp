#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the tax settings for a company location.
/// </summary>
public record CompanyLocationTaxSettings : IGraphQLObject
{
    /// <summary>
    /// Whether the location is exempt from taxes.
    /// </summary>
    [JsonPropertyName("taxExempt")]
    public bool? taxExempt { get; set; } = null;

    /// <summary>
    /// The list of tax exemptions applied to the location.
    /// </summary>
    [JsonPropertyName("taxExemptions")]
    public ICollection<TaxExemption>? taxExemptions { get; set; } = null;

    /// <summary>
    /// The tax registration ID for the company location.
    /// </summary>
    [JsonPropertyName("taxRegistrationId")]
    public string? taxRegistrationId { get; set; } = null;
}