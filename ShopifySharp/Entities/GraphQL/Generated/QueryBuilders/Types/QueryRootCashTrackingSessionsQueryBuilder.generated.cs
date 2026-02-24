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
    public sealed class QueryRootCashTrackingSessionsQueryBuilder : FieldsQueryBuilderBase<CashTrackingSessionConnection, QueryRootCashTrackingSessionsQueryBuilder>, IHasArguments<QueryRootCashTrackingSessionsArgumentsBuilder>
    {
        public QueryRootCashTrackingSessionsArgumentsBuilder Arguments { get; }
        protected override QueryRootCashTrackingSessionsQueryBuilder Self => this;

        public QueryRootCashTrackingSessionsQueryBuilder(string name) : base(new Query<CashTrackingSessionConnection>(name))
        {
            Arguments = new QueryRootCashTrackingSessionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashTrackingSessionsQueryBuilder(IQuery<CashTrackingSessionConnection> query) : base(query)
        {
            Arguments = new QueryRootCashTrackingSessionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashTrackingSessionsQueryBuilder SetArguments(Action<QueryRootCashTrackingSessionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCashTrackingSessionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionEdgeQueryBuilder> build)
        {
            var query = new Query<CashTrackingSessionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSessionEdge>(query);
            return this;
        }

        public QueryRootCashTrackingSessionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder> build)
        {
            var query = new Query<CashTrackingSession>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSession>(query);
            return this;
        }

        public QueryRootCashTrackingSessionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}