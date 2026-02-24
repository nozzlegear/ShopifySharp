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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ProductRestrictedForResourceArgumentsBuilder : ArgumentsBuilderBase<RestrictedForResource?, ProductRestrictedForResourceArgumentsBuilder>
    {
        protected override ProductRestrictedForResourceArgumentsBuilder Self => this;

        public ProductRestrictedForResourceArgumentsBuilder(IQuery<RestrictedForResource?> query) : base(query)
        {
        }

        public ProductRestrictedForResourceArgumentsBuilder CalculatedOrderId(string? calculatedOrderId)
        {
            base.InnerQuery.AddArgument("calculatedOrderId", calculatedOrderId);
            return this;
        }
    }
}