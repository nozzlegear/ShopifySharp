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
    public sealed class MarketCatalogConnectionQueryBuilder : FieldsQueryBuilderBase<MarketCatalogConnection, MarketCatalogConnectionQueryBuilder>
    {
        protected override MarketCatalogConnectionQueryBuilder Self => this;

        public MarketCatalogConnectionQueryBuilder() : this("marketCatalogConnection")
        {
        }

        public MarketCatalogConnectionQueryBuilder(string name) : base(new Query<MarketCatalogConnection>(name))
        {
        }

        public MarketCatalogConnectionQueryBuilder(IQuery<MarketCatalogConnection> query) : base(query)
        {
        }

        public MarketCatalogConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCatalogEdgeQueryBuilder> build)
        {
            var query = new Query<MarketCatalogEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCatalogEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalogEdge>(query);
            return this;
        }

        public MarketCatalogConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCatalogQueryBuilder> build)
        {
            var query = new Query<MarketCatalog>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalog>(query);
            return this;
        }

        public MarketCatalogConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}