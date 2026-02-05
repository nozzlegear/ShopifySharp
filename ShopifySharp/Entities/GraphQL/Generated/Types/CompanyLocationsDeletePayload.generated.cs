#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `companyLocationsDelete` mutation.
/// </summary>
public record CompanyLocationsDeletePayload : IGraphQLObject
{
    /// <summary>
    /// A list of IDs of the deleted company locations.
    /// </summary>
    [JsonPropertyName("deletedCompanyLocationIds")]
    public ICollection<string>? deletedCompanyLocationIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}