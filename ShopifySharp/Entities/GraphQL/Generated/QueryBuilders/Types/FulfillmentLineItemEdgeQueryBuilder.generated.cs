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
    public sealed class FulfillmentLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<FulfillmentLineItemEdge, FulfillmentLineItemEdgeQueryBuilder>
    {
        protected override FulfillmentLineItemEdgeQueryBuilder Self => this;

        public FulfillmentLineItemEdgeQueryBuilder() : this("fulfillmentLineItemEdge")
        {
        }

        public FulfillmentLineItemEdgeQueryBuilder(string name) : base(new Query<FulfillmentLineItemEdge>(name))
        {
        }

        public FulfillmentLineItemEdgeQueryBuilder(IQuery<FulfillmentLineItemEdge> query) : base(query)
        {
        }

        public FulfillmentLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public FulfillmentLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItem>(query);
            return this;
        }
    }
}