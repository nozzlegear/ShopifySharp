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
    public sealed class CustomerPaypalBillingAgreementQueryBuilder : FieldsQueryBuilderBase<CustomerPaypalBillingAgreement, CustomerPaypalBillingAgreementQueryBuilder>
    {
        protected override CustomerPaypalBillingAgreementQueryBuilder Self => this;

        public CustomerPaypalBillingAgreementQueryBuilder() : this("customerPaypalBillingAgreement")
        {
        }

        public CustomerPaypalBillingAgreementQueryBuilder(string name) : base(new Query<CustomerPaypalBillingAgreement>(name))
        {
        }

        public CustomerPaypalBillingAgreementQueryBuilder(IQuery<CustomerPaypalBillingAgreement> query) : base(query)
        {
        }

        public CustomerPaypalBillingAgreementQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentInstrumentBillingAddressQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentInstrumentBillingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentInstrumentBillingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentInstrumentBillingAddress>(query);
            return this;
        }

        public CustomerPaypalBillingAgreementQueryBuilder Inactive()
        {
            base.InnerQuery.AddField("inactive");
            return this;
        }

        public CustomerPaypalBillingAgreementQueryBuilder IsRevocable()
        {
            base.InnerQuery.AddField("isRevocable");
            return this;
        }

        public CustomerPaypalBillingAgreementQueryBuilder PaypalAccountEmail()
        {
            base.InnerQuery.AddField("paypalAccountEmail");
            return this;
        }
    }
}