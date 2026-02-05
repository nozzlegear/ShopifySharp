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
    public sealed class BlogUpdateArgumentsBuilder : ArgumentsBuilderBase<BlogUpdatePayload, BlogUpdateArgumentsBuilder>
    {
        protected override BlogUpdateArgumentsBuilder Self => this;

        public BlogUpdateArgumentsBuilder(IQuery<BlogUpdatePayload> query) : base(query)
        {
        }

        public BlogUpdateArgumentsBuilder Blog(BlogUpdateInput? blog)
        {
            base.InnerQuery.AddArgument("blog", blog);
            return this;
        }

        public BlogUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}