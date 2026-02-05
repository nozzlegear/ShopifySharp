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