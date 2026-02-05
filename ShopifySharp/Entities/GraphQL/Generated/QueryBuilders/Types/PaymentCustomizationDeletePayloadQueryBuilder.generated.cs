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
    public sealed class PaymentCustomizationDeletePayloadQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationDeletePayload, PaymentCustomizationDeletePayloadQueryBuilder>
    {
        protected override PaymentCustomizationDeletePayloadQueryBuilder Self => this;

        public PaymentCustomizationDeletePayloadQueryBuilder() : this("paymentCustomizationDeletePayload")
        {
        }

        public PaymentCustomizationDeletePayloadQueryBuilder(string name) : base(new Query<PaymentCustomizationDeletePayload>(name))
        {
        }

        public PaymentCustomizationDeletePayloadQueryBuilder(IQuery<PaymentCustomizationDeletePayload> query) : base(query)
        {
        }

        public PaymentCustomizationDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public PaymentCustomizationDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}