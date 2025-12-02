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
/// The input fields for the role and contact to assign on a location.
/// </summary>
public record CompanyLocationRoleAssign : GraphQLInputObject<CompanyLocationRoleAssign>
{
    /// <summary>
    /// The company contact ID..
    /// </summary>
    [JsonPropertyName("companyContactId")]
    public string? companyContactId { get; set; } = null;

    /// <summary>
    /// The role ID.
    /// </summary>
    [JsonPropertyName("companyContactRoleId")]
    public string? companyContactRoleId { get; set; } = null;
}