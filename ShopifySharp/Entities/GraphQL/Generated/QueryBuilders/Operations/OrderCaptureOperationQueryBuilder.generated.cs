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
    public sealed class OrderCaptureOperationQueryBuilder : FieldsQueryBuilderBase<OrderCapturePayload, OrderCaptureOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderCapturePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderCaptureArgumentsBuilder Arguments { get; }
        protected override OrderCaptureOperationQueryBuilder Self => this;

        public OrderCaptureOperationQueryBuilder() : this("orderCapture")
        {
        }

        public OrderCaptureOperationQueryBuilder(string name) : base(new Query<OrderCapturePayload>(name))
        {
            Arguments = new OrderCaptureArgumentsBuilder(base.InnerQuery);
        }

        public OrderCaptureOperationQueryBuilder(IQuery<OrderCapturePayload> query) : base(query)
        {
            Arguments = new OrderCaptureArgumentsBuilder(base.InnerQuery);
        }

        public OrderCaptureOperationQueryBuilder Transaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public OrderCaptureOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}