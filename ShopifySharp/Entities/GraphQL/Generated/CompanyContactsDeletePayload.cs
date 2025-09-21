#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `companyContactsDelete` mutation.
/// </summary>
public record CompanyContactsDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The list of IDs of the deleted company contacts.
    /// </summary>
    [JsonPropertyName("deletedCompanyContactIds")]
    public ICollection<string>? deletedCompanyContactIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}