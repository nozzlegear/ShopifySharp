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