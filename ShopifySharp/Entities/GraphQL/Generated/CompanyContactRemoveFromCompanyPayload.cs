#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyContactRemoveFromCompany` mutation.
/// </summary>
public record CompanyContactRemoveFromCompanyPayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the removed company contact.
    /// </summary>
    [JsonPropertyName("removedCompanyContactId")]
    public string? removedCompanyContactId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}