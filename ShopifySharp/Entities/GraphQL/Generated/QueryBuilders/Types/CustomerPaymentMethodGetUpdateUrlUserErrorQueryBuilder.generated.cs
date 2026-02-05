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
    public sealed class CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodGetUpdateUrlUserError, CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder>
    {
        protected override CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder Self => this;

        public CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder() : this("customerPaymentMethodGetUpdateUrlUserError")
        {
        }

        public CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder(string name) : base(new Query<CustomerPaymentMethodGetUpdateUrlUserError>(name))
        {
        }

        public CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder(IQuery<CustomerPaymentMethodGetUpdateUrlUserError> query) : base(query)
        {
        }

        public CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}