#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `companyAddressDelete` mutation.
/// </summary>
public record CompanyAddressDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted address.
    /// </summary>
    [JsonPropertyName("deletedAddressId")]
    public string? deletedAddressId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}