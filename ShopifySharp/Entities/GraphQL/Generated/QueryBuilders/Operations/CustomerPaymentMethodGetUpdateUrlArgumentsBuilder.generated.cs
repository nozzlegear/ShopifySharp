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
    public sealed class CustomerPaymentMethodGetUpdateUrlArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodGetUpdateUrlPayload, CustomerPaymentMethodGetUpdateUrlArgumentsBuilder>
    {
        protected override CustomerPaymentMethodGetUpdateUrlArgumentsBuilder Self => this;

        public CustomerPaymentMethodGetUpdateUrlArgumentsBuilder(IQuery<CustomerPaymentMethodGetUpdateUrlPayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodGetUpdateUrlArgumentsBuilder CustomerPaymentMethodId(string? customerPaymentMethodId)
        {
            base.InnerQuery.AddArgument("customerPaymentMethodId", customerPaymentMethodId);
            return this;
        }
    }
}