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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodPaypalBillingAgreementUpdatePayload, CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder>
    {
        protected override CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder Self => this;

        public CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder(IQuery<CustomerPaymentMethodPaypalBillingAgreementUpdatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder BillingAddress(MailingAddressInput? billingAddress)
        {
            base.InnerQuery.AddArgument("billingAddress", billingAddress);
            return this;
        }

        public CustomerPaymentMethodPaypalBillingAgreementUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}