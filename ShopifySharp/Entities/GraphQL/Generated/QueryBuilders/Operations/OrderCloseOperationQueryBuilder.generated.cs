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
    public sealed class OrderCloseOperationQueryBuilder : FieldsQueryBuilderBase<OrderClosePayload, OrderCloseOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderClosePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderCloseArgumentsBuilder Arguments { get; }
        protected override OrderCloseOperationQueryBuilder Self => this;

        public OrderCloseOperationQueryBuilder() : this("orderClose")
        {
        }

        public OrderCloseOperationQueryBuilder(string name) : base(new Query<OrderClosePayload>(name))
        {
            Arguments = new OrderCloseArgumentsBuilder(base.InnerQuery);
        }

        public OrderCloseOperationQueryBuilder(IQuery<OrderClosePayload> query) : base(query)
        {
            Arguments = new OrderCloseArgumentsBuilder(base.InnerQuery);
        }

        public OrderCloseOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCloseOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}