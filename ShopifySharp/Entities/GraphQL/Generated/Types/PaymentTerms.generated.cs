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
/// Payment conditions for an
/// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order) or [`DraftOrder`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrder),
/// including when payment is due and how it's scheduled. Payment terms are created
/// from templates that specify net terms (payment due after a certain number of
/// days) or fixed schedules with specific due dates. You can optionally provide
/// custom payment schedules using [`PaymentScheduleInput`](https://shopify.dev/docs/api/admin-graphql/latest/input-objects/PaymentScheduleInput).
/// Each payment term contains one or more [`PaymentSchedule`](https://shopify.dev/docs/api/admin-graphql/latest/objects/PaymentSchedule),
/// which you can access through the [`paymentSchedules`](https://shopify.dev/docs/api/admin-graphql/latest/objects/PaymentTerms#field-PaymentTerms.fields.paymentSchedules)
/// field. Payment schedules contain detailed information for each payment installment.
/// Learn more about [payment terms](https://shopify.dev/docs/apps/build/checkout/payments/payment-terms).
/// </summary>
public record PaymentTerms : IGraphQLObject, INode
{
    /// <summary>
    /// The draft order associated with the payment terms.
    /// </summary>
    [JsonPropertyName("draftOrder")]
    public DraftOrder? draftOrder { get; set; } = null;

    /// <summary>
    /// Whether payment terms have a payment schedule that's due.
    /// </summary>
    [JsonPropertyName("due")]
    public bool? due { get; set; } = null;

    /// <summary>
    /// Duration of payment terms in days based on the payment terms template used to create the payment terms.
    /// </summary>
    [JsonPropertyName("dueInDays")]
    public int? dueInDays { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The order associated with the payment terms.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// Whether the payment terms have overdue payment schedules.
    /// </summary>
    [JsonPropertyName("overdue")]
    public bool? overdue { get; set; } = null;

    /// <summary>
    /// List of schedules for the payment terms.
    /// </summary>
    [JsonPropertyName("paymentSchedules")]
    public PaymentScheduleConnection? paymentSchedules { get; set; } = null;

    /// <summary>
    /// The name of the payment terms template used to create the payment terms.
    /// </summary>
    [JsonPropertyName("paymentTermsName")]
    public string? paymentTermsName { get; set; } = null;

    /// <summary>
    /// The payment terms template type used to create the payment terms.
    /// </summary>
    [JsonPropertyName("paymentTermsType")]
    public PaymentTermsType? paymentTermsType { get; set; } = null;

    /// <summary>
    /// The payment terms name, translated into the shop admin's preferred language.
    /// </summary>
    [JsonPropertyName("translatedName")]
    public string? translatedName { get; set; } = null;
}