#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents information about a customer of the shop, such as the customer's contact details, their order
/// history, and whether they've agreed to receive marketing material by email.
/// **Caution:** Only use this data if it's required for your app's functionality.
/// Shopify will restrict [access to
/// scopes](https://shopify.dev/api/usage/access-scopes) for apps that don't have a
/// legitimate use for the associated data.
/// </summary>
public record Customer : CommentEventEmbed, IGraphQLUnionCase, IGraphQLObject, ICommentEventSubject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, IHasStoreCreditAccounts, ILegacyInteroperability, INode
{
    /// <summary>
    /// A list of addresses associated with the customer.
    /// </summary>
    [JsonPropertyName("addresses")]
    public ICollection<MailingAddress>? addresses { get; set; } = null;

    /// <summary>
    /// The addresses associated with the customer.
    /// </summary>
    [JsonPropertyName("addressesV2")]
    public MailingAddressConnection? addressesV2 { get; set; } = null;

    /// <summary>
    /// The total amount that the customer has spent on orders in their lifetime.
    /// </summary>
    [JsonPropertyName("amountSpent")]
    public MoneyV2? amountSpent { get; set; } = null;

    /// <summary>
    /// Whether the merchant can delete the customer from their store.
    /// A customer can be deleted from a store only if they haven't yet made an order. After a customer makes an
    /// order, they can't be deleted from a store.
    /// </summary>
    [JsonPropertyName("canDelete")]
    public bool? canDelete { get; set; } = null;

    /// <summary>
    /// A list of the customer's company contact profiles.
    /// </summary>
    [JsonPropertyName("companyContactProfiles")]
    public ICollection<CompanyContact>? companyContactProfiles { get; set; } = null;

    /// <summary>
    /// The date and time when the customer was added to the store.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Whether the customer has opted out of having their data sold.
    /// </summary>
    [JsonPropertyName("dataSaleOptOut")]
    public bool? dataSaleOptOut { get; set; } = null;

    /// <summary>
    /// The default address associated with the customer.
    /// </summary>
    [JsonPropertyName("defaultAddress")]
    public MailingAddress? defaultAddress { get; set; } = null;

    /// <summary>
    /// The customer's default email address.
    /// </summary>
    [JsonPropertyName("defaultEmailAddress")]
    public CustomerEmailAddress? defaultEmailAddress { get; set; } = null;

    /// <summary>
    /// The customer's default phone number.
    /// </summary>
    [JsonPropertyName("defaultPhoneNumber")]
    public CustomerPhoneNumber? defaultPhoneNumber { get; set; } = null;

