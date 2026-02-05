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
    public sealed class ArticleCreateArgumentsBuilder : ArgumentsBuilderBase<ArticleCreatePayload, ArticleCreateArgumentsBuilder>
    {
        protected override ArticleCreateArgumentsBuilder Self => this;

        public ArticleCreateArgumentsBuilder(IQuery<ArticleCreatePayload> query) : base(query)
        {
        }

        public ArticleCreateArgumentsBuilder Article(ArticleCreateInput? article)
        {
            base.InnerQuery.AddArgument("article", article);
            return this;
        }

        public ArticleCreateArgumentsBuilder Blog(ArticleBlogInput? blog)
        {
            base.InnerQuery.AddArgument("blog", blog);
            return this;
        }
    }
}