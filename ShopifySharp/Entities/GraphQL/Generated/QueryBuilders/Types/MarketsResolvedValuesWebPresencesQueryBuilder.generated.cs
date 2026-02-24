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
    public sealed class MarketsResolvedValuesWebPresencesQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceConnection, MarketsResolvedValuesWebPresencesQueryBuilder>, IHasArguments<MarketsResolvedValuesWebPresencesArgumentsBuilder>
    {
        public MarketsResolvedValuesWebPresencesArgumentsBuilder Arguments { get; }
        protected override MarketsResolvedValuesWebPresencesQueryBuilder Self => this;

        public MarketsResolvedValuesWebPresencesQueryBuilder(string name) : base(new Query<MarketWebPresenceConnection>(name))
        {
            Arguments = new MarketsResolvedValuesWebPresencesArgumentsBuilder(base.InnerQuery);
        }

        public MarketsResolvedValuesWebPresencesQueryBuilder(IQuery<MarketWebPresenceConnection> query) : base(query)
        {
            Arguments = new MarketsResolvedValuesWebPresencesArgumentsBuilder(base.InnerQuery);
        }

        public MarketsResolvedValuesWebPresencesQueryBuilder SetArguments(Action<MarketsResolvedValuesWebPresencesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketsResolvedValuesWebPresencesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceEdge>(query);
            return this;
        }

        public MarketsResolvedValuesWebPresencesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public MarketsResolvedValuesWebPresencesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}