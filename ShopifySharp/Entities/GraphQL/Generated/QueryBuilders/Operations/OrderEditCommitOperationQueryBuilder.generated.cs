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
    public sealed class OrderEditCommitOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditCommitPayload, OrderEditCommitOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditCommitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditCommitArgumentsBuilder Arguments { get; }
        protected override OrderEditCommitOperationQueryBuilder Self => this;

        public OrderEditCommitOperationQueryBuilder() : this("orderEditCommit")
        {
        }

        public OrderEditCommitOperationQueryBuilder(string name) : base(new Query<OrderEditCommitPayload>(name))
        {
            Arguments = new OrderEditCommitArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditCommitOperationQueryBuilder(IQuery<OrderEditCommitPayload> query) : base(query)
        {
            Arguments = new OrderEditCommitArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditCommitOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderEditCommitOperationQueryBuilder SuccessMessages()
        {
            base.InnerQuery.AddField("successMessages");
            return this;
        }

        public OrderEditCommitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}