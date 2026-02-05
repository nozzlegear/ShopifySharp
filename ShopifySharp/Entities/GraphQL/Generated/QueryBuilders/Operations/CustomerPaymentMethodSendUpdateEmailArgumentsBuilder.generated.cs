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
    public sealed class CustomerPaymentMethodSendUpdateEmailArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodSendUpdateEmailPayload, CustomerPaymentMethodSendUpdateEmailArgumentsBuilder>
    {
        protected override CustomerPaymentMethodSendUpdateEmailArgumentsBuilder Self => this;

        public CustomerPaymentMethodSendUpdateEmailArgumentsBuilder(IQuery<CustomerPaymentMethodSendUpdateEmailPayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodSendUpdateEmailArgumentsBuilder CustomerPaymentMethodId(string? customerPaymentMethodId)
        {
            base.InnerQuery.AddArgument("customerPaymentMethodId", customerPaymentMethodId);
            return this;
        }

        public CustomerPaymentMethodSendUpdateEmailArgumentsBuilder Email(EmailInput? email)
        {
            base.InnerQuery.AddArgument("email", email);
            return this;
        }
    }
}