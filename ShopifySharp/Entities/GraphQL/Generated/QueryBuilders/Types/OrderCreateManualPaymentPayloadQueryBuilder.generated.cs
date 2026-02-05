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
    public sealed class OrderCreateManualPaymentPayloadQueryBuilder : FieldsQueryBuilderBase<OrderCreateManualPaymentPayload, OrderCreateManualPaymentPayloadQueryBuilder>
    {
        protected override OrderCreateManualPaymentPayloadQueryBuilder Self => this;

        public OrderCreateManualPaymentPayloadQueryBuilder() : this("orderCreateManualPaymentPayload")
        {
        }

        public OrderCreateManualPaymentPayloadQueryBuilder(string name) : base(new Query<OrderCreateManualPaymentPayload>(name))
        {
        }

        public OrderCreateManualPaymentPayloadQueryBuilder(IQuery<OrderCreateManualPaymentPayload> query) : base(query)
        {
        }

        public OrderCreateManualPaymentPayloadQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCreateManualPaymentPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder> build)
        {
            var query = new Query<OrderCreateManualPaymentOrderCreateManualPaymentError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCreateManualPaymentOrderCreateManualPaymentError>(query);
            return this;
        }
    }
}