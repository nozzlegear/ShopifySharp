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