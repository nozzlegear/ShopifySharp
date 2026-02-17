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
    public sealed class PriceListEdgeQueryBuilder : FieldsQueryBuilderBase<PriceListEdge, PriceListEdgeQueryBuilder>
    {
        protected override PriceListEdgeQueryBuilder Self => this;

        public PriceListEdgeQueryBuilder() : this("priceListEdge")
        {
        }

        public PriceListEdgeQueryBuilder(string name) : base(new Query<PriceListEdge>(name))
        {
        }

        public PriceListEdgeQueryBuilder(IQuery<PriceListEdge> query) : base(query)
        {
        }

        public PriceListEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PriceListEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }
    }
}