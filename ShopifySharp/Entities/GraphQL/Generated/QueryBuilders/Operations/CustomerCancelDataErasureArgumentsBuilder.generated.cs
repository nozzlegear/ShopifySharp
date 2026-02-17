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