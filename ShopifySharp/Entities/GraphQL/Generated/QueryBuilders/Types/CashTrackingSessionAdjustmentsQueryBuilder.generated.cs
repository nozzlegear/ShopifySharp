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
    public sealed class CashTrackingSessionAdjustmentsQueryBuilder : FieldsQueryBuilderBase<CashTrackingAdjustmentConnection, CashTrackingSessionAdjustmentsQueryBuilder>, IHasArguments<CashTrackingSessionAdjustmentsArgumentsBuilder>
    {
        public CashTrackingSessionAdjustmentsArgumentsBuilder Arguments { get; }
        protected override CashTrackingSessionAdjustmentsQueryBuilder Self => this;

        public CashTrackingSessionAdjustmentsQueryBuilder(string name) : base(new Query<CashTrackingAdjustmentConnection>(name))
        {
            Arguments = new CashTrackingSessionAdjustmentsArgumentsBuilder(base.InnerQuery);
        }

        public CashTrackingSessionAdjustmentsQueryBuilder(IQuery<CashTrackingAdjustmentConnection> query) : base(query)
        {
            Arguments = new CashTrackingSessionAdjustmentsArgumentsBuilder(base.InnerQuery);
        }

        public CashTrackingSessionAdjustmentsQueryBuilder SetArguments(Action<CashTrackingSessionAdjustmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashTrackingSessionAdjustmentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentEdgeQueryBuilder> build)
        {
            var query = new Query<CashTrackingAdjustmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingAdjustmentEdge>(query);
            return this;
        }

        public CashTrackingSessionAdjustmentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentQueryBuilder> build)
        {
            var query = new Query<CashTrackingAdjustment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingAdjustment>(query);
            return this;
        }

        public CashTrackingSessionAdjustmentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}