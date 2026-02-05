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
    public sealed class CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodCreditCardUpdatePayload, CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder Self => this;

        public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder() : this("customerPaymentMethodCreditCardUpdatePayload")
        {
        }

        public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodCreditCardUpdatePayload>(name))
        {
        }

        public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder(IQuery<CustomerPaymentMethodCreditCardUpdatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder Processing()
        {
            base.InnerQuery.AddField("processing");
            return this;
        }

        public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}