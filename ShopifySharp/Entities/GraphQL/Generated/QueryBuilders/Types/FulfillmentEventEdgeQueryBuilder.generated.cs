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
    public sealed class FulfillmentEventEdgeQueryBuilder : FieldsQueryBuilderBase<FulfillmentEventEdge, FulfillmentEventEdgeQueryBuilder>
    {
        protected override FulfillmentEventEdgeQueryBuilder Self => this;

        public FulfillmentEventEdgeQueryBuilder() : this("fulfillmentEventEdge")
        {
        }

        public FulfillmentEventEdgeQueryBuilder(string name) : base(new Query<FulfillmentEventEdge>(name))
        {
        }

        public FulfillmentEventEdgeQueryBuilder(IQuery<FulfillmentEventEdge> query) : base(query)
        {
        }

        public FulfillmentEventEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public FulfillmentEventEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventQueryBuilder> build)
        {
            var query = new Query<FulfillmentEvent>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEvent>(query);
            return this;
        }
    }
}