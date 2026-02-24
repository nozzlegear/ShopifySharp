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
    public sealed class MarketingEventConnectionQueryBuilder : FieldsQueryBuilderBase<MarketingEventConnection, MarketingEventConnectionQueryBuilder>, IHasArguments<MarketingEventConnectionArgumentsBuilder>
    {
        public MarketingEventConnectionArgumentsBuilder Arguments { get; }
        protected override MarketingEventConnectionQueryBuilder Self => this;

        public MarketingEventConnectionQueryBuilder() : this("marketingEventConnection")
        {
        }

        public MarketingEventConnectionQueryBuilder(string name) : base(new Query<MarketingEventConnection>(name))
        {
            Arguments = new MarketingEventConnectionArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEventConnectionQueryBuilder(IQuery<MarketingEventConnection> query) : base(query)
        {
            Arguments = new MarketingEventConnectionArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEventConnectionQueryBuilder SetArguments(Action<MarketingEventConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketingEventConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventEdgeQueryBuilder> build)
        {
            var query = new Query<MarketingEventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEventEdge>(query);
            return this;
        }

        public MarketingEventConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }

        public MarketingEventConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}