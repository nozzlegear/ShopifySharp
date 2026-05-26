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
/// The input fields for updating a cash drawer.
/// </summary>
public record CashDrawerUpdateInput : GraphQLInputObject<CashDrawerUpdateInput>
{
    /// <summary>
    /// The new name for the cash drawer.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}