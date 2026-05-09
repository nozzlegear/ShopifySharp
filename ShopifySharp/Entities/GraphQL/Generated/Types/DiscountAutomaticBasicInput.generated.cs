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
/// The input fields for creating or updating an
/// [amount off discount](https://help.shopify.com/manual/discounts/discount-types/percentage-fixed-amount)
/// that's automatically applied on a cart and at checkout.
/// During creation the required fields are:
///   - `customerGets`
///   - `startsAt`
///   - `title`
/// </summary>
public record DiscountAutomaticBasicInput : GraphQLInputObject<DiscountAutomaticBasicInput>
{
    /// <summary>
    /// The
    /// [discount classes](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that you can use in combination with
    /// [Shopify discount types](https://help.shopify.com/manual/discounts/discount-types),
    /// and the product discount tags that determine which product discounts can apply
    /// together on the same cart line.
    /// </summary>
    [JsonPropertyName("combinesWith")]
    public DiscountCombinesWithInput? combinesWith { get; set; } = null;

    /// <summary>
    /// The context defining which buyers can use the discount.
    /// You can target specific customer IDs, customer segments, or make the discount available to all buyers.
    /// Discounts automatically apply on Point of Sale (POS) for Pro locations when the context is not set to ALL.
    /// </summary>
    [JsonPropertyName("context")]
    public DiscountContextInput? context { get; set; } = null;

    /// <summary>
    /// Information about the qualifying items and their discount.
    /// </summary>
    [JsonPropertyName("customerGets")]
    public DiscountCustomerGetsInput? customerGets { get; set; } = null;

    /// <summary>
    /// The date and time when the discount expires and is no longer available to customers.
    /// For discounts without a fixed expiration date, specify `null`.
    /// </summary>
    [JsonPropertyName("endsAt")]
    public DateTimeOffset? endsAt { get; set; } = null;

    /// <summary>
    /// The minimum subtotal or quantity of items that are required for the discount to be applied.
    /// </summary>
    [JsonPropertyName("minimumRequirement")]
    public DiscountMinimumRequirementInput? minimumRequirement { get; set; } = null;

    /// <summary>
    /// The number of billing cycles for which the discount can be applied,
    /// which is useful for subscription-based discounts. For example, if you set this field
    /// to `3`, then the discount only applies to the first three billing cycles of a
    /// subscription. If you specify `0`, then the discount applies indefinitely.
    /// </summary>
    [JsonPropertyName("recurringCycleLimit")]
    public int? recurringCycleLimit { get; set; } = null;

    /// <summary>
    /// The date and time when the discount becomes active and is available to customers.
    /// </summary>
    [JsonPropertyName("startsAt")]
    public DateTimeOffset? startsAt { get; set; } = null;

    /// <summary>
    /// A list of searchable keywords that are associated with the discount.
    /// For example, a `loyalty` tag could be applied to discounts
    /// that are associated with a loyalty program.
    /// Updating `tags` overwrites any existing tags that were previously added to the discount.
    /// To add new tags without overwriting existing tags, use the
    /// [`tagsAdd`](https://shopify.dev/api/admin-graphql/latest/mutations/tagsadd)
    /// mutation.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// The discount's name that displays to merchants in the Shopify admin and to customers.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}