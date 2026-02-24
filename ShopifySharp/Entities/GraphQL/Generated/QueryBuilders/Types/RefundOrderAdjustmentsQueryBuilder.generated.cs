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
    public sealed class RefundOrderAdjustmentsQueryBuilder : FieldsQueryBuilderBase<OrderAdjustmentConnection, RefundOrderAdjustmentsQueryBuilder>, IHasArguments<RefundOrderAdjustmentsArgumentsBuilder>
    {
        public RefundOrderAdjustmentsArgumentsBuilder Arguments { get; }
        protected override RefundOrderAdjustmentsQueryBuilder Self => this;

        public RefundOrderAdjustmentsQueryBuilder(string name) : base(new Query<OrderAdjustmentConnection>(name))
        {
            Arguments = new RefundOrderAdjustmentsArgumentsBuilder(base.InnerQuery);
        }

        public RefundOrderAdjustmentsQueryBuilder(IQuery<OrderAdjustmentConnection> query) : base(query)
        {
            Arguments = new RefundOrderAdjustmentsArgumentsBuilder(base.InnerQuery);
        }

        public RefundOrderAdjustmentsQueryBuilder SetArguments(Action<RefundOrderAdjustmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public RefundOrderAdjustmentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentEdgeQueryBuilder> build)
        {
            var query = new Query<OrderAdjustmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAdjustmentEdge>(query);
            return this;
        }

        public RefundOrderAdjustmentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentQueryBuilder> build)
        {
            var query = new Query<OrderAdjustment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAdjustment>(query);
            return this;
        }

        public RefundOrderAdjustmentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}