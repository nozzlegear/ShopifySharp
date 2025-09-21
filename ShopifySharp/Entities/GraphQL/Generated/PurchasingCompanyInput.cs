#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a purchasing company, which is a combination of company, company contact, and company location.
/// </summary>
public record PurchasingCompanyInput : GraphQLInputObject<PurchasingCompanyInput>
{
    /// <summary>
    /// ID of the company contact.
    /// </summary>
    [JsonPropertyName("companyContactId")]
    public string? companyContactId { get; set; } = null;

    /// <summary>
    /// ID of the company.
    /// </summary>
    [JsonPropertyName("companyId")]
    public string? companyId { get; set; } = null;

    /// <summary>
    /// ID of the company location.
    /// </summary>
    [JsonPropertyName("companyLocationId")]
    public string? companyLocationId { get; set; } = null;
}