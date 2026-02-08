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
/// How a product can be sold and purchased through recurring billing or deferred
/// purchase options. Defines the specific terms for subscriptions, pre-orders, or
/// try-before-you-buy offers, including when to bill customers, when to fulfill
/// orders, and what pricing adjustments to apply.
/// Each selling plan has billing, delivery, and pricing policies that control the
/// purchase experience. The plan's [`options`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SellingPlan#field-SellingPlan.fields.options) and [`category`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SellingPlan#field-SellingPlan.fields.category)
/// help merchants organize and report on different selling strategies. Plans are
/// grouped within a [`SellingPlanGroup`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SellingPlanGroup)
/// that associates them with
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) and [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant) objects.
/// > Caution:
/// > Selling plans and associated records are automatically deleted 48 hours after
/// a merchant uninstalls the
/// [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) that
/// created them. Back up these records if you need to restore them later.
/// Learn more about [selling plans](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/selling-plans/build-a-selling-plan).
/// </summary>
public record SellingPlan : IGraphQLObject, IHasMetafieldDefinitions, IHasMetafields, IHasPublishedTranslations, INode
{
    /// <summary>
    /// A selling plan policy which describes the recurring billing details.
    /// </summary>
    [JsonPropertyName("billingPolicy")]
    public SellingPlanBillingPolicy? billingPolicy { get; set; } = null;

    /// <summary>
    /// The category used to classify the selling plan for reporting purposes.
    /// </summary>
    [JsonPropertyName("category")]
    public SellingPlanCategory? category { get; set; } = null;

    /// <summary>
    /// The date and time when the selling plan was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// A selling plan policy which describes the delivery details.
    /// </summary>
    [JsonPropertyName("deliveryPolicy")]
    public SellingPlanDeliveryPolicy? deliveryPolicy { get; set; } = null;

    /// <summary>
    /// Buyer facing string which describes the selling plan commitment.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// When to reserve inventory for a selling plan.
    /// </summary>
    [JsonPropertyName("inventoryPolicy")]
    public SellingPlanInventoryPolicy? inventoryPolicy { get; set; } = null;

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
    /// A customer-facing description of the selling plan.
    /// If your store supports multiple currencies, then don't include
    /// country-specific pricing content, such as "Buy monthly, get 10$ CAD off". This
    /// field won't be converted to reflect different currencies.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The values of all options available on the selling plan. Selling plans are
    /// grouped together in Liquid when they're created by the same app, and have the
    /// same `selling_plan_group.name` and `selling_plan_group.options` values.
    /// </summary>
    [JsonPropertyName("options")]
    public ICollection<string>? options { get; set; } = null;

    /// <summary>
    /// Relative position of the selling plan for display. A lower position will be displayed before a higher position.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// Selling plan pricing details.
    /// </summary>
    [JsonPropertyName("pricingPolicies")]
    public ICollection<SellingPlanPricingPolicy>? pricingPolicies { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;
}