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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ShopPayPaymentRequestReceiptsOperationQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestReceiptConnection, ShopPayPaymentRequestReceiptsOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopPayPaymentRequestReceiptConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ShopPayPaymentRequestReceiptsArgumentsBuilder Arguments { get; }
        protected override ShopPayPaymentRequestReceiptsOperationQueryBuilder Self => this;

        public ShopPayPaymentRequestReceiptsOperationQueryBuilder() : this("shopPayPaymentRequestReceipts")
        {
        }

        public ShopPayPaymentRequestReceiptsOperationQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestReceiptConnection>(name))
        {
            Arguments = new ShopPayPaymentRequestReceiptsArgumentsBuilder(base.InnerQuery);
        }

        public ShopPayPaymentRequestReceiptsOperationQueryBuilder(IQuery<ShopPayPaymentRequestReceiptConnection> query) : base(query)
        {
            Arguments = new ShopPayPaymentRequestReceiptsArgumentsBuilder(base.InnerQuery);
        }

        public ShopPayPaymentRequestReceiptsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptEdgeQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceiptEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceiptEdge>(query);
            return this;
        }

        public ShopPayPaymentRequestReceiptsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceipt>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPayPaymentRequestReceiptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceipt>(query);
            return this;
        }

        public ShopPayPaymentRequestReceiptsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}