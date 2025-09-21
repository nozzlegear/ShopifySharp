#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to override default customer merge rules.
/// </summary>
public record CustomerMergeOverrideFields : GraphQLInputObject<CustomerMergeOverrideFields>
{
    /// <summary>
    /// The ID of the customer whose default address will be kept.
    /// </summary>
    [JsonPropertyName("customerIdOfDefaultAddressToKeep")]
    public string? customerIdOfDefaultAddressToKeep { get; set; } = null;

    /// <summary>
    /// The ID of the customer whose email will be kept.
    /// </summary>
    [JsonPropertyName("customerIdOfEmailToKeep")]
    public string? customerIdOfEmailToKeep { get; set; } = null;

    /// <summary>
    /// The ID of the customer whose first name will be kept.
    /// </summary>
    [JsonPropertyName("customerIdOfFirstNameToKeep")]
    public string? customerIdOfFirstNameToKeep { get; set; } = null;

    /// <summary>
    /// The ID of the customer whose last name will be kept.
    /// </summary>
    [JsonPropertyName("customerIdOfLastNameToKeep")]
    public string? customerIdOfLastNameToKeep { get; set; } = null;

    /// <summary>
    /// The ID of the customer whose phone number will be kept.
    /// </summary>
    [JsonPropertyName("customerIdOfPhoneNumberToKeep")]
    public string? customerIdOfPhoneNumberToKeep { get; set; } = null;

    /// <summary>
    /// The note to keep.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The tags to keep.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;
}