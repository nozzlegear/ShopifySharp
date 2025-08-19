#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyLocationDelete` mutation.
/// </summary>
public record CompanyLocationDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted company location.
    /// </summary>
    [JsonPropertyName("deletedCompanyLocationId")]
    public string? deletedCompanyLocationId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}