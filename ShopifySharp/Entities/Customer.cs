using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp;

public class Customer : ShopifyObject
{
    /// <summary>
    /// A list of addresses for the customer.
    /// </summary>
    [JsonProperty("addresses")]
    public IEnumerable<Address> Addresses { get; set; }

    /// <summary>
    /// The date and time when the customer was created. 
    /// </summary>
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// Currency used for customer's last order
    /// </summary>
    [JsonProperty("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The default address for the customer.
    /// </summary>
    [JsonProperty("default_address")]
    public Address DefaultAddress { get; set; }

    /// <summary>
    /// The email address of the customer.
    /// </summary>
    [JsonProperty("email")]
    public string Email { get; set; }

    /// <summary>
    /// The customer's first name.
    /// </summary>
    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// The customer's identifier used with Multipass login
    /// </summary>
    [JsonProperty("multipass_identifier")]
    public string MultipassIdentifier { get; set; }

    /// <summary>
    /// The customer's last name.
    /// </summary>
    [JsonProperty("last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// The id of the customer's last order. 
    /// **Note**: this value is deprecated specifically when the customer is returned using the Orders API. In that case, the value will always be null. The property is still available via the Customers API.
    /// </summary>
    /// <remarks>Property can be null or longer than max int32 value. Set to nullable long instead.</remarks>
    [JsonProperty("last_order_id")]
    public long? LastOrderId { get; set; }

    /// <summary>
    /// The name of the customer's last order. This is directly related to the Order's name field.
    /// **Note**: this value is deprecated specifically when the customer is returned using the Orders API. In that case, the value will always be null. The property is still available via the Customers API.
    /// </summary>
    [JsonProperty("last_order_name")]
    public string LastOrderName { get; set; }

    /// <summary>
    /// A note about the customer.
    /// </summary>
    [JsonProperty("note")]
    public string Note { get; set; }

    /// <summary>
    /// The number of orders associated with this customer.
    /// **Note**: this value is deprecated specifically when the customer is returned using the Orders API. In that case, the value will always be null. The property is still available via the Customers API.
    /// </summary>
    [JsonProperty("orders_count")]
    public int? OrdersCount { get; set; }

    /// <summary>
    /// The phone number for the customer. Valid formats can be of different types, for example:
    /// 
    /// 6135551212
    /// 
    /// +16135551212
    /// 
    /// 555-1212
    /// 
    /// (613)555-1212
    /// 
    /// +1 613-555-1212
    /// </summary>
    [JsonProperty("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The state of the customer in a shop. Valid values are 'disabled', 'decline', 'invited' and 'enabled'.
    /// </summary>
    [JsonProperty("state")]
    public string State { get; set; }

    /// <summary>
    /// Tags are additional short descriptors formatted as a string of comma-separated values.
    /// </summary>
    [JsonProperty("tags")]
    public string Tags { get; set; }

    /// <summary>
    /// Indicates whether the customer should be charged taxes when placing orders. 
    /// </summary>
    [JsonProperty("tax_exempt")]
    public bool? TaxExempt { get; set; }

    /// <summary>
    /// Whether the customer is exempt from paying specific taxes on their order. Canadian taxes only
    /// </summary>
    [JsonProperty("tax_exemptions")]
    public string[] TaxExemptions { get; set; }

    /// <summary>
    /// The total amount of money that the customer has spent at the shop.
    /// **Note**: this value is deprecated specifically when the customer is returned using the Orders API. In that case, the value will always be null. The property is still available via the Customers API.
    /// </summary>
    /// <remarks>The Shopify API actually returns this value as a string, but Json.Net can automatically convert to decimal.</remarks>
    [JsonProperty("total_spent")]
    public decimal? TotalSpent { get; set; }

    /// <summary>
    /// The date and time when the customer information was updated. 
    /// </summary>
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// States whether or not the email address has been verified.
    /// </summary>
    [JsonProperty("verified_email")]
    public bool? VerifiedEmail { get; set; }

    /// <summary>
    /// The marketing consent information when the customer consented to receiving marketing material by SMS. The phone property is required to create a customer with SMS consent information and to perform an SMS update on a customer that doesn't have a phone number recorded. 
    /// </summary>
    [JsonProperty("sms_marketing_consent")]
    public CustomerSmsMarketingConsent SmsMarketingConsent { get; set; }

    /// <summary>
    /// Additional metadata about the <see cref="Customer"/>. Note: This is not naturally returned with a <see cref="Customer"/> response, as
    /// Shopify will not return <see cref="Customer"/> metafields unless specified. Instead, you need to query metafields with <see cref="MetaFieldService"/>. 
    /// Uses include: Creating, updating, & deserializing webhook bodies that include them.
    /// </summary>
    [JsonProperty("metafields")]
    public IEnumerable<MetaField> Metafields { get; set; }

    /// <summary>
    /// The marketing consent information when the customer consented to receiving marketing material by email. The email property is required to create a customer with email consent information and to update a customer for email consent that doesn't have an email recorded.
    /// </summary>
    [JsonProperty("email_marketing_consent")]
    public CustomerEmailMarketingConsent EmailMarketingConsent { get; set; }
}