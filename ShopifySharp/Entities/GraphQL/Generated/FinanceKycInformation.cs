#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Shopify Payments account information shared with embedded finance applications.
/// </summary>
public record FinanceKycInformation : IGraphQLObject
{
    /// <summary>
    /// The legal entity business address.
    /// </summary>
    [JsonPropertyName("businessAddress")]
    public ShopifyPaymentsAddressBasic? businessAddress { get; set; } = null;

    /// <summary>
    /// The legal entity business type.
    /// </summary>
    [JsonPropertyName("businessType")]
    public ShopifyPaymentsBusinessType? businessType { get; set; } = null;

    /// <summary>
    /// Business industry.
    /// </summary>
    [JsonPropertyName("industry")]
    public ShopifyPaymentsMerchantCategoryCode? industry { get; set; } = null;

    /// <summary>
    /// Returns the business legal name.
    /// </summary>
    [JsonPropertyName("legalName")]
    public string? legalName { get; set; } = null;

    /// <summary>
    /// The shop owner information for financial KYC purposes.
    /// </summary>
    [JsonPropertyName("shopOwner")]
    public FinancialKycShopOwner? shopOwner { get; set; } = null;

    /// <summary>
    /// Tax identification information.
    /// </summary>
    [JsonPropertyName("taxIdentification")]
    public ShopifyPaymentsTaxIdentification? taxIdentification { get; set; } = null;
}