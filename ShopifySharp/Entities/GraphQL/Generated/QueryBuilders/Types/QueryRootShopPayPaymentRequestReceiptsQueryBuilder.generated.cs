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
    public sealed class QueryRootShopPayPaymentRequestReceiptsQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestReceiptConnection, QueryRootShopPayPaymentRequestReceiptsQueryBuilder>, IHasArguments<QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder>
    {
        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder Arguments { get; }
        protected override QueryRootShopPayPaymentRequestReceiptsQueryBuilder Self => this;

        public QueryRootShopPayPaymentRequestReceiptsQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestReceiptConnection>(name))
        {
            Arguments = new QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopPayPaymentRequestReceiptsQueryBuilder(IQuery<ShopPayPaymentRequestReceiptConnection> query) : base(query)
        {
            Arguments = new QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopPayPaymentRequestReceiptsQueryBuilder SetArguments(Action<QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptEdgeQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceiptEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceiptEdge>(query);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceipt>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceipt>(query);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}