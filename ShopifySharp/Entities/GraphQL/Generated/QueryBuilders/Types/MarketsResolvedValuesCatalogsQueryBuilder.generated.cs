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
    public sealed class MarketsResolvedValuesCatalogsQueryBuilder : FieldsQueryBuilderBase<MarketCatalogConnection, MarketsResolvedValuesCatalogsQueryBuilder>, IHasArguments<MarketsResolvedValuesCatalogsArgumentsBuilder>
    {
        public MarketsResolvedValuesCatalogsArgumentsBuilder Arguments { get; }
        protected override MarketsResolvedValuesCatalogsQueryBuilder Self => this;

        public MarketsResolvedValuesCatalogsQueryBuilder(string name) : base(new Query<MarketCatalogConnection>(name))
        {
            Arguments = new MarketsResolvedValuesCatalogsArgumentsBuilder(base.InnerQuery);
        }

        public MarketsResolvedValuesCatalogsQueryBuilder(IQuery<MarketCatalogConnection> query) : base(query)
        {
            Arguments = new MarketsResolvedValuesCatalogsArgumentsBuilder(base.InnerQuery);
        }

        public MarketsResolvedValuesCatalogsQueryBuilder SetArguments(Action<MarketsResolvedValuesCatalogsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketsResolvedValuesCatalogsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogEdgeQueryBuilder> build)
        {
            var query = new Query<MarketCatalogEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalogEdge>(query);
            return this;
        }

        public MarketsResolvedValuesCatalogsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder> build)
        {
            var query = new Query<MarketCatalog>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalog>(query);
            return this;
        }

        public MarketsResolvedValuesCatalogsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}