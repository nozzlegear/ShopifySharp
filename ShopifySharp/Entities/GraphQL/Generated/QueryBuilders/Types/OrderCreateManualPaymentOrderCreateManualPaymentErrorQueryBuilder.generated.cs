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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder : FieldsQueryBuilderBase<OrderCreateManualPaymentOrderCreateManualPaymentError, OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder>
    {
        protected override OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder Self => this;

        public OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder() : this("orderCreateManualPaymentOrderCreateManualPaymentError")
        {
        }

        public OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder(string name) : base(new Query<OrderCreateManualPaymentOrderCreateManualPaymentError>(name))
        {
        }

        public OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder(IQuery<OrderCreateManualPaymentOrderCreateManualPaymentError> query) : base(query)
        {
        }

        public OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}