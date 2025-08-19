#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record PurchasingEntityCustomer(Customer Value): PurchasingEntity;
internal record PurchasingEntityPurchasingCompany(PurchasingCompany Value): PurchasingEntity;
#endif /// <summary>

/// The input fields for a purchasing entity. Can either be a customer or a purchasing company.
/// </summary>
public record PurchasingEntityInput : GraphQLInputObject<PurchasingEntityInput>
{
    /// <summary>
    /// Represents a customer. Null if there's a purchasing company.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// Represents a purchasing company. Null if there's a customer.
    /// </summary>
    [JsonPropertyName("purchasingCompany")]
    public PurchasingCompanyInput? purchasingCompany { get; set; } = null;
}