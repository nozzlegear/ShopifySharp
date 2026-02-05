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
    public sealed class PaymentCustomizationCreatePayloadQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationCreatePayload, PaymentCustomizationCreatePayloadQueryBuilder>
    {
        protected override PaymentCustomizationCreatePayloadQueryBuilder Self => this;

        public PaymentCustomizationCreatePayloadQueryBuilder() : this("paymentCustomizationCreatePayload")
        {
        }

        public PaymentCustomizationCreatePayloadQueryBuilder(string name) : base(new Query<PaymentCustomizationCreatePayload>(name))
        {
        }

        public PaymentCustomizationCreatePayloadQueryBuilder(IQuery<PaymentCustomizationCreatePayload> query) : base(query)
        {
        }

        public PaymentCustomizationCreatePayloadQueryBuilder PaymentCustomization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("paymentCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public PaymentCustomizationCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationError>(query);
            return this;
        }
    }
}