    /// <summary>
    /// The full name of the customer, based on the values for first_name and last_name. If the first_name and
    /// last_name are not available, then this falls back to the customer's email
    /// address, and if that is not available, the customer's phone number.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// The customer's email address.
    /// </summary>
    [JsonPropertyName("email")]
    [Obsolete("Use `defaultEmailAddress.emailAddress` instead.")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The current email marketing state for the customer.
    /// If the customer doesn't have an email address, then this property is `null`.
    /// </summary>
    [JsonPropertyName("emailMarketingConsent")]
    [Obsolete("Use `defaultEmailAddress.marketingState`, `defaultEmailAddress.marketingOptInLevel`, `defaultEmailAddress.marketingUpdatedAt`, and `defaultEmailAddress.sourceLocation` instead.")]
    public CustomerEmailMarketingConsentState? emailMarketingConsent { get; set; } = null;

    /// <summary>
    /// A list of events associated with the customer.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// The customer's first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// Whether the merchant has added timeline comments about the customer on the customer's page.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    [Obsolete("To query for comments on the timeline, use the `events` connection and a query argument containing `verb:comment`, or look for a CommentEvent in the `__typename` of `events`.")]
    public bool? hasTimelineComment { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image associated with the customer.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// The customer's last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The customer's last order.
    /// </summary>
    [JsonPropertyName("lastOrder")]
    public Order? lastOrder { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The amount of time since the customer was first added to the store.
    /// Example: 'about 12 years'.
    /// </summary>
    [JsonPropertyName("lifetimeDuration")]
    public string? lifetimeDuration { get; set; } = null;

    /// <summary>
    /// The customer's locale.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The market that includes the customer’s default address.
    /// </summary>
    [JsonPropertyName("market")]
    [Obsolete("This `market` field will be removed in a future version of the API.")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// Whether the customer can be merged with another customer.
    /// </summary>
    [JsonPropertyName("mergeable")]
    public CustomerMergeable? mergeable { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// A unique identifier for the customer that's used with Multipass login.
    /// </summary>
    [JsonPropertyName("multipassIdentifier")]
    public string? multipassIdentifier { get; set; } = null;

    /// <summary>
    /// A note about the customer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The number of orders that the customer has made at the store in their lifetime.
    /// </summary>
    [JsonPropertyName("numberOfOrders")]
    public ulong? numberOfOrders { get; set; } = null;

    /// <summary>
    /// A list of the customer's orders.
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// A list of the customer's payment methods.
    /// </summary>
    [JsonPropertyName("paymentMethods")]
    public CustomerPaymentMethodConnection? paymentMethods { get; set; } = null;

    /// <summary>
    /// The customer's phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    [Obsolete("Use `defaultPhoneNumber.phoneNumber` instead.")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// Possible subscriber states of a customer defined by their subscription contracts.
    /// </summary>
    [JsonPropertyName("productSubscriberStatus")]
    public CustomerProductSubscriberStatus? productSubscriberStatus { get; set; } = null;

    /// <summary>
    /// The current SMS marketing state for the customer's phone number.
    /// If the customer does not have a phone number, then this property is `null`.
    /// </summary>
    [JsonPropertyName("smsMarketingConsent")]
    [Obsolete("Use `defaultPhoneNumber.marketingState`, `defaultPhoneNumber.marketingOptInLevel`, `defaultPhoneNumber.marketingUpdatedAt`, `defaultPhoneNumber.marketingCollectedFrom`, and `defaultPhoneNumber.sourceLocation` instead.")]
    public CustomerSmsMarketingConsentState? smsMarketingConsent { get; set; } = null;

    /// <summary>
    /// The state of the customer's account with the shop.
    /// Please note that this only meaningful when Classic Customer Accounts is active.
    /// </summary>
    [JsonPropertyName("state")]
    public CustomerState? state { get; set; } = null;

    /// <summary>
    /// The statistics for a given customer.
    /// </summary>
    [JsonPropertyName("statistics")]
    public CustomerStatistics? statistics { get; set; } = null;

    /// <summary>
    /// Returns a list of store credit accounts that belong to the owner resource.
    /// A store credit account owner can hold multiple accounts each with a different currency.
    /// </summary>
    [JsonPropertyName("storeCreditAccounts")]
    public StoreCreditAccountConnection? storeCreditAccounts { get; set; } = null;

    /// <summary>
    /// A list of the customer's subscription contracts.
    /// </summary>
    [JsonPropertyName("subscriptionContracts")]
    public SubscriptionContractConnection? subscriptionContracts { get; set; } = null;

    /// <summary>
    /// A comma separated list of tags that have been added to the customer.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// Whether the customer is exempt from being charged taxes on their orders.
    /// </summary>
    [JsonPropertyName("taxExempt")]
    public bool? taxExempt { get; set; } = null;

    /// <summary>
    /// The list of tax exemptions applied to the customer.
    /// </summary>
    [JsonPropertyName("taxExemptions")]
    public ICollection<TaxExemption>? taxExemptions { get; set; } = null;

    /// <summary>
    /// The URL to unsubscribe the customer from the mailing list.
    /// </summary>
    [JsonPropertyName("unsubscribeUrl")]
    [Obsolete("Use `defaultEmailAddress.marketingUnsubscribeUrl` instead.")]
    public string? unsubscribeUrl { get; set; } = null;

    /// <summary>
    /// The date and time when the customer was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// Whether the email address is formatted correctly.
    /// Returns `true` when the email is formatted correctly and
    /// belongs to an existing domain. This doesn't guarantee that
    /// the email address actually exists.
    /// </summary>
    [JsonPropertyName("validEmailAddress")]
    [Obsolete("Use `defaultEmailAddress.validFormat` instead.")]
    public bool? validEmailAddress { get; set; } = null;

    /// <summary>
    /// Whether the customer has verified their email address. Defaults to `true` if
    /// the customer is created through the Shopify admin or API.
    /// </summary>
    [JsonPropertyName("verifiedEmail")]
    public bool? verifiedEmail { get; set; } = null;
}