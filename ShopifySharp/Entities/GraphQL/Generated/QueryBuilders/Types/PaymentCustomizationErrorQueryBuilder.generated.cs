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
    public sealed class PaymentCustomizationErrorQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationError, PaymentCustomizationErrorQueryBuilder>
    {
        protected override PaymentCustomizationErrorQueryBuilder Self => this;

        public PaymentCustomizationErrorQueryBuilder() : this("paymentCustomizationError")
        {
        }

        public PaymentCustomizationErrorQueryBuilder(string name) : base(new Query<PaymentCustomizationError>(name))
        {
        }

        public PaymentCustomizationErrorQueryBuilder(IQuery<PaymentCustomizationError> query) : base(query)
        {
        }

        public PaymentCustomizationErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PaymentCustomizationErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PaymentCustomizationErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}