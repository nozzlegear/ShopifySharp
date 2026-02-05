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
    public sealed class CustomerPaymentMethodCreateFromDuplicationDataArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodCreateFromDuplicationDataPayload, CustomerPaymentMethodCreateFromDuplicationDataArgumentsBuilder>
    {
        protected override CustomerPaymentMethodCreateFromDuplicationDataArgumentsBuilder Self => this;

        public CustomerPaymentMethodCreateFromDuplicationDataArgumentsBuilder(IQuery<CustomerPaymentMethodCreateFromDuplicationDataPayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodCreateFromDuplicationDataArgumentsBuilder BillingAddress(MailingAddressInput? billingAddress)
        {
            base.InnerQuery.AddArgument("billingAddress", billingAddress);
            return this;
        }

        public CustomerPaymentMethodCreateFromDuplicationDataArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerPaymentMethodCreateFromDuplicationDataArgumentsBuilder EncryptedDuplicationData(string? encryptedDuplicationData)
        {
            base.InnerQuery.AddArgument("encryptedDuplicationData", encryptedDuplicationData);
            return this;
        }
    }
}