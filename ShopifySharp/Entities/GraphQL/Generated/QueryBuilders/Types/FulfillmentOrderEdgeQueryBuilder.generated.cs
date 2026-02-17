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

        public FulfillmentOrderEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }
    }
}