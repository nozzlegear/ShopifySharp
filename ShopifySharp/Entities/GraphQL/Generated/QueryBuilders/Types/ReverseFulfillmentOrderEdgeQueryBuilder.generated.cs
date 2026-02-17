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
    public sealed class ReverseFulfillmentOrderEdgeQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderEdge, ReverseFulfillmentOrderEdgeQueryBuilder>
    {
        protected override ReverseFulfillmentOrderEdgeQueryBuilder Self => this;

        public ReverseFulfillmentOrderEdgeQueryBuilder() : this("reverseFulfillmentOrderEdge")
        {
        }

        public ReverseFulfillmentOrderEdgeQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderEdge>(name))
        {
        }

        public ReverseFulfillmentOrderEdgeQueryBuilder(IQuery<ReverseFulfillmentOrderEdge> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReverseFulfillmentOrderEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrder>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrder>(query);
            return this;
        }
    }
}