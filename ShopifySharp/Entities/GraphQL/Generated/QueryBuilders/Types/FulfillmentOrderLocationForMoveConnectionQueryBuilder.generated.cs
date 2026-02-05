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
    public sealed class FulfillmentOrderLocationForMoveConnectionQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLocationForMoveConnection, FulfillmentOrderLocationForMoveConnectionQueryBuilder>
    {
        protected override FulfillmentOrderLocationForMoveConnectionQueryBuilder Self => this;

        public FulfillmentOrderLocationForMoveConnectionQueryBuilder() : this("fulfillmentOrderLocationForMoveConnection")
        {
        }

        public FulfillmentOrderLocationForMoveConnectionQueryBuilder(string name) : base(new Query<FulfillmentOrderLocationForMoveConnection>(name))
        {
        }

        public FulfillmentOrderLocationForMoveConnectionQueryBuilder(IQuery<FulfillmentOrderLocationForMoveConnection> query) : base(query)
        {
        }

        public FulfillmentOrderLocationForMoveConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLocationForMoveEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLocationForMoveEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLocationForMoveEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLocationForMoveEdge>(query);
            return this;
        }

        public FulfillmentOrderLocationForMoveConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLocationForMoveQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLocationForMove>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLocationForMoveQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLocationForMove>(query);
            return this;
        }

        public FulfillmentOrderLocationForMoveConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}