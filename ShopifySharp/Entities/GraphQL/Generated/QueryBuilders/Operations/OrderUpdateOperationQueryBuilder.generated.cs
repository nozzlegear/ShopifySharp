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
    public sealed class OrderUpdateOperationQueryBuilder : FieldsQueryBuilderBase<OrderUpdatePayload, OrderUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderUpdateArgumentsBuilder Arguments { get; }
        protected override OrderUpdateOperationQueryBuilder Self => this;

        public OrderUpdateOperationQueryBuilder() : this("orderUpdate")
        {
        }

        public OrderUpdateOperationQueryBuilder(string name) : base(new Query<OrderUpdatePayload>(name))
        {
            Arguments = new OrderUpdateArgumentsBuilder(base.InnerQuery);
        }

        public OrderUpdateOperationQueryBuilder(IQuery<OrderUpdatePayload> query) : base(query)
        {
            Arguments = new OrderUpdateArgumentsBuilder(base.InnerQuery);
        }

        public OrderUpdateOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}