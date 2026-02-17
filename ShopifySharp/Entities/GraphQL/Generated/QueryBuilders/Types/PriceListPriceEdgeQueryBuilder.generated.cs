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
    public sealed class PriceListPriceEdgeQueryBuilder : FieldsQueryBuilderBase<PriceListPriceEdge, PriceListPriceEdgeQueryBuilder>
    {
        protected override PriceListPriceEdgeQueryBuilder Self => this;

        public PriceListPriceEdgeQueryBuilder() : this("priceListPriceEdge")
        {
        }

        public PriceListPriceEdgeQueryBuilder(string name) : base(new Query<PriceListPriceEdge>(name))
        {
        }

        public PriceListPriceEdgeQueryBuilder(IQuery<PriceListPriceEdge> query) : base(query)
        {
        }

        public PriceListPriceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PriceListPriceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder> build)
        {
            var query = new Query<PriceListPrice>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPrice>(query);
            return this;
        }
    }
}