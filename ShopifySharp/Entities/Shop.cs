using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    public class Shop: ShopifyObject
    {
        /// <summary>
        /// The shop's street address.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }
        
        /// <summary>
        /// The optional second line of the shop's street address.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The city in which the shop is located.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The shop's country (by default equal to the two-letter country code).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The two-letter country code corresponding to the shop's country.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The shop's normalized country name.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// The date and time when the shop was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The customer's email.
        /// </summary>
        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// The three-letter code for the currency that the shop accepts.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The shop's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The shop's domain.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// The contact email address for the shop.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Enabled currencies
        /// </summary>
        [JsonProperty("enabled_presentment_currencies")]
        public string[] EnabledPresentmentCurrencies { get; set; }

        /// <summary>
        /// Present when a shop has a google app domain. It will be returned as a URL, else null.
        /// </summary>
        [JsonProperty("google_apps_domain")]
        public string GoogleAppsDomain { get; set; }

        /// <summary>
        /// Present if a shop has google apps enabled. Those shops with this feature will be able to login to the google apps login.
        /// </summary>
        [JsonProperty("google_apps_login_enabled")]
        public string GoogleAppsLoginEnabled { get; set; }
        
        /// <summary>
        /// Whether the shop is eligible to receive a free credit card reader from Shopify.
        /// </summary>
        [JsonProperty("eligible_for_card_reader_giveaway")]
        public bool? EligibleForCardReaderGiveaway { get; set; }
        
        /// <summary>
        /// Whether the shop is eligible to use Shopify Payments.
        /// </summary>
        [JsonProperty("eligible_for_payments")]
        public bool? EligibleForPayments { get; set; }

        /// <summary>
        /// Whether the shop is capable of accepting payments directly through the Checkout API.
        /// </summary>
        [JsonProperty("checkout_api_supported")]
        public bool? CheckoutApiSupported { get; set; }

        /// <summary>
        /// Whether any active discounts exist for the shop.
        /// </summary>
        [JsonProperty("has_discounts")]
        public bool? HasDiscounts { get; set; }
        
        /// <summary>
        /// Whether any active gift cards exist for the shop.
        /// </summary>
        [JsonProperty("has_gift_cards")]
        public bool? HasGiftCards { get; set; }
        
        /// <summary>
        /// Geographic coordinate specifying the north/south location of a shop.
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Geographic coordinate specifying the east/west location of a shop.
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// A string representing the way currency is formatted when the currency isn't specified.
        /// </summary>
        [JsonProperty("money_format")]
        public string MoneyFormat { get; set; }
        
        /// <summary>
        /// A string representing the way currency is formatted in email notifications when the currency isn't specified.
        /// </summary>
        [JsonProperty("money_in_emails_format")]
        public string MoneyInEmailsFormat { get; set; }
        
        /// <summary>
        /// A string representing the way currency is formatted when the currency is specified.
        /// </summary>
        [JsonProperty("money_with_currency_format")]
        public string MoneyWithCurrencyFormat { get; set; }
        
        /// <summary>
        /// A string representing the way currency is formatted in email notifications when the currency is specified.
        /// </summary>
        [JsonProperty("money_with_currency_in_emails_format")]
        public string MoneyWithCurrencyInEmailsFormat { get; set; }
        
        

        /// <summary>
        /// Whether multi-location is enabled
        /// </summary>
        [JsonProperty("multi_location_enabled")]
        public bool? MultiLocationEnabled { get; set; }
        
        /// <summary>
        /// Whether the pre-launch page is enabled on the online storefront.
        /// </summary>
        [JsonProperty("pre_launch_enabled")]
        public bool? PreLaunchEnabled { get; set; }
        
        /// <summary>
        /// Whether the shop requires an extra Shopify Payments agreement.
        /// </summary>
        [JsonProperty("requires_extra_payments_agreement")]
        public bool? RequiresExtraPaymentsAgreement { get; set; }

        /// <summary>
        /// The shop's 'myshopify.com' domain.
        /// </summary>
        [JsonProperty("myshopify_domain")]
        public string MyShopifyDomain { get; set; }

        /// <summary>
        /// The name of the shop.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The name of the Shopify plan the shop is on.
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// The display name of the Shopify plan the shop is on.
        /// </summary>
        [JsonProperty("plan_display_name")]
        public string PlanDisplayName { get; set; }

        /// <summary>
        /// Indicates whether the Storefront password protection is enabled.
        /// </summary>
        [JsonProperty("password_enabled")]
        public bool? PasswordEnabled { get; set; }

        /// <summary>
        /// The contact phone number for the shop.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The shop's primary locale.
        /// </summary>
        [JsonProperty("primary_locale")]
        public string PrimaryLocale { get; set; }

        /// <summary>
        /// The shop's normalized province or state name.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// The two-letter code for the shop's province or state.
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// A list of countries the shop ships products to, separated by a comma.
        /// </summary>
        [JsonProperty("ships_to_countries")]
        public string ShipsToCountries { get; set; }

        /// <summary>
        /// The username of the shop owner.
        /// </summary>
        [JsonProperty("shop_owner")]
        public string ShopOwner { get; set; }

        /// <summary>
        /// Unkown. Shopify documentation does not currently indicate what this property actually is.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Specifies whether or not taxes were charged for shipping.
        /// </summary>
        /// <remarks>Although the Shopify docs don't indicate this, it's possible for the value to be null.</remarks>
        [JsonProperty("tax_shipping")]
        public bool? TaxShipping { get; set; }

        /// <summary>
        /// The setting for whether applicable taxes are included in product prices. 
        /// </summary>
        [JsonProperty("taxes_included")]
        public bool? TaxesIncluded { get; set; }

        /// <summary>
        /// The setting for whether the shop is applying taxes on a per-county basis or not (US-only). Valid values are: "true" or "null."
        /// </summary>
        [JsonProperty("county_taxes")]
        public bool? CountyTaxes { get; set; }

        /// <summary>
        /// The name of the timezone the shop is in.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// The named timezone assigned by the IANA.
        /// </summary>
        [JsonProperty("iana_timezone")]
        public string IANATimezone { get; set; }

        /// <summary>
        /// The zip or postal code of the shop's address.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Indicates whether the shop has web-based storefront or not.
        /// </summary>
        [JsonProperty("has_storefront")]
        public bool? HasStorefront { get; set; }

        /// <summary>
        /// Indicates whether the shop has any outstanding setup steps or not.
        /// </summary>
        [JsonProperty("setup_required")]
        public bool? SetupRequired { get; set; }

        /// <summary>
        /// The default unit of weight measurement 
        /// </summary>
        [JsonProperty("weight_unit")]
        public string WeightUnit { get; set; }

        /// <summary>
        /// The date and time when the shop was last updated. 
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The default location of the shop
        /// </summary>
        [JsonProperty("primary_location_id")]
        public long? PrimaryLocationId { get; set; }

        /// <summary>
        /// Whether transactional SMS sent by Shopify are disabled on the shop's online store
        /// </summary>
        [JsonProperty("transactional_sms_disabled")]
        public bool? TransactionalSmsDisabled { get; set; }

        /// <summary>
        /// Whether SMS marketing has been enabled on the shop's checkout configuration settings
        /// </summary>
        [JsonProperty("marketing_sms_consent_enabled_at_checkout")]
        public bool? MarketingSmsConsentEnabledAtCheckout { get; set; }
    }
}
