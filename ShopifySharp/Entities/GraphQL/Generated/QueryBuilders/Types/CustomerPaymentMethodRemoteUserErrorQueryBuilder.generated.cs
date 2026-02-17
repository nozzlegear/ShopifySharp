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
    public sealed class CustomerPaymentMethodRemoteUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodRemoteUserError, CustomerPaymentMethodRemoteUserErrorQueryBuilder>
    {
        protected override CustomerPaymentMethodRemoteUserErrorQueryBuilder Self => this;

        public CustomerPaymentMethodRemoteUserErrorQueryBuilder() : this("customerPaymentMethodRemoteUserError")
        {
        }

        public CustomerPaymentMethodRemoteUserErrorQueryBuilder(string name) : base(new Query<CustomerPaymentMethodRemoteUserError>(name))
        {
        }

        public CustomerPaymentMethodRemoteUserErrorQueryBuilder(IQuery<CustomerPaymentMethodRemoteUserError> query) : base(query)
        {
        }

        public CustomerPaymentMethodRemoteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerPaymentMethodRemoteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerPaymentMethodRemoteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}