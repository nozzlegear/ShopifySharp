using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp;

public class ShippingLine : ShopifyObject
{
    /// <summary>
    /// The carrier provided identifier.
    /// </summary>
    [JsonProperty("carrier_identifier")]
    public string CarrierIdentifier { get; set; }

    /// <summary>
    /// A reference to the shipping method.
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Whether the shipping line has been removed from the order.
    /// </summary>
    [JsonProperty("is_removed")]
    public bool? IsRemoved { get; set; }

    /// <summary>
    /// The phone number used for the shipment.
    /// </summary>
    [JsonProperty("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The price of this shipping method.
    /// </summary>
    [JsonProperty("price")]
    public decimal? Price { get; set; }

    /// <summary>
    /// The discounted price of this shipping method.
    /// </summary>
    [JsonProperty("discounted_price")]
    public decimal? DiscountedPrice { get; set; }

    /// <summary>
    /// An ordered list of amounts allocated by discount applications. Each discount allocation is associated to a particular discount application.
    /// </summary>
    [JsonProperty("discount_allocations")]
    public IEnumerable<DiscountAllocation> DiscountAllocations { get; set; }

    /// <summary>
    /// The source of the shipping method.
    /// </summary>
    [JsonProperty("source")]
    public string Source { get; set; }

    /// <summary>
    /// The title of the shipping method.
    /// </summary>
    [JsonProperty("title")]
    public string Title { get; set; }

    /// <summary>
    /// A list of <see cref="TaxLine"/> objects, each of which details the taxes applicable to this <see cref="ShippingLine"/>.
    /// </summary>
    [JsonProperty("tax_lines")]
    public IEnumerable<TaxLine> TaxLines { get; set; }

    /// <summary>
    /// The price of the shipping method in shop and presentment currencies.
    /// </summary>
    [JsonProperty("price_set")]
    public PriceSet PriceSet { get; set; }

    /// <summary>
    /// The price of the shipping method in both shop and presentment currencies after line-level discounts have been applied.
    /// </summary>
    [JsonProperty("discounted_price_set")]
    public PriceSet DiscountedPriceSet { get; set; }
}