#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ShopPayPaymentRequestReceiptQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestReceipt, ShopPayPaymentRequestReceiptQueryBuilder>
    {
        protected override ShopPayPaymentRequestReceiptQueryBuilder Self => this;

        public ShopPayPaymentRequestReceiptQueryBuilder() : this("shopPayPaymentRequestReceipt")
        {
        }

        public ShopPayPaymentRequestReceiptQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestReceipt>(name))
        {
        }

        public ShopPayPaymentRequestReceiptQueryBuilder(IQuery<ShopPayPaymentRequestReceipt> query) : base(query)
        {
        }

        public ShopPayPaymentRequestReceiptQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ShopPayPaymentRequestReceiptQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public ShopPayPaymentRequestReceiptQueryBuilder PaymentRequest(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequest>("paymentRequest");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequest>(query);
            return this;
        }

        public ShopPayPaymentRequestReceiptQueryBuilder ProcessingStatus(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceiptProcessingStatus>("processingStatus");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceiptProcessingStatus>(query);
            return this;
        }

        public ShopPayPaymentRequestReceiptQueryBuilder SourceIdentifier()
        {
            base.InnerQuery.AddField("sourceIdentifier");
            return this;
        }

        public ShopPayPaymentRequestReceiptQueryBuilder Token()
        {
            base.InnerQuery.AddField("token");
            return this;
        }
    }
}