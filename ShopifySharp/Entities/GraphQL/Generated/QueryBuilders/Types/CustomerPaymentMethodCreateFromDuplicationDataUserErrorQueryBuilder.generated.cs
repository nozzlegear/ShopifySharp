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
    public sealed class CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodCreateFromDuplicationDataUserError, CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder>
    {
        protected override CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder Self => this;

        public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder() : this("customerPaymentMethodCreateFromDuplicationDataUserError")
        {
        }

        public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder(string name) : base(new Query<CustomerPaymentMethodCreateFromDuplicationDataUserError>(name))
        {
        }

        public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder(IQuery<CustomerPaymentMethodCreateFromDuplicationDataUserError> query) : base(query)
        {
        }

        public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}