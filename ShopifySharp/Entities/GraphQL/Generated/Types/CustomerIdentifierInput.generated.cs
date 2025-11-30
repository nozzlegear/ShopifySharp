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
/// The input fields for identifying a customer.
/// </summary>
public record CustomerIdentifierInput : GraphQLInputObject<CustomerIdentifierInput>
{
    /// <summary>
    /// The [custom ID](https://shopify.dev/docs/apps/build/custom-data/metafields/working-with-custom-ids) of the customer.
    /// </summary>
    [JsonPropertyName("customId")]
    public UniqueMetafieldValueInput? customId { get; set; } = null;

    /// <summary>
    /// The email address of the customer.
    /// </summary>
    [JsonPropertyName("emailAddress")]
    public string? emailAddress { get; set; } = null;

    /// <summary>
    /// The ID of the customer.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The phone number of the customer.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public string? phoneNumber { get; set; } = null;
}