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
/// Return type for `draftOrderInvoiceSend` mutation.
/// </summary>
public record DraftOrderInvoiceSendPayload : IGraphQLObject
{
    /// <summary>
    /// The draft order an invoice email is sent for.
    /// </summary>
    [JsonPropertyName("draftOrder")]
    public DraftOrder? draftOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}