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
/// Additional information included on a delivery method that will help during the delivery process.
/// </summary>
public record DeliveryMethodAdditionalInformation : IGraphQLObject
{
    /// <summary>
    /// The delivery instructions to follow when performing the delivery.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? instructions { get; set; } = null;

    /// <summary>
    /// The phone number to contact when performing the delivery.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;
}