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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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

        public WebPresencesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceEdge>(query);
            return this;
        }

        public WebPresencesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public WebPresencesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}