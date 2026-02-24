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
    public sealed class OrderReturnsQueryBuilder : FieldsQueryBuilderBase<ReturnConnection, OrderReturnsQueryBuilder>, IHasArguments<OrderReturnsArgumentsBuilder>
    {
        public OrderReturnsArgumentsBuilder Arguments { get; }
        protected override OrderReturnsQueryBuilder Self => this;

        public OrderReturnsQueryBuilder(string name) : base(new Query<ReturnConnection>(name))
        {
            Arguments = new OrderReturnsArgumentsBuilder(base.InnerQuery);
        }

        public OrderReturnsQueryBuilder(IQuery<ReturnConnection> query) : base(query)
        {
            Arguments = new OrderReturnsArgumentsBuilder(base.InnerQuery);
        }

        public OrderReturnsQueryBuilder SetArguments(Action<OrderReturnsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderReturnsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnEdge>(query);
            return this;
        }

        public OrderReturnsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public OrderReturnsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}