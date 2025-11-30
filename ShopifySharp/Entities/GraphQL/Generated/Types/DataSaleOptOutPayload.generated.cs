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
/// Return type for `dataSaleOptOut` mutation.
/// </summary>
public record DataSaleOptOutPayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the customer whose email address has been opted out of data sale.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DataSaleOptOutUserError>? userErrors { get; set; } = null;
}