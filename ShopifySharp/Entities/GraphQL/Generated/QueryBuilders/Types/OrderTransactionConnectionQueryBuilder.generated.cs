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
    public sealed class OrderTransactionConnectionQueryBuilder : FieldsQueryBuilderBase<OrderTransactionConnection, OrderTransactionConnectionQueryBuilder>
    {
        protected override OrderTransactionConnectionQueryBuilder Self => this;

        public OrderTransactionConnectionQueryBuilder() : this("orderTransactionConnection")
        {
        }

        public OrderTransactionConnectionQueryBuilder(string name) : base(new Query<OrderTransactionConnection>(name))
        {
        }

        public OrderTransactionConnectionQueryBuilder(IQuery<OrderTransactionConnection> query) : base(query)
        {
        }

        public OrderTransactionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<OrderTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionEdge>(query);
            return this;
        }

        public OrderTransactionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public OrderTransactionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}