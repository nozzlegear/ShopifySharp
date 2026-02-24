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
    public sealed class FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderConnection, FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder>, IHasArguments<FulfillmentOrderFulfillmentOrdersForMergeArgumentsBuilder>
    {
        public FulfillmentOrderFulfillmentOrdersForMergeArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder Self => this;

        public FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder(string name) : base(new Query<FulfillmentOrderConnection>(name))
        {
            Arguments = new FulfillmentOrderFulfillmentOrdersForMergeArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder(IQuery<FulfillmentOrderConnection> query) : base(query)
        {
            Arguments = new FulfillmentOrderFulfillmentOrdersForMergeArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder SetArguments(Action<FulfillmentOrderFulfillmentOrdersForMergeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderEdge>(query);
            return this;
        }

        public FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderFulfillmentOrdersForMergeQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}