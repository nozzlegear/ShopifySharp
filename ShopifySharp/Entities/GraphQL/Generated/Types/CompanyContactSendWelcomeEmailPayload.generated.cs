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
/// Return type for `companyContactSendWelcomeEmail` mutation.
/// </summary>
public record CompanyContactSendWelcomeEmailPayload : IGraphQLObject
{
    /// <summary>
    /// The company contact to whom a welcome email was sent.
    /// </summary>
    [JsonPropertyName("companyContact")]
    public CompanyContact? companyContact { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BusinessCustomerUserError>? userErrors { get; set; } = null;
}