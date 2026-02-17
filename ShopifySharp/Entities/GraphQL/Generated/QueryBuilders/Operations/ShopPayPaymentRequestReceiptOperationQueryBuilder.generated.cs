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
    public sealed class ShopPayPaymentRequestReceiptOperationQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestReceipt, ShopPayPaymentRequestReceiptOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopPayPaymentRequestReceipt>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ShopPayPaymentRequestReceiptArgumentsBuilder Arguments { get; }
        protected override ShopPayPaymentRequestReceiptOperationQueryBuilder Self => this;

        public ShopPayPaymentRequestReceiptOperationQueryBuilder() : this("shopPayPaymentRequestReceipt")
        {
        }

        public ShopPayPaymentRequestReceiptOperationQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestReceipt>(name))
        {
            Arguments = new ShopPayPaymentRequestReceiptArgumentsBuilder(base.InnerQuery);
        }

        public ShopPayPaymentRequestReceiptOperationQueryBuilder(IQuery<ShopPayPaymentRequestReceipt> query) : base(query)
        {
            Arguments = new ShopPayPaymentRequestReceiptArgumentsBuilder(base.InnerQuery);
        }

        public ShopPayPaymentRequestReceiptOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ShopPayPaymentRequestReceiptOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public ShopPayPaymentRequestReceiptOperationQueryBuilder PaymentRequest(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequest>("paymentRequest");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequest>(query);
            return this;
        }

        public ShopPayPaymentRequestReceiptOperationQueryBuilder ProcessingStatus(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceiptProcessingStatus>("processingStatus");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceiptProcessingStatus>(query);
            return this;
        }

        public ShopPayPaymentRequestReceiptOperationQueryBuilder SourceIdentifier()
        {
            base.InnerQuery.AddField("sourceIdentifier");
            return this;
        }

        public ShopPayPaymentRequestReceiptOperationQueryBuilder Token()
        {
            base.InnerQuery.AddField("token");
            return this;
        }
    }
}