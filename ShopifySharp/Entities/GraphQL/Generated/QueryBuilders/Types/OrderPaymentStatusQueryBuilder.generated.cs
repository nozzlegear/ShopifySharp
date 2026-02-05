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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class OrderPaymentStatusQueryBuilder : FieldsQueryBuilderBase<OrderPaymentStatus, OrderPaymentStatusQueryBuilder>
    {
        protected override OrderPaymentStatusQueryBuilder Self => this;

        public OrderPaymentStatusQueryBuilder() : this("orderPaymentStatus")
        {
        }

        public OrderPaymentStatusQueryBuilder(string name) : base(new Query<OrderPaymentStatus>(name))
        {
        }

        public OrderPaymentStatusQueryBuilder(IQuery<OrderPaymentStatus> query) : base(query)
        {
        }

        public OrderPaymentStatusQueryBuilder ErrorMessage()
        {
            base.InnerQuery.AddField("errorMessage");
            return this;
        }

        public OrderPaymentStatusQueryBuilder PaymentReferenceId()
        {
            base.InnerQuery.AddField("paymentReferenceId");
            return this;
        }

        public OrderPaymentStatusQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public OrderPaymentStatusQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public OrderPaymentStatusQueryBuilder TranslatedErrorMessage()
        {
            base.InnerQuery.AddField("translatedErrorMessage");
            return this;
        }
    }
}