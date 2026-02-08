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
    public sealed class CustomerPaymentMethodRevokeArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodRevokePayload, CustomerPaymentMethodRevokeArgumentsBuilder>
    {
        protected override CustomerPaymentMethodRevokeArgumentsBuilder Self => this;

        public CustomerPaymentMethodRevokeArgumentsBuilder(IQuery<CustomerPaymentMethodRevokePayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodRevokeArgumentsBuilder CustomerPaymentMethodId(string? customerPaymentMethodId)
        {
            base.InnerQuery.AddArgument("customerPaymentMethodId", customerPaymentMethodId);
            return this;
        }
    }
}