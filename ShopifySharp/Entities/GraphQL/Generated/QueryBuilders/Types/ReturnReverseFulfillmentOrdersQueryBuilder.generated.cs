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
    public sealed class ReturnReverseFulfillmentOrdersQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderConnection, ReturnReverseFulfillmentOrdersQueryBuilder>, IHasArguments<ReturnReverseFulfillmentOrdersArgumentsBuilder>
    {
        public ReturnReverseFulfillmentOrdersArgumentsBuilder Arguments { get; }
        protected override ReturnReverseFulfillmentOrdersQueryBuilder Self => this;

        public ReturnReverseFulfillmentOrdersQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderConnection>(name))
        {
            Arguments = new ReturnReverseFulfillmentOrdersArgumentsBuilder(base.InnerQuery);
        }

        public ReturnReverseFulfillmentOrdersQueryBuilder(IQuery<ReverseFulfillmentOrderConnection> query) : base(query)
        {
            Arguments = new ReturnReverseFulfillmentOrdersArgumentsBuilder(base.InnerQuery);
        }

        public ReturnReverseFulfillmentOrdersQueryBuilder SetArguments(Action<ReturnReverseFulfillmentOrdersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ReturnReverseFulfillmentOrdersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderEdgeQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderEdge>(query);
            return this;
        }

        public ReturnReverseFulfillmentOrdersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrder>(query);
            return this;
        }

        public ReturnReverseFulfillmentOrdersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}