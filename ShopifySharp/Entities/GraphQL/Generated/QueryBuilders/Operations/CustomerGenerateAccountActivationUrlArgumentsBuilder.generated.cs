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