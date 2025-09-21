#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a remote Authorize.net customer payment profile.
/// </summary>
public record RemoteAuthorizeNetCustomerPaymentProfileInput : GraphQLInputObject<RemoteAuthorizeNetCustomerPaymentProfileInput>
{
    /// <summary>
    /// The customerPaymentProfileId value from the Authorize.net API. Starting on 2025,
    /// customer_payment_profile_id will become mandatory for all API versions.
    /// </summary>
    [JsonPropertyName("customerPaymentProfileId")]
    public string? customerPaymentProfileId { get; set; } = null;

    /// <summary>
    /// The customerProfileId value from the Authorize.net API.
    /// </summary>
    [JsonPropertyName("customerProfileId")]
    public string? customerProfileId { get; set; } = null;
}