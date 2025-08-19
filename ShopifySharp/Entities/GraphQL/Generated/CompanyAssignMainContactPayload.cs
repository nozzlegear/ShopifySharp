#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyAssignMainContact` mutation.
/// </summary>
public record CompanyAssignMainContactPayload : IGraphQLObject
{
    /// <summary>
    /// The company for which the main contact is assigned.
    /// </summary>
    [JsonPropertyName("company")]
    public Company? company { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}