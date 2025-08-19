#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the role and location to assign to a company contact.
/// </summary>
public record CompanyContactRoleAssign : GraphQLInputObject<CompanyContactRoleAssign>
{
    /// <summary>
    /// The role ID.
    /// </summary>
    [JsonPropertyName("companyContactRoleId")]
    public string? companyContactRoleId { get; set; } = null;

    /// <summary>
    /// The location.
    /// </summary>
    [JsonPropertyName("companyLocationId")]
    public string? companyLocationId { get; set; } = null;
}