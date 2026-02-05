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
    public sealed class OrderMarkAsPaidOperationQueryBuilder : FieldsQueryBuilderBase<OrderMarkAsPaidPayload, OrderMarkAsPaidOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderMarkAsPaidPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderMarkAsPaidArgumentsBuilder Arguments { get; }
        protected override OrderMarkAsPaidOperationQueryBuilder Self => this;

        public OrderMarkAsPaidOperationQueryBuilder() : this("orderMarkAsPaid")
        {
        }

        public OrderMarkAsPaidOperationQueryBuilder(string name) : base(new Query<OrderMarkAsPaidPayload>(name))
        {
            Arguments = new OrderMarkAsPaidArgumentsBuilder(base.InnerQuery);
        }

        public OrderMarkAsPaidOperationQueryBuilder(IQuery<OrderMarkAsPaidPayload> query) : base(query)
        {
            Arguments = new OrderMarkAsPaidArgumentsBuilder(base.InnerQuery);
        }

        public OrderMarkAsPaidOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderMarkAsPaidOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}