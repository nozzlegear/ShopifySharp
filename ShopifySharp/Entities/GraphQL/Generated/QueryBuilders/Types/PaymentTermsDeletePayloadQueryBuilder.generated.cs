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
    public sealed class PaymentTermsDeletePayloadQueryBuilder : FieldsQueryBuilderBase<PaymentTermsDeletePayload, PaymentTermsDeletePayloadQueryBuilder>
    {
        protected override PaymentTermsDeletePayloadQueryBuilder Self => this;

        public PaymentTermsDeletePayloadQueryBuilder() : this("paymentTermsDeletePayload")
        {
        }

        public PaymentTermsDeletePayloadQueryBuilder(string name) : base(new Query<PaymentTermsDeletePayload>(name))
        {
        }

        public PaymentTermsDeletePayloadQueryBuilder(IQuery<PaymentTermsDeletePayload> query) : base(query)
        {
        }

        public PaymentTermsDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public PaymentTermsDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentTermsDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsDeleteUserError>(query);
            return this;
        }
    }
}