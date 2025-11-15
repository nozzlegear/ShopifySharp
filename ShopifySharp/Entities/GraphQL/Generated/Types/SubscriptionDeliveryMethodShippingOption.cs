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
/// Represents the selected shipping option on a subscription contract.
/// </summary>
public record SubscriptionDeliveryMethodShippingOption : IGraphQLObject
{
    /// <summary>
    /// The carrier service that's providing this shipping option.
    /// This field isn't currently supported and returns null.
    /// </summary>
    [JsonPropertyName("carrierService")]
    [Obsolete("This field has never been implemented.")]
    public DeliveryCarrierService? carrierService { get; set; } = null;

    /// <summary>
    /// The code of the shipping option.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The description of the shipping option.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The presentment title of the shipping option.
    /// </summary>
    [JsonPropertyName("presentmentTitle")]
    public string? presentmentTitle { get; set; } = null;

    /// <summary>
    /// The title of the shipping option.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}