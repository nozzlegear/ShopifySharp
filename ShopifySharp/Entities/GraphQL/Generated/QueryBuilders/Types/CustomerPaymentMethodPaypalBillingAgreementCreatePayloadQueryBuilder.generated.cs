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
    public sealed class CustomerPaymentMethodPaypalBillingAgreementCreatePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodPaypalBillingAgreementCreatePayload, CustomerPaymentMethodPaypalBillingAgreementCreatePayloadQueryBuilder>
    {
        protected override CustomerPaymentMethodPaypalBillingAgreementCreatePayloadQueryBuilder Self => this;

        public CustomerPaymentMethodPaypalBillingAgreementCreatePayloadQueryBuilder() : this("customerPaymentMethodPaypalBillingAgreementCreatePayload")
        {
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreatePayloadQueryBuilder(string name) : base(new Query<CustomerPaymentMethodPaypalBillingAgreementCreatePayload>(name))
        {
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreatePayloadQueryBuilder(IQuery<CustomerPaymentMethodPaypalBillingAgreementCreatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreatePayloadQueryBuilder CustomerPaymentMethod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("customerPaymentMethod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodUserError>(query);
            return this;
        }
    }
}