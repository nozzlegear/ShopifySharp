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
    public sealed class PaymentCustomizationUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationUpdatePayload, PaymentCustomizationUpdatePayloadQueryBuilder>
    {
        protected override PaymentCustomizationUpdatePayloadQueryBuilder Self => this;

        public PaymentCustomizationUpdatePayloadQueryBuilder() : this("paymentCustomizationUpdatePayload")
        {
        }

        public PaymentCustomizationUpdatePayloadQueryBuilder(string name) : base(new Query<PaymentCustomizationUpdatePayload>(name))
        {
        }

        public PaymentCustomizationUpdatePayloadQueryBuilder(IQuery<PaymentCustomizationUpdatePayload> query) : base(query)
        {
        }

        public PaymentCustomizationUpdatePayloadQueryBuilder PaymentCustomization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("paymentCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public PaymentCustomizationUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}