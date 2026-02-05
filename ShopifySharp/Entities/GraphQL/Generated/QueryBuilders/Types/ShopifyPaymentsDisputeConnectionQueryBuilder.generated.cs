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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ShopifyPaymentsDisputeConnectionQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeConnection, ShopifyPaymentsDisputeConnectionQueryBuilder>
    {
        protected override ShopifyPaymentsDisputeConnectionQueryBuilder Self => this;

        public ShopifyPaymentsDisputeConnectionQueryBuilder() : this("shopifyPaymentsDisputeConnection")
        {
        }

        public ShopifyPaymentsDisputeConnectionQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeConnection>(name))
        {
        }

        public ShopifyPaymentsDisputeConnectionQueryBuilder(IQuery<ShopifyPaymentsDisputeConnection> query) : base(query)
        {
        }

        public ShopifyPaymentsDisputeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEdge>(query);
            return this;
        }

        public ShopifyPaymentsDisputeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDispute>(query);
            return this;
        }

        public ShopifyPaymentsDisputeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}