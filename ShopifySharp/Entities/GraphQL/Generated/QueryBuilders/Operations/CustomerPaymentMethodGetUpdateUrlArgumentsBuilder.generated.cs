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