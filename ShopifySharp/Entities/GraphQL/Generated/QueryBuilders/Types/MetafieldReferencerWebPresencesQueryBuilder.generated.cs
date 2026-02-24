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
    public sealed class MetafieldReferencerWebPresencesQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceConnection, MetafieldReferencerWebPresencesQueryBuilder>, IHasArguments<MetafieldReferencerWebPresencesArgumentsBuilder>
    {
        public MetafieldReferencerWebPresencesArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerWebPresencesQueryBuilder Self => this;

        public MetafieldReferencerWebPresencesQueryBuilder(string name) : base(new Query<MarketWebPresenceConnection>(name))
        {
            Arguments = new MetafieldReferencerWebPresencesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerWebPresencesQueryBuilder(IQuery<MarketWebPresenceConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerWebPresencesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerWebPresencesQueryBuilder SetArguments(Action<MetafieldReferencerWebPresencesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerWebPresencesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceEdge>(query);
            return this;
        }

        public MetafieldReferencerWebPresencesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public MetafieldReferencerWebPresencesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}