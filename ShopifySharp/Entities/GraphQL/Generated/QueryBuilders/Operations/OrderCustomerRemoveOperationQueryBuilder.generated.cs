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
    public sealed class OrderCustomerRemoveOperationQueryBuilder : FieldsQueryBuilderBase<OrderCustomerRemovePayload, OrderCustomerRemoveOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderCustomerRemovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderCustomerRemoveArgumentsBuilder Arguments { get; }
        protected override OrderCustomerRemoveOperationQueryBuilder Self => this;

        public OrderCustomerRemoveOperationQueryBuilder() : this("orderCustomerRemove")
        {
        }

        public OrderCustomerRemoveOperationQueryBuilder(string name) : base(new Query<OrderCustomerRemovePayload>(name))
        {
            Arguments = new OrderCustomerRemoveArgumentsBuilder(base.InnerQuery);
        }

        public OrderCustomerRemoveOperationQueryBuilder(IQuery<OrderCustomerRemovePayload> query) : base(query)
        {
            Arguments = new OrderCustomerRemoveArgumentsBuilder(base.InnerQuery);
        }

        public OrderCustomerRemoveOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCustomerRemoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderCustomerRemoveUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCustomerRemoveUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderCustomerRemoveUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCustomerRemoveUserError>(query);
            return this;
        }
    }
}