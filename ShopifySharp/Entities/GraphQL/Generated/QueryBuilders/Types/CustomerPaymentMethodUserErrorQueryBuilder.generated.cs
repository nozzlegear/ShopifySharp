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
    public sealed class CustomerPaymentMethodUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodUserError, CustomerPaymentMethodUserErrorQueryBuilder>
    {
        protected override CustomerPaymentMethodUserErrorQueryBuilder Self => this;

        public CustomerPaymentMethodUserErrorQueryBuilder() : this("customerPaymentMethodUserError")
        {
        }

        public CustomerPaymentMethodUserErrorQueryBuilder(string name) : base(new Query<CustomerPaymentMethodUserError>(name))
        {
        }

        public CustomerPaymentMethodUserErrorQueryBuilder(IQuery<CustomerPaymentMethodUserError> query) : base(query)
        {
        }

        public CustomerPaymentMethodUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerPaymentMethodUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerPaymentMethodUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}