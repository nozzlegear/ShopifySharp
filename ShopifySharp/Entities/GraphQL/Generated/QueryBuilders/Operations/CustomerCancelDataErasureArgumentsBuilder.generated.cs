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
    public sealed class CustomerCancelDataErasureArgumentsBuilder : ArgumentsBuilderBase<CustomerCancelDataErasurePayload, CustomerCancelDataErasureArgumentsBuilder>
    {
        protected override CustomerCancelDataErasureArgumentsBuilder Self => this;

        public CustomerCancelDataErasureArgumentsBuilder(IQuery<CustomerCancelDataErasurePayload> query) : base(query)
        {
        }

        public CustomerCancelDataErasureArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }
    }
}