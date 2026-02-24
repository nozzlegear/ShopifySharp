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
    public sealed class QueryRootMarketingEventsQueryBuilder : FieldsQueryBuilderBase<MarketingEventConnection, QueryRootMarketingEventsQueryBuilder>, IHasArguments<QueryRootMarketingEventsArgumentsBuilder>
    {
        public QueryRootMarketingEventsArgumentsBuilder Arguments { get; }
        protected override QueryRootMarketingEventsQueryBuilder Self => this;

        public QueryRootMarketingEventsQueryBuilder(string name) : base(new Query<MarketingEventConnection>(name))
        {
            Arguments = new QueryRootMarketingEventsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketingEventsQueryBuilder(IQuery<MarketingEventConnection> query) : base(query)
        {
            Arguments = new QueryRootMarketingEventsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketingEventsQueryBuilder SetArguments(Action<QueryRootMarketingEventsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMarketingEventsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventEdgeQueryBuilder> build)
        {
            var query = new Query<MarketingEventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEventEdge>(query);
            return this;
        }

        public QueryRootMarketingEventsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }

        public QueryRootMarketingEventsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}