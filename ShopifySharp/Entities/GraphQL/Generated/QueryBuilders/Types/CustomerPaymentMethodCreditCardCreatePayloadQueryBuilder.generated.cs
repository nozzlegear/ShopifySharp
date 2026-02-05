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
    public sealed class CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodCreditCardCreatePayload, CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder Self => this;

        public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder() : this("customerPaymentMethodCreditCardCreatePayload")
        {
        }

        public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodCreditCardCreatePayload>(name))
        {
        }

        public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder(IQuery<CustomerPaymentMethodCreditCardCreatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder Processing()
        {
            base.InnerQuery.AddField("processing");
            return this;
        }

        public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}