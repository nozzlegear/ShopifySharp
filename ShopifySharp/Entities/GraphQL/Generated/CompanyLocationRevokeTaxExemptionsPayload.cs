#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyLocationRevokeTaxExemptions` mutation.
/// </summary>
public record CompanyLocationRevokeTaxExemptionsPayload : IGraphQLObject
{
    /// <summary>
    /// The updated company location.
    /// </summary>
    [JsonPropertyName("companyLocation")]
    public CompanyLocation? companyLocation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}