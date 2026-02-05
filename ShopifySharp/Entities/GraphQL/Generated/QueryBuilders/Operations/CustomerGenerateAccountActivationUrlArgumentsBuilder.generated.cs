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
    public sealed class CustomerGenerateAccountActivationUrlArgumentsBuilder : ArgumentsBuilderBase<CustomerGenerateAccountActivationUrlPayload, CustomerGenerateAccountActivationUrlArgumentsBuilder>
    {
        protected override CustomerGenerateAccountActivationUrlArgumentsBuilder Self => this;

        public CustomerGenerateAccountActivationUrlArgumentsBuilder(IQuery<CustomerGenerateAccountActivationUrlPayload> query) : base(query)
        {
        }

        public CustomerGenerateAccountActivationUrlArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }
    }
}