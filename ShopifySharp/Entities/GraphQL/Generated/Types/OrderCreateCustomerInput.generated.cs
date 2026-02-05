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
/// The input fields for a customer to associate with an order. Allows creation of a new customer or specifying an existing one.
/// </summary>
public record OrderCreateCustomerInput : GraphQLInputObject<OrderCreateCustomerInput>
{
    /// <summary>
    /// An existing customer to associate with the order, specified by ID.
    /// </summary>
    [JsonPropertyName("toAssociate")]
    public OrderCreateAssociateCustomerAttributesInput? toAssociate { get; set; } = null;

    /// <summary>
    /// A new customer to create or update and associate with the order.
    /// </summary>
    [JsonPropertyName("toUpsert")]
    public OrderCreateUpsertCustomerAttributesInput? toUpsert { get; set; } = null;
}