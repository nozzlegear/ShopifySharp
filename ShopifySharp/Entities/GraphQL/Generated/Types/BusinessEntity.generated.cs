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
/// A legal entity through which a merchant operates. Each business entity contains its own [`BusinessEntityAddress`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BusinessEntityAddress),
/// company information, and can be associated with its own [`ShopifyPaymentsAccount`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsAccount).
/// [`Market`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Market)
/// objects can be assigned to a business entity to determine payment processing and
/// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order) attribution.
/// Every shop must have one primary business entity. Additional entities enable
/// international operations by establishing legal presence in multiple countries.
/// Learn more about [managing multiple legal entities](https://shopify.dev/docs/apps/build/markets/multiple-entities).
/// </summary>
public record BusinessEntity : IGraphQLObject, INode
{
    /// <summary>
    /// The address of the merchant's Business Entity.
    /// </summary>
    [JsonPropertyName("address")]
    public BusinessEntityAddress? address { get; set; } = null;

    /// <summary>
    /// Whether the Business Entity is archived from the shop.
    /// </summary>
    [JsonPropertyName("archived")]
    public bool? archived { get; set; } = null;

    /// <summary>
    /// The name of the company associated with the merchant's Business Entity.
    /// </summary>
    [JsonPropertyName("companyName")]
    public string? companyName { get; set; } = null;

    /// <summary>
    /// The display name of the merchant's Business Entity.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether it's the merchant's primary Business Entity.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool? primary { get; set; } = null;

    /// <summary>
    /// Returns the Shopify Payments account information for the shop. Includes
    /// current balances across all currencies, payout schedules, and bank account
    /// configurations.
    /// The account includes [`ShopifyPaymentsBalanceTransaction`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsBalanceTransaction)
    /// records showing charges, refunds, and adjustments that affect your balance. Also includes [`ShopifyPaymentsDispute`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsDispute) records and [`ShopifyPaymentsPayout`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsPayout)
    /// history between the account and connected [`ShopifyPaymentsBankAccount`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsBankAccount)
    /// configurations.
    /// </summary>
    [JsonPropertyName("shopifyPaymentsAccount")]
    public ShopifyPaymentsAccount? shopifyPaymentsAccount { get; set; } = null;
}