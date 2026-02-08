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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class OrderCancelOperationQueryBuilder : FieldsQueryBuilderBase<OrderCancelPayload, OrderCancelOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderCancelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderCancelArgumentsBuilder Arguments { get; }
        protected override OrderCancelOperationQueryBuilder Self => this;

        public OrderCancelOperationQueryBuilder() : this("orderCancel")
        {
        }

        public OrderCancelOperationQueryBuilder(string name) : base(new Query<OrderCancelPayload>(name))
        {
            Arguments = new OrderCancelArgumentsBuilder(base.InnerQuery);
        }

        public OrderCancelOperationQueryBuilder(IQuery<OrderCancelPayload> query) : base(query)
        {
            Arguments = new OrderCancelArgumentsBuilder(base.InnerQuery);
        }

        public OrderCancelOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public OrderCancelOperationQueryBuilder OrderCancelUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancelUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCancelUserError>("orderCancelUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCancelUserError>(query);
            return this;
        }

        public OrderCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}