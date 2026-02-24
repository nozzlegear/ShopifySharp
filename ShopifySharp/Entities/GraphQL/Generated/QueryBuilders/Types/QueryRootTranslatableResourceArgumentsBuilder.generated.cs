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
    public sealed class QueryRootTranslatableResourceArgumentsBuilder : ArgumentsBuilderBase<TranslatableResource?, QueryRootTranslatableResourceArgumentsBuilder>
    {
        protected override QueryRootTranslatableResourceArgumentsBuilder Self => this;

        public QueryRootTranslatableResourceArgumentsBuilder(IQuery<TranslatableResource?> query) : base(query)
        {
        }

        public QueryRootTranslatableResourceArgumentsBuilder ResourceId(string? resourceId)
        {
            base.InnerQuery.AddArgument("resourceId", resourceId);
            return this;
        }
    }
}