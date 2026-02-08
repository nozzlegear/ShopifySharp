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
    public sealed class ReverseFulfillmentOrderLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderLineItemEdge, ReverseFulfillmentOrderLineItemEdgeQueryBuilder>
    {
        protected override ReverseFulfillmentOrderLineItemEdgeQueryBuilder Self => this;

        public ReverseFulfillmentOrderLineItemEdgeQueryBuilder() : this("reverseFulfillmentOrderLineItemEdge")
        {
        }

        public ReverseFulfillmentOrderLineItemEdgeQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderLineItemEdge>(name))
        {
        }

        public ReverseFulfillmentOrderLineItemEdgeQueryBuilder(IQuery<ReverseFulfillmentOrderLineItemEdge> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReverseFulfillmentOrderLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItem>(query);
            return this;
        }
    }
}