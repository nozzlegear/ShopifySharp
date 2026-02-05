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
    public sealed class CustomerPaymentMethodCreditCardCreateArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodCreditCardCreatePayload, CustomerPaymentMethodCreditCardCreateArgumentsBuilder>
    {
        protected override CustomerPaymentMethodCreditCardCreateArgumentsBuilder Self => this;

        public CustomerPaymentMethodCreditCardCreateArgumentsBuilder(IQuery<CustomerPaymentMethodCreditCardCreatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodCreditCardCreateArgumentsBuilder BillingAddress(MailingAddressInput? billingAddress)
        {
            base.InnerQuery.AddArgument("billingAddress", billingAddress);
            return this;
        }

        public CustomerPaymentMethodCreditCardCreateArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerPaymentMethodCreditCardCreateArgumentsBuilder SessionId(string? sessionId)
        {
            base.InnerQuery.AddArgument("sessionId", sessionId);
            return this;
        }
    }
}