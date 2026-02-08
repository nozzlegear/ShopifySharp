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
/// Return type for `appPurchaseOneTimeCreate` mutation.
/// </summary>
public record AppPurchaseOneTimeCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created app one-time purchase.
    /// </summary>
    [JsonPropertyName("appPurchaseOneTime")]
    public AppPurchaseOneTime? appPurchaseOneTime { get; set; } = null;

    /// <summary>
    /// The URL that the merchant can access to approve or decline the newly created app one-time purchase.
    /// If the merchant declines, then the merchant is redirected to the app and
    /// receives a notification message stating that the charge was declined.
    /// If the merchant approves and they're successfully invoiced, then the state of
    /// the charge changes from `pending` to `active`.
    /// You get paid after the charge is activated.
    /// </summary>
    [JsonPropertyName("confirmationUrl")]
    public string? confirmationUrl { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}