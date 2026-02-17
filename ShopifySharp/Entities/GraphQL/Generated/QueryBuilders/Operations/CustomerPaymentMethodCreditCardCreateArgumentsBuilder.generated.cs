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