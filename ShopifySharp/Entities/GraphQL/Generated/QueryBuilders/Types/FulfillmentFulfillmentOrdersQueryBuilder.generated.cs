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
    public sealed class FulfillmentFulfillmentOrdersQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderConnection, FulfillmentFulfillmentOrdersQueryBuilder>, IHasArguments<FulfillmentFulfillmentOrdersArgumentsBuilder>
    {
        public FulfillmentFulfillmentOrdersArgumentsBuilder Arguments { get; }
        protected override FulfillmentFulfillmentOrdersQueryBuilder Self => this;

        public FulfillmentFulfillmentOrdersQueryBuilder(string name) : base(new Query<FulfillmentOrderConnection>(name))
        {
            Arguments = new FulfillmentFulfillmentOrdersArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentFulfillmentOrdersQueryBuilder(IQuery<FulfillmentOrderConnection> query) : base(query)
        {
            Arguments = new FulfillmentFulfillmentOrdersArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentFulfillmentOrdersQueryBuilder SetArguments(Action<FulfillmentFulfillmentOrdersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentFulfillmentOrdersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderEdge>(query);
            return this;
        }

        public FulfillmentFulfillmentOrdersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentFulfillmentOrdersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}