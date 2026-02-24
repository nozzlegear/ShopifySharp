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
    public sealed class QueryRootShopPayPaymentRequestReceiptQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestReceipt, QueryRootShopPayPaymentRequestReceiptQueryBuilder>, IHasArguments<QueryRootShopPayPaymentRequestReceiptArgumentsBuilder>
    {
        public QueryRootShopPayPaymentRequestReceiptArgumentsBuilder Arguments { get; }
        protected override QueryRootShopPayPaymentRequestReceiptQueryBuilder Self => this;

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestReceipt>(name))
        {
            Arguments = new QueryRootShopPayPaymentRequestReceiptArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder(IQuery<ShopPayPaymentRequestReceipt> query) : base(query)
        {
            Arguments = new QueryRootShopPayPaymentRequestReceiptArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder SetArguments(Action<QueryRootShopPayPaymentRequestReceiptArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder PaymentRequest(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequest>("paymentRequest");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequest>(query);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder ProcessingStatus(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceiptProcessingStatus>("processingStatus");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceiptProcessingStatus>(query);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder SourceIdentifier()
        {
            base.InnerQuery.AddField("sourceIdentifier");
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptQueryBuilder Token()
        {
            base.InnerQuery.AddField("token");
            return this;
        }
    }
}