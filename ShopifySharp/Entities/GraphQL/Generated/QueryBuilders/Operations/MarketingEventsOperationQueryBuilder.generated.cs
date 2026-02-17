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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class MarketingEventsOperationQueryBuilder : FieldsQueryBuilderBase<MarketingEventConnection, MarketingEventsOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingEventConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketingEventsArgumentsBuilder Arguments { get; }
        protected override MarketingEventsOperationQueryBuilder Self => this;

        public MarketingEventsOperationQueryBuilder() : this("marketingEvents")
        {
        }

        public MarketingEventsOperationQueryBuilder(string name) : base(new Query<MarketingEventConnection>(name))
        {
            Arguments = new MarketingEventsArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEventsOperationQueryBuilder(IQuery<MarketingEventConnection> query) : base(query)
        {
            Arguments = new MarketingEventsArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEventsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventEdgeQueryBuilder> build)
        {
            var query = new Query<MarketingEventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEventEdge>(query);
            return this;
        }

        public MarketingEventsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }

        public MarketingEventsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}