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