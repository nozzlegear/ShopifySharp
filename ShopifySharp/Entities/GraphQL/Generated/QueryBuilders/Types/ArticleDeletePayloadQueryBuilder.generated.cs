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
    public sealed class ArticleDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ArticleDeletePayload, ArticleDeletePayloadQueryBuilder>
    {
        protected override ArticleDeletePayloadQueryBuilder Self => this;

        public ArticleDeletePayloadQueryBuilder() : this("articleDeletePayload")
        {
        }

        public ArticleDeletePayloadQueryBuilder(string name) : base(new Query<ArticleDeletePayload>(name))
        {
        }

        public ArticleDeletePayloadQueryBuilder(IQuery<ArticleDeletePayload> query) : base(query)
        {
        }

        public ArticleDeletePayloadQueryBuilder DeletedArticleId()
        {
            base.InnerQuery.AddField("deletedArticleId");
            return this;
        }

        public ArticleDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ArticleDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleDeleteUserError>(query);
            return this;
        }
    }
}