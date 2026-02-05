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
    public sealed class ReverseFulfillmentOrderConnectionQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderConnection, ReverseFulfillmentOrderConnectionQueryBuilder>
    {
        protected override ReverseFulfillmentOrderConnectionQueryBuilder Self => this;

        public ReverseFulfillmentOrderConnectionQueryBuilder() : this("reverseFulfillmentOrderConnection")
        {
        }

        public ReverseFulfillmentOrderConnectionQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderConnection>(name))
        {
        }

        public ReverseFulfillmentOrderConnectionQueryBuilder(IQuery<ReverseFulfillmentOrderConnection> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderEdgeQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderEdge>(query);
            return this;
        }

        public ReverseFulfillmentOrderConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrder>(query);
            return this;
        }

        public ReverseFulfillmentOrderConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}