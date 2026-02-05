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