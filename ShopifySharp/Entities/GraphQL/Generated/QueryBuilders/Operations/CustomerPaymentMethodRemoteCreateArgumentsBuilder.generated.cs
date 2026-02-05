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
    public sealed class CustomerPaymentMethodRemoteCreateArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodRemoteCreatePayload, CustomerPaymentMethodRemoteCreateArgumentsBuilder>
    {
        protected override CustomerPaymentMethodRemoteCreateArgumentsBuilder Self => this;

        public CustomerPaymentMethodRemoteCreateArgumentsBuilder(IQuery<CustomerPaymentMethodRemoteCreatePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodRemoteCreateArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerPaymentMethodRemoteCreateArgumentsBuilder RemoteReference(CustomerPaymentMethodRemoteInput? remoteReference)
        {
            base.InnerQuery.AddArgument("remoteReference", remoteReference);
            return this;
        }
    }
}