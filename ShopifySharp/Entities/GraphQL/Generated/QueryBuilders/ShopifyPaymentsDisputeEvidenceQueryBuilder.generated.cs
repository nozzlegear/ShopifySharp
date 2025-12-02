#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopifyPaymentsDisputeEvidenceQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsDisputeEvidence>("shopifyPaymentsDisputeEvidence")
{
    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldAccessActivityLog()
    {
        AddField("accessActivityLog");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldBillingAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("billingAddress", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCancellationPolicyDisclosure()
    {
        AddField("cancellationPolicyDisclosure");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCancellationPolicyFile(Func<ShopifyPaymentsDisputeFileUploadQueryBuilder, ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeFileUpload, ShopifyPaymentsDisputeFileUploadQueryBuilder>("cancellationPolicyFile", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCancellationRebuttal()
    {
        AddField("cancellationRebuttal");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldCustomerCommunicationFile(Func<ShopifyPaymentsDisputeFileUploadQueryBuilder, ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeFileUpload, ShopifyPaymentsDisputeFileUploadQueryBuilder>("customerCommunicationFile", build);
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

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldDispute(Func<ShopifyPaymentsDisputeQueryBuilder, ShopifyPaymentsDisputeQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDispute, ShopifyPaymentsDisputeQueryBuilder>("dispute", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldDisputeFileUploads(Func<ShopifyPaymentsDisputeFileUploadQueryBuilder, ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeFileUpload, ShopifyPaymentsDisputeFileUploadQueryBuilder>("disputeFileUploads", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldFulfillments(Func<ShopifyPaymentsDisputeFulfillmentQueryBuilder, ShopifyPaymentsDisputeFulfillmentQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeFulfillment, ShopifyPaymentsDisputeFulfillmentQueryBuilder>("fulfillments", build);
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

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldRefundPolicyFile(Func<ShopifyPaymentsDisputeFileUploadQueryBuilder, ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeFileUpload, ShopifyPaymentsDisputeFileUploadQueryBuilder>("refundPolicyFile", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldRefundRefusalExplanation()
    {
        AddField("refundRefusalExplanation");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldServiceDocumentationFile(Func<ShopifyPaymentsDisputeFileUploadQueryBuilder, ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeFileUpload, ShopifyPaymentsDisputeFileUploadQueryBuilder>("serviceDocumentationFile", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldShippingAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("shippingAddress", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldShippingDocumentationFile(Func<ShopifyPaymentsDisputeFileUploadQueryBuilder, ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeFileUpload, ShopifyPaymentsDisputeFileUploadQueryBuilder>("shippingDocumentationFile", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldSubmitted()
    {
        AddField("submitted");
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldUncategorizedFile(Func<ShopifyPaymentsDisputeFileUploadQueryBuilder, ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeFileUpload, ShopifyPaymentsDisputeFileUploadQueryBuilder>("uncategorizedFile", build);
        return this;
    }

    public ShopifyPaymentsDisputeEvidenceQueryBuilder AddFieldUncategorizedText()
    {
        AddField("uncategorizedText");
        return this;
    }
}