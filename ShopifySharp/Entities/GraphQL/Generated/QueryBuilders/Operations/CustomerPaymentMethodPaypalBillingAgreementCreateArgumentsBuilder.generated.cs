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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodPaypalBillingAgreementCreatePayload, CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder>
    {
        protected override CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder Self => this;

        public CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder(IQuery<CustomerPaymentMethodPaypalBillingAgreementCreatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder BillingAddress(MailingAddressInput? billingAddress)
        {
            base.InnerQuery.AddArgument("billingAddress", billingAddress);
            return this;
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder BillingAgreementId(string? billingAgreementId)
        {
            base.InnerQuery.AddArgument("billingAgreementId", billingAgreementId);
            return this;
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerPaymentMethodPaypalBillingAgreementCreateArgumentsBuilder Inactive(bool? inactive)
        {
            base.InnerQuery.AddArgument("inactive", inactive);
            return this;
        }
    }
}