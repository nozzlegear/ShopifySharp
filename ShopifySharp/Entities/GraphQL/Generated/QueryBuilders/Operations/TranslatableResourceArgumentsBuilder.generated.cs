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
    public sealed class TranslatableResourceArgumentsBuilder : ArgumentsBuilderBase<TranslatableResource, TranslatableResourceArgumentsBuilder>
    {
        protected override TranslatableResourceArgumentsBuilder Self => this;

        public TranslatableResourceArgumentsBuilder(IQuery<TranslatableResource> query) : base(query)
        {
        }

        public TranslatableResourceArgumentsBuilder ResourceId(string? resourceId)
        {
            base.InnerQuery.AddArgument("resourceId", resourceId);
            return this;
        }
    }
}