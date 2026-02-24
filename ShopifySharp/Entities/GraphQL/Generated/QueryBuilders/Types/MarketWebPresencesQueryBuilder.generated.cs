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
    public sealed class MarketWebPresencesQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceConnection, MarketWebPresencesQueryBuilder>, IHasArguments<MarketWebPresencesArgumentsBuilder>
    {
        public MarketWebPresencesArgumentsBuilder Arguments { get; }
        protected override MarketWebPresencesQueryBuilder Self => this;

        public MarketWebPresencesQueryBuilder(string name) : base(new Query<MarketWebPresenceConnection>(name))
        {
            Arguments = new MarketWebPresencesArgumentsBuilder(base.InnerQuery);
        }

        public MarketWebPresencesQueryBuilder(IQuery<MarketWebPresenceConnection> query) : base(query)
        {
            Arguments = new MarketWebPresencesArgumentsBuilder(base.InnerQuery);
        }

        public MarketWebPresencesQueryBuilder SetArguments(Action<MarketWebPresencesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketWebPresencesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceEdge>(query);
            return this;
        }

        public MarketWebPresencesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public MarketWebPresencesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}