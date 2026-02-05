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
/// A carrier service (also known as a carrier calculated service or shipping
/// service) provides real-time shipping rates to Shopify. Some common carrier
/// services include Canada Post, FedEx, UPS, and USPS. The term **carrier** is
/// often used interchangeably with the terms **shipping company** and **rate provider**.
/// Using the CarrierService resource, you can add a carrier service to a shop and
/// then provide a list of applicable shipping rates at checkout. You can even use
/// the cart data to adjust shipping rates and offer shipping discounts based on
/// what is in the customer's cart.
/// ## Requirements for accessing the CarrierService resource
/// To access the CarrierService resource, add the `write_shipping` permission to
/// your app's requested scopes. For more information, see [API access
/// scopes](https://shopify.dev/docs/admin-api/access-scopes).
/// Your app's request to create a carrier service will fail unless the store
/// installing your carrier service meets one of the following requirements:
/// * It's on the Advanced Shopify plan or higher.
/// * It's on the Shopify plan with yearly billing, or the carrier service feature
/// has been added to the store for a monthly fee. For more information, contact
/// [Shopify Support](https://help.shopify.com/questions).
/// * It's a development store.
/// > Note:
/// > If a store changes its Shopify plan, then the store's association with a
/// carrier service is deactivated if the store no long meets one of the
/// requirements above.
/// ## Providing shipping rates to Shopify
/// When adding a carrier service to a store, you need to provide a POST endpoint
/// rooted in the `callbackUrl` property where Shopify can retrieve applicable
/// shipping rates. The callback URL should be a public endpoint that expects these
/// requests from Shopify.
/// ### Example shipping rate request sent to a carrier service
/// ```json
/// {
///   "rate": {
///     "origin": {
///       "country": "CA",
///       "postal_code": "K2P1L4",
///       "province": "ON",
///       "city": "Ottawa",
///       "name": null,
///       "address1": "150 Elgin St.",
///       "address2": "",
///       "address3": null,
///       "phone": null,
///       "fax": null,
///       "email": null,
///       "address_type": null,
///       "company_name": "Jamie D's Emporium"
///     },
///     "destination": {
///       "country": "CA",
///       "postal_code": "K1M1M4",
///       "province": "ON",
///       "city": "Ottawa",
///       "name": "Bob Norman",
///       "address1": "24 Sussex Dr.",
///       "address2": "",
///       "address3": null,
///       "phone": null,
///       "fax": null,
///       "email": null,
///       "address_type": null,
///       "company_name": null
///     },
///     "items": [{
///       "name": "Short Sleeve T-Shirt",
///       "sku": "",
///       "quantity": 1,
///       "grams": 1000,
///       "price": 1999,
///       "vendor": "Jamie D's Emporium",
///       "requires_shipping": true,
///       "taxable": true,
///       "fulfillment_service": "manual",
///       "properties": null,
///       "product_id": 48447225880,
///       "variant_id": 258644705304
///     }],
///     "currency": "USD",
///     "locale": "en",
///     "order_totals": {
///       "subtotal_price": "1999",
///       "total_price": "2199",
///       "discount_amount": "150"
///     },
///     "customer": {
///       "id": 207119551,
///       "tags": ["VIP", "wholesale"]
///     }
///   }
/// }
/// ```
/// ### Example response
/// ```json
/// {
///    "rates": [
///        {
///            "service_name": "canadapost-overnight",
///            "service_code": "ON",
///            "total_price": "1295",
///            "description": "This is the fastest option by far",
///            "currency": "CAD",
///            "min_delivery_date": "2013-04-12 14:48:45 -0400",
///            "max_delivery_date": "2013-04-12 14:48:45 -0400"
///        },
///        {
///            "service_name": "fedex-2dayground",
///            "service_code": "2D",
///            "total_price": "2934",
///            "currency": "USD",
///            "min_delivery_date": "2013-04-12 14:48:45 -0400",
///            "max_delivery_date": "2013-04-12 14:48:45 -0400"
///        },
///        {
///            "service_name": "fedex-priorityovernight",
///            "service_code": "1D",
///            "total_price": "3587",
///            "currency": "USD",
///            "min_delivery_date": "2013-04-12 14:48:45 -0400",
///            "max_delivery_date": "2013-04-12 14:48:45 -0400",
///            "metafields": [
///                {
///                    "key": "tracking_url",
///                    "value": "abc123",
///                    "namespace": "carrier_service_metadata",
///                    "type": "single_line_text_field"
///                }
///            ]
///        }
///    ]
/// }
/// ```
/// The `address3`, `fax`, `address_type`, and `company_name` fields are returned by
/// specific [ActiveShipping](https://github.com/Shopify/active_shipping) providers.
/// For API-created carrier services, you should use only the following shipping
/// address fields:
/// * `address1`
/// * `address2`
/// * `city`
/// * `zip`
/// * `province`
/// * `country`
/// Other values remain as `null` and are not sent to the callback URL.
/// ### Response fields
/// When Shopify requests shipping rates using your callback URL, the response
/// object `rates` must be a JSON array of objects with the following fields. 
/// Required fields must be included in the response for the carrier service
/// integration to work properly.
/// | Field                   | Required | Description                              
///                                                                                 
///                                                                                   |
/// | ----------------------- | -------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
/// | `service_name`          | Yes      | The name of the rate, which customers see
/// at checkout. For example: `Expedited Mail`.                                     
///                                                                                   |
/// | `description`           | Yes      | A description of the rate, which
/// customers see at checkout. For example: `Includes tracking and insurance`.      
///                                                                                            |
/// | `service_code`          | Yes      | A unique code associated with the rate
/// that must be consistent across requests. For example: `expedited_mail`.         
///                                                                                      |
/// | `currency`              | Yes      | The currency of the shipping rate.       
///                                                                                 
///                                                                                   |
/// | `total_price`           | Yes      | The total price expressed in subunits. If
/// the currency doesn't use subunits, then the value must be multiplied by 100. For
/// example: `"total_price": 500` for 5.00 CAD, `"total_price": 100000` for 1000 JPY. |
/// | `phone_required`        | No       | Whether the customer must provide a phone
/// number at checkout.                                                             
///                                                                                   |
/// | `min_delivery_date`     | No       | The earliest delivery date for the
/// displayed rate.                                                                 
///                                                                                          |
/// | `max_delivery_date`     | No       | The latest delivery date for the
/// displayed rate to still be valid.                                               
///                                                                                            |
/// | `metafields`            | No       | An array of metafield objects to attach
/// custom metadata to the shipping rate.                                           
///                                                                                     |
/// ### Special conditions
/// * To indicate that this carrier service cannot handle this shipping request,
/// return an empty array and any successful (20x) HTTP code.
/// * To force backup rates instead, return a 40x or 50x HTTP code with any content.
/// A good choice is the regular 404 Not Found code.
/// * Redirects (30x codes) will only be followed for the same domain as the
/// original callback URL. Attempting to redirect to a different domain will trigger backup rates.
/// * There is no retry mechanism. The response must be successful on the first try,
/// within the time budget listed below. Timeouts or errors will trigger backup rates.
/// * The `service_code` must be stable and consistent across requests for the same
/// shipping option. It should not contain dynamic values like session IDs,
/// timestamps, or request-specific identifiers. Use metafields for passing dynamic
/// or session-specific data.
/// ## Response Timeouts
/// The read timeout for rate requests are dynamic, based on the number of requests
/// per minute (RPM). These limits are applied to each shop-app pair. The timeout
/// values are as follows.
/// | RPM Range     | Timeout    |
/// | ------------- | ---------- |
/// | Under 1500    | 10s        |
/// | 1500 to 3000  | 5s         |
/// | Over 3000     | 3s         |
/// > Note:
/// > These values are upper limits and should not be interpretted as a goal to
/// develop towards. Shopify is constantly evaluating the performance of the
/// platform and working towards improving resilience as well as app capabilities.
/// As such, these numbers may be adjusted outside of our normal versioning timelines.
/// ## Server-side caching of requests
/// Shopify provides server-side caching to reduce the number of requests it makes.
/// Any shipping rate request that identically matches the following fields will be
/// retrieved from Shopify's cache of the initial response:
/// * variant IDs
/// * default shipping box weight and dimensions
/// * variant quantities
/// * carrier service ID
/// * origin address
/// * destination address
/// * item weights and signatures
/// If any of these fields differ, or if the cache has expired since the original
/// request, then new shipping rates are requested. The cache expires 15 minutes
/// after rates are successfully returned. If an error occurs, then the cache
/// expires after 30 seconds.
/// </summary>
public record DeliveryCarrierService : IGraphQLObject, INode
{
    /// <summary>
    /// Whether the carrier service is active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? active { get; set; } = null;

    /// <summary>
    /// The list of services offered for given destinations.
    /// </summary>
    [JsonPropertyName("availableServicesForCountries")]
    public ICollection<DeliveryAvailableService>? availableServicesForCountries { get; set; } = null;

    /// <summary>
    /// The URL endpoint that Shopify needs to retrieve shipping rates.
    /// </summary>
    [JsonPropertyName("callbackUrl")]
    public string? callbackUrl { get; set; } = null;

    /// <summary>
    /// The properly formatted name of the shipping service provider, ready to display.
    /// </summary>
    [JsonPropertyName("formattedName")]
    public string? formattedName { get; set; } = null;

    /// <summary>
    /// The logo of the service provider.
    /// </summary>
    [JsonPropertyName("icon")]
    public Image? icon { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the shipping service provider.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether merchants are able to send dummy data to your service through the Shopify admin to see shipping rate examples.
    /// </summary>
    [JsonPropertyName("supportsServiceDiscovery")]
    public bool? supportsServiceDiscovery { get; set; } = null;
}