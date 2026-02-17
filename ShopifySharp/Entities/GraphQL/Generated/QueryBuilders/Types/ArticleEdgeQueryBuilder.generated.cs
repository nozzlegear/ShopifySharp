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
    public sealed class ArticleEdgeQueryBuilder : FieldsQueryBuilderBase<ArticleEdge, ArticleEdgeQueryBuilder>
    {
        protected override ArticleEdgeQueryBuilder Self => this;

        public ArticleEdgeQueryBuilder() : this("articleEdge")
        {
        }

        public ArticleEdgeQueryBuilder(string name) : base(new Query<ArticleEdge>(name))
        {
        }

        public ArticleEdgeQueryBuilder(IQuery<ArticleEdge> query) : base(query)
        {
        }

        public ArticleEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ArticleEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }
    }
}