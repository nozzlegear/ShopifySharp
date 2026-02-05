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
/// The input fields required to identify a customer.
/// </summary>
public record CustomerSetIdentifiers : GraphQLInputObject<CustomerSetIdentifiers>
{
    /// <summary>
    /// Custom ID of customer to upsert.
    /// </summary>
    [JsonPropertyName("customId")]
    public UniqueMetafieldValueInput? customId { get; set; } = null;

    /// <summary>
    /// Email address of the customer to upsert.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// ID of customer to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Phone number of the customer to upsert.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;
}