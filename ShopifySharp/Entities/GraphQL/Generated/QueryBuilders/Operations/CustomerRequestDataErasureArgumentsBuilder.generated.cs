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
    public sealed class CustomerRequestDataErasureArgumentsBuilder : ArgumentsBuilderBase<CustomerRequestDataErasurePayload, CustomerRequestDataErasureArgumentsBuilder>
    {
        protected override CustomerRequestDataErasureArgumentsBuilder Self => this;

        public CustomerRequestDataErasureArgumentsBuilder(IQuery<CustomerRequestDataErasurePayload> query) : base(query)
        {
        }

        public CustomerRequestDataErasureArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }
    }
}