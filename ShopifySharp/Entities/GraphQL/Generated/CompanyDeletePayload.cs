#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyDelete` mutation.
/// </summary>
public record CompanyDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted company.
    /// </summary>
    [JsonPropertyName("deletedCompanyId")]
    public string? deletedCompanyId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}