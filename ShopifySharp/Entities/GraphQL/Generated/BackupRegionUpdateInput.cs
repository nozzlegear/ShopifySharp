#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating a backup region with exactly one required option.
/// </summary>
public record BackupRegionUpdateInput : GraphQLInputObject<BackupRegionUpdateInput>
{
    /// <summary>
    /// A country code for the backup region.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;
}