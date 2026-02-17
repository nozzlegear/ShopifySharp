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
    public sealed class CashTrackingAdjustmentConnectionQueryBuilder : FieldsQueryBuilderBase<CashTrackingAdjustmentConnection, CashTrackingAdjustmentConnectionQueryBuilder>
    {
        protected override CashTrackingAdjustmentConnectionQueryBuilder Self => this;

        public CashTrackingAdjustmentConnectionQueryBuilder() : this("cashTrackingAdjustmentConnection")
        {
        }

        public CashTrackingAdjustmentConnectionQueryBuilder(string name) : base(new Query<CashTrackingAdjustmentConnection>(name))
        {
        }

        public CashTrackingAdjustmentConnectionQueryBuilder(IQuery<CashTrackingAdjustmentConnection> query) : base(query)
        {
        }

        public CashTrackingAdjustmentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentEdgeQueryBuilder> build)
        {
            var query = new Query<CashTrackingAdjustmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingAdjustmentEdge>(query);
            return this;
        }

        public CashTrackingAdjustmentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentQueryBuilder> build)
        {
            var query = new Query<CashTrackingAdjustment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingAdjustment>(query);
            return this;
        }

        public CashTrackingAdjustmentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}