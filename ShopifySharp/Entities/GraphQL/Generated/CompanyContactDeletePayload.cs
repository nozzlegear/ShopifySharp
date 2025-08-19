#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyContactDelete` mutation.
/// </summary>
public record CompanyContactDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted company contact.
    /// </summary>
    [JsonPropertyName("deletedCompanyContactId")]
    public string? deletedCompanyContactId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}