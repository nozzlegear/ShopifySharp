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
    public sealed class PaymentTermsDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<PaymentTermsDeleteUserError, PaymentTermsDeleteUserErrorQueryBuilder>
    {
        protected override PaymentTermsDeleteUserErrorQueryBuilder Self => this;

        public PaymentTermsDeleteUserErrorQueryBuilder() : this("paymentTermsDeleteUserError")
        {
        }

        public PaymentTermsDeleteUserErrorQueryBuilder(string name) : base(new Query<PaymentTermsDeleteUserError>(name))
        {
        }

        public PaymentTermsDeleteUserErrorQueryBuilder(IQuery<PaymentTermsDeleteUserError> query) : base(query)
        {
        }

        public PaymentTermsDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PaymentTermsDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PaymentTermsDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}