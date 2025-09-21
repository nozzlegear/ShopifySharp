#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for identifying an existing customer to associate with the order.
/// </summary>
public record OrderCreateAssociateCustomerAttributesInput : GraphQLInputObject<OrderCreateAssociateCustomerAttributesInput>
{
    /// <summary>
    /// The email of the customer to associate to the order.
    ///               > Note:
    ///               > If both this email input field and the email on `OrderCreateOrderInput` are provided, this field will
    ///               > take precedence.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The customer to associate to the order.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}