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
    public sealed class PaymentTermsUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<PaymentTermsUpdateUserError, PaymentTermsUpdateUserErrorQueryBuilder>
    {
        protected override PaymentTermsUpdateUserErrorQueryBuilder Self => this;

        public PaymentTermsUpdateUserErrorQueryBuilder() : this("paymentTermsUpdateUserError")
        {
        }

        public PaymentTermsUpdateUserErrorQueryBuilder(string name) : base(new Query<PaymentTermsUpdateUserError>(name))
        {
        }

        public PaymentTermsUpdateUserErrorQueryBuilder(IQuery<PaymentTermsUpdateUserError> query) : base(query)
        {
        }

        public PaymentTermsUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PaymentTermsUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PaymentTermsUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}