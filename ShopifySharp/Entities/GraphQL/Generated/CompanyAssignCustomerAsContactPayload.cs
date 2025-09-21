#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `companyAssignCustomerAsContact` mutation.
/// </summary>
public record CompanyAssignCustomerAsContactPayload : IGraphQLObject
{
    /// <summary>
    /// The created company contact.
    /// </summary>
    [JsonPropertyName("companyContact")]
    public CompanyContact? companyContact { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}