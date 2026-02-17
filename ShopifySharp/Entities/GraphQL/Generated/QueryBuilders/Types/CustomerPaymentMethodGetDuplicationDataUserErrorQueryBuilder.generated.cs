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
    public sealed class CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodGetDuplicationDataUserError, CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder>
    {
        protected override CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder Self => this;

        public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder() : this("customerPaymentMethodGetDuplicationDataUserError")
        {
        }

        public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder(string name) : base(new Query<CustomerPaymentMethodGetDuplicationDataUserError>(name))
        {
        }

        public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder(IQuery<CustomerPaymentMethodGetDuplicationDataUserError> query) : base(query)
        {
        }

        public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}