#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for company contact attributes when creating or updating a company contact.
/// </summary>
public record CompanyContactInput : GraphQLInputObject<CompanyContactInput>
{
    /// <summary>
    /// The unique email address of the company contact.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The company contact's first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The company contact's last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The contact's locale.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The phone number of the company contact.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The title of the company contact.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}