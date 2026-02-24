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
    public sealed class QueryRootDisputeEvidenceQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeEvidence, QueryRootDisputeEvidenceQueryBuilder>, IHasArguments<QueryRootDisputeEvidenceArgumentsBuilder>
    {
        public QueryRootDisputeEvidenceArgumentsBuilder Arguments { get; }
        protected override QueryRootDisputeEvidenceQueryBuilder Self => this;

        public QueryRootDisputeEvidenceQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeEvidence>(name))
        {
            Arguments = new QueryRootDisputeEvidenceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDisputeEvidenceQueryBuilder(IQuery<ShopifyPaymentsDisputeEvidence> query) : base(query)
        {
            Arguments = new QueryRootDisputeEvidenceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDisputeEvidenceQueryBuilder SetArguments(Action<QueryRootDisputeEvidenceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder AccessActivityLog()
        {
            base.InnerQuery.AddField("accessActivityLog");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder CancellationPolicyDisclosure()
        {
            base.InnerQuery.AddField("cancellationPolicyDisclosure");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder CancellationPolicyFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("cancellationPolicyFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder CancellationRebuttal()
        {
            base.InnerQuery.AddField("cancellationRebuttal");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder CustomerCommunicationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("customerCommunicationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder CustomerEmailAddress()
        {
            base.InnerQuery.AddField("customerEmailAddress");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder CustomerFirstName()
        {
            base.InnerQuery.AddField("customerFirstName");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder CustomerLastName()
        {
            base.InnerQuery.AddField("customerLastName");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder CustomerPurchaseIp()
        {
            base.InnerQuery.AddField("customerPurchaseIp");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder Dispute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("dispute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDispute>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder DisputeFileUploads(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("disputeFileUploads");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder Fulfillments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFulfillmentQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFulfillment>("fulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFulfillment>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder ProductDescription()
        {
            base.InnerQuery.AddField("productDescription");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder RefundPolicyDisclosure()
        {
            base.InnerQuery.AddField("refundPolicyDisclosure");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder RefundPolicyFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("refundPolicyFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder RefundRefusalExplanation()
        {
            base.InnerQuery.AddField("refundRefusalExplanation");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder ServiceDocumentationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("serviceDocumentationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder ShippingDocumentationFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("shippingDocumentationFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder Submitted()
        {
            base.InnerQuery.AddField("submitted");
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder UncategorizedFile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeFileUpload>("uncategorizedFile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeFileUploadQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeFileUpload>(query);
            return this;
        }

        public QueryRootDisputeEvidenceQueryBuilder UncategorizedText()
        {
            base.InnerQuery.AddField("uncategorizedText");
            return this;
        }
    }
}