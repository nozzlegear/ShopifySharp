#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for company location when creating or updating a company location.
/// </summary>
public record CompanyLocationUpdateInput : GraphQLInputObject<CompanyLocationUpdateInput>
{
    /// <summary>
    /// The configuration for the buyer's checkout at the company location.
    /// </summary>
    [JsonPropertyName("buyerExperienceConfiguration")]
    public BuyerExperienceConfigurationInput? buyerExperienceConfiguration { get; set; } = null;

    /// <summary>
    /// A unique externally-supplied ID for the company location.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? externalId { get; set; } = null;

    /// <summary>
    /// The preferred locale of the company location.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The name of the company location.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A note about the company location.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The phone number of the company location.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;
}