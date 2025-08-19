#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to update a dispute evidence object.
/// </summary>
public record ShopifyPaymentsDisputeEvidenceUpdateInput : GraphQLInputObject<ShopifyPaymentsDisputeEvidenceUpdateInput>
{
    /// <summary>
    /// Activity logs.
    /// </summary>
    [JsonPropertyName("accessActivityLog")]
    public string? accessActivityLog { get; set; } = null;

    /// <summary>
    /// Cancellation policy disclosure.
    /// </summary>
    [JsonPropertyName("cancellationPolicyDisclosure")]
    public string? cancellationPolicyDisclosure { get; set; } = null;

    /// <summary>
    /// Cancellation policy file.
    /// </summary>
    [JsonPropertyName("cancellationPolicyFile")]
    public ShopifyPaymentsDisputeFileUploadUpdateInput? cancellationPolicyFile { get; set; } = null;

    /// <summary>
    /// Cancellation rebuttal.
    /// </summary>
    [JsonPropertyName("cancellationRebuttal")]
    public string? cancellationRebuttal { get; set; } = null;

    /// <summary>
    /// Customer communication file.
    /// </summary>
    [JsonPropertyName("customerCommunicationFile")]
    public ShopifyPaymentsDisputeFileUploadUpdateInput? customerCommunicationFile { get; set; } = null;

    /// <summary>
    /// Customer email address.
    /// </summary>
    [JsonPropertyName("customerEmailAddress")]
    public string? customerEmailAddress { get; set; } = null;

    /// <summary>
    /// Customer first name.
    /// </summary>
    [JsonPropertyName("customerFirstName")]
    public string? customerFirstName { get; set; } = null;

    /// <summary>
    /// Customer last name.
    /// </summary>
    [JsonPropertyName("customerLastName")]
    public string? customerLastName { get; set; } = null;

    /// <summary>
    /// Refund policy disclosure.
    /// </summary>
    [JsonPropertyName("refundPolicyDisclosure")]
    public string? refundPolicyDisclosure { get; set; } = null;

    /// <summary>
    /// Refund policy file.
    /// </summary>
    [JsonPropertyName("refundPolicyFile")]
    public ShopifyPaymentsDisputeFileUploadUpdateInput? refundPolicyFile { get; set; } = null;

    /// <summary>
    /// Refund refusal explanation.
    /// </summary>
    [JsonPropertyName("refundRefusalExplanation")]
    public string? refundRefusalExplanation { get; set; } = null;

    /// <summary>
    /// Service documentation file.
    /// </summary>
    [JsonPropertyName("serviceDocumentationFile")]
    public ShopifyPaymentsDisputeFileUploadUpdateInput? serviceDocumentationFile { get; set; } = null;

    /// <summary>
    /// The shipping address associated with the dispute evidence.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public MailingAddressInput? shippingAddress { get; set; } = null;

    /// <summary>
    /// Shipping documentation file.
    /// </summary>
    [JsonPropertyName("shippingDocumentationFile")]
    public ShopifyPaymentsDisputeFileUploadUpdateInput? shippingDocumentationFile { get; set; } = null;

    /// <summary>
    /// Whether to submit the evidence.
    /// </summary>
    [JsonPropertyName("submitEvidence")]
    public bool? submitEvidence { get; set; } = null;

    /// <summary>
    /// Uncategorized file.
    /// </summary>
    [JsonPropertyName("uncategorizedFile")]
    public ShopifyPaymentsDisputeFileUploadUpdateInput? uncategorizedFile { get; set; } = null;

    /// <summary>
    /// Uncategorized text.
    /// </summary>
    [JsonPropertyName("uncategorizedText")]
    public string? uncategorizedText { get; set; } = null;
}