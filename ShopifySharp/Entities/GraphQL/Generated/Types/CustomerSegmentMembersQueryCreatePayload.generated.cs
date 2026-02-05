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
/// Return type for `customerSegmentMembersQueryCreate` mutation.
/// </summary>
public record CustomerSegmentMembersQueryCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created customer segment members query.
    /// </summary>
    [JsonPropertyName("customerSegmentMembersQuery")]
    public CustomerSegmentMembersQuery? customerSegmentMembersQuery { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerSegmentMembersQueryUserError>? userErrors { get; set; } = null;
}