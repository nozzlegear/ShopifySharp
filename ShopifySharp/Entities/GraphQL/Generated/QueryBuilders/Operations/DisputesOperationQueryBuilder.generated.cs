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
    public sealed class DisputesOperationQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeConnection, DisputesOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopifyPaymentsDisputeConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DisputesArgumentsBuilder Arguments { get; }
        protected override DisputesOperationQueryBuilder Self => this;

        public DisputesOperationQueryBuilder() : this("disputes")
        {
        }

        public DisputesOperationQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeConnection>(name))
        {
            Arguments = new DisputesArgumentsBuilder(base.InnerQuery);
        }

        public DisputesOperationQueryBuilder(IQuery<ShopifyPaymentsDisputeConnection> query) : base(query)
        {
            Arguments = new DisputesArgumentsBuilder(base.InnerQuery);
        }

        public DisputesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEdge>(query);
            return this;
        }

        public DisputesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDispute>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDispute>(query);
            return this;
        }

        public DisputesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}