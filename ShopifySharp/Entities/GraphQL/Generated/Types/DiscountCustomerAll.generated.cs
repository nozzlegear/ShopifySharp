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
/// Creates the broadest possible discount reach by targeting all customers,
/// regardless of their purchase history or segment membership. This gives merchants
/// maximum flexibility to run store-wide promotions without worrying about customer
/// eligibility restrictions.
/// For example, a flash sale or grand opening promotion would target all customers
/// to maximize participation and store visibility.
/// Learn more about [customer targeting](https://help.shopify.com/manual/discounts/).
/// </summary>
public record DiscountCustomerAll : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Whether the discount can be applied by all customers. This value is always `true`.
    /// </summary>
    [JsonPropertyName("allCustomers")]
    public bool? allCustomers { get; set; } = null;
}