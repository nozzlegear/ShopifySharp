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
    public sealed class ArticleTagsArgumentsBuilder : ArgumentsBuilderBase<GraphQLCollection<string>, ArticleTagsArgumentsBuilder>
    {
        protected override ArticleTagsArgumentsBuilder Self => this;

        public ArticleTagsArgumentsBuilder(IQuery<GraphQLCollection<string>> query) : base(query)
        {
        }

        public ArticleTagsArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public ArticleTagsArgumentsBuilder Sort(ArticleTagSort? sort)
        {
            base.InnerQuery.AddArgument("sort", sort);
            return this;
        }
    }
}