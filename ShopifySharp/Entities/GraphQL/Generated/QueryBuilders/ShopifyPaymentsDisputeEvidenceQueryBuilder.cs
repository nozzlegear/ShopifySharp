#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopifyPaymentsDisputeEvidenceQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsDisputeEvidence>("query shopifyPaymentsDisputeEvidence")
{
    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldAccessActivityLog()
    {
        AddField("accessActivityLog");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldBillingAddress()
    {
        AddField("billingAddress");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCancellationPolicyDisclosure()
    {
        AddField("cancellationPolicyDisclosure");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCancellationPolicyFile()
    {
        AddField("cancellationPolicyFile");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCancellationRebuttal()
    {
        AddField("cancellationRebuttal");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCustomerCommunicationFile()
    {
        AddField("customerCommunicationFile");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCustomerEmailAddress()
    {
        AddField("customerEmailAddress");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCustomerFirstName()
    {
        AddField("customerFirstName");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCustomerLastName()
    {
        AddField("customerLastName");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCustomerPurchaseIp()
    {
        AddField("customerPurchaseIp");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldDispute()
    {
        AddField("dispute");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldDisputeFileUploads()
    {
        AddField("disputeFileUploads");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldFulfillments()
    {
        AddField("fulfillments");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldProductDescription()
    {
        AddField("productDescription");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldRefundPolicyDisclosure()
    {
        AddField("refundPolicyDisclosure");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldRefundPolicyFile()
    {
        AddField("refundPolicyFile");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldRefundRefusalExplanation()
    {
        AddField("refundRefusalExplanation");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldServiceDocumentationFile()
    {
        AddField("serviceDocumentationFile");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldShippingAddress()
    {
        AddField("shippingAddress");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldShippingDocumentationFile()
    {
        AddField("shippingDocumentationFile");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldSubmitted()
    {
        AddField("submitted");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldUncategorizedFile()
    {
        AddField("uncategorizedFile");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldUncategorizedText()
    {
        AddField("uncategorizedText");
        return this;
    }
}