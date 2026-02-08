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
    public sealed class OrderInvoiceSendOperationQueryBuilder : FieldsQueryBuilderBase<OrderInvoiceSendPayload, OrderInvoiceSendOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderInvoiceSendPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderInvoiceSendArgumentsBuilder Arguments { get; }
        protected override OrderInvoiceSendOperationQueryBuilder Self => this;

        public OrderInvoiceSendOperationQueryBuilder() : this("orderInvoiceSend")
        {
        }

        public OrderInvoiceSendOperationQueryBuilder(string name) : base(new Query<OrderInvoiceSendPayload>(name))
        {
            Arguments = new OrderInvoiceSendArgumentsBuilder(base.InnerQuery);
        }

        public OrderInvoiceSendOperationQueryBuilder(IQuery<OrderInvoiceSendPayload> query) : base(query)
        {
            Arguments = new OrderInvoiceSendArgumentsBuilder(base.InnerQuery);
        }

        public OrderInvoiceSendOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderInvoiceSendOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderInvoiceSendUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderInvoiceSendUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderInvoiceSendUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderInvoiceSendUserError>(query);
            return this;
        }
    }
}