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
    public sealed class PaymentTermsCreatePayloadQueryBuilder : FieldsQueryBuilderBase<PaymentTermsCreatePayload, PaymentTermsCreatePayloadQueryBuilder>
    {
        protected override PaymentTermsCreatePayloadQueryBuilder Self => this;

        public PaymentTermsCreatePayloadQueryBuilder() : this("paymentTermsCreatePayload")
        {
        }

        public PaymentTermsCreatePayloadQueryBuilder(string name) : base(new Query<PaymentTermsCreatePayload>(name))
        {
        }

        public PaymentTermsCreatePayloadQueryBuilder(IQuery<PaymentTermsCreatePayload> query) : base(query)
        {
        }

        public PaymentTermsCreatePayloadQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public PaymentTermsCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentTermsCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsCreateUserError>(query);
            return this;
        }
    }
}