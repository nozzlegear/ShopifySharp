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
    public sealed class WebPresencesOperationQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceConnection, WebPresencesOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketWebPresenceConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public WebPresencesArgumentsBuilder Arguments { get; }
        protected override WebPresencesOperationQueryBuilder Self => this;

        public WebPresencesOperationQueryBuilder() : this("webPresences")
        {
        }

        public WebPresencesOperationQueryBuilder(string name) : base(new Query<MarketWebPresenceConnection>(name))
        {
            Arguments = new WebPresencesArgumentsBuilder(base.InnerQuery);
        }

        public WebPresencesOperationQueryBuilder(IQuery<MarketWebPresenceConnection> query) : base(query)
        {
            Arguments = new WebPresencesArgumentsBuilder(base.InnerQuery);
        }

        public WebPresencesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceEdge>(query);
            return this;
        }

        public WebPresencesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public WebPresencesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}