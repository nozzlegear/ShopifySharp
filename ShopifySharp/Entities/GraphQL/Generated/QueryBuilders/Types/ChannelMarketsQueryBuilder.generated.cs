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
    public sealed class ChannelMarketsQueryBuilder : FieldsQueryBuilderBase<MarketConnection, ChannelMarketsQueryBuilder>, IHasArguments<ChannelMarketsArgumentsBuilder>
    {
        public ChannelMarketsArgumentsBuilder Arguments { get; }
        protected override ChannelMarketsQueryBuilder Self => this;

        public ChannelMarketsQueryBuilder(string name) : base(new Query<MarketConnection>(name))
        {
            Arguments = new ChannelMarketsArgumentsBuilder(base.InnerQuery);
        }

        public ChannelMarketsQueryBuilder(IQuery<MarketConnection> query) : base(query)
        {
            Arguments = new ChannelMarketsArgumentsBuilder(base.InnerQuery);
        }

        public ChannelMarketsQueryBuilder SetArguments(Action<ChannelMarketsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ChannelMarketsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketEdgeQueryBuilder> build)
        {
            var query = new Query<MarketEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketEdge>(query);
            return this;
        }

        public ChannelMarketsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ChannelMarketsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}