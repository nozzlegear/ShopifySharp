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
    public sealed class OrderPaymentStatusOperationQueryBuilder : FieldsQueryBuilderBase<OrderPaymentStatus, OrderPaymentStatusOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderPaymentStatus>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public OrderPaymentStatusArgumentsBuilder Arguments { get; }
        protected override OrderPaymentStatusOperationQueryBuilder Self => this;

        public OrderPaymentStatusOperationQueryBuilder() : this("orderPaymentStatus")
        {
        }

        public OrderPaymentStatusOperationQueryBuilder(string name) : base(new Query<OrderPaymentStatus>(name))
        {
            Arguments = new OrderPaymentStatusArgumentsBuilder(base.InnerQuery);
        }

        public OrderPaymentStatusOperationQueryBuilder(IQuery<OrderPaymentStatus> query) : base(query)
        {
            Arguments = new OrderPaymentStatusArgumentsBuilder(base.InnerQuery);
        }

        public OrderPaymentStatusOperationQueryBuilder ErrorMessage()
        {
            base.InnerQuery.AddField("errorMessage");
            return this;
        }

        public OrderPaymentStatusOperationQueryBuilder PaymentReferenceId()
        {
            base.InnerQuery.AddField("paymentReferenceId");
            return this;
        }

        public OrderPaymentStatusOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public OrderPaymentStatusOperationQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public OrderPaymentStatusOperationQueryBuilder TranslatedErrorMessage()
        {
            base.InnerQuery.AddField("translatedErrorMessage");
            return this;
        }
    }
}