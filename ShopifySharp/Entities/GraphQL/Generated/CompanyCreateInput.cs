#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields and values for creating a company and its associated resources.
/// </summary>
public record CompanyCreateInput : GraphQLInputObject<CompanyCreateInput>
{
    /// <summary>
    /// The attributes for the company.
    /// </summary>
    [JsonPropertyName("company")]
    public CompanyInput? company { get; set; } = null;

    /// <summary>
    /// The attributes for the company contact.
    /// </summary>
    [JsonPropertyName("companyContact")]
    public CompanyContactInput? companyContact { get; set; } = null;

    /// <summary>
    /// The attributes for the company location.
    /// </summary>
    [JsonPropertyName("companyLocation")]
    public CompanyLocationInput? companyLocation { get; set; } = null;
}