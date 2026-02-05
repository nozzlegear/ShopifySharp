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
    public sealed class FulfillmentOrderLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemEdge, FulfillmentOrderLineItemEdgeQueryBuilder>
    {
        protected override FulfillmentOrderLineItemEdgeQueryBuilder Self => this;

        public FulfillmentOrderLineItemEdgeQueryBuilder() : this("fulfillmentOrderLineItemEdge")
        {
        }

        public FulfillmentOrderLineItemEdgeQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemEdge>(name))
        {
        }

        public FulfillmentOrderLineItemEdgeQueryBuilder(IQuery<FulfillmentOrderLineItemEdge> query) : base(query)
        {
        }

        public FulfillmentOrderLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public FulfillmentOrderLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItem>(query);
            return this;
        }
    }
}