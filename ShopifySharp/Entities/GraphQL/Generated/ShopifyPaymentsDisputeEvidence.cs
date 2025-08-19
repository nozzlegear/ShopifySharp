#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The evidence associated with the dispute.
/// </summary>
public record ShopifyPaymentsDisputeEvidence : IGraphQLObject, INode
{
    /// <summary>
    /// The activity logs associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("accessActivityLog")]
    public string? accessActivityLog { get; set; } = null;

    /// <summary>
    /// The billing address that's provided by the customer.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public MailingAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// The cancellation policy disclosure associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("cancellationPolicyDisclosure")]
    public string? cancellationPolicyDisclosure { get; set; } = null;

    /// <summary>
    /// The cancellation policy file associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("cancellationPolicyFile")]
    public ShopifyPaymentsDisputeFileUpload? cancellationPolicyFile { get; set; } = null;

    /// <summary>
    /// The cancellation rebuttal associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("cancellationRebuttal")]
    public string? cancellationRebuttal { get; set; } = null;

    /// <summary>
    /// The customer communication file associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("customerCommunicationFile")]
    public ShopifyPaymentsDisputeFileUpload? customerCommunicationFile { get; set; } = null;

    /// <summary>
    /// The customer's email address.
    /// </summary>
    [JsonPropertyName("customerEmailAddress")]
    public string? customerEmailAddress { get; set; } = null;

    /// <summary>
    /// The customer's first name.
    /// </summary>
    [JsonPropertyName("customerFirstName")]
    public string? customerFirstName { get; set; } = null;

    /// <summary>
    /// The customer's last name.
    /// </summary>
    [JsonPropertyName("customerLastName")]
    public string? customerLastName { get; set; } = null;

    /// <summary>
    /// The customer purchase ip for this dispute evidence.
    /// </summary>
    [JsonPropertyName("customerPurchaseIp")]
    public string? customerPurchaseIp { get; set; } = null;

    /// <summary>
    /// The dispute associated with the evidence.
    /// </summary>
    [JsonPropertyName("dispute")]
    public ShopifyPaymentsDispute? dispute { get; set; } = null;

    /// <summary>
    /// The file uploads associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("disputeFileUploads")]
    public ICollection<ShopifyPaymentsDisputeFileUpload>? disputeFileUploads { get; set; } = null;

    /// <summary>
    /// The fulfillments associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("fulfillments")]
    public ICollection<ShopifyPaymentsDisputeFulfillment>? fulfillments { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The product description for this dispute evidence.
    /// </summary>
    [JsonPropertyName("productDescription")]
    public string? productDescription { get; set; } = null;

    /// <summary>
    /// The refund policy disclosure associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("refundPolicyDisclosure")]
    public string? refundPolicyDisclosure { get; set; } = null;

    /// <summary>
    /// The refund policy file associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("refundPolicyFile")]
    public ShopifyPaymentsDisputeFileUpload? refundPolicyFile { get; set; } = null;

    /// <summary>
    /// The refund refusal explanation associated with dispute evidence.
    /// </summary>
    [JsonPropertyName("refundRefusalExplanation")]
    public string? refundRefusalExplanation { get; set; } = null;

    /// <summary>
    /// The service documentation file associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("serviceDocumentationFile")]
    public ShopifyPaymentsDisputeFileUpload? serviceDocumentationFile { get; set; } = null;

    /// <summary>
    /// The mailing address for shipping that's provided by the customer.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public MailingAddress? shippingAddress { get; set; } = null;

    /// <summary>
    /// The shipping documentation file associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("shippingDocumentationFile")]
    public ShopifyPaymentsDisputeFileUpload? shippingDocumentationFile { get; set; } = null;

    /// <summary>
    /// Whether the dispute evidence is submitted.
    /// </summary>
    [JsonPropertyName("submitted")]
    public bool? submitted { get; set; } = null;

    /// <summary>
    /// The uncategorized file associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("uncategorizedFile")]
    public ShopifyPaymentsDisputeFileUpload? uncategorizedFile { get; set; } = null;

    /// <summary>
    /// The uncategorized text for the dispute evidence.
    /// </summary>
    [JsonPropertyName("uncategorizedText")]
    public string? uncategorizedText { get; set; } = null;
}