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
    public sealed class ArticleAuthorEdgeQueryBuilder : FieldsQueryBuilderBase<ArticleAuthorEdge, ArticleAuthorEdgeQueryBuilder>
    {
        protected override ArticleAuthorEdgeQueryBuilder Self => this;

        public ArticleAuthorEdgeQueryBuilder() : this("articleAuthorEdge")
        {
        }

        public ArticleAuthorEdgeQueryBuilder(string name) : base(new Query<ArticleAuthorEdge>(name))
        {
        }

        public ArticleAuthorEdgeQueryBuilder(IQuery<ArticleAuthorEdge> query) : base(query)
        {
        }

        public ArticleAuthorEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ArticleAuthorEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorQueryBuilder> build)
        {
            var query = new Query<ArticleAuthor>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleAuthor>(query);
            return this;
        }
    }
}