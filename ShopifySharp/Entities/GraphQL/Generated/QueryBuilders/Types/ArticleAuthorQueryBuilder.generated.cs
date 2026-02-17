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
    public sealed class ArticleAuthorQueryBuilder : FieldsQueryBuilderBase<ArticleAuthor, ArticleAuthorQueryBuilder>
    {
        protected override ArticleAuthorQueryBuilder Self => this;

        public ArticleAuthorQueryBuilder() : this("articleAuthor")
        {
        }

        public ArticleAuthorQueryBuilder(string name) : base(new Query<ArticleAuthor>(name))
        {
        }

        public ArticleAuthorQueryBuilder(IQuery<ArticleAuthor> query) : base(query)
        {
        }

        public ArticleAuthorQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}