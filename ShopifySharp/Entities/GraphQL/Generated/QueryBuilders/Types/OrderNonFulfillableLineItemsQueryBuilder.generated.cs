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
    public sealed class OrderNonFulfillableLineItemsQueryBuilder : FieldsQueryBuilderBase<LineItemConnection, OrderNonFulfillableLineItemsQueryBuilder>, IHasArguments<OrderNonFulfillableLineItemsArgumentsBuilder>
    {
        public OrderNonFulfillableLineItemsArgumentsBuilder Arguments { get; }
        protected override OrderNonFulfillableLineItemsQueryBuilder Self => this;

        public OrderNonFulfillableLineItemsQueryBuilder(string name) : base(new Query<LineItemConnection>(name))
        {
            Arguments = new OrderNonFulfillableLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public OrderNonFulfillableLineItemsQueryBuilder(IQuery<LineItemConnection> query) : base(query)
        {
            Arguments = new OrderNonFulfillableLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public OrderNonFulfillableLineItemsQueryBuilder SetArguments(Action<OrderNonFulfillableLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderNonFulfillableLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder> build)
        {
            var query = new Query<LineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemEdge>(query);
            return this;
        }

        public OrderNonFulfillableLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public OrderNonFulfillableLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}