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

        public ReverseFulfillmentOrderEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrder>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrder>(query);
            return this;
        }
    }
}