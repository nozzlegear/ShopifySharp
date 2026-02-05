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

        public OrderCloseOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCloseOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}