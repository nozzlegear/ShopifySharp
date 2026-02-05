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
    public sealed class OrderOpenOperationQueryBuilder : FieldsQueryBuilderBase<OrderOpenPayload, OrderOpenOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderOpenPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderOpenArgumentsBuilder Arguments { get; }
        protected override OrderOpenOperationQueryBuilder Self => this;

        public OrderOpenOperationQueryBuilder() : this("orderOpen")
        {
        }

        public OrderOpenOperationQueryBuilder(string name) : base(new Query<OrderOpenPayload>(name))
        {
            Arguments = new OrderOpenArgumentsBuilder(base.InnerQuery);
        }

        public OrderOpenOperationQueryBuilder(IQuery<OrderOpenPayload> query) : base(query)
        {
            Arguments = new OrderOpenArgumentsBuilder(base.InnerQuery);
        }

        public OrderOpenOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderOpenOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}