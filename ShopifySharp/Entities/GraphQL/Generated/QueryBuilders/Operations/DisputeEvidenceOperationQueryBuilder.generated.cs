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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DisputeEvidenceOperationQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeEvidence, DisputeEvidenceOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopifyPaymentsDisputeEvidence>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DisputeEvidenceArgumentsBuilder Arguments { get; }
        protected override DisputeEvidenceOperationQueryBuilder Self => this;

        public DisputeEvidenceOperationQueryBuilder() : this("disputeEvidence")
        {
        }

        public DisputeEvidenceOperationQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeEvidence>(name))
        {
            Arguments = new DisputeEvidenceArgumentsBuilder(base.InnerQuery);
        }

        public DisputeEvidenceOperationQueryBuilder(IQuery<ShopifyPaymentsDisputeEvidence> query) : base(query)
        {
            Arguments = new DisputeEvidenceArgumentsBuilder(base.InnerQuery);
        }

        public DisputeEvidenceOperationQueryBuilder AccessActivityLog()
        {
            base.InnerQuery.AddField("accessActivityLog");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder CancellationPolicyDisclosure()
        {
            base.InnerQuery.AddField("cancellationPolicyDisclosure");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder CancellationPolicyFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("cancellationPolicyFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder CancellationRebuttal()
        {
            base.InnerQuery.AddField("cancellationRebuttal");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder CustomerCommunicationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("customerCommunicationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder CustomerEmailAddress()
        {
            base.InnerQuery.AddField("customerEmailAddress");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder CustomerFirstName()
        {
            base.InnerQuery.AddField("customerFirstName");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder CustomerLastName()
        {
            base.InnerQuery.AddField("customerLastName");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder CustomerPurchaseIp()
        {
            base.InnerQuery.AddField("customerPurchaseIp");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder Dispute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("dispute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDispute>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder DisputeFileUploads(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("disputeFileUploads");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder Fulfillments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFulfillmentQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFulfillment>("fulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFulfillment>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder ProductDescription()
        {
            base.InnerQuery.AddField("productDescription");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder RefundPolicyDisclosure()
        {
            base.InnerQuery.AddField("refundPolicyDisclosure");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder RefundPolicyFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("refundPolicyFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder RefundRefusalExplanation()
        {
            base.InnerQuery.AddField("refundRefusalExplanation");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder ServiceDocumentationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("serviceDocumentationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder ShippingDocumentationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("shippingDocumentationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder Submitted()
        {
            base.InnerQuery.AddField("submitted");
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder UncategorizedFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("uncategorizedFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public DisputeEvidenceOperationQueryBuilder UncategorizedText()
        {
            base.InnerQuery.AddField("uncategorizedText");
            return this;
        }
    }
}