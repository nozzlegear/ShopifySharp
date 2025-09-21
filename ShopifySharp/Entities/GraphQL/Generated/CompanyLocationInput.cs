#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for company location when creating or updating a company location.
/// </summary>
public record CompanyLocationInput : GraphQLInputObject<CompanyLocationInput>
{
    /// <summary>
    /// The input fields to create or update the billing address for a company location.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public CompanyAddressInput? billingAddress { get; set; } = null;

    /// <summary>
    /// Whether the billing address is the same as the shipping address. If the value
    /// is true, then the input for `billingAddress` is ignored.
    /// </summary>
    [JsonPropertyName("billingSameAsShipping")]
    public bool? billingSameAsShipping { get; set; } = null;

    /// <summary>
    /// The configuration for the buyer's checkout at the company location.
    /// </summary>
    [JsonPropertyName("buyerExperienceConfiguration")]
    public BuyerExperienceConfigurationInput? buyerExperienceConfiguration { get; set; } = null;

    /// <summary>
    /// A unique externally-supplied ID for the company location.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? externalId { get; set; } = null;

    /// <summary>
    /// The preferred locale of the company location.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The name of the company location.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A note about the company location.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The phone number of the company location.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The input fields to create or update the shipping address for a company location.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public CompanyAddressInput? shippingAddress { get; set; } = null;

    /// <summary>
    /// Whether the location is exempt from taxes.
    /// </summary>
    [JsonPropertyName("taxExempt")]
    public bool? taxExempt { get; set; } = null;

    /// <summary>
    /// The list of tax exemptions to apply to the company location.
    /// </summary>
    [JsonPropertyName("taxExemptions")]
    public ICollection<TaxExemption>? taxExemptions { get; set; } = null;

    /// <summary>
    /// The tax registration ID of the company location.
    /// </summary>
    [JsonPropertyName("taxRegistrationId")]
    public string? taxRegistrationId { get; set; } = null;
}