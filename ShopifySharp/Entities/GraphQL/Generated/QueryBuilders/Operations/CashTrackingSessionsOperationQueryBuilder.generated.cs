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
    public sealed class CashTrackingSessionsOperationQueryBuilder : FieldsQueryBuilderBase<CashTrackingSessionConnection, CashTrackingSessionsOperationQueryBuilder>, IGraphOperationQueryBuilder<CashTrackingSessionConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CashTrackingSessionsArgumentsBuilder Arguments { get; }
        protected override CashTrackingSessionsOperationQueryBuilder Self => this;

        public CashTrackingSessionsOperationQueryBuilder() : this("cashTrackingSessions")
        {
        }

        public CashTrackingSessionsOperationQueryBuilder(string name) : base(new Query<CashTrackingSessionConnection>(name))
        {
            Arguments = new CashTrackingSessionsArgumentsBuilder(base.InnerQuery);
        }

        public CashTrackingSessionsOperationQueryBuilder(IQuery<CashTrackingSessionConnection> query) : base(query)
        {
            Arguments = new CashTrackingSessionsArgumentsBuilder(base.InnerQuery);
        }

        public CashTrackingSessionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionEdgeQueryBuilder> build)
        {
            var query = new Query<CashTrackingSessionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSessionEdge>(query);
            return this;
        }

        public CashTrackingSessionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder> build)
        {
            var query = new Query<CashTrackingSession>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSession>(query);
            return this;
        }

        public CashTrackingSessionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}