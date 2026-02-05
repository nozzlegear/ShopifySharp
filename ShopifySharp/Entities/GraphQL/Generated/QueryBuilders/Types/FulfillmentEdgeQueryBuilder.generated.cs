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
    public sealed class FulfillmentEdgeQueryBuilder : FieldsQueryBuilderBase<FulfillmentEdge, FulfillmentEdgeQueryBuilder>
    {
        protected override FulfillmentEdgeQueryBuilder Self => this;

        public FulfillmentEdgeQueryBuilder() : this("fulfillmentEdge")
        {
        }

        public FulfillmentEdgeQueryBuilder(string name) : base(new Query<FulfillmentEdge>(name))
        {
        }

        public FulfillmentEdgeQueryBuilder(IQuery<FulfillmentEdge> query) : base(query)
        {
        }

        public FulfillmentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public FulfillmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }
    }
}