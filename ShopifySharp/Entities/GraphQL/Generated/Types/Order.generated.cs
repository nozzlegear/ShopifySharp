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
/// The `Order` object represents a customer's request to purchase one or more
/// products from a store. Use the `Order` object to handle the complete purchase
/// lifecycle from checkout to fulfillment.
/// Use the `Order` object when you need to:
/// - Display order details on customer account pages or admin dashboards.
/// - Create orders for phone sales, wholesale customers, or subscription services.
/// - Update order information like shipping addresses, notes, or fulfillment status.
/// - Process returns, exchanges, and partial refunds.
/// - Generate invoices, receipts, and shipping labels.
/// The `Order` object serves as the central hub connecting customer information,
/// product details, payment processing, and fulfillment data within the GraphQL
/// Admin API schema.
/// > Note:
/// > Only the last 60 days' worth of orders from a store are accessible from the
/// `Order` object by default. If you want to access older records,
/// > then you need to [request access to all
/// orders](https://shopify.dev/docs/api/usage/access-scopes#orders-permissions). If
/// your app is granted
/// > access, then you can add the `read_all_orders`, `read_orders`, and `write_orders` scopes.
/// > Caution:
/// > Only use orders data if it's required for your app's functionality. Shopify
/// will restrict [access to scopes](https://shopify.dev/docs/api/usage/access-scopes#requesting-specific-permissions)
/// for apps that don't have a legitimate use for the associated data.
/// Learn more about [building apps for orders and fulfillment](https://shopify.dev/docs/apps/build/orders-fulfillment).
/// </summary>
public record Order : IGraphQLUnionCase, IGraphQLObject, ICommentEventSubject, IHasEvents, IHasLocalizationExtensions, IHasLocalizedFields, IHasMetafieldDefinitions, IHasMetafields, ILegacyInteroperability, INode
{
    /// <summary>
    /// A list of additional fees applied to an order, such as duties, import fees, or [tax lines](https://shopify.dev/docs/api/admin-graphql/latest/objects/order#field-Order.fields.additionalFees.taxLines).
    /// </summary>
    [JsonPropertyName("additionalFees")]
    public ICollection<AdditionalFee>? additionalFees { get; set; } = null;

    /// <summary>
    /// A list of sales agreements associated with the order, such as contracts
    /// defining payment terms, or delivery schedules between merchants and customers.
    /// </summary>
    [JsonPropertyName("agreements")]
    public SalesAgreementConnection? agreements { get; set; } = null;

    /// <summary>
    /// A list of messages that appear on the **Orders** page in the Shopify admin.
    /// These alerts provide merchants with important information about an order's
    /// status or required actions.
    /// </summary>
    [JsonPropertyName("alerts")]
    public ICollection<ResourceAlert>? alerts { get; set; } = null;

    /// <summary>
    /// The application that created the order. For example, "Online Store", "Point of Sale", or a custom app name.
    /// Use this to identify the order source for attribution and fulfillment workflows.
    /// Learn more about [building apps for orders and fulfillment](https://shopify.dev/docs/apps/build/orders-fulfillment).
    /// </summary>
    [JsonPropertyName("app")]
    public OrderApp? app { get; set; } = null;

    /// <summary>
    /// The billing address associated with the payment method selected by the customer for an order.
    /// Returns `null` if no billing address was provided during checkout.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public MailingAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// Whether the billing address matches the [shipping address](https://shopify.dev/docs/api/admin-graphql/latest/objects/order#field-Order.fields.shippingAddress).
    /// Returns `true` if both addresses are the same, and `false` if they're
    /// different or if an address is missing.
    /// </summary>
    [JsonPropertyName("billingAddressMatchesShippingAddress")]
    public bool? billingAddressMatchesShippingAddress { get; set; } = null;

    /// <summary>
    /// Details of an order's cancellation, if it has been canceled. This includes the
    /// reason, date, and any [staff notes](https://shopify.dev/api/admin-graphql/latest/objects/OrderCancellation#field-OrderCancellation.fields.staffNote).
    /// </summary>
    [JsonPropertyName("cancellation")]
    public OrderCancellation? cancellation { get; set; } = null;

    /// <summary>
    /// The date and time in [ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601) when an order was canceled.
    /// Returns `null` if the order hasn't been canceled.
    /// </summary>
    [JsonPropertyName("cancelledAt")]
    public DateTimeOffset? cancelledAt { get; set; } = null;

    /// <summary>
    /// The reason provided for an order cancellation. For example, a merchant might
    /// cancel an order if there's insufficient inventory. Returns `null` if the order
    /// hasn't been canceled.
    /// </summary>
    [JsonPropertyName("cancelReason")]
    public OrderCancelReason? cancelReason { get; set; } = null;

    /// <summary>
    /// Whether an order can be manually marked as paid. Returns `false` if the order
    /// is already paid, is canceled, has pending [Shopify Payments](https://help.shopify.com/en/manual/payments/shopify-payments/payouts)
    /// transactions, or has a negative payment amount.
    /// </summary>
    [JsonPropertyName("canMarkAsPaid")]
    public bool? canMarkAsPaid { get; set; } = null;

    /// <summary>
    /// Whether order notifications can be sent to the customer.
    /// Returns `true` if the customer has a valid [email address](https://shopify.dev/docs/api/admin-graphql/latest/objects/order#field-Order.fields.email).
    /// </summary>
    [JsonPropertyName("canNotifyCustomer")]
    public bool? canNotifyCustomer { get; set; } = null;

