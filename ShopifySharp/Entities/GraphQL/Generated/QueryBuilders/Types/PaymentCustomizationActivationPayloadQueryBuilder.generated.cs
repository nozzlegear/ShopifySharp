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
    public sealed class PaymentCustomizationActivationPayloadQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationActivationPayload, PaymentCustomizationActivationPayloadQueryBuilder>
    {
        protected override PaymentCustomizationActivationPayloadQueryBuilder Self => this;

        public PaymentCustomizationActivationPayloadQueryBuilder() : this("paymentCustomizationActivationPayload")
        {
        }

        public PaymentCustomizationActivationPayloadQueryBuilder(string name) : base(new Query<PaymentCustomizationActivationPayload>(name))
        {
        }

        public PaymentCustomizationActivationPayloadQueryBuilder(IQuery<PaymentCustomizationActivationPayload> query) : base(query)
        {
        }

        public PaymentCustomizationActivationPayloadQueryBuilder Ids()
        {
            base.InnerQuery.AddField("ids");
            return this;
        }

        public PaymentCustomizationActivationPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}