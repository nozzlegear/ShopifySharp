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
    public sealed class CustomerPaymentMethodCreditCardUpdateArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodCreditCardUpdatePayload, CustomerPaymentMethodCreditCardUpdateArgumentsBuilder>
    {
        protected override CustomerPaymentMethodCreditCardUpdateArgumentsBuilder Self => this;

        public CustomerPaymentMethodCreditCardUpdateArgumentsBuilder(IQuery<CustomerPaymentMethodCreditCardUpdatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodCreditCardUpdateArgumentsBuilder BillingAddress(MailingAddressInput? billingAddress)
        {
            base.InnerQuery.AddArgument("billingAddress", billingAddress);
            return this;
        }

        public CustomerPaymentMethodCreditCardUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public CustomerPaymentMethodCreditCardUpdateArgumentsBuilder SessionId(string? sessionId)
        {
            base.InnerQuery.AddArgument("sessionId", sessionId);
            return this;
        }
    }
}