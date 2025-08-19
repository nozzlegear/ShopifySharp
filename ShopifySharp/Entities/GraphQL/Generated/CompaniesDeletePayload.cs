#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companiesDelete` mutation.
/// </summary>
public record CompaniesDeletePayload : IGraphQLObject
{
    /// <summary>
    /// A list of IDs of the deleted companies.
    /// </summary>
    [JsonPropertyName("deletedCompanyIds")]
    public ICollection<string>? deletedCompanyIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}