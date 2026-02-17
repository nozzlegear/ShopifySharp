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
    public sealed class ArticleUpdateArgumentsBuilder : ArgumentsBuilderBase<ArticleUpdatePayload, ArticleUpdateArgumentsBuilder>
    {
        protected override ArticleUpdateArgumentsBuilder Self => this;

        public ArticleUpdateArgumentsBuilder(IQuery<ArticleUpdatePayload> query) : base(query)
        {
        }

        public ArticleUpdateArgumentsBuilder Article(ArticleUpdateInput? article)
        {
            base.InnerQuery.AddArgument("article", article);
            return this;
        }

        public ArticleUpdateArgumentsBuilder Blog(ArticleBlogInput? blog)
        {
            base.InnerQuery.AddArgument("blog", blog);
            return this;
        }

        public ArticleUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}