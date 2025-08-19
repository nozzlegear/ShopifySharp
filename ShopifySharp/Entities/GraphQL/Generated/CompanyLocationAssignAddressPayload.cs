#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyLocationAssignAddress` mutation.
/// </summary>
public record CompanyLocationAssignAddressPayload : IGraphQLObject
{
    /// <summary>
    /// The list of updated addresses on the company location.
    /// </summary>
    [JsonPropertyName("addresses")]
    public ICollection<CompanyAddress>? addresses { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}