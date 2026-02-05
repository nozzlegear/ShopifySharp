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
    public sealed class DisputeArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsDispute, DisputeArgumentsBuilder>
    {
        protected override DisputeArgumentsBuilder Self => this;

        public DisputeArgumentsBuilder(IQuery<ShopifyPaymentsDispute> query) : base(query)
        {
        }

        public DisputeArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}