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
    public sealed class FulfillmentOrderEdgeQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderEdge, FulfillmentOrderEdgeQueryBuilder>
    {
        protected override FulfillmentOrderEdgeQueryBuilder Self => this;

        public FulfillmentOrderEdgeQueryBuilder() : this("fulfillmentOrderEdge")
        {
        }

        public FulfillmentOrderEdgeQueryBuilder(string name) : base(new Query<FulfillmentOrderEdge>(name))
        {
        }

        public FulfillmentOrderEdgeQueryBuilder(IQuery<FulfillmentOrderEdge> query) : base(query)
        {
        }

        public FulfillmentOrderEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public FulfillmentOrderEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }
    }
}