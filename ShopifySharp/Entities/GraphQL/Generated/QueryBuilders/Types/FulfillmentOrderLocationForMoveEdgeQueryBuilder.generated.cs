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
    public sealed class FulfillmentOrderLocationForMoveEdgeQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLocationForMoveEdge, FulfillmentOrderLocationForMoveEdgeQueryBuilder>
    {
        protected override FulfillmentOrderLocationForMoveEdgeQueryBuilder Self => this;

        public FulfillmentOrderLocationForMoveEdgeQueryBuilder() : this("fulfillmentOrderLocationForMoveEdge")
        {
        }

        public FulfillmentOrderLocationForMoveEdgeQueryBuilder(string name) : base(new Query<FulfillmentOrderLocationForMoveEdge>(name))
        {
        }

        public FulfillmentOrderLocationForMoveEdgeQueryBuilder(IQuery<FulfillmentOrderLocationForMoveEdge> query) : base(query)
        {
        }

        public FulfillmentOrderLocationForMoveEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public FulfillmentOrderLocationForMoveEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLocationForMoveQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLocationForMove>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLocationForMoveQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLocationForMove>(query);
            return this;
        }
    }
}