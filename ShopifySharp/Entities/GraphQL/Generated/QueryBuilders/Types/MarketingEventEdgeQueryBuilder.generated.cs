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
    public sealed class MarketingEventEdgeQueryBuilder : FieldsQueryBuilderBase<MarketingEventEdge, MarketingEventEdgeQueryBuilder>
    {
        protected override MarketingEventEdgeQueryBuilder Self => this;

        public MarketingEventEdgeQueryBuilder() : this("marketingEventEdge")
        {
        }

        public MarketingEventEdgeQueryBuilder(string name) : base(new Query<MarketingEventEdge>(name))
        {
        }

        public MarketingEventEdgeQueryBuilder(IQuery<MarketingEventEdge> query) : base(query)
        {
        }

        public MarketingEventEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MarketingEventEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }
    }
}