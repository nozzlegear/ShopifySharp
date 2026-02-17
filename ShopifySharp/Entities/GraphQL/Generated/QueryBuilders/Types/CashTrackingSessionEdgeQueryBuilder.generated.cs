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
    public sealed class CashTrackingSessionEdgeQueryBuilder : FieldsQueryBuilderBase<CashTrackingSessionEdge, CashTrackingSessionEdgeQueryBuilder>
    {
        protected override CashTrackingSessionEdgeQueryBuilder Self => this;

        public CashTrackingSessionEdgeQueryBuilder() : this("cashTrackingSessionEdge")
        {
        }

        public CashTrackingSessionEdgeQueryBuilder(string name) : base(new Query<CashTrackingSessionEdge>(name))
        {
        }

        public CashTrackingSessionEdgeQueryBuilder(IQuery<CashTrackingSessionEdge> query) : base(query)
        {
        }

        public CashTrackingSessionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CashTrackingSessionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder> build)
        {
            var query = new Query<CashTrackingSession>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingSession>(query);
            return this;
        }
    }
}