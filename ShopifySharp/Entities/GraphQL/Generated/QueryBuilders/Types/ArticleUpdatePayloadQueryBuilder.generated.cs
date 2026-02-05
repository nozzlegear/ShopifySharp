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
    public sealed class ArticleUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ArticleUpdatePayload, ArticleUpdatePayloadQueryBuilder>
    {
        protected override ArticleUpdatePayloadQueryBuilder Self => this;

        public ArticleUpdatePayloadQueryBuilder() : this("articleUpdatePayload")
        {
        }

        public ArticleUpdatePayloadQueryBuilder(string name) : base(new Query<ArticleUpdatePayload>(name))
        {
        }

        public ArticleUpdatePayloadQueryBuilder(IQuery<ArticleUpdatePayload> query) : base(query)
        {
        }

        public ArticleUpdatePayloadQueryBuilder Article(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("article");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public ArticleUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ArticleUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleUpdateUserError>(query);
            return this;
        }
    }
}