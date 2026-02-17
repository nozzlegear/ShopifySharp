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
    public sealed class PaymentTermsCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<PaymentTermsCreateUserError, PaymentTermsCreateUserErrorQueryBuilder>
    {
        protected override PaymentTermsCreateUserErrorQueryBuilder Self => this;

        public PaymentTermsCreateUserErrorQueryBuilder() : this("paymentTermsCreateUserError")
        {
        }

        public PaymentTermsCreateUserErrorQueryBuilder(string name) : base(new Query<PaymentTermsCreateUserError>(name))
        {
        }

        public PaymentTermsCreateUserErrorQueryBuilder(IQuery<PaymentTermsCreateUserError> query) : base(query)
        {
        }

        public PaymentTermsCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PaymentTermsCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PaymentTermsCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}