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
/// Represents the tracking information for a fulfillment.
/// </summary>
public record FulfillmentTrackingInfo : IGraphQLObject
{
    /// <summary>
    /// The name of the tracking company.
    /// For tracking company names from the list below
    /// Shopify will automatically build tracking URLs for all provided tracking numbers,
    /// which will make the tracking numbers clickable in the interface.
    /// Additionally, for the tracking companies listed on the
    /// [Shipping Carriers help page](https://help.shopify.com/manual/shipping/understanding-shipping/shipping-carriers#integrated-shipping-carriers)
    /// Shopify will automatically update the fulfillment's `shipment_status` field during the fulfillment process.
    /// ### Supported tracking companies
    /// The following tracking companies display for shops located in any country:
    ///   * 4PX
    ///   * AGS
    ///   * Amazon
    ///   * Amazon Logistics UK
    ///   * An Post
    ///   * Anjun Logistics
    ///   * APC
    ///   * Asendia USA
    ///   * Australia Post
    ///   * Bonshaw
    ///   * BPost
    ///   * BPost International
    ///   * Canada Post
    ///   * Canpar
    ///   * CDL Last Mile
    ///   * China Post
    ///   * Chronopost
    ///   * Chukou1
    ///   * Colissimo
    ///   * Comingle
    ///   * Coordinadora
    ///   * Correios
    ///   * Correos
    ///   * CTT
    ///   * CTT Express
    ///   * Cyprus Post
    ///   * Delnext
    ///   * Deutsche Post
    ///   * DHL eCommerce
    ///   * DHL eCommerce Asia
    ///   * DHL Express
    ///   * DPD
    ///   * DPD Local
    ///   * DPD UK
    ///   * DTD Express
    ///   * DX
    ///   * Eagle
    ///   * Estes
    ///   * Evri
    ///   * FedEx
    ///   * First Global Logistics
    ///   * First Line
    ///   * FSC
    ///   * Fulfilla
    ///   * GLS
    ///   * Guangdong Weisuyi Information Technology (WSE)
    ///   * Heppner Internationale Spedition GmbH & Co.
    ///   * Iceland Post
    ///   * IDEX
    ///   * Israel Post
    ///   * Japan Post (EN)
    ///   * Japan Post (JA)
    ///   * La Poste Colissimo
    ///   * La Poste Burkina Faso
    ///   * Lasership
    ///   * Latvia Post
    ///   * Lietuvos Paštas
    ///   * Logisters
    ///   * Lone Star Overnight
    ///   * M3 Logistics
    ///   * Meteor Space
    ///   * Mondial Relay
    ///   * New Zealand Post
    ///   * NinjaVan
    ///   * North Russia Supply Chain (Shenzhen) Co.
    ///   * OnTrac
    ///   * Packeta
    ///   * Pago Logistics
    ///   * Ping An Da Tengfei Express
    ///   * Pitney Bowes
    ///   * Portal PostNord
    ///   * Poste Italiane
    ///   * PostNL
    ///   * PostNord DK
    ///   * PostNord NO
    ///   * PostNord SE
    ///   * Purolator
    ///   * Qxpress
    ///   * Qyun Express
    ///   * Royal Mail
    ///   * Royal Shipments
    ///   * Sagawa (EN)
    ///   * Sagawa (JA)
    ///   * Sendle
    ///   * SF Express
    ///   * SFC Fulfillment
    ///   * SHREE NANDAN COURIER
    ///   * Singapore Post
    ///   * Southwest Air Cargo
    ///   * StarTrack
    ///   * Step Forward Freight
    ///   * Swiss Post
    ///   * TForce Final Mile
    ///   * Tinghao
    ///   * TNT
    ///   * Toll IPEC
    ///   * United Delivery Service
    ///   * UPS
    ///   * USPS
    ///   * Venipak
    ///   * We Post
    ///   * Whistl
    ///   * Wizmo
    ///   * WMYC
    ///   * Xpedigo
    ///   * XPO Logistics
    ///   * Yamato (EN)
    ///   * Yamato (JA)
    ///   * YiFan Express
    ///   * YunExpress
    /// The following tracking companies are displayed for shops located in specific countries:
    ///   * **Australia**: Australia Post, Sendle, Aramex Australia, TNT Australia,
    /// Hunter Express, Couriers Please, Bonds, Allied Express, Direct Couriers,
    /// Northline, GO Logistics
    ///   * **Austria**: Österreichische Post
    ///   * **Bulgaria**: Speedy
    ///   * **Canada**: Intelcom, BoxKnight, Loomis, GLS
    ///   * **China**: China Post, DHL eCommerce Asia, WanbExpress, YunExpress, Anjun Logistics, SFC Fulfillment, FSC
    ///   * **Czechia**: Zásilkovna
    ///   * **Germany**: Deutsche Post (DE), Deutsche Post (EN), DHL, DHL Express, Swiship, Hermes, GLS
    ///   * **Spain**: SEUR
    ///   * **France**: Colissimo, Mondial Relay, Colis Privé, GLS
    ///   * **United Kingdom**: Evri, DPD UK, Parcelforce, Yodel, DHL Parcel, Tuffnells
    ///   * **Greece**: ACS Courier
    ///   * **Hong Kong SAR**: SF Express
    ///   * **Ireland**: Fastway, DPD Ireland
    ///   * **India**: DTDC, India Post, Delhivery, Gati KWE, Professional Couriers,
    /// XpressBees, Ecom Express, Ekart, Shadowfax, Bluedart
    ///   * **Italy**: BRT, GLS Italy
    ///   * **Japan**: エコ配, 西濃運輸, 西濃スーパーエキスプレス, 福山通運, 日本通運, 名鉄運輸, 第一貨物
    ///   * **Netherlands**: DHL Parcel, DPD
    ///   * **Norway**: Bring
    ///   * **Poland**: Inpost
    ///   * **Turkey**: PTT, Yurtiçi Kargo, Aras Kargo, Sürat Kargo
    ///   * **United States**: GLS, Alliance Air Freight, Pilot Freight, LSO, Old
    /// Dominion, Pandion, R+L Carriers, Southwest Air Cargo
    ///   * **South Africa**: Fastway, Skynet.
    /// </summary>
    [JsonPropertyName("company")]
    public string? company { get; set; } = null;

    /// <summary>
    /// The tracking number of the fulfillment.
    /// The tracking number is clickable in the interface if one of the following applies
    /// (the highest in the list has the highest priority):
    /// * Tracking url provided in the `url` field.
    /// * [Shopify-known tracking company name](#supported-tracking-companies) specified in the `company` field.
    ///   Shopify will build the tracking URL automatically based on the tracking number specified.
    /// * The tracking number has a Shopify-known format.
    ///   Shopify will guess the tracking provider and build the tracking url based on the tracking number format.
    ///   Not all tracking carriers are supported, and multiple tracking carriers may use similarly formatted tracking numbers.
    ///   This can result in an invalid tracking URL.
    ///   It is highly recommended that you send the tracking company and the tracking URL.
    /// </summary>
    [JsonPropertyName("number")]
    public string? number { get; set; } = null;

    /// <summary>
    /// The URLs to track the fulfillment.
    /// The tracking URL is displayed in the merchant's admin on the order page.
    /// The tracking URL is displayed in the shipping confirmation email, which can optionally be sent to the customer.
    /// When accounts are enabled, it's also displayed in the customer's order history.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}