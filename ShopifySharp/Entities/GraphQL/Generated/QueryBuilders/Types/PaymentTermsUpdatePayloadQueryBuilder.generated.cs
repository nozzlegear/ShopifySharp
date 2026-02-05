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
    public sealed class PaymentTermsUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<PaymentTermsUpdatePayload, PaymentTermsUpdatePayloadQueryBuilder>
    {
        protected override PaymentTermsUpdatePayloadQueryBuilder Self => this;

        public PaymentTermsUpdatePayloadQueryBuilder() : this("paymentTermsUpdatePayload")
        {
        }

        public PaymentTermsUpdatePayloadQueryBuilder(string name) : base(new Query<PaymentTermsUpdatePayload>(name))
        {
        }

        public PaymentTermsUpdatePayloadQueryBuilder(IQuery<PaymentTermsUpdatePayload> query) : base(query)
        {
        }

        public PaymentTermsUpdatePayloadQueryBuilder PaymentTerms(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder> build)
        {
            var query = new Query<PaymentTerms>("paymentTerms");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTerms>(query);
            return this;
        }

        public PaymentTermsUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentTermsUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsUpdateUserError>(query);
            return this;
        }
    }
}