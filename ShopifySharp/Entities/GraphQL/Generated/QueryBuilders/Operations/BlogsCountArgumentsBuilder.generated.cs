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
    public sealed class BlogsCountArgumentsBuilder : ArgumentsBuilderBase<Count, BlogsCountArgumentsBuilder>
    {
        protected override BlogsCountArgumentsBuilder Self => this;

        public BlogsCountArgumentsBuilder(IQuery<Count> query) : base(query)
        {
        }

        public BlogsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public BlogsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}