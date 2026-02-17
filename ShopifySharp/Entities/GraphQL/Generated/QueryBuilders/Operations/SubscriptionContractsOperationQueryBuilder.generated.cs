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
    public sealed class SubscriptionContractsOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractConnection, SubscriptionContractsOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SubscriptionContractsArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractsOperationQueryBuilder Self => this;

        public SubscriptionContractsOperationQueryBuilder() : this("subscriptionContracts")
        {
        }

        public SubscriptionContractsOperationQueryBuilder(string name) : base(new Query<SubscriptionContractConnection>(name))
        {
            Arguments = new SubscriptionContractsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractsOperationQueryBuilder(IQuery<SubscriptionContractConnection> query) : base(query)
        {
            Arguments = new SubscriptionContractsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractEdge>(query);
            return this;
        }

        public SubscriptionContractsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}