    /// <summary>
    /// Whether an authorized payment for an order can be captured.
    /// Returns `true` if an authorized payment exists that hasn't been fully captured
    /// yet. Learn more about [capturing payments](https://help.shopify.com/en/manual/fulfillment/managing-orders/payments/capturing-payments).
    /// </summary>
    [JsonPropertyName("capturable")]
    public bool? capturable { get; set; } = null;

    /// <summary>
    /// The total discount amount that applies to the entire order in shop currency,
    /// before returns, refunds, order edits, and cancellations.
    /// </summary>
    [JsonPropertyName("cartDiscountAmount")]
    [Obsolete("Use `cartDiscountAmountSet` instead.")]
    public decimal? cartDiscountAmount { get; set; } = null;

    /// <summary>
    /// The total discount amount applied at the time the order was created, displayed
    /// in both shop and presentment currencies, before returns, refunds, order edits,
    /// and cancellations. This field only includes discounts applied to the entire order.
    /// </summary>
    [JsonPropertyName("cartDiscountAmountSet")]
    public MoneyBag? cartDiscountAmountSet { get; set; } = null;

    /// <summary>
    /// The sales channel from which an order originated, such as the [Online
    /// Store](https://shopify.dev/docs/apps/build/app-surfaces#online-store) or
    /// [Shopify POS](https://shopify.dev/docs/apps/build/app-surfaces#point-of-sale).
    /// </summary>
    [JsonPropertyName("channel")]
    [Obsolete("Use `publication` instead.")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// Details about the sales channel that created the order, such as the [channel app type](https://shopify.dev/docs/api/admin-graphql/latest/objects/channel#field-Channel.fields.channelType)
    /// and [channel name](https://shopify.dev/docs/api/admin-graphql/latest/objects/ChannelDefinition#field-ChannelDefinition.fields.channelName), which helps to track order sources.
    /// </summary>
    [JsonPropertyName("channelInformation")]
    public ChannelInformation? channelInformation { get; set; } = null;

    /// <summary>
    /// The IP address of the customer who placed the order. Useful for fraud detection and geographic analysis.
    /// </summary>
    [JsonPropertyName("clientIp")]
    public string? clientIp { get; set; } = null;

    /// <summary>
    /// Whether an order is closed. An order is considered closed if all its line
    /// items have been fulfilled or canceled, and all financial transactions are complete.
    /// </summary>
    [JsonPropertyName("closed")]
    public bool? closed { get; set; } = null;

    /// <summary>
    /// The date and time [ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601)
    /// when an order was closed. Shopify automatically records this timestamp when
    /// all items have been fulfilled or canceled, and all financial transactions are
    /// complete. Returns `null` if the order isn't closed.
    /// </summary>
    [JsonPropertyName("closedAt")]
    public DateTimeOffset? closedAt { get; set; } = null;

    /// <summary>
    /// A customer-facing order identifier, often shown instead of the sequential order name.
    /// It uses a random alphanumeric format (for example, `XPAV284CT`) and isn't guaranteed to be unique across orders.
    /// </summary>
    [JsonPropertyName("confirmationNumber")]
    public string? confirmationNumber { get; set; } = null;

    /// <summary>
    /// Whether inventory has been reserved for an order. Returns `true` if inventory
    /// quantities for an order's [line
    /// items](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem)
    /// have been reserved.
    /// Learn more about [managing inventory quantities and states](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps/manage-quantities-states).
    /// </summary>
    [JsonPropertyName("confirmed")]
    public bool? confirmed { get; set; } = null;

    /// <summary>
    /// The date and time in [ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601)
    /// when an order was created. This timestamp is set when the customer completes
    /// checkout and remains unchanged throughout an order's lifecycle.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The shop currency when the order was placed. For example, "USD" or "CAD".
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;

    /// <summary>
    /// The current total of all discounts applied to the entire order, after returns,
    /// refunds, order edits, and cancellations. This includes discount codes,
    /// automatic discounts, and other promotions that affect the whole order rather
    /// than individual line items. To get the original discount amount at the time of
    /// order creation, use the [`cartDiscountAmountSet`](https://shopify.dev/docs/api/admin-graphql/latest/objects/order#field-Order.fields.cartDiscountAmountSet) field.
    /// </summary>
    [JsonPropertyName("currentCartDiscountAmountSet")]
    public MoneyBag? currentCartDiscountAmountSet { get; set; } = null;

    /// <summary>
    /// The current shipping price after applying refunds and discounts.
    /// If the parent `order.taxesIncluded` field is true, then this price includes
    /// taxes. Otherwise, this field is the pre-tax price.
    /// </summary>
    [JsonPropertyName("currentShippingPriceSet")]
    public MoneyBag? currentShippingPriceSet { get; set; } = null;

    /// <summary>
    /// The current sum of the quantities for all line items that contribute to the
    /// order's subtotal price, after returns, refunds, order edits, and cancellations.
    /// </summary>
    [JsonPropertyName("currentSubtotalLineItemsQuantity")]
    public int? currentSubtotalLineItemsQuantity { get; set; } = null;

    /// <summary>
    /// The total price of the order, after returns and refunds, in shop and presentment currencies.
    /// This includes taxes and discounts.
    /// </summary>
    [JsonPropertyName("currentSubtotalPriceSet")]
    public MoneyBag? currentSubtotalPriceSet { get; set; } = null;

    /// <summary>
    /// A list of all tax lines applied to line items on the order, after returns.
    /// Tax line prices represent the total price for all tax lines with the same `rate` and `title`.
    /// </summary>
    [JsonPropertyName("currentTaxLines")]
    public ICollection<TaxLine>? currentTaxLines { get; set; } = null;

    /// <summary>
    /// The current total of all additional fees for an order, after any returns or
    /// modifications. Modifications include returns, refunds, order edits, and
    /// cancellations. Additional fees can include charges such as duties, import
    /// fees, and special handling.
    /// </summary>
    [JsonPropertyName("currentTotalAdditionalFeesSet")]
    public MoneyBag? currentTotalAdditionalFeesSet { get; set; } = null;

    /// <summary>
    /// The total amount discounted on the order after returns and refunds, in shop and presentment currencies.
    /// This includes both order and line level discounts.
    /// </summary>
    [JsonPropertyName("currentTotalDiscountsSet")]
    public MoneyBag? currentTotalDiscountsSet { get; set; } = null;

    /// <summary>
    /// The current total duties amount for an order, after any returns or
    /// modifications. Modifications include returns, refunds, order edits, and cancellations.
    /// </summary>
    [JsonPropertyName("currentTotalDutiesSet")]
    public MoneyBag? currentTotalDutiesSet { get; set; } = null;

    /// <summary>
    /// The total price of the order, after returns, in shop and presentment currencies.
    /// This includes taxes and discounts.
    /// </summary>
    [JsonPropertyName("currentTotalPriceSet")]
    public MoneyBag? currentTotalPriceSet { get; set; } = null;

    /// <summary>
    /// The sum of the prices of all tax lines applied to line items on the order,
    /// after returns and refunds, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("currentTotalTaxSet")]
    public MoneyBag? currentTotalTaxSet { get; set; } = null;

    /// <summary>
    /// The total weight of the order after returns and refunds, in grams.
    /// </summary>
    [JsonPropertyName("currentTotalWeight")]
    public ulong? currentTotalWeight { get; set; } = null;

    /// <summary>
    /// A list of additional information that has been attached to the order. For
    /// example, gift message, delivery instructions, or internal notes.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// The customer who placed an order. Returns `null` if an order was created
    /// through a checkout without customer authentication, such as a guest checkout.
    /// Learn more about [customer accounts](https://help.shopify.com/manual/customers/customer-accounts).
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// Whether the customer agreed to receive marketing emails at the time of purchase.
    /// Use this to ensure compliance with marketing consent laws and to segment customers for email campaigns.
    /// Learn more about [building customer segments](https://shopify.dev/docs/apps/build/marketing-analytics/customer-segments).
    /// </summary>
    [JsonPropertyName("customerAcceptsMarketing")]
    public bool? customerAcceptsMarketing { get; set; } = null;

    /// <summary>
    /// The customer's visits and interactions with the online store before placing the order.
    /// </summary>
    [JsonPropertyName("customerJourney")]
    [Obsolete("Use `customerJourneySummary` instead.")]
    public CustomerJourney? customerJourney { get; set; } = null;

    /// <summary>
    /// The customer's visits and interactions with the online store before placing the order.
    /// Use this to understand customer behavior, attribution sources, and marketing effectiveness to optimize your sales funnel.
    /// </summary>
    [JsonPropertyName("customerJourneySummary")]
    public CustomerJourneySummary? customerJourneySummary { get; set; } = null;

    /// <summary>
    /// The customer's language and region preference at the time of purchase. For
    /// example, "en" for English, "fr-CA" for French (Canada), or "es-MX" for Spanish (Mexico).
    /// Use this to provide localized customer service and targeted marketing in the customer's preferred language.
    /// </summary>
    [JsonPropertyName("customerLocale")]
    public string? customerLocale { get; set; } = null;

    /// <summary>
    /// A list of discounts that are applied to the order, excluding order edits and refunds.
    /// Includes discount codes, automatic discounts, and other promotions that reduce the order total.
    /// </summary>
    [JsonPropertyName("discountApplications")]
    public DiscountApplicationConnection? discountApplications { get; set; } = null;

    /// <summary>
    /// The discount code used for an order. Returns `null` if no discount code was applied.
    /// </summary>
    [JsonPropertyName("discountCode")]
    public string? discountCode { get; set; } = null;

    /// <summary>
    /// The discount codes used for the order. Multiple codes can be applied to a single order.
    /// </summary>
    [JsonPropertyName("discountCodes")]
    public ICollection<string>? discountCodes { get; set; } = null;

    /// <summary>
    /// The primary address of the customer, prioritizing shipping address over billing address when both are available.
    /// Returns `null` if neither shipping address nor billing address was provided.
    /// </summary>
    [JsonPropertyName("displayAddress")]
    public MailingAddress? displayAddress { get; set; } = null;

    /// <summary>
    /// An order's financial status for display in the Shopify admin.
    /// </summary>
    [JsonPropertyName("displayFinancialStatus")]
    public OrderDisplayFinancialStatus? displayFinancialStatus { get; set; } = null;

    /// <summary>
    /// The order's fulfillment status that displays in the Shopify admin to
    /// merchants. For example, an order might be unfulfilled or scheduled.
    /// For detailed processing, use the [`FulfillmentOrder`](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentOrder) object.
    /// </summary>
    [JsonPropertyName("displayFulfillmentStatus")]
    public OrderDisplayFulfillmentStatus? displayFulfillmentStatus { get; set; } = null;

    /// <summary>
    /// A list of payment disputes associated with the order, such as chargebacks or payment inquiries.
    /// Disputes occur when customers challenge transactions with their bank or payment provider.
    /// </summary>
    [JsonPropertyName("disputes")]
    public ICollection<OrderDisputeSummary>? disputes { get; set; } = null;

    /// <summary>
    /// Whether duties are included in the subtotal price of the order.
    /// Duties are import taxes charged by customs authorities when goods cross international borders.
    /// </summary>
    [JsonPropertyName("dutiesIncluded")]
    public bool? dutiesIncluded { get; set; } = null;

    /// <summary>
    /// Whether the order has had any edits applied. For example, adding or removing
    /// line items, updating quantities, or changing prices.
    /// </summary>
    [JsonPropertyName("edited")]
    public bool? edited { get; set; } = null;

    /// <summary>
    /// The email address associated with the customer for this order.
    /// Used for sending order confirmations, shipping notifications, and other order-related communications.
    /// Returns `null` if no email address was provided during checkout.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// Whether taxes on the order are estimated.
    /// This field returns `false` when taxes on the order are finalized and aren't subject to any changes.
    /// </summary>
    [JsonPropertyName("estimatedTaxes")]
    public bool? estimatedTaxes { get; set; } = null;

    /// <summary>
    /// A list of events associated with the order. Events track significant changes
    /// and activities related to the order, such as creation, payment, fulfillment,
    /// and cancellation.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// A list of ExchangeV2s for the order.
    /// </summary>
    [JsonPropertyName("exchangeV2s")]
    [Obsolete("Use `returns` instead.")]
    public ExchangeV2Connection? exchangeV2s { get; set; } = null;

    /// <summary>
    /// Whether there are line items that can be fulfilled.
    /// This field returns `false` when the order has no fulfillable line items.
    /// For a more granular view of the fulfillment status, refer to the [FulfillmentOrder](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrder) object.
    /// </summary>
    [JsonPropertyName("fulfillable")]
    public bool? fulfillable { get; set; } = null;

    /// <summary>
    /// A list of [fulfillment orders](https://shopify.dev/docs/api/admin-graphql/latest/objects/FulfillmentOrder) for an order.
    /// Each fulfillment order groups [line items](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order#field-Order.fields.lineItems)
    /// that are fulfilled together,
    /// allowing an order to be processed in parts if needed.
    /// </summary>
    [JsonPropertyName("fulfillmentOrders")]
    public FulfillmentOrderConnection? fulfillmentOrders { get; set; } = null;

    /// <summary>
    /// A list of shipments for the order. Fulfillments represent the physical shipment of products to customers.
    /// </summary>
    [JsonPropertyName("fulfillments")]
    public ICollection<Fulfillment>? fulfillments { get; set; } = null;

    /// <summary>
    /// The total number of fulfillments for the order, including canceled ones.
    /// </summary>
    [JsonPropertyName("fulfillmentsCount")]
    public Count? fulfillmentsCount { get; set; } = null;

    /// <summary>
    /// Whether the order has been paid in full. This field returns `true` when the
    /// total amount received equals or exceeds the order total.
    /// </summary>
    [JsonPropertyName("fullyPaid")]
    public bool? fullyPaid { get; set; } = null;

    /// <summary>
    /// Whether the merchant has added a timeline comment to the order.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The URL of the first page of the online store that the customer visited before they submitted the order.
    /// </summary>
    [JsonPropertyName("landingPageDisplayText")]
    [Obsolete("Use `customerJourneySummary.lastVisit.landingPageHtml` instead")]
    public string? landingPageDisplayText { get; set; } = null;

    /// <summary>
    /// The first page of the online store that the customer visited before they submitted the order.
    /// </summary>
    [JsonPropertyName("landingPageUrl")]
    [Obsolete("Use `customerJourneySummary.lastVisit.landingPage` instead")]
    public string? landingPageUrl { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// A list of the order's line items. Line items represent the individual products and quantities that make up the order.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public LineItemConnection? lineItems { get; set; } = null;

    /// <summary>
    /// List of localization extensions for the resource.
    /// </summary>
    [JsonPropertyName("localizationExtensions")]
    [Obsolete("This connection will be removed in a future version. Use `localizedFields` instead.")]
    public LocalizationExtensionConnection? localizationExtensions { get; set; } = null;

    /// <summary>
    /// List of localized fields for the resource.
    /// </summary>
    [JsonPropertyName("localizedFields")]
    public LocalizedFieldConnection? localizedFields { get; set; } = null;

    /// <summary>
    /// The legal business structure that the merchant operates under for this order, such as an LLC, corporation, or partnership.
    /// Used for tax reporting, legal compliance, and determining which business entity is responsible for the order.
    /// </summary>
    [JsonPropertyName("merchantBusinessEntity")]
    public BusinessEntity? merchantBusinessEntity { get; set; } = null;

    /// <summary>
    /// Whether the order can be edited by the merchant. Returns `false` for orders
    /// that can't be modified, such as canceled orders or orders with specific
    /// payment statuses.
    /// </summary>
    [JsonPropertyName("merchantEditable")]
    public bool? merchantEditable { get; set; } = null;

    /// <summary>
    /// A list of reasons why the order can't be edited. For example, canceled orders can't be edited.
    /// </summary>
    [JsonPropertyName("merchantEditableErrors")]
    public ICollection<string>? merchantEditableErrors { get; set; } = null;

    /// <summary>
    /// The application acting as the Merchant of Record for the order. The Merchant
    /// of Record is responsible for tax collection and remittance.
    /// </summary>
    [JsonPropertyName("merchantOfRecordApp")]
    public OrderApp? merchantOfRecordApp { get; set; } = null;

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
    /// The unique identifier for the order that appears on the order page in the Shopify admin and the **Order status** page.
    /// For example, "#1001", "EN1001", or "1001-A".
    /// This value isn't unique across multiple stores. Use this field to identify
    /// orders in the Shopify admin and for order tracking.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The net payment for the order, based on the total amount received minus the total amount refunded, in shop currency.
    /// </summary>
    [JsonPropertyName("netPayment")]
    [Obsolete("Use `netPaymentSet` instead.")]
    public decimal? netPayment { get; set; } = null;

    /// <summary>
    /// The net payment for the order, based on the total amount received minus the
    /// total amount refunded, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("netPaymentSet")]
    public MoneyBag? netPaymentSet { get; set; } = null;

    /// <summary>
    /// A list of line items that can't be fulfilled.
    /// For example, tips and fully refunded line items can't be fulfilled.
    /// For a more granular view of the fulfillment status, refer to the [FulfillmentOrder](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrder) object.
    /// </summary>
    [JsonPropertyName("nonFulfillableLineItems")]
    public LineItemConnection? nonFulfillableLineItems { get; set; } = null;

    /// <summary>
    /// The note associated with the order.
    /// Contains additional information or instructions added by merchants or customers during the order process.
    /// Commonly used for special delivery instructions, gift messages, or internal processing notes.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The order number used to generate the name using the store's configured order
    /// number prefix/suffix. This number isn't guaranteed to follow a consecutive
    /// integer sequence (e.g. 1, 2, 3..), nor is it guaranteed to be unique across
    /// multiple stores, or even for a single store.
    /// </summary>
    [JsonPropertyName("number")]
    public int? number { get; set; } = null;

    /// <summary>
    /// The total amount of all additional fees, such as import fees or taxes, that were applied when an order was created.
    /// Returns `null` if additional fees aren't applicable.
    /// </summary>
    [JsonPropertyName("originalTotalAdditionalFeesSet")]
    public MoneyBag? originalTotalAdditionalFeesSet { get; set; } = null;

    /// <summary>
    /// The total amount of duties calculated when an order was created, before any
    /// modifications. Modifications include returns, refunds, order edits, and
    /// cancellations. Use [`currentTotalDutiesSet`](https://shopify.dev/docs/api/admin-graphql/latest/objects/order#field-Order.fields.currentTotalDutiesSet)
    /// to retrieve the current duties amount after adjustments.
    /// </summary>
    [JsonPropertyName("originalTotalDutiesSet")]
    public MoneyBag? originalTotalDutiesSet { get; set; } = null;

    /// <summary>
    /// The total price of the order at the time of order creation, in shop and presentment currencies.
    /// Use this to compare the original order value against the current total after edits, returns, or refunds.
    /// </summary>
    [JsonPropertyName("originalTotalPriceSet")]
    public MoneyBag? originalTotalPriceSet { get; set; } = null;

    /// <summary>
    /// The payment collection details for the order, including payment status, outstanding amounts, and collection information.
    /// Use this to understand when and how payments should be collected, especially
    /// for orders with deferred or installment payment terms.
    /// </summary>
    [JsonPropertyName("paymentCollectionDetails")]
    public OrderPaymentCollectionDetails? paymentCollectionDetails { get; set; } = null;

    /// <summary>
    /// A list of the names of all payment gateways used for the order.
    /// For example, "Shopify Payments" and "Cash on Delivery (COD)".
    /// </summary>
    [JsonPropertyName("paymentGatewayNames")]
    public ICollection<string>? paymentGatewayNames { get; set; } = null;

    /// <summary>
    /// The payment terms associated with the order, such as net payment due dates or
    /// early payment discounts. Payment terms define when and how an order should be
    /// paid. Returns `null` if no specific payment terms were set for the order.
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public PaymentTerms? paymentTerms { get; set; } = null;

    /// <summary>
    /// The phone number associated with the customer for this order.
    /// Useful for contacting customers about shipping updates, delivery notifications, or order issues.
    /// Returns `null` if no phone number was provided during checkout.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The fulfillment location that was assigned when the order was created.
    /// Orders can have multiple fulfillment orders. These fulfillment orders can each
    /// be assigned to a different location which is responsible for fulfilling a
    /// subset of the items in an order. The `Order.physicalLocation` field will only
    /// point to one of these locations.
    /// Use the [`FulfillmentOrder`](https://shopify.dev/api/admin-graphql/latest/objects/fulfillmentorder)
    /// object for up to date fulfillment location information.
    /// </summary>
    [JsonPropertyName("physicalLocation")]
    [Obsolete("Use `fulfillmentOrders` to get the fulfillment location for the order")]
    public Location? physicalLocation { get; set; } = null;

    /// <summary>
    /// The purchase order (PO) number that's associated with an order.
    /// This is typically provided by business customers who require a PO number for their procurement.
    /// </summary>
    [JsonPropertyName("poNumber")]
    public string? poNumber { get; set; } = null;

    /// <summary>
    /// The currency used by the customer when placing the order. For example, "USD", "EUR", or "CAD".
    /// This may differ from the shop's base currency when serving international customers or using multi-currency pricing.
    /// </summary>
    [JsonPropertyName("presentmentCurrencyCode")]
    public CurrencyCode? presentmentCurrencyCode { get; set; } = null;

    /// <summary>
    /// The date and time in [ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601) when the order was processed.
    /// This date and time might not match the date and time when the order was created.
    /// </summary>
    [JsonPropertyName("processedAt")]
    public DateTimeOffset? processedAt { get; set; } = null;

    /// <summary>
    /// Whether the customer also purchased items from other stores in the network.
    /// </summary>
    [JsonPropertyName("productNetwork")]
    public bool? productNetwork { get; set; } = null;

    /// <summary>
    /// The sales channel that the order was created from, such as the [Online
    /// Store](https://shopify.dev/docs/apps/build/app-surfaces#online-store) or
    /// [Shopify POS](https://shopify.dev/docs/apps/build/app-surfaces#point-of-sale).
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// The business entity that placed the order, including company details and purchasing relationships.
    /// Used for B2B transactions to track which company or organization is responsible for the purchase and payment terms.
    /// </summary>
    [JsonPropertyName("purchasingEntity")]
    public PurchasingEntity? purchasingEntity { get; set; } = null;

    /// <summary>
    /// The marketing referral code from the link that the customer clicked to visit the store.
    /// Supports the following URL attributes: "ref", "source", or "r".
    /// For example, if the URL is `{shop}.myshopify.com/products/slide?ref=j2tj1tn2`, then this value is `j2tj1tn2`.
    /// </summary>
    [JsonPropertyName("referralCode")]
    [Obsolete("Use `customerJourneySummary.lastVisit.referralCode` instead")]
    public string? referralCode { get; set; } = null;

    /// <summary>
    /// A web domain or short description of the source that sent the customer to your
    /// online store. For example, "shopify.com" or "email".
    /// </summary>
    [JsonPropertyName("referrerDisplayText")]
    [Obsolete("Use `customerJourneySummary.lastVisit.referralInfoHtml` instead")]
    public string? referrerDisplayText { get; set; } = null;

    /// <summary>
    /// The URL of the webpage where the customer clicked a link that sent them to your online store.
    /// </summary>
    [JsonPropertyName("referrerUrl")]
    [Obsolete("Use `customerJourneySummary.lastVisit.referrerUrl` instead")]
    public string? referrerUrl { get; set; } = null;

    /// <summary>
    /// Whether the order can be refunded based on its payment transactions.
    /// Returns `false` for orders with no eligible payment transactions, such as
    /// fully refunded orders or orders with non-refundable payment methods.
    /// </summary>
    [JsonPropertyName("refundable")]
    public bool? refundable { get; set; } = null;

    /// <summary>
    /// The difference between the suggested and actual refund amount of all refunds that have been applied to the order.
    /// A positive value indicates a difference in the merchant's favor, and a
    /// negative value indicates a difference in the customer's favor.
    /// </summary>
    [JsonPropertyName("refundDiscrepancySet")]
    public MoneyBag? refundDiscrepancySet { get; set; } = null;

    /// <summary>
    /// A list of refunds that have been applied to the order.
    /// Refunds represent money returned to customers for returned items, cancellations, or adjustments.
    /// </summary>
    [JsonPropertyName("refunds")]
    public ICollection<Refund>? refunds { get; set; } = null;

    /// <summary>
    /// The URL of the source that the order originated from, if found in the domain
    /// registry. Returns `null` if the source URL isn't in the domain registry.
    /// </summary>
    [JsonPropertyName("registeredSourceUrl")]
    public string? registeredSourceUrl { get; set; } = null;

    /// <summary>
    /// Whether the order requires physical shipping to the customer.
    /// Returns `false` for digital-only orders (such as gift cards or downloadable
    /// products) and `true` for orders with physical products that need delivery.
    /// Use this to determine shipping workflows and logistics requirements.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// Whether any line items on the order can be restocked into inventory.
    /// Returns `false` for digital products, custom items, or items that can't be resold.
    /// </summary>
    [JsonPropertyName("restockable")]
    public bool? restockable { get; set; } = null;

    /// <summary>
    /// The physical location where a retail order is created or completed, except for
    /// draft POS orders completed using the "mark as paid" flow in the Shopify admin,
    /// which return `null`. Transactions associated with the order might have been
    /// processed at a different location.
    /// </summary>
    [JsonPropertyName("retailLocation")]
    public Location? retailLocation { get; set; } = null;

    /// <summary>
    /// The returns associated with the order.
    /// Contains information about items that customers have requested to return,
    /// including return reasons, status, and refund details.
    /// Use this to track and manage the return process for order items.
    /// </summary>
    [JsonPropertyName("returns")]
    public ReturnConnection? returns { get; set; } = null;

    /// <summary>
    /// The order's aggregated return status for display purposes.
    /// Indicates the overall state of returns for the order, helping merchants track and manage the return process.
    /// </summary>
    [JsonPropertyName("returnStatus")]
    public OrderReturnStatus? returnStatus { get; set; } = null;

    /// <summary>
    /// The risk assessment summary for the order.
    /// Provides fraud analysis and risk scoring to help you identify potentially fraudulent orders.
    /// Use this to make informed decisions about order fulfillment and payment processing.
    /// </summary>
    [JsonPropertyName("risk")]
    public OrderRiskSummary? risk { get; set; } = null;

    /// <summary>
    /// The fraud risk level of the order.
    /// </summary>
    [JsonPropertyName("riskLevel")]
    [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
    public OrderRiskLevel? riskLevel { get; set; } = null;

    /// <summary>
    /// A list of risks associated with the order.
    /// </summary>
    [JsonPropertyName("risks")]
    [Obsolete("This field is deprecated in favor of OrderRiskAssessment, which provides enhanced capabilities such as distinguishing risks from their provider.")]
    public ICollection<OrderRisk>? risks { get; set; } = null;

    /// <summary>
    /// The shipping address where the order will be delivered.
    /// Contains the customer's delivery location for fulfillment and shipping label generation.
    /// Returns `null` for digital orders or orders that don't require shipping.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public MailingAddress? shippingAddress { get; set; } = null;

    /// <summary>
    /// A summary of all shipping costs on the order.
    /// Aggregates shipping charges, discounts, and taxes to provide a single view of delivery costs.
    /// </summary>
    [JsonPropertyName("shippingLine")]
    public ShippingLine? shippingLine { get; set; } = null;

    /// <summary>
    /// The shipping methods applied to the order.
    /// Each shipping line represents a shipping option chosen during checkout, including the carrier, service level, and cost.
    /// Use this to understand shipping charges and delivery options for the order.
    /// </summary>
    [JsonPropertyName("shippingLines")]
    public ShippingLineConnection? shippingLines { get; set; } = null;

    /// <summary>
    /// The Shopify Protect details for the order, including fraud protection status and coverage information.
    /// Shopify Protect helps protect eligible orders against fraudulent chargebacks.
    /// Returns `null` if Shopify Protect is disabled for the shop or the order isn't eligible for protection.
    /// Learn more about [Shopify Protect](https://www.shopify.com/protect).
    /// </summary>
    [JsonPropertyName("shopifyProtect")]
    public ShopifyProtectOrderSummary? shopifyProtect { get; set; } = null;

    /// <summary>
    /// A unique POS or third party order identifier.
    /// For example, "1234-12-1000" or "111-98567-54". The [`receiptNumber`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order#field-receiptNumber)
    /// field is derived from this value for POS orders.
    /// </summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? sourceIdentifier { get; set; } = null;

    /// <summary>
    /// The name of the source associated with the order, such as "web", "mobile_app",
    /// or "pos". Use this field to identify the platform where the order was placed.
    /// </summary>
    [JsonPropertyName("sourceName")]
    public string? sourceName { get; set; } = null;

    /// <summary>
    /// The staff member who created or is responsible for the order.
    /// Useful for tracking which team member handled phone orders, manual orders, or order modifications.
    /// Returns `null` for orders created directly by customers through the online store.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// The URL where customers can check their order's current status, including tracking information and delivery updates.
    /// Provides order tracking links in emails, apps, or customer communications.
    /// </summary>
    [JsonPropertyName("statusPageUrl")]
    public string? statusPageUrl { get; set; } = null;

    /// <summary>
    /// The sum of quantities for all line items that contribute to the order's subtotal price.
    /// This excludes quantities for items like tips, shipping costs, or gift cards that don't affect the subtotal.
    /// Use this to quickly understand the total item count for pricing calculations.
    /// </summary>
    [JsonPropertyName("subtotalLineItemsQuantity")]
    public int? subtotalLineItemsQuantity { get; set; } = null;

    /// <summary>
    /// The sum of the prices for all line items after discounts and before returns, in shop currency.
    /// If `taxesIncluded` is `true`, then the subtotal also includes tax.
    /// </summary>
    [JsonPropertyName("subtotalPrice")]
    [Obsolete("Use `subtotalPriceSet` instead.")]
    public decimal? subtotalPrice { get; set; } = null;

    /// <summary>
    /// The sum of the prices for all line items after discounts and before returns, in shop and presentment currencies.
    /// If `taxesIncluded` is `true`, then the subtotal also includes tax.
    /// </summary>
    [JsonPropertyName("subtotalPriceSet")]
    public MoneyBag? subtotalPriceSet { get; set; } = null;

    /// <summary>
    /// A calculated refund suggestion for the order based on specified line items, shipping, and duties.
    /// Use this to preview refund amounts, taxes, and processing fees before creating an actual refund.
    /// </summary>
    [JsonPropertyName("suggestedRefund")]
    public SuggestedRefund? suggestedRefund { get; set; } = null;

    /// <summary>
    /// A comma separated list of tags associated with the order. Updating `tags` overwrites
    /// any existing tags that were previously added to the order. To add new tags without overwriting
    /// existing tags, use the [tagsAdd](https://shopify.dev/api/admin-graphql/latest/mutations/tagsadd)
    /// mutation.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// Whether taxes are included in the subtotal price of the order.
    /// When `true`, the subtotal and line item prices include tax amounts. When
    /// `false`, taxes are calculated and displayed separately.
    /// </summary>
    [JsonPropertyName("taxesIncluded")]
    public bool? taxesIncluded { get; set; } = null;

    /// <summary>
    /// Whether taxes are exempt on the order.
    /// Returns `true` for orders where the customer or business has a valid tax
    /// exemption, such as non-profit organizations or tax-free purchases.
    /// Use this to understand if tax calculations were skipped during checkout.
    /// </summary>
    [JsonPropertyName("taxExempt")]
    public bool? taxExempt { get; set; } = null;

    /// <summary>
    /// A list of all tax lines applied to line items on the order, before returns.
    /// Tax line prices represent the total price for all tax lines with the same `rate` and `title`.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// Whether the order is a test.
    /// Test orders are made using the Shopify Bogus Gateway or a payment provider with test mode enabled.
    /// A test order can't be converted into a real order and vice versa.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;

    /// <summary>
    /// The authorized amount that's uncaptured or undercaptured, in shop currency.
    /// This amount isn't adjusted for returns.
    /// </summary>
    [JsonPropertyName("totalCapturable")]
    [Obsolete("Use `totalCapturableSet` instead.")]
    public decimal? totalCapturable { get; set; } = null;

    /// <summary>
    /// The authorized amount that's uncaptured or undercaptured, in shop and presentment currencies.
    /// This amount isn't adjusted for returns.
    /// </summary>
    [JsonPropertyName("totalCapturableSet")]
    public MoneyBag? totalCapturableSet { get; set; } = null;

    /// <summary>
    /// The total rounding adjustment applied to payments or refunds for an order
    /// involving cash payments. Applies to some countries where cash transactions are
    /// rounded to the nearest currency denomination.
    /// </summary>
    [JsonPropertyName("totalCashRoundingAdjustment")]
    public CashRoundingAdjustment? totalCashRoundingAdjustment { get; set; } = null;

    /// <summary>
    /// The total amount discounted on the order before returns, in shop currency.
    /// This includes both order and line level discounts.
    /// </summary>
    [JsonPropertyName("totalDiscounts")]
    [Obsolete("Use `totalDiscountsSet` instead.")]
    public decimal? totalDiscounts { get; set; } = null;

    /// <summary>
    /// The total amount discounted on the order before returns, in shop and presentment currencies.
    /// This includes both order and line level discounts.
    /// </summary>
    [JsonPropertyName("totalDiscountsSet")]
    public MoneyBag? totalDiscountsSet { get; set; } = null;

    /// <summary>
    /// The total amount not yet transacted for the order, in shop and presentment currencies.
    /// A positive value indicates a difference in the merchant's favor (payment from
    /// customer to merchant) and a negative value indicates a difference in the
    /// customer's favor (refund from merchant to customer).
    /// </summary>
    [JsonPropertyName("totalOutstandingSet")]
    public MoneyBag? totalOutstandingSet { get; set; } = null;

    /// <summary>
    /// The total price of the order, before returns, in shop currency.
    /// This includes taxes and discounts.
    /// </summary>
    [JsonPropertyName("totalPrice")]
    [Obsolete("Use `totalPriceSet` instead.")]
    public decimal? totalPrice { get; set; } = null;

    /// <summary>
    /// The total price of the order, before returns, in shop and presentment currencies.
    /// This includes taxes and discounts.
    /// </summary>
    [JsonPropertyName("totalPriceSet")]
    public MoneyBag? totalPriceSet { get; set; } = null;

    /// <summary>
    /// The total amount received from the customer before returns, in shop currency.
    /// </summary>
    [JsonPropertyName("totalReceived")]
    [Obsolete("Use `totalReceivedSet` instead.")]
    public decimal? totalReceived { get; set; } = null;

    /// <summary>
    /// The total amount received from the customer before returns, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalReceivedSet")]
    public MoneyBag? totalReceivedSet { get; set; } = null;

    /// <summary>
    /// The total amount that was refunded, in shop currency.
    /// </summary>
    [JsonPropertyName("totalRefunded")]
    [Obsolete("Use `totalRefundedSet` instead.")]
    public decimal? totalRefunded { get; set; } = null;

    /// <summary>
    /// The total amount that was refunded, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalRefundedSet")]
    public MoneyBag? totalRefundedSet { get; set; } = null;

    /// <summary>
    /// The total amount of shipping that was refunded, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalRefundedShippingSet")]
    public MoneyBag? totalRefundedShippingSet { get; set; } = null;

    /// <summary>
    /// The total shipping amount before discounts and returns, in shop currency.
    /// </summary>
    [JsonPropertyName("totalShippingPrice")]
    [Obsolete("Use `totalShippingPriceSet` instead.")]
    public decimal? totalShippingPrice { get; set; } = null;

    /// <summary>
    /// The total shipping costs returned to the customer, in shop and presentment
    /// currencies. This includes fees and any related discounts that were refunded.
    /// </summary>
    [JsonPropertyName("totalShippingPriceSet")]
    public MoneyBag? totalShippingPriceSet { get; set; } = null;

    /// <summary>
    /// The total tax amount before returns, in shop currency.
    /// </summary>
    [JsonPropertyName("totalTax")]
    [Obsolete("Use `totalTaxSet` instead.")]
    public decimal? totalTax { get; set; } = null;

    /// <summary>
    /// The total tax amount before returns, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalTaxSet")]
    public MoneyBag? totalTaxSet { get; set; } = null;

    /// <summary>
    /// The sum of all tip amounts for the order, in shop currency.
    /// </summary>
    [JsonPropertyName("totalTipReceived")]
    [Obsolete("Use `totalTipReceivedSet` instead.")]
    public MoneyV2? totalTipReceived { get; set; } = null;

    /// <summary>
    /// The sum of all tip amounts for the order, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalTipReceivedSet")]
    public MoneyBag? totalTipReceivedSet { get; set; } = null;

    /// <summary>
    /// The total weight of the order before returns, in grams.
    /// </summary>
    [JsonPropertyName("totalWeight")]
    public ulong? totalWeight { get; set; } = null;

    /// <summary>
    /// A list of transactions associated with the order.
    /// </summary>
    [JsonPropertyName("transactions")]
    public ICollection<OrderTransaction>? transactions { get; set; } = null;

    /// <summary>
    /// The number of transactions associated with the order.
    /// </summary>
    [JsonPropertyName("transactionsCount")]
    public Count? transactionsCount { get; set; } = null;

    /// <summary>
    /// Whether no payments have been made for the order.
    /// </summary>
    [JsonPropertyName("unpaid")]
    public bool? unpaid { get; set; } = null;

    /// <summary>
    /// The date and time in [ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601) when the order was last modified.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}