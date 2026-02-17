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
    public sealed class CashTrackingAdjustmentEdgeQueryBuilder : FieldsQueryBuilderBase<CashTrackingAdjustmentEdge, CashTrackingAdjustmentEdgeQueryBuilder>
    {
        protected override CashTrackingAdjustmentEdgeQueryBuilder Self => this;

        public CashTrackingAdjustmentEdgeQueryBuilder() : this("cashTrackingAdjustmentEdge")
        {
        }

        public CashTrackingAdjustmentEdgeQueryBuilder(string name) : base(new Query<CashTrackingAdjustmentEdge>(name))
        {
        }

        public CashTrackingAdjustmentEdgeQueryBuilder(IQuery<CashTrackingAdjustmentEdge> query) : base(query)
        {
        }

        public CashTrackingAdjustmentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CashTrackingAdjustmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentQueryBuilder> build)
        {
            var query = new Query<CashTrackingAdjustment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingAdjustment>(query);
            return this;
        }
    }
}