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
    public sealed class MetafieldReferencerRegionsQueryBuilder : FieldsQueryBuilderBase<MarketRegionConnection, MetafieldReferencerRegionsQueryBuilder>, IHasArguments<MetafieldReferencerRegionsArgumentsBuilder>
    {
        public MetafieldReferencerRegionsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerRegionsQueryBuilder Self => this;

        public MetafieldReferencerRegionsQueryBuilder(string name) : base(new Query<MarketRegionConnection>(name))
        {
            Arguments = new MetafieldReferencerRegionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRegionsQueryBuilder(IQuery<MarketRegionConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerRegionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRegionsQueryBuilder SetArguments(Action<MetafieldReferencerRegionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerRegionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionEdgeQueryBuilder> build)
        {
            var query = new Query<MarketRegionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketRegionEdge>(query);
            return this;
        }

        public MetafieldReferencerRegionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionQueryBuilder> build)
        {
            var query = new Query<IMarketRegion>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMarketRegion>(query);
            return this;
        }

        public MetafieldReferencerRegionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}