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
/// The fields that can be used to override the default fields.
/// </summary>
public record CustomerMergePreviewAlternateFields : IGraphQLObject
{
    /// <summary>
    /// The default address of a customer.
    /// </summary>
    [JsonPropertyName("defaultAddress")]
    public MailingAddress? defaultAddress { get; set; } = null;

    /// <summary>
    /// The email state of a customer.
    /// </summary>
    [JsonPropertyName("email")]
    public CustomerEmailAddress? email { get; set; } = null;

    /// <summary>
    /// The first name of a customer.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The last name of a customer.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The phone number state of a customer.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public CustomerPhoneNumber? phoneNumber { get; set; } = null;
}