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
    public sealed class QuantityPriceBreakEdgeQueryBuilder : FieldsQueryBuilderBase<QuantityPriceBreakEdge, QuantityPriceBreakEdgeQueryBuilder>
    {
        protected override QuantityPriceBreakEdgeQueryBuilder Self => this;

        public QuantityPriceBreakEdgeQueryBuilder() : this("quantityPriceBreakEdge")
        {
        }

        public QuantityPriceBreakEdgeQueryBuilder(string name) : base(new Query<QuantityPriceBreakEdge>(name))
        {
        }

        public QuantityPriceBreakEdgeQueryBuilder(IQuery<QuantityPriceBreakEdge> query) : base(query)
        {
        }

        public QuantityPriceBreakEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public QuantityPriceBreakEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityPriceBreakQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreak>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityPriceBreakQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreak>(query);
            return this;
        }
    }
}