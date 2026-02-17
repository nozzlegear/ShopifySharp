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
    public sealed class CashTrackingSessionConnectionQueryBuilder : FieldsQueryBuilderBase<CashTrackingSessionConnection, CashTrackingSessionConnectionQueryBuilder>
    {
        protected override CashTrackingSessionConnectionQueryBuilder Self => this;

        public CashTrackingSessionConnectionQueryBuilder() : this("cashTrackingSessionConnection")
        {
        }

        public CashTrackingSessionConnectionQueryBuilder(string name) : base(new Query<CashTrackingSessionConnection>(name))
        {
        }

        public CashTrackingSessionConnectionQueryBuilder(IQuery<CashTrackingSessionConnection> query) : base(query)
        {
        }

        public CashTrackingSessionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionEdgeQueryBuilder> build)
        {
            var query = new Query<CashTrackingSessionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSessionEdge>(query);
            return this;
        }

        public CashTrackingSessionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder> build)
        {
            var query = new Query<CashTrackingSession>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSession>(query);
            return this;
        }

        public CashTrackingSessionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}