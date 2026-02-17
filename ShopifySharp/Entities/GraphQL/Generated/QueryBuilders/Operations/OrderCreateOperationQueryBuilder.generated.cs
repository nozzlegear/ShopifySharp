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
    public sealed class OrderCreateOperationQueryBuilder : FieldsQueryBuilderBase<OrderCreatePayload, OrderCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderCreateArgumentsBuilder Arguments { get; }
        protected override OrderCreateOperationQueryBuilder Self => this;

        public OrderCreateOperationQueryBuilder() : this("orderCreate")
        {
        }

        public OrderCreateOperationQueryBuilder(string name) : base(new Query<OrderCreatePayload>(name))
        {
            Arguments = new OrderCreateArgumentsBuilder(base.InnerQuery);
        }

        public OrderCreateOperationQueryBuilder(IQuery<OrderCreatePayload> query) : base(query)
        {
            Arguments = new OrderCreateArgumentsBuilder(base.InnerQuery);
        }

        public OrderCreateOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCreateUserError>(query);
            return this;
        }
    }
}