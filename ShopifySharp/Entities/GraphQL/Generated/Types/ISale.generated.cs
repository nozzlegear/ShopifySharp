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
/// An individual sale record associated with a sales agreement. Every money value
/// in an order's sales data is represented in the currency's smallest unit. When
/// amounts are divided across multiple line items, such as taxes or order
/// discounts, the amounts might not divide evenly across all of the line items on
/// the order. To address this, the remaining currency units that couldn't be
/// divided evenly are allocated one at a time, starting with the first line item,
/// until they are all accounted for. In aggregate, the values sum up correctly. In
/// isolation, one line item might have a different tax or discount amount than
/// another line item of the same price, before taxes and discounts. This is because
/// the amount could not be divided evenly across the items. The allocation of
/// currency units across line items is immutable. After they are allocated,
/// currency units are never reallocated or redistributed among the line items.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AdditionalFeeSale), typeDiscriminator: "AdditionalFeeSale")]
[JsonDerivedType(typeof(AdjustmentSale), typeDiscriminator: "AdjustmentSale")]
[JsonDerivedType(typeof(DutySale), typeDiscriminator: "DutySale")]
[JsonDerivedType(typeof(FeeSale), typeDiscriminator: "FeeSale")]
[JsonDerivedType(typeof(GiftCardSale), typeDiscriminator: "GiftCardSale")]
[JsonDerivedType(typeof(ProductSale), typeDiscriminator: "ProductSale")]
[JsonDerivedType(typeof(ShippingLineSale), typeDiscriminator: "ShippingLineSale")]
[JsonDerivedType(typeof(TipSale), typeDiscriminator: "TipSale")]
[JsonDerivedType(typeof(UnknownSale), typeDiscriminator: "UnknownSale")]
public interface ISale : IGraphQLObject
{
    /// <summary>
    /// The type of order action that the sale represents.
    /// </summary>
    [JsonPropertyName("actionType")]
    public SaleActionType? actionType { get; set; }

    /// <summary>
    /// The unique ID for the sale.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The line type assocated with the sale.
    /// </summary>
    [JsonPropertyName("lineType")]
    public SaleLineType? lineType { get; set; }

    /// <summary>
    /// The number of units either ordered or intended to be returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; }

    /// <summary>
    /// All individual taxes associated with the sale.
    /// </summary>
    [JsonPropertyName("taxes")]
    public ICollection<SaleTax>? taxes { get; set; }

    /// <summary>
    /// The total sale amount after taxes and discounts.
    /// </summary>
    [JsonPropertyName("totalAmount")]
    public MoneyBag? totalAmount { get; set; }

    /// <summary>
    /// The total discounts allocated to the sale after taxes.
    /// </summary>
    [JsonPropertyName("totalDiscountAmountAfterTaxes")]
    public MoneyBag? totalDiscountAmountAfterTaxes { get; set; }

    /// <summary>
    /// The total discounts allocated to the sale before taxes.
    /// </summary>
    [JsonPropertyName("totalDiscountAmountBeforeTaxes")]
    public MoneyBag? totalDiscountAmountBeforeTaxes { get; set; }

    /// <summary>
    /// The total amount of taxes for the sale.
    /// </summary>
    [JsonPropertyName("totalTaxAmount")]
    public MoneyBag? totalTaxAmount { get; set; }
}