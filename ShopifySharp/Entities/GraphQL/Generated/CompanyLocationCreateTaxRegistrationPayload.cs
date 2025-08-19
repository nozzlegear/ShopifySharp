#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `companyLocationCreateTaxRegistration` mutation.
/// </summary>
public record CompanyLocationCreateTaxRegistrationPayload : IGraphQLObject
{
    /// <summary>
    /// The company location with the created tax registration.
    /// </summary>
    [JsonPropertyName("companyLocation")]
    public CompanyLocation? companyLocation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}