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
    public sealed class MarketWebPresenceEdgeQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceEdge, MarketWebPresenceEdgeQueryBuilder>
    {
        protected override MarketWebPresenceEdgeQueryBuilder Self => this;

        public MarketWebPresenceEdgeQueryBuilder() : this("marketWebPresenceEdge")
        {
        }

        public MarketWebPresenceEdgeQueryBuilder(string name) : base(new Query<MarketWebPresenceEdge>(name))
        {
        }

        public MarketWebPresenceEdgeQueryBuilder(IQuery<MarketWebPresenceEdge> query) : base(query)
        {
        }

        public MarketWebPresenceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MarketWebPresenceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }
    }
}