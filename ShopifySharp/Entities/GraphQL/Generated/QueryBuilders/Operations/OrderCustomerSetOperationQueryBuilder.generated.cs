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
    public sealed class OrderCustomerSetOperationQueryBuilder : FieldsQueryBuilderBase<OrderCustomerSetPayload, OrderCustomerSetOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderCustomerSetPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderCustomerSetArgumentsBuilder Arguments { get; }
        protected override OrderCustomerSetOperationQueryBuilder Self => this;

        public OrderCustomerSetOperationQueryBuilder() : this("orderCustomerSet")
        {
        }

        public OrderCustomerSetOperationQueryBuilder(string name) : base(new Query<OrderCustomerSetPayload>(name))
        {
            Arguments = new OrderCustomerSetArgumentsBuilder(base.InnerQuery);
        }

        public OrderCustomerSetOperationQueryBuilder(IQuery<OrderCustomerSetPayload> query) : base(query)
        {
            Arguments = new OrderCustomerSetArgumentsBuilder(base.InnerQuery);
        }

        public OrderCustomerSetOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCustomerSetOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCustomerSetUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCustomerSetUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCustomerSetUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCustomerSetUserError>(query);
            return this;
        }
    }
}