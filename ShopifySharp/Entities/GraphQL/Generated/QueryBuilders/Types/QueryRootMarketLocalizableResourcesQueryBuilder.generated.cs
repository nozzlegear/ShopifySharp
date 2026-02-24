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
    public sealed class QueryRootMarketLocalizableResourcesQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableResourceConnection, QueryRootMarketLocalizableResourcesQueryBuilder>, IHasArguments<QueryRootMarketLocalizableResourcesArgumentsBuilder>
    {
        public QueryRootMarketLocalizableResourcesArgumentsBuilder Arguments { get; }
        protected override QueryRootMarketLocalizableResourcesQueryBuilder Self => this;

        public QueryRootMarketLocalizableResourcesQueryBuilder(string name) : base(new Query<MarketLocalizableResourceConnection>(name))
        {
            Arguments = new QueryRootMarketLocalizableResourcesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketLocalizableResourcesQueryBuilder(IQuery<MarketLocalizableResourceConnection> query) : base(query)
        {
            Arguments = new QueryRootMarketLocalizableResourcesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketLocalizableResourcesQueryBuilder SetArguments(Action<QueryRootMarketLocalizableResourcesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMarketLocalizableResourcesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResourceEdge>(query);
            return this;
        }

        public QueryRootMarketLocalizableResourcesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResource>(query);
            return this;
        }

        public QueryRootMarketLocalizableResourcesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}