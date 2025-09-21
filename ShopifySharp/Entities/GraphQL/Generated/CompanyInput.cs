#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for company attributes when creating or updating a company.
/// </summary>
public record CompanyInput : GraphQLInputObject<CompanyInput>
{
    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) at
    ///           which the company became the customer.
    /// </summary>
    [JsonPropertyName("customerSince")]
    public DateTime? customerSince { get; set; } = null;

    /// <summary>
    /// A unique externally-supplied ID for the company.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? externalId { get; set; } = null;

    /// <summary>
    /// The name of the company.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A note about the company.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;
}