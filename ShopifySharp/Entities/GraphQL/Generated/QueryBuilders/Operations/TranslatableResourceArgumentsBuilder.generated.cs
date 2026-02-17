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