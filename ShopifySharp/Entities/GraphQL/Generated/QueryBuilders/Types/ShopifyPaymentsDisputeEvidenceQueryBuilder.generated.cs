#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ShopifyPaymentsDisputeEvidenceQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeEvidence, ShopifyPaymentsDisputeEvidenceQueryBuilder>
    {
        protected override ShopifyPaymentsDisputeEvidenceQueryBuilder Self => this;

        public ShopifyPaymentsDisputeEvidenceQueryBuilder() : this("shopifyPaymentsDisputeEvidence")
        {
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeEvidence>(name))
        {
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder(IQuery<ShopifyPaymentsDisputeEvidence> query) : base(query)
        {
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder AccessActivityLog()
        {
            base.InnerQuery.AddField("accessActivityLog");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder CancellationPolicyDisclosure()
        {
            base.InnerQuery.AddField("cancellationPolicyDisclosure");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder CancellationPolicyFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("cancellationPolicyFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder CancellationRebuttal()
        {
            base.InnerQuery.AddField("cancellationRebuttal");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder CustomerCommunicationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("customerCommunicationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder CustomerEmailAddress()
        {
            base.InnerQuery.AddField("customerEmailAddress");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder CustomerFirstName()
        {
            base.InnerQuery.AddField("customerFirstName");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder CustomerLastName()
        {
            base.InnerQuery.AddField("customerLastName");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder CustomerPurchaseIp()
        {
            base.InnerQuery.AddField("customerPurchaseIp");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder Dispute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("dispute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDispute>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder DisputeFileUploads(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("disputeFileUploads");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder Fulfillments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFulfillmentQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFulfillment>("fulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFulfillment>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder ProductDescription()
        {
            base.InnerQuery.AddField("productDescription");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder RefundPolicyDisclosure()
        {
            base.InnerQuery.AddField("refundPolicyDisclosure");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder RefundPolicyFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("refundPolicyFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder RefundRefusalExplanation()
        {
            base.InnerQuery.AddField("refundRefusalExplanation");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder ServiceDocumentationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("serviceDocumentationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder ShippingDocumentationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("shippingDocumentationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder Submitted()
        {
            base.InnerQuery.AddField("submitted");
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder UncategorizedFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("uncategorizedFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public ShopifyPaymentsDisputeEvidenceQueryBuilder UncategorizedText()
        {
            base.InnerQuery.AddField("uncategorizedText");
            return this;
        }
    }
}