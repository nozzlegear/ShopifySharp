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
    public sealed class MarketCatalogEdgeQueryBuilder : FieldsQueryBuilderBase<MarketCatalogEdge, MarketCatalogEdgeQueryBuilder>
    {
        protected override MarketCatalogEdgeQueryBuilder Self => this;

        public MarketCatalogEdgeQueryBuilder() : this("marketCatalogEdge")
        {
        }

        public MarketCatalogEdgeQueryBuilder(string name) : base(new Query<MarketCatalogEdge>(name))
        {
        }

        public MarketCatalogEdgeQueryBuilder(IQuery<MarketCatalogEdge> query) : base(query)
        {
        }

        public MarketCatalogEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MarketCatalogEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCatalogQueryBuilder> build)
        {
            var query = new Query<MarketCatalog>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalog>(query);
            return this;
        }
    }
}