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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
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