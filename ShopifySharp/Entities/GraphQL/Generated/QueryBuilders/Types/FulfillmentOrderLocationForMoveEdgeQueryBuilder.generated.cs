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

        public FulfillmentOrderLocationForMoveEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLocationForMoveQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLocationForMove>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLocationForMoveQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLocationForMove>(query);
            return this;
        }
    }